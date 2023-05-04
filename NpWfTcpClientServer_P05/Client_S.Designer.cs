namespace NpWfTcpClientServer_P05
{
    partial class Client_S
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.regLogin = new System.Windows.Forms.TextBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logLogin = new System.Windows.Forms.TextBox();
            this.logPassword = new System.Windows.Forms.TextBox();
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.okRegButton = new System.Windows.Forms.Button();
            this.okLogButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(35, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(408, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message:";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(233, 75);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 23);
            this.tbIP.TabIndex = 4;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(446, 75);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 23);
            this.tbPort.TabIndex = 5;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(115, 170);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(431, 23);
            this.tbMessage.TabIndex = 6;
            // 
            // regLogin
            // 
            this.regLogin.Location = new System.Drawing.Point(768, 69);
            this.regLogin.Name = "regLogin";
            this.regLogin.Size = new System.Drawing.Size(100, 23);
            this.regLogin.TabIndex = 7;
            // 
            // regPassword
            // 
            this.regPassword.Location = new System.Drawing.Point(768, 115);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(100, 23);
            this.regPassword.TabIndex = 8;
            this.regPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(779, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Registration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(968, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Login";
            // 
            // logLogin
            // 
            this.logLogin.Location = new System.Drawing.Point(944, 68);
            this.logLogin.Name = "logLogin";
            this.logLogin.Size = new System.Drawing.Size(100, 23);
            this.logLogin.TabIndex = 13;
            // 
            // logPassword
            // 
            this.logPassword.Location = new System.Drawing.Point(944, 115);
            this.logPassword.Name = "logPassword";
            this.logPassword.Size = new System.Drawing.Size(100, 23);
            this.logPassword.TabIndex = 14;
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Location = new System.Drawing.Point(779, 170);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(78, 23);
            this.RegistrationBtn.TabIndex = 15;
            this.RegistrationBtn.Text = "Registration";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(968, 169);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 16;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // okRegButton
            // 
            this.okRegButton.Location = new System.Drawing.Point(779, 207);
            this.okRegButton.Name = "okRegButton";
            this.okRegButton.Size = new System.Drawing.Size(75, 23);
            this.okRegButton.TabIndex = 17;
            this.okRegButton.Text = "Ok";
            this.okRegButton.UseVisualStyleBackColor = true;
            this.okRegButton.Click += new System.EventHandler(this.okRegButton_Click);
            // 
            // okLogButton
            // 
            this.okLogButton.Location = new System.Drawing.Point(968, 207);
            this.okLogButton.Name = "okLogButton";
            this.okLogButton.Size = new System.Drawing.Size(75, 23);
            this.okLogButton.TabIndex = 18;
            this.okLogButton.Text = "Ok";
            this.okLogButton.UseVisualStyleBackColor = true;
            this.okLogButton.Click += new System.EventHandler(this.okLogButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(35, 269);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1009, 244);
            this.listBox1.TabIndex = 19;
            // 
            // Client_S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 536);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.okLogButton);
            this.Controls.Add(this.okRegButton);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.RegistrationBtn);
            this.Controls.Add(this.logPassword);
            this.Controls.Add(this.logLogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.regLogin);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Client_S";
            this.Text = "\\";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbIP;
        private TextBox tbPort;
        private TextBox tbMessage;
        private TextBox regLogin;
        private TextBox regPassword;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox logLogin;
        private TextBox logPassword;
        private Button RegistrationBtn;
        private Button LoginBtn;
        private Button okRegButton;
        private Button okLogButton;
        private ListBox listBox1;
    }
}