﻿using System.Windows.Forms;

namespace TecShop.Presentation
{
    partial class LoginScreen
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
        //private void InitializeComponent()
        //{
        //    btn_clear = new Button();
        //    checkBox_ShowPass = new CheckBox();
        //    lb_SignUp = new Label();
        //    lb_messageDonothave = new Label();
        //    button1 = new Button();
        //    tb_Password = new TextBox();
        //    lb_password = new Label();
        //    tb_UserName = new TextBox();
        //    lb_Email = new Label();
        //    lb_welcomeLogin = new Label();
        //    pictureBox1 = new PictureBox();
        //    lb_closeLogin = new Label();
        //    ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        //    SuspendLayout();
        //    // 
        //    // btn_clear
        //    // 
        //    btn_clear.BackColor = Color.FromArgb(225, 241, 251);
        //    btn_clear.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        //    btn_clear.ForeColor = Color.FromArgb(50, 74, 133);
        //    btn_clear.Location = new Point(666, 321);
        //    btn_clear.Name = "btn_clear";
        //    btn_clear.Size = new Size(147, 55);
        //    btn_clear.TabIndex = 22;
        //    btn_clear.Text = "Clear ";
        //    btn_clear.UseVisualStyleBackColor = false;
        //    //btn_clear.Click += btn_clear_Click;
        //    // 
        //    // checkBox_ShowPass
        //    // 
        //    checkBox_ShowPass.AutoSize = true;
        //    checkBox_ShowPass.Font = new Font("Segoe UI", 12F);
        //    checkBox_ShowPass.ForeColor = Color.FromArgb(50, 74, 133);
        //    checkBox_ShowPass.Location = new Point(666, 245);
        //    checkBox_ShowPass.Name = "checkBox_ShowPass";
        //    checkBox_ShowPass.Size = new Size(138, 25);
        //    checkBox_ShowPass.TabIndex = 21;
        //    checkBox_ShowPass.Text = "Show Password";
        //    checkBox_ShowPass.UseVisualStyleBackColor = true;
        //    //checkBox_ShowPass.CheckedChanged += checkBox_ShowPass_CheckedChanged;
        //    // 
        //    // lb_SignUp
        //    // 
        //    lb_SignUp.AutoSize = true;
        //    lb_SignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        //    lb_SignUp.ForeColor = Color.FromArgb(50, 74, 133);
        //    lb_SignUp.Location = new Point(648, 282);
        //    lb_SignUp.Name = "lb_SignUp";
        //    lb_SignUp.Size = new Size(66, 21);
        //    lb_SignUp.TabIndex = 20;
        //    lb_SignUp.Text = "SignUp";
        //    //lb_SignUp.Click += lb_SignUp_Click;
        //    // 
        //    // lb_messageDonothave
        //    // 
        //    lb_messageDonothave.AutoSize = true;
        //    lb_messageDonothave.Font = new Font("Segoe UI", 12F);
        //    lb_messageDonothave.ForeColor = Color.FromArgb(50, 74, 133);
        //    lb_messageDonothave.Location = new Point(478, 282);
        //    lb_messageDonothave.Name = "lb_messageDonothave";
        //    lb_messageDonothave.Size = new Size(175, 21);
        //    lb_messageDonothave.TabIndex = 19;
        //    lb_messageDonothave.Text = "Don't have an account ?";
        //    // 
        //    // button1
        //    // 
        //    button1.BackColor = Color.FromArgb(225, 241, 251);
        //    button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        //    button1.ForeColor = Color.FromArgb(50, 74, 133);
        //    button1.Location = new Point(478, 321);
        //    button1.Name = "button1";
        //    button1.Size = new Size(147, 55);
        //    button1.TabIndex = 18;
        //    button1.Text = "LOGIN";
        //    button1.UseVisualStyleBackColor = false;
        //    //button1.Click += button1_Click;
        //    // 
        //    // tb_Password
        //    // 
        //    tb_Password.BackColor = Color.FromArgb(178, 197, 217);
        //    tb_Password.Font = new Font("Segoe UI", 20F);
        //    tb_Password.ForeColor = Color.White;
        //    tb_Password.Location = new Point(478, 192);
        //    tb_Password.Name = "tb_Password";
        //    tb_Password.Size = new Size(286, 43);
        //    tb_Password.TabIndex = 17;
        //    tb_Password.UseSystemPasswordChar = true;
        //    // 
        //    // lb_password
        //    // 
        //    lb_password.AutoSize = true;
        //    lb_password.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        //    lb_password.ForeColor = Color.FromArgb(50, 74, 133);
        //    lb_password.Location = new Point(371, 195);
        //    lb_password.Name = "lb_password";
        //    lb_password.Size = new Size(76, 20);
        //    lb_password.TabIndex = 16;
        //    lb_password.Text = "Password";
        //    // 
        //    // tb_UserName
        //    // 
        //    tb_UserName.BackColor = Color.FromArgb(178, 197, 217);
        //    tb_UserName.Font = new Font("Segoe UI", 20F);
        //    tb_UserName.ForeColor = Color.White;
        //    tb_UserName.Location = new Point(478, 120);
        //    tb_UserName.Name = "tb_UserName";
        //    tb_UserName.Size = new Size(286, 43);
        //    tb_UserName.TabIndex = 15;
        //    // 
        //    // lb_Email
        //    // 
        //    lb_Email.AutoSize = true;
        //    lb_Email.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        //    lb_Email.ForeColor = Color.FromArgb(50, 74, 133);
        //    lb_Email.Location = new Point(371, 123);
        //    lb_Email.Name = "lb_Email";
        //    lb_Email.Size = new Size(47, 20);
        //    lb_Email.TabIndex = 14;
        //    lb_Email.Text = "Email";
        //    // 
        //    // lb_welcomeLogin
        //    // 
        //    lb_welcomeLogin.AutoSize = true;
        //    lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
        //    lb_welcomeLogin.ForeColor = Color.FromArgb(50, 74, 133);
        //    lb_welcomeLogin.Location = new Point(357, 43);
        //    lb_welcomeLogin.Name = "lb_welcomeLogin";
        //    lb_welcomeLogin.Size = new Size(271, 46);
        //    lb_welcomeLogin.TabIndex = 13;
        //    lb_welcomeLogin.Text = "Welcome Back !";
        //    // 
        //    // pictureBox1
        //    // 
        //    //pictureBox1.Image = Properties.Resources.Login_Icon;
        //    //pictureBox1.Location = new Point(5, 12);
        //    //pictureBox1.Name = "pictureBox1";
        //    //pictureBox1.Size = new Size(346, 452);
        //    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    //pictureBox1.TabIndex = 12;
        //    //pictureBox1.TabStop = false;
        //    // 
        //    // lb_closeLogin
        //    // 
        //    lb_closeLogin.AutoSize = true;
        //    lb_closeLogin.BackColor = Color.FromArgb(225, 241, 251);
        //    lb_closeLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        //    lb_closeLogin.ForeColor = Color.FromArgb(50, 74, 133);
        //    lb_closeLogin.Location = new Point(601, 390);
        //    lb_closeLogin.Name = "lb_closeLogin";
        //    lb_closeLogin.Size = new Size(86, 21);
        //    lb_closeLogin.TabIndex = 23;
        //    lb_closeLogin.Text = "Close App";
        //    //lb_closeLogin.Click += lb_closeApp_Click;
        //    // 
        //    // Login
        //    // 
        //    AutoScaleDimensions = new SizeF(7F, 15F);
        //    AutoScaleMode = AutoScaleMode.Font;
        //    BackColor = Color.FromArgb(227, 241, 250);
        //    ClientSize = new Size(840, 489);
        //    ControlBox = false;
        //    Controls.Add(lb_closeLogin);
        //    Controls.Add(btn_clear);
        //    Controls.Add(checkBox_ShowPass);
        //    Controls.Add(lb_SignUp);
        //    Controls.Add(lb_messageDonothave);
        //    Controls.Add(button1);
        //    Controls.Add(tb_Password);
        //    Controls.Add(lb_password);
        //    Controls.Add(tb_UserName);
        //    Controls.Add(lb_Email);
        //    Controls.Add(lb_welcomeLogin);
        //    Controls.Add(pictureBox1);
        //    FormBorderStyle = FormBorderStyle.FixedToolWindow;
        //    Name = "Login";
        //    Text = "Login";
        //    //Load += Login_Load;
        //    ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        //    ResumeLayout(false);
        //    PerformLayout();
        //}
        private void InitializeComponent()
        {
            btn_clear = new Button();
            checkBox_ShowPass = new CheckBox();
            lb_SignUp = new Label();
            lb_messageDonothave = new Label();
            button1 = new Button();
            tb_Password = new TextBox();
            lb_password = new Label();
            tb_UserName = new TextBox();
            lb_Email = new Label();
            lb_welcomeLogin = new Label();
            lb_closeLogin = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(229, 27, 27);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_clear.ForeColor = SystemColors.Window;
            btn_clear.Location = new Point(698, 389);
            btn_clear.Margin = new Padding(3, 4, 3, 4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(168, 73);
            btn_clear.TabIndex = 22;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // checkBox_ShowPass
            // 
            checkBox_ShowPass.AutoSize = true;
            checkBox_ShowPass.Font = new Font("Segoe UI", 12F);
            checkBox_ShowPass.ForeColor = Color.FromArgb(146, 160, 144);
            checkBox_ShowPass.Location = new Point(501, 301);
            checkBox_ShowPass.Margin = new Padding(3, 4, 3, 4);
            checkBox_ShowPass.Name = "checkBox_ShowPass";
            checkBox_ShowPass.Size = new Size(168, 32);
            checkBox_ShowPass.TabIndex = 21;
            checkBox_ShowPass.Text = "Show Password";
            checkBox_ShowPass.UseVisualStyleBackColor = true;
            checkBox_ShowPass.CheckedChanged += checkBox_ShowPass_CheckedChanged;
            // 
            // lb_SignUp
            // 
            lb_SignUp.AutoSize = true;
            lb_SignUp.Cursor = Cursors.Hand;
            lb_SignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_SignUp.ForeColor = Color.FromArgb(59, 119, 149);
            lb_SignUp.Location = new Point(688, 337);
            lb_SignUp.Name = "lb_SignUp";
            lb_SignUp.Size = new Size(79, 28);
            lb_SignUp.TabIndex = 20;
            lb_SignUp.Text = "SignUp";
            lb_SignUp.Click += lb_SignUp_Click;
            // 
            // lb_messageDonothave
            // 
            lb_messageDonothave.AutoSize = true;
            lb_messageDonothave.Font = new Font("Segoe UI", 12F);
            lb_messageDonothave.ForeColor = Color.FromArgb(146, 160, 144);
            lb_messageDonothave.Location = new Point(501, 337);
            lb_messageDonothave.Name = "lb_messageDonothave";
            lb_messageDonothave.Size = new Size(216, 28);
            lb_messageDonothave.TabIndex = 19;
            lb_messageDonothave.Text = "Don't have an account?";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(501, 389);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(168, 73);
            button1.TabIndex = 18;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.FromArgb(240, 240, 240);
            tb_Password.BorderStyle = BorderStyle.FixedSingle;
            tb_Password.Font = new Font("Segoe UI", 15F);
            tb_Password.ForeColor = Color.FromArgb(64, 64, 64);
            tb_Password.Location = new Point(501, 253);
            tb_Password.Margin = new Padding(3, 4, 3, 4);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(365, 41);
            tb_Password.TabIndex = 17;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_password.ForeColor = Color.FromArgb(146, 160, 144);
            lb_password.Location = new Point(501, 221);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(101, 28);
            lb_password.TabIndex = 16;
            lb_password.Text = "Password";
            // 
            // tb_UserName
            // 
            tb_UserName.BackColor = Color.FromArgb(240, 240, 240);
            tb_UserName.BorderStyle = BorderStyle.FixedSingle;
            tb_UserName.Font = new Font("Segoe UI", 15F);
            tb_UserName.ForeColor = Color.FromArgb(64, 64, 64);
            tb_UserName.Location = new Point(501, 149);
            tb_UserName.Margin = new Padding(3, 4, 3, 4);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(365, 41);
            tb_UserName.TabIndex = 15;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Email.ForeColor = Color.FromArgb(146, 160, 144);
            lb_Email.Location = new Point(501, 117);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(116, 28);
            lb_Email.TabIndex = 14;
            lb_Email.Text = "User Name";
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.BackColor = Color.Transparent;
            lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(59, 119, 149);
            lb_welcomeLogin.Location = new Point(313, 19);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(327, 57);
            lb_welcomeLogin.TabIndex = 13;
            lb_welcomeLogin.Text = "Welcome Back!";
            lb_welcomeLogin.Click += lb_welcomeLogin_Click;
            // 
            // lb_closeLogin
            // 
            lb_closeLogin.AutoSize = true;
            lb_closeLogin.Cursor = Cursors.Hand;
            lb_closeLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_closeLogin.ForeColor = Color.FromArgb(52, 152, 219);
            lb_closeLogin.Location = new Point(1056, 608);
            lb_closeLogin.Name = "lb_closeLogin";
            lb_closeLogin.Size = new Size(106, 28);
            lb_closeLogin.TabIndex = 23;
            lb_closeLogin.Text = "Close App";
            lb_closeLogin.Click += lb_closeLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imageLogin2;
            pictureBox1.Location = new Point(11, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 352);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close;
            pictureBox2.Location = new Point(879, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(969, 538);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lb_closeLogin);
            Controls.Add(btn_clear);
            Controls.Add(checkBox_ShowPass);
            Controls.Add(lb_SignUp);
            Controls.Add(lb_messageDonothave);
            Controls.Add(button1);
            Controls.Add(tb_Password);
            Controls.Add(lb_password);
            Controls.Add(tb_UserName);
            Controls.Add(lb_Email);
            Controls.Add(lb_welcomeLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Button btn_clear;
        private CheckBox checkBox_ShowPass;
        private Label lb_SignUp;
        private Label lb_messageDonothave;
        private Button button1;
        private TextBox tb_Password;
        private Label lb_password;
        private TextBox tb_UserName;
        private Label lb_Email;
        private Label lb_welcomeLogin;
        private Label lb_closeLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}