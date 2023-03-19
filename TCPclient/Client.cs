using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCPclient
{
    public partial class Client : Form
    {
        private const int BUFFER_SIZE = 1024;
        SimpleTcpClient client;

        public Client() //khởi tạo
        {
            InitializeComponent();
            textBox1.Text = "127.0.0.1";
            //ghi sẵn loopback ip lên textbox ip
            radioButton1.Checked = true; // trạng thái chưa kết nối
        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            textBox4.Invoke((MethodInvoker)delegate ()
            {
                textBox4.Text = textBox4.Text + e.MessageString + "\r\n"; // hiện thị thông điệp nhận lại từ server
            });
        }


        private void conn_button_Click(object sender, EventArgs e)
        {
            //thao tác kết nối với server. Nếu thành công thì chuyển trạng thái thành đã kết nối, vô hiệu nút kết nối và textbox chứa tên
            try
            {
                client.Connect(textBox1.Text, Convert.ToInt32(textBox2.Text)); //kết nối theo ip và port được lấy từ các textbox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message); // hiển thị lỗi
            }
            finally
            {
                //vô hiệu nút kết nối và textbox chứa tên để tránh lỗi do người dùng, tránh người dùng đổi tên tùm lum 
                textBox3.Enabled = false;
                conn_button.Enabled = false;
                radioButton2.Checked = true;
            }

        }

        private void send_button_Click(object sender, EventArgs e)
        {
            //gửi đi tin nhắn lấy từ ô nhập tin nhắn(5) cùng với tên client lấy từ textbox chứa tên(3), thời gian chờ 0 giây
            client.WriteLine(textBox3.Text + ": " + textBox5.Text);
            textBox4.Text += "\r\n";
            textBox5.Clear(); // xóa ô nhập tin nhắn để người dùng có thể nhập liệu 1 tin nhắn mới
        }
    }
}
