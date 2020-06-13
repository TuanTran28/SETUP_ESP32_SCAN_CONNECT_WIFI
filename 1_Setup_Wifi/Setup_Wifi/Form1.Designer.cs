namespace Setup_Wifi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Connect_Port = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SelectParity = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SelectBaurate = new System.Windows.Forms.ComboBox();
            this.StopBit = new System.Windows.Forms.ComboBox();
            this.DataBit = new System.Windows.Forms.ComboBox();
            this.SelectCom = new System.Windows.Forms.ComboBox();
            this.Connect_Wifi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Check_SSID = new System.Windows.Forms.CheckBox();
            this.SSID_Name = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.ErrorText_WifiStatus = new System.Windows.Forms.TextBox();
            this.Password_Text = new System.Windows.Forms.TextBox();
            this.Error2_Text = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.List_SSID = new System.Windows.Forms.ComboBox();
            this.GateCom = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Connect_Port);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.SelectParity);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.SelectBaurate);
            this.groupBox1.Controls.Add(this.StopBit);
            this.groupBox1.Controls.Add(this.DataBit);
            this.groupBox1.Controls.Add(this.SelectCom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(30, 333);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(200, 45);
            this.textBox10.TabIndex = 6;
            this.textBox10.Text = "Status";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(30, 19);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 45);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Select and Set up COMPORT ";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Select COM";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Connect_Port
            // 
            this.Connect_Port.BackColor = System.Drawing.Color.Cyan;
            this.Connect_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_Port.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Connect_Port.Location = new System.Drawing.Point(63, 245);
            this.Connect_Port.Name = "Connect_Port";
            this.Connect_Port.Size = new System.Drawing.Size(138, 66);
            this.Connect_Port.TabIndex = 4;
            this.Connect_Port.Text = "Connect";
            this.Connect_Port.UseVisualStyleBackColor = false;
            this.Connect_Port.Click += new System.EventHandler(this.Connect_Port_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(14, 199);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "Parity";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectParity
            // 
            this.SelectParity.FormattingEnabled = true;
            this.SelectParity.Location = new System.Drawing.Point(120, 199);
            this.SelectParity.Name = "SelectParity";
            this.SelectParity.Size = new System.Drawing.Size(121, 21);
            this.SelectParity.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 172);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "StopBit";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 145);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Databits";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 118);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Baurate";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectBaurate
            // 
            this.SelectBaurate.FormattingEnabled = true;
            this.SelectBaurate.Location = new System.Drawing.Point(120, 118);
            this.SelectBaurate.Name = "SelectBaurate";
            this.SelectBaurate.Size = new System.Drawing.Size(121, 21);
            this.SelectBaurate.TabIndex = 0;
            // 
            // StopBit
            // 
            this.StopBit.FormattingEnabled = true;
            this.StopBit.Location = new System.Drawing.Point(120, 172);
            this.StopBit.Name = "StopBit";
            this.StopBit.Size = new System.Drawing.Size(121, 21);
            this.StopBit.TabIndex = 0;
            // 
            // DataBit
            // 
            this.DataBit.FormattingEnabled = true;
            this.DataBit.Location = new System.Drawing.Point(120, 145);
            this.DataBit.Name = "DataBit";
            this.DataBit.Size = new System.Drawing.Size(121, 21);
            this.DataBit.TabIndex = 0;
            // 
            // SelectCom
            // 
            this.SelectCom.FormattingEnabled = true;
            this.SelectCom.ItemHeight = 13;
            this.SelectCom.Location = new System.Drawing.Point(120, 91);
            this.SelectCom.Name = "SelectCom";
            this.SelectCom.Size = new System.Drawing.Size(121, 21);
            this.SelectCom.TabIndex = 0;
            // 
            // Connect_Wifi
            // 
            this.Connect_Wifi.BackColor = System.Drawing.Color.Cyan;
            this.Connect_Wifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_Wifi.Location = new System.Drawing.Point(255, 208);
            this.Connect_Wifi.Name = "Connect_Wifi";
            this.Connect_Wifi.Size = new System.Drawing.Size(97, 65);
            this.Connect_Wifi.TabIndex = 0;
            this.Connect_Wifi.Text = "CONNECT WIFI";
            this.Connect_Wifi.UseVisualStyleBackColor = false;
            this.Connect_Wifi.Click += new System.EventHandler(this.Connect_Wifi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.Check_SSID);
            this.groupBox2.Controls.Add(this.SSID_Name);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.ErrorText_WifiStatus);
            this.groupBox2.Controls.Add(this.Password_Text);
            this.groupBox2.Controls.Add(this.Error2_Text);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.Connect_Wifi);
            this.groupBox2.Controls.Add(this.List_SSID);
            this.groupBox2.Location = new System.Drawing.Point(288, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Check_SSID
            // 
            this.Check_SSID.AutoSize = true;
            this.Check_SSID.Location = new System.Drawing.Point(262, 172);
            this.Check_SSID.Name = "Check_SSID";
            this.Check_SSID.Size = new System.Drawing.Size(116, 17);
            this.Check_SSID.TabIndex = 10;
            this.Check_SSID.Text = "Get From List SSID";
            this.Check_SSID.UseVisualStyleBackColor = true;
            // 
            // SSID_Name
            // 
            this.SSID_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSID_Name.Location = new System.Drawing.Point(262, 139);
            this.SSID_Name.Multiline = true;
            this.SSID_Name.Name = "SSID_Name";
            this.SSID_Name.Size = new System.Drawing.Size(175, 21);
            this.SSID_Name.TabIndex = 9;
            this.SSID_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(262, 100);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(175, 21);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "SSID";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorText_WifiStatus
            // 
            this.ErrorText_WifiStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText_WifiStatus.Location = new System.Drawing.Point(201, 333);
            this.ErrorText_WifiStatus.Multiline = true;
            this.ErrorText_WifiStatus.Name = "ErrorText_WifiStatus";
            this.ErrorText_WifiStatus.Size = new System.Drawing.Size(200, 45);
            this.ErrorText_WifiStatus.TabIndex = 6;
            this.ErrorText_WifiStatus.Text = "Status";
            this.ErrorText_WifiStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password_Text
            // 
            this.Password_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Text.Location = new System.Drawing.Point(465, 137);
            this.Password_Text.Multiline = true;
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(135, 21);
            this.Password_Text.TabIndex = 7;
            this.Password_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Error2_Text
            // 
            this.Error2_Text.BackColor = System.Drawing.Color.Red;
            this.Error2_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error2_Text.Location = new System.Drawing.Point(236, 279);
            this.Error2_Text.Multiline = true;
            this.Error2_Text.Name = "Error2_Text";
            this.Error2_Text.Size = new System.Drawing.Size(130, 31);
            this.Error2_Text.TabIndex = 6;
            this.Error2_Text.Text = "Disconected";
            this.Error2_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(255, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 65);
            this.button2.TabIndex = 0;
            this.button2.Text = "Refresh WIFI LIST";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(465, 100);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(135, 21);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "Password";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(31, 100);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(193, 21);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "LIST SSID";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // List_SSID
            // 
            this.List_SSID.FormattingEnabled = true;
            this.List_SSID.ItemHeight = 13;
            this.List_SSID.Location = new System.Drawing.Point(31, 139);
            this.List_SSID.Name = "List_SSID";
            this.List_SSID.Size = new System.Drawing.Size(193, 21);
            this.List_SSID.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox SelectBaurate;
        private System.Windows.Forms.ComboBox StopBit;
        private System.Windows.Forms.ComboBox DataBit;
        private System.Windows.Forms.ComboBox SelectCom;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox SelectParity;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Connect_Port;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox List_SSID;
        private System.Windows.Forms.Button Connect_Wifi;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox Password_Text;
        private System.Windows.Forms.TextBox Error2_Text;
        private System.IO.Ports.SerialPort GateCom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox ErrorText_WifiStatus;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox SSID_Name;
        private System.Windows.Forms.CheckBox Check_SSID;
    }
}

