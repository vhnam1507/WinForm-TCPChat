namespace TCPserver
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.conn_button = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.daketnoi_radio = new System.Windows.Forms.RadioButton();
            this.doiclient_radio = new System.Windows.Forms.RadioButton();
            this.chuakhoitao_radio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "SERVER IP";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Roboto Cn", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(588, 74);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 52);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Roboto Cn", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(176, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 52);
            this.textBox1.TabIndex = 9;
            // 
            // conn_button
            // 
            this.conn_button.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conn_button.Location = new System.Drawing.Point(794, 71);
            this.conn_button.Name = "conn_button";
            this.conn_button.Size = new System.Drawing.Size(139, 59);
            this.conn_button.TabIndex = 7;
            this.conn_button.Text = "CONNECT";
            this.conn_button.UseVisualStyleBackColor = true;
            this.conn_button.Click += new System.EventHandler(this.conn_button_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Roboto Cn", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(36, 206);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1042, 337);
            this.textBox3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Bk", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 34);
            this.label3.TabIndex = 12;
            this.label3.Text = "KHỞI TẠO SERVER";
            // 
            // daketnoi_radio
            // 
            this.daketnoi_radio.AutoSize = true;
            this.daketnoi_radio.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daketnoi_radio.Location = new System.Drawing.Point(501, 162);
            this.daketnoi_radio.Name = "daketnoi_radio";
            this.daketnoi_radio.Size = new System.Drawing.Size(182, 28);
            this.daketnoi_radio.TabIndex = 14;
            this.daketnoi_radio.TabStop = true;
            this.daketnoi_radio.Text = "Đã có Client kết nối";
            this.daketnoi_radio.UseVisualStyleBackColor = true;
            // 
            // doiclient_radio
            // 
            this.doiclient_radio.AutoSize = true;
            this.doiclient_radio.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doiclient_radio.Location = new System.Drawing.Point(217, 162);
            this.doiclient_radio.Name = "doiclient_radio";
            this.doiclient_radio.Size = new System.Drawing.Size(242, 28);
            this.doiclient_radio.TabIndex = 14;
            this.doiclient_radio.TabStop = true;
            this.doiclient_radio.Text = "Đã khởi tạo/đang đợi client";
            this.doiclient_radio.UseVisualStyleBackColor = true;
            // 
            // chuakhoitao_radio
            // 
            this.chuakhoitao_radio.AutoSize = true;
            this.chuakhoitao_radio.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuakhoitao_radio.Location = new System.Drawing.Point(37, 162);
            this.chuakhoitao_radio.Name = "chuakhoitao_radio";
            this.chuakhoitao_radio.Size = new System.Drawing.Size(138, 28);
            this.chuakhoitao_radio.TabIndex = 14;
            this.chuakhoitao_radio.TabStop = true;
            this.chuakhoitao_radio.Text = "Chưa khởi tạo";
            this.chuakhoitao_radio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(939, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "DISCONNECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.disconn_button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(949, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 81);
            this.button2.TabIndex = 15;
            this.button2.Text = "GỬI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.send_click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Roboto Cn", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(36, 566);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(897, 81);
            this.textBox4.TabIndex = 13;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1111, 670);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chuakhoitao_radio);
            this.Controls.Add(this.doiclient_radio);
            this.Controls.Add(this.daketnoi_radio);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.conn_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button conn_button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton daketnoi_radio;
        private System.Windows.Forms.RadioButton doiclient_radio;
        private System.Windows.Forms.RadioButton chuakhoitao_radio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
    }
}

