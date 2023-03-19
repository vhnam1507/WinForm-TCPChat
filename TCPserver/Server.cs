using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCPserver
{
    public partial class Server : Form
    {
        SimpleTcpServer server; // khởi tạo biến server tcp

        public Server()
        {
            InitializeComponent();
            textBox1.Text = "127.0.0.1"; //ghi sẵn loopback ip lên textbox ip
            chuakhoitao_radio.Checked = true; // trạng thái kết nối
        }

        private void Server_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //Enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            textBox3.Invoke((MethodInvoker)delegate ()
            {
                textBox3.Text += "\r\n" + e.MessageString; //tin nhắn nhận được từ client được xuống dòng và in ra textbox3
                server.Broadcast(e.MessageString); // gửi tới mọi client đang kết nối

            });
        }
        private void conn_button_Click(object sender, EventArgs e) //event click nút kết nối
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(textBox1.Text); // lấy ip từ textbox 1 có chứa ip
            server.Start(ip, Convert.ToInt32(textBox2.Text)); // lấy port từ textbox 2 có chứa port
            textBox3.Text += "Server starting"; //ghi dòng thông báo server đang hoạt động ra khung chat

            conn_button.Enabled = false; //vô hiệu nút kết nối để tránh bị spam click, tránh lỗi do người dùng phá hoại
            textBox2.Enabled = false; //vô hiệu ô text box chứa port để tránh bị sửa xóa phá trong lúc server đã chạy, tránh lỗi do người dùng phá hoại
            doiclient_radio.Checked = true; // chuyển trạng thái server thành đang đợi

        }

        private void disconn_button_Click(object sender, EventArgs e) //event khi click nút hủy kết nối
        {
            if (server.IsStarted) //Ngừng server, xóa khung chat
            {
                server.Stop();
                textBox3.Clear();
            }
            conn_button.Enabled = true; // cho phép người dùng click lại nút kết nối
            textBox2.Enabled = true; //cho phép người dùng thao tác lại lên ô textbox chứa port
        }

        private void send_click(object sender, EventArgs e)
        {
            server.Broadcast("Server đến mọi client: " + textBox4.Text);// gửi tới mọi client
            textBox3.Text = textBox3.Text + "\r\nServer: " + textBox4.Text; // xuống dòng cho khung chat
            textBox4.Clear(); // xóa ô nhập tin nhắn để người dùng có thể nhập liệu 1 tin nhắn mới
        }
    }
}
