namespace TecShop.Presentation
{
    partial class AdminChangePasswordForm
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
            lb_welcomeLogin = new Label();
            cb_newPassword = new CheckBox();
            txt_oldPassword = new TextBox();
            lb_password = new Label();
            cb_oldPassword = new CheckBox();
            txt_newPassword = new TextBox();
            label1 = new Label();
            cb_confirmPassword = new CheckBox();
            txt_confirmPassword = new TextBox();
            label2 = new Label();
            btn_logout = new Button();
            btn_back = new Button();
            btn_updateProfile = new Button();
            SuspendLayout();
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(52, 152, 219);
            lb_welcomeLogin.Location = new Point(269, 9);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(371, 57);
            lb_welcomeLogin.TabIndex = 14;
            lb_welcomeLogin.Text = "Change Password";
            // 
            // cb_newPassword
            // 
            cb_newPassword.AutoSize = true;
            cb_newPassword.Font = new Font("Segoe UI", 12F);
            cb_newPassword.ForeColor = Color.FromArgb(64, 64, 64);
            cb_newPassword.Location = new Point(767, 299);
            cb_newPassword.Margin = new Padding(3, 4, 3, 4);
            cb_newPassword.Name = "cb_newPassword";
            cb_newPassword.Size = new Size(168, 32);
            cb_newPassword.TabIndex = 24;
            cb_newPassword.Text = "Show Password";
            cb_newPassword.UseVisualStyleBackColor = true;
            cb_newPassword.CheckedChanged += cb_newPassword_CheckedChanged;
            // 
            // txt_oldPassword
            // 
            txt_oldPassword.BackColor = Color.FromArgb(240, 240, 240);
            txt_oldPassword.BorderStyle = BorderStyle.FixedSingle;
            txt_oldPassword.Font = new Font("Segoe UI", 14F);
            txt_oldPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txt_oldPassword.Location = new Point(608, 148);
            txt_oldPassword.Margin = new Padding(3, 4, 3, 4);
            txt_oldPassword.Name = "txt_oldPassword";
            txt_oldPassword.Size = new Size(327, 39);
            txt_oldPassword.TabIndex = 23;
            txt_oldPassword.UseSystemPasswordChar = true;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_password.ForeColor = Color.FromArgb(64, 64, 64);
            lb_password.Location = new Point(459, 263);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(150, 28);
            lb_password.TabIndex = 22;
            lb_password.Text = "New Password";
            // 
            // cb_oldPassword
            // 
            cb_oldPassword.AutoSize = true;
            cb_oldPassword.Font = new Font("Segoe UI", 12F);
            cb_oldPassword.ForeColor = Color.FromArgb(64, 64, 64);
            cb_oldPassword.Location = new Point(767, 195);
            cb_oldPassword.Margin = new Padding(3, 4, 3, 4);
            cb_oldPassword.Name = "cb_oldPassword";
            cb_oldPassword.Size = new Size(288, 32);
            cb_oldPassword.TabIndex = 27;
            cb_oldPassword.Text = "Show old Password Password";
            cb_oldPassword.UseVisualStyleBackColor = true;
            cb_oldPassword.CheckedChanged += cb_oldPassword_CheckedChanged;
            // 
            // txt_newPassword
            // 
            txt_newPassword.BackColor = Color.FromArgb(240, 240, 240);
            txt_newPassword.BorderStyle = BorderStyle.FixedSingle;
            txt_newPassword.Font = new Font("Segoe UI", 14F);
            txt_newPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txt_newPassword.Location = new Point(608, 252);
            txt_newPassword.Margin = new Padding(3, 4, 3, 4);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.Size = new Size(327, 39);
            txt_newPassword.TabIndex = 26;
            txt_newPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(459, 152);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 25;
            label1.Text = "Old Password";
            // 
            // cb_confirmPassword
            // 
            cb_confirmPassword.AutoSize = true;
            cb_confirmPassword.Font = new Font("Segoe UI", 12F);
            cb_confirmPassword.ForeColor = Color.FromArgb(64, 64, 64);
            cb_confirmPassword.Location = new Point(767, 414);
            cb_confirmPassword.Margin = new Padding(3, 4, 3, 4);
            cb_confirmPassword.Name = "cb_confirmPassword";
            cb_confirmPassword.Size = new Size(168, 32);
            cb_confirmPassword.TabIndex = 30;
            cb_confirmPassword.Text = "Show Password";
            cb_confirmPassword.UseVisualStyleBackColor = true;
            cb_confirmPassword.CheckedChanged += cb_confirmPassword_CheckedChanged;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.BackColor = Color.FromArgb(240, 240, 240);
            txt_confirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txt_confirmPassword.Font = new Font("Segoe UI", 14F);
            txt_confirmPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txt_confirmPassword.Location = new Point(608, 367);
            txt_confirmPassword.Margin = new Padding(3, 4, 3, 4);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(327, 39);
            txt_confirmPassword.TabIndex = 29;
            txt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(426, 378);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 28;
            label2.Text = "Confirm Password";
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(231, 76, 60);
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(857, 9);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 40);
            btn_logout.TabIndex = 63;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 18);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 64;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_updateProfile
            // 
            btn_updateProfile.BackColor = Color.FromArgb(52, 152, 219);
            btn_updateProfile.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_updateProfile.ForeColor = Color.White;
            btn_updateProfile.Location = new Point(308, 509);
            btn_updateProfile.Margin = new Padding(3, 4, 3, 4);
            btn_updateProfile.Name = "btn_updateProfile";
            btn_updateProfile.Size = new Size(365, 84);
            btn_updateProfile.TabIndex = 65;
            btn_updateProfile.Text = "Update";
            btn_updateProfile.UseVisualStyleBackColor = false;
            btn_updateProfile.Click += btn_updateProfile_Click;
            // 
            // AdminChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 606);
            Controls.Add(btn_updateProfile);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(cb_confirmPassword);
            Controls.Add(txt_confirmPassword);
            Controls.Add(label2);
            Controls.Add(cb_oldPassword);
            Controls.Add(txt_newPassword);
            Controls.Add(label1);
            Controls.Add(cb_newPassword);
            Controls.Add(txt_oldPassword);
            Controls.Add(lb_password);
            Controls.Add(lb_welcomeLogin);
            Name = "AdminChangePasswordForm";
            Text = "AdminChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_welcomeLogin;
        private CheckBox cb_newPassword;
        private TextBox txt_oldPassword;
        private Label lb_password;
        private CheckBox cb_oldPassword;
        private TextBox txt_newPassword;
        private Label label1;
        private CheckBox cb_confirmPassword;
        private TextBox txt_confirmPassword;
        private Label label2;
        private Button btn_logout;
        private Button btn_back;
        private Button btn_updateProfile;
    }
}