﻿using System.Windows.Forms;

namespace TecShop.Presentation
{
    partial class SinUpSCreen
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
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinUpSCreen));
        //    pictureBox1 = new PictureBox();
        //    lb_welcomeLogin = new Label();
        //    tb_Email = new TextBox();
        //    lb_email = new Label();
        //    tb_UserName = new TextBox();
        //    lb_UserName = new Label();
        //    tb_Address = new TextBox();
        //    lb_Address = new Label();
        //    lb_Age = new Label();
        //    tb_Password = new TextBox();
        //    lb_password = new Label();
        //    numberic_Age = new NumericUpDown();
        //    btn_SignUp = new Button();
        //    Btn_Clear = new Button();
        //    lb_closeSignUp = new Label();
        //    lb_LoginHere = new Label();
        //    lb_messagehaveAccount = new Label();
        //    checkBox_ShowPass = new CheckBox();
        //    lb_checkEmail = new Label();
        //    lb_checkUserName = new Label();
        //    lb_checkPassword = new Label();
        //    lb_checkAge = new Label();
        //    ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)numberic_Age).BeginInit();
        //    SuspendLayout();
        //    // 
        //    // pictureBox1
        //    // 
        //    pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        //    pictureBox1.Location = new Point(12, 67);
        //    pictureBox1.Name = "pictureBox1";
        //    pictureBox1.Size = new Size(278, 500);
        //    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        //    pictureBox1.TabIndex = 0;
        //    pictureBox1.TabStop = false;
        //    // 
        //    // lb_welcomeLogin
        //    // 
        //    lb_welcomeLogin.AutoSize = true;
        //    lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
        //    lb_welcomeLogin.ForeColor = Color.FromArgb(230, 134, 57);
        //    lb_welcomeLogin.Location = new Point(357, 18);
        //    lb_welcomeLogin.Name = "lb_welcomeLogin";
        //    lb_welcomeLogin.Size = new Size(233, 46);
        //    lb_welcomeLogin.TabIndex = 18;
        //    lb_welcomeLogin.Text = "Get Started!!!";
        //    // 
        //    // tb_Email
        //    // 
        //    tb_Email.BackColor = Color.FromArgb(178, 197, 217);
        //    tb_Email.Font = new Font("Segoe UI", 15F);
        //    tb_Email.ForeColor = Color.White;
        //    tb_Email.Location = new Point(443, 161);
        //    tb_Email.Name = "tb_Email";
        //    tb_Email.Size = new Size(294, 34);
        //    tb_Email.TabIndex = 26;
        //    // 
        //    // lb_email
        //    // 
        //    lb_email.AutoSize = true;
        //    lb_email.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        //    lb_email.ForeColor = Color.FromArgb(43, 70, 139);
        //    lb_email.Location = new Point(335, 175);
        //    lb_email.Name = "lb_email";
        //    lb_email.Size = new Size(53, 20);
        //    lb_email.TabIndex = 25;
        //    lb_email.Text = "E-mail";
        //    // 
        //    // tb_UserName
        //    // 
        //    tb_UserName.BackColor = Color.FromArgb(178, 197, 217);
        //    tb_UserName.Font = new Font("Segoe UI", 15F);
        //    tb_UserName.ForeColor = Color.White;
        //    tb_UserName.Location = new Point(443, 77);
        //    tb_UserName.Name = "tb_UserName";
        //    tb_UserName.Size = new Size(294, 34);
        //    tb_UserName.TabIndex = 24;
        //    // 
        //    // lb_UserName
        //    // 
        //    lb_UserName.AutoSize = true;
        //    lb_UserName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        //    lb_UserName.ForeColor = Color.FromArgb(43, 70, 139);
        //    lb_UserName.Location = new Point(336, 91);
        //    lb_UserName.Name = "lb_UserName";
        //    lb_UserName.Size = new Size(83, 20);
        //    lb_UserName.TabIndex = 23;
        //    lb_UserName.Text = "UserName";
        //    // 
        //    // tb_Address
        //    // 
        //    tb_Address.BackColor = Color.FromArgb(178, 197, 217);
        //    tb_Address.Font = new Font("Segoe UI", 15F);
        //    tb_Address.ForeColor = Color.White;
        //    tb_Address.Location = new Point(442, 406);
        //    tb_Address.Name = "tb_Address";
        //    tb_Address.Size = new Size(295, 34);
        //    tb_Address.TabIndex = 33;
        //    // 
        //    // lb_Address
        //    // 
        //    lb_Address.AutoSize = true;
        //    lb_Address.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        //    lb_Address.ForeColor = Color.FromArgb(43, 70, 139);
        //    lb_Address.Location = new Point(335, 406);
        //    lb_Address.Name = "lb_Address";
        //    lb_Address.Size = new Size(66, 20);
        //    lb_Address.TabIndex = 31;
        //    lb_Address.Text = "Address";
        //    // 
        //    // lb_Age
        //    // 
        //    lb_Age.AutoSize = true;
        //    lb_Age.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        //    lb_Age.ForeColor = Color.FromArgb(43, 70, 139);
        //    lb_Age.Location = new Point(335, 321);
        //    lb_Age.Name = "lb_Age";
        //    lb_Age.Size = new Size(37, 20);
        //    lb_Age.TabIndex = 29;
        //    lb_Age.Text = "Age";
        //    // 
        //    // tb_Password
        //    // 
        //    tb_Password.BackColor = Color.FromArgb(178, 197, 217);
        //    tb_Password.Font = new Font("Segoe UI", 15F);
        //    tb_Password.ForeColor = Color.White;
        //    tb_Password.Location = new Point(442, 240);
        //    tb_Password.Name = "tb_Password";
        //    tb_Password.Size = new Size(295, 34);
        //    tb_Password.TabIndex = 28;
        //    tb_Password.UseSystemPasswordChar = true;
        //    // 
        //    // lb_password
        //    // 
        //    lb_password.AutoSize = true;
        //    lb_password.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        //    lb_password.ForeColor = Color.FromArgb(43, 70, 139);
        //    lb_password.Location = new Point(335, 243);
        //    lb_password.Name = "lb_password";
        //    lb_password.Size = new Size(76, 20);
        //    lb_password.TabIndex = 27;
        //    lb_password.Text = "Password";
        //    // 
        //    // numberic_Age
        //    // 
        //    numberic_Age.BackColor = Color.FromArgb(178, 197, 217);
        //    numberic_Age.Font = new Font("Segoe UI", 15F);
        //    numberic_Age.ForeColor = Color.White;
        //    numberic_Age.Location = new Point(442, 323);
        //    numberic_Age.Name = "numberic_Age";
        //    numberic_Age.Size = new Size(295, 34);
        //    numberic_Age.TabIndex = 32;
        //    // 
        //    // btn_SignUp
        //    // 
        //    btn_SignUp.BackColor = Color.FromArgb(134, 209, 205);
        //    btn_SignUp.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        //    btn_SignUp.ForeColor = Color.FromArgb(45, 58, 100);
        //    btn_SignUp.Location = new Point(443, 517);
        //    btn_SignUp.Name = "btn_SignUp";
        //    btn_SignUp.Size = new Size(139, 63);
        //    btn_SignUp.TabIndex = 34;
        //    btn_SignUp.Text = "SignUp";
        //    btn_SignUp.UseVisualStyleBackColor = false;
        //    //btn_SignUp.Click += btn_SignUp_Click;
        //    // 
        //    // Btn_Clear
        //    // 
        //    Btn_Clear.BackColor = Color.FromArgb(134, 209, 205);
        //    Btn_Clear.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        //    Btn_Clear.ForeColor = Color.FromArgb(45, 58, 100);
        //    Btn_Clear.Location = new Point(598, 517);
        //    Btn_Clear.Name = "Btn_Clear";
        //    Btn_Clear.Size = new Size(139, 63);
        //    Btn_Clear.TabIndex = 35;
        //    Btn_Clear.Text = "Clear";
        //    Btn_Clear.UseVisualStyleBackColor = false;
        //    //Btn_Clear.Click += Btn_Clear_Click;
        //    // 
        //    // lb_closeSignUp
        //    // 
        //    lb_closeSignUp.AutoSize = true;
        //    lb_closeSignUp.BackColor = Color.White;
        //    lb_closeSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        //    lb_closeSignUp.ForeColor = Color.FromArgb(50, 74, 133);
        //    lb_closeSignUp.Location = new Point(543, 601);
        //    lb_closeSignUp.Name = "lb_closeSignUp";
        //    lb_closeSignUp.Size = new Size(86, 21);
        //    lb_closeSignUp.TabIndex = 36;
        //    lb_closeSignUp.Text = "Close App";
        //    //lb_closeSignUp.Click += lb_closeSignUp_Click;
        //    // 
        //    // lb_LoginHere
        //    // 
        //    lb_LoginHere.AutoSize = true;
        //    lb_LoginHere.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        //    lb_LoginHere.ForeColor = Color.FromArgb(43, 70, 139);
        //    lb_LoginHere.Location = new Point(622, 460);
        //    lb_LoginHere.Name = "lb_LoginHere";
        //    lb_LoginHere.Size = new Size(97, 21);
        //    lb_LoginHere.TabIndex = 38;
        //    lb_LoginHere.Text = " Login Here";
        //    //lb_LoginHere.Click += lb_LoginHere_Click;
        //    // 
        //    // lb_messagehaveAccount
        //    // 
        //    lb_messagehaveAccount.AutoSize = true;
        //    lb_messagehaveAccount.Font = new Font("Segoe UI", 12F);
        //    lb_messagehaveAccount.ForeColor = Color.FromArgb(43, 70, 139);
        //    lb_messagehaveAccount.Location = new Point(442, 460);
        //    lb_messagehaveAccount.Name = "lb_messagehaveAccount";
        //    lb_messagehaveAccount.Size = new Size(186, 21);
        //    lb_messagehaveAccount.TabIndex = 37;
        //    lb_messagehaveAccount.Text = "Already have an account?";
        //    // 
        //    // checkBox_ShowPass
        //    // 
        //    checkBox_ShowPass.AutoSize = true;
        //    checkBox_ShowPass.Font = new Font("Segoe UI", 12F);
        //    checkBox_ShowPass.ForeColor = Color.FromArgb(43, 70, 139);
        //    checkBox_ShowPass.Location = new Point(613, 280);
        //    checkBox_ShowPass.Name = "checkBox_ShowPass";
        //    checkBox_ShowPass.Size = new Size(138, 25);
        //    checkBox_ShowPass.TabIndex = 39;
        //    checkBox_ShowPass.Text = "Show Password";
        //    checkBox_ShowPass.UseVisualStyleBackColor = true;
        //    //checkBox_ShowPass.CheckedChanged += checkBox_ShowPass_CheckedChanged;
        //    // 
        //    // lb_checkEmail
        //    // 
        //    lb_checkEmail.AutoSize = true;
        //    lb_checkEmail.Font = new Font("Segoe UI", 10F);
        //    lb_checkEmail.ForeColor = Color.FromArgb(230, 134, 57);
        //    lb_checkEmail.Location = new Point(446, 208);
        //    lb_checkEmail.Name = "lb_checkEmail";
        //    lb_checkEmail.Size = new Size(0, 19);
        //    lb_checkEmail.TabIndex = 40;
        //    // 
        //    // lb_checkUserName
        //    // 
        //    lb_checkUserName.AutoSize = true;
        //    lb_checkUserName.Font = new Font("Segoe UI", 10F);
        //    lb_checkUserName.ForeColor = Color.FromArgb(230, 134, 57);
        //    lb_checkUserName.Location = new Point(446, 125);
        //    lb_checkUserName.Name = "lb_checkUserName";
        //    lb_checkUserName.Size = new Size(0, 19);
        //    lb_checkUserName.TabIndex = 41;
        //    // 
        //    // lb_checkPassword
        //    // 
        //    lb_checkPassword.AutoSize = true;
        //    lb_checkPassword.Font = new Font("Segoe UI", 10F);
        //    lb_checkPassword.ForeColor = Color.FromArgb(230, 134, 57);
        //    lb_checkPassword.Location = new Point(446, 286);
        //    lb_checkPassword.Name = "lb_checkPassword";
        //    lb_checkPassword.Size = new Size(0, 19);
        //    lb_checkPassword.TabIndex = 42;
        //    // 
        //    // lb_checkAge
        //    // 
        //    lb_checkAge.AutoSize = true;
        //    lb_checkAge.Font = new Font("Segoe UI", 10F);
        //    lb_checkAge.ForeColor = Color.FromArgb(230, 134, 57);
        //    lb_checkAge.Location = new Point(446, 372);
        //    lb_checkAge.Name = "lb_checkAge";
        //    lb_checkAge.Size = new Size(0, 19);
        //    lb_checkAge.TabIndex = 43;
        //    // 
        //    // SignUp
        //    // 
        //    AutoScaleDimensions = new SizeF(7F, 15F);
        //    AutoScaleMode = AutoScaleMode.Font;
        //    BackColor = Color.White;
        //    ClientSize = new Size(777, 690);
        //    ControlBox = false;
        //    Controls.Add(lb_checkAge);
        //    Controls.Add(lb_checkPassword);
        //    Controls.Add(lb_checkUserName);
        //    Controls.Add(lb_checkEmail);
        //    Controls.Add(checkBox_ShowPass);
        //    Controls.Add(lb_LoginHere);
        //    Controls.Add(lb_messagehaveAccount);
        //    Controls.Add(lb_closeSignUp);
        //    Controls.Add(Btn_Clear);
        //    Controls.Add(btn_SignUp);
        //    Controls.Add(numberic_Age);
        //    Controls.Add(tb_Address);
        //    Controls.Add(lb_Address);
        //    Controls.Add(lb_Age);
        //    Controls.Add(tb_Password);
        //    Controls.Add(lb_password);
        //    Controls.Add(tb_Email);
        //    Controls.Add(lb_email);
        //    Controls.Add(tb_UserName);
        //    Controls.Add(lb_UserName);
        //    Controls.Add(lb_welcomeLogin);
        //    Controls.Add(pictureBox1);
        //    FormBorderStyle = FormBorderStyle.FixedToolWindow;
        //    Name = "SignUp";
        //    Text = "SignUp";
        //    ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)numberic_Age).EndInit();
        //    ResumeLayout(false);
        //    PerformLayout();

        //    #endregion
        //}
        private void InitializeComponent()
        {
            lb_welcomeLogin = new Label();
            tb_Email = new TextBox();
            lb_email = new Label();
            tb_UserName = new TextBox();
            lb_UserName = new Label();
            tb_Address = new TextBox();
            lb_Address = new Label();
            lb_Age = new Label();
            numberic_Age = new NumericUpDown();
            btn_SignUp = new Button();
            lb_checkEmail = new Label();
            lb_checkUserName = new Label();
            lb_checkPassword = new Label();
            lb_checkAge = new Label();
            Btn_Clear = new Button();
            lb_LoginHere = new Label();
            lb_messagehaveAccount = new Label();
            lb_password = new Label();
            checkBox_ShowPass = new CheckBox();
            tb_Password = new TextBox();
            pictureBox1 = new PictureBox();
            lb_close = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numberic_Age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).BeginInit();
            SuspendLayout();
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(32, 88, 138);
            lb_welcomeLogin.Location = new Point(526, 24);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(168, 57);
            lb_welcomeLogin.TabIndex = 18;
            lb_welcomeLogin.Text = "SingUp";
            // 
            // tb_Email
            // 
            tb_Email.BackColor = Color.FromArgb(236, 240, 241);
            tb_Email.Font = new Font("Segoe UI", 15F);
            tb_Email.ForeColor = Color.FromArgb(44, 62, 80);
            tb_Email.Location = new Point(434, 272);
            tb_Email.Margin = new Padding(3, 4, 3, 4);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(305, 41);
            tb_Email.TabIndex = 26;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_email.ForeColor = Color.FromArgb(146, 160, 144);
            lb_email.Location = new Point(434, 243);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(67, 25);
            lb_email.TabIndex = 25;
            lb_email.Text = "E-mail";
            // 
            // tb_UserName
            // 
            tb_UserName.BackColor = Color.FromArgb(236, 240, 241);
            tb_UserName.Font = new Font("Segoe UI", 15F);
            tb_UserName.ForeColor = Color.FromArgb(44, 62, 80);
            tb_UserName.Location = new Point(434, 171);
            tb_UserName.Margin = new Padding(3, 4, 3, 4);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(305, 41);
            tb_UserName.TabIndex = 24;
            // 
            // lb_UserName
            // 
            lb_UserName.AutoSize = true;
            lb_UserName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_UserName.ForeColor = Color.FromArgb(146, 160, 144);
            lb_UserName.Location = new Point(434, 127);
            lb_UserName.Name = "lb_UserName";
            lb_UserName.Size = new Size(104, 25);
            lb_UserName.TabIndex = 23;
            lb_UserName.Text = "UserName";
            // 
            // tb_Address
            // 
            tb_Address.BackColor = Color.FromArgb(236, 240, 241);
            tb_Address.Font = new Font("Segoe UI", 15F);
            tb_Address.ForeColor = Color.FromArgb(44, 62, 80);
            tb_Address.Location = new Point(434, 371);
            tb_Address.Margin = new Padding(3, 4, 3, 4);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(305, 41);
            tb_Address.TabIndex = 33;
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_Address.ForeColor = Color.FromArgb(146, 160, 144);
            lb_Address.Location = new Point(434, 332);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(83, 25);
            lb_Address.TabIndex = 31;
            lb_Address.Text = "Address";
            // 
            // lb_Age
            // 
            lb_Age.AutoSize = true;
            lb_Age.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_Age.ForeColor = Color.FromArgb(146, 160, 144);
            lb_Age.Location = new Point(792, 131);
            lb_Age.Name = "lb_Age";
            lb_Age.Size = new Size(47, 25);
            lb_Age.TabIndex = 29;
            lb_Age.Text = "Age";
            // 
            // numberic_Age
            // 
            numberic_Age.BackColor = Color.FromArgb(236, 240, 241);
            numberic_Age.Font = new Font("Segoe UI", 15F);
            numberic_Age.ForeColor = Color.FromArgb(44, 62, 80);
            numberic_Age.Location = new Point(792, 171);
            numberic_Age.Margin = new Padding(3, 4, 3, 4);
            numberic_Age.Name = "numberic_Age";
            numberic_Age.Size = new Size(314, 41);
            numberic_Age.TabIndex = 32;
            numberic_Age.ValueChanged += numberic_Age_ValueChanged;
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.Green;
            btn_SignUp.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_SignUp.ForeColor = Color.White;
            btn_SignUp.Location = new Point(629, 509);
            btn_SignUp.Margin = new Padding(3, 4, 3, 4);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(159, 84);
            btn_SignUp.TabIndex = 34;
            btn_SignUp.Text = "SignUp";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // lb_checkEmail
            // 
            lb_checkEmail.AutoSize = true;
            lb_checkEmail.Font = new Font("Segoe UI", 10F);
            lb_checkEmail.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkEmail.Location = new Point(766, 189);
            lb_checkEmail.Name = "lb_checkEmail";
            lb_checkEmail.Size = new Size(0, 23);
            lb_checkEmail.TabIndex = 40;
            // 
            // lb_checkUserName
            // 
            lb_checkUserName.AutoSize = true;
            lb_checkUserName.Font = new Font("Segoe UI", 10F);
            lb_checkUserName.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkUserName.Location = new Point(912, 188);
            lb_checkUserName.Name = "lb_checkUserName";
            lb_checkUserName.Size = new Size(0, 23);
            lb_checkUserName.TabIndex = 41;
            // 
            // lb_checkPassword
            // 
            lb_checkPassword.AutoSize = true;
            lb_checkPassword.Font = new Font("Segoe UI", 10F);
            lb_checkPassword.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkPassword.Location = new Point(1018, 315);
            lb_checkPassword.Name = "lb_checkPassword";
            lb_checkPassword.Size = new Size(0, 23);
            lb_checkPassword.TabIndex = 42;
            // 
            // lb_checkAge
            // 
            lb_checkAge.AutoSize = true;
            lb_checkAge.Font = new Font("Segoe UI", 10F);
            lb_checkAge.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkAge.Location = new Point(661, 307);
            lb_checkAge.Name = "lb_checkAge";
            lb_checkAge.Size = new Size(0, 23);
            lb_checkAge.TabIndex = 43;
            // 
            // Btn_Clear
            // 
            Btn_Clear.BackColor = Color.FromArgb(229, 27, 27);
            Btn_Clear.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Btn_Clear.ForeColor = Color.White;
            Btn_Clear.Location = new Point(805, 509);
            Btn_Clear.Margin = new Padding(3, 4, 3, 4);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(159, 84);
            Btn_Clear.TabIndex = 35;
            Btn_Clear.Text = "Clear";
            Btn_Clear.UseVisualStyleBackColor = false;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // lb_LoginHere
            // 
            lb_LoginHere.AutoSize = true;
            lb_LoginHere.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_LoginHere.ForeColor = Color.FromArgb(32, 88, 138);
            lb_LoginHere.Location = new Point(821, 440);
            lb_LoginHere.Name = "lb_LoginHere";
            lb_LoginHere.Size = new Size(121, 28);
            lb_LoginHere.TabIndex = 38;
            lb_LoginHere.Text = " Login Here";
            lb_LoginHere.Click += lb_LoginHere_Click;
            // 
            // lb_messagehaveAccount
            // 
            lb_messagehaveAccount.AutoSize = true;
            lb_messagehaveAccount.Font = new Font("Segoe UI", 12F);
            lb_messagehaveAccount.ForeColor = Color.FromArgb(146, 160, 144);
            lb_messagehaveAccount.Location = new Point(599, 440);
            lb_messagehaveAccount.Name = "lb_messagehaveAccount";
            lb_messagehaveAccount.Size = new Size(234, 28);
            lb_messagehaveAccount.TabIndex = 37;
            lb_messagehaveAccount.Text = "Already have an account?";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_password.ForeColor = Color.FromArgb(146, 160, 144);
            lb_password.Location = new Point(792, 243);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(97, 25);
            lb_password.TabIndex = 27;
            lb_password.Text = "Password";
            // 
            // checkBox_ShowPass
            // 
            checkBox_ShowPass.AutoSize = true;
            checkBox_ShowPass.Font = new Font("Segoe UI", 12F);
            checkBox_ShowPass.ForeColor = Color.FromArgb(146, 160, 144);
            checkBox_ShowPass.Location = new Point(938, 328);
            checkBox_ShowPass.Margin = new Padding(3, 4, 3, 4);
            checkBox_ShowPass.Name = "checkBox_ShowPass";
            checkBox_ShowPass.Size = new Size(168, 32);
            checkBox_ShowPass.TabIndex = 39;
            checkBox_ShowPass.Text = "Show Password";
            checkBox_ShowPass.UseVisualStyleBackColor = true;
            checkBox_ShowPass.CheckedChanged += checkBox_ShowPass_CheckedChanged;
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.FromArgb(236, 240, 241);
            tb_Password.Font = new Font("Segoe UI", 15F);
            tb_Password.ForeColor = Color.FromArgb(44, 62, 80);
            tb_Password.Location = new Point(792, 272);
            tb_Password.Margin = new Padding(3, 4, 3, 4);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(314, 41);
            tb_Password.TabIndex = 28;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImageSignUp2;
            pictureBox1.Location = new Point(50, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 444);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // lb_close
            // 
            lb_close.Image = Properties.Resources.Close;
            lb_close.Location = new Point(1093, 12);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(39, 41);
            lb_close.SizeMode = PictureBoxSizeMode.Zoom;
            lb_close.TabIndex = 45;
            lb_close.TabStop = false;
            lb_close.Click += lb_close_Click;
            // 
            // SinUpSCreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(1185, 658);
            ControlBox = false;
            Controls.Add(lb_close);
            Controls.Add(pictureBox1);
            Controls.Add(lb_checkAge);
            Controls.Add(lb_checkPassword);
            Controls.Add(lb_checkUserName);
            Controls.Add(lb_checkEmail);
            Controls.Add(checkBox_ShowPass);
            Controls.Add(lb_messagehaveAccount);
            Controls.Add(Btn_Clear);
            Controls.Add(btn_SignUp);
            Controls.Add(numberic_Age);
            Controls.Add(tb_Address);
            Controls.Add(lb_Address);
            Controls.Add(lb_Age);
            Controls.Add(tb_Password);
            Controls.Add(lb_password);
            Controls.Add(tb_Email);
            Controls.Add(lb_email);
            Controls.Add(tb_UserName);
            Controls.Add(lb_UserName);
            Controls.Add(lb_welcomeLogin);
            Controls.Add(lb_LoginHere);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SinUpSCreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)numberic_Age).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_welcomeLogin;
        private TextBox tb_Email;
        private Label lb_email;
        private TextBox tb_UserName;
        private Label lb_UserName;
        private TextBox tb_Address;
        private Label lb_Address;
        private Label lb_Age;
        private TextBox tb_Password;
        private Label lb_password;
        private NumericUpDown numberic_Age;
        private Button btn_SignUp;
        private Label lb_LoginHere;
        private Label lb_messagehaveAccount;
        private CheckBox checkBox_ShowPass;
        private Label lb_checkEmail;
        private Label lb_checkUserName;
        private Label lb_checkPassword;
        private Label lb_checkAge;
        private Button Btn_Clear;
        private PictureBox pictureBox1;
        private PictureBox lb_close;
    }
}