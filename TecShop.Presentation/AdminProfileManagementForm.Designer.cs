namespace TecShop.Presentation
{
    partial class AdminProfileManagementForm
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
            btn_back = new Button();
            btn_logout = new Button();
            btn_changePassword = new Button();
            lb_checkAge = new Label();
            lb_checkPassword = new Label();
            lb_checkUserName = new Label();
            lb_checkEmail = new Label();
            btn_updateProfile = new Button();
            numberic_Age = new NumericUpDown();
            tb_Address = new TextBox();
            lb_Address = new Label();
            lb_Age = new Label();
            tb_Email = new TextBox();
            lb_email = new Label();
            tb_UserName = new TextBox();
            lb_UserName = new Label();
            lb_welcomeLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)numberic_Age).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 63;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(231, 76, 60);
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(796, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 40);
            btn_logout.TabIndex = 62;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_changePassword
            // 
            btn_changePassword.BackColor = Color.FromArgb(52, 152, 219);
            btn_changePassword.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_changePassword.ForeColor = Color.White;
            btn_changePassword.Location = new Point(481, 525);
            btn_changePassword.Margin = new Padding(3, 4, 3, 4);
            btn_changePassword.Name = "btn_changePassword";
            btn_changePassword.Size = new Size(365, 84);
            btn_changePassword.TabIndex = 61;
            btn_changePassword.Text = "Change Password";
            btn_changePassword.UseVisualStyleBackColor = false;
            btn_changePassword.Click += btn_changePassword_Click;
            // 
            // lb_checkAge
            // 
            lb_checkAge.AutoSize = true;
            lb_checkAge.Font = new Font("Segoe UI", 10F);
            lb_checkAge.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkAge.Location = new Point(527, 366);
            lb_checkAge.Name = "lb_checkAge";
            lb_checkAge.Size = new Size(0, 23);
            lb_checkAge.TabIndex = 60;
            // 
            // lb_checkPassword
            // 
            lb_checkPassword.AutoSize = true;
            lb_checkPassword.Font = new Font("Segoe UI", 10F);
            lb_checkPassword.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkPassword.Location = new Point(526, 365);
            lb_checkPassword.Name = "lb_checkPassword";
            lb_checkPassword.Size = new Size(0, 23);
            lb_checkPassword.TabIndex = 59;
            // 
            // lb_checkUserName
            // 
            lb_checkUserName.AutoSize = true;
            lb_checkUserName.Font = new Font("Segoe UI", 10F);
            lb_checkUserName.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkUserName.Location = new Point(526, 151);
            lb_checkUserName.Name = "lb_checkUserName";
            lb_checkUserName.Size = new Size(0, 23);
            lb_checkUserName.TabIndex = 58;
            // 
            // lb_checkEmail
            // 
            lb_checkEmail.AutoSize = true;
            lb_checkEmail.Font = new Font("Segoe UI", 10F);
            lb_checkEmail.ForeColor = Color.FromArgb(231, 76, 60);
            lb_checkEmail.Location = new Point(526, 261);
            lb_checkEmail.Name = "lb_checkEmail";
            lb_checkEmail.Size = new Size(0, 23);
            lb_checkEmail.TabIndex = 57;
            // 
            // btn_updateProfile
            // 
            btn_updateProfile.BackColor = Color.FromArgb(52, 152, 219);
            btn_updateProfile.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_updateProfile.ForeColor = Color.White;
            btn_updateProfile.Location = new Point(86, 525);
            btn_updateProfile.Margin = new Padding(3, 4, 3, 4);
            btn_updateProfile.Name = "btn_updateProfile";
            btn_updateProfile.Size = new Size(365, 84);
            btn_updateProfile.TabIndex = 56;
            btn_updateProfile.Text = "Update";
            btn_updateProfile.UseVisualStyleBackColor = false;
            btn_updateProfile.Click += btn_updateProfile_Click;
            // 
            // numberic_Age
            // 
            numberic_Age.BackColor = Color.FromArgb(236, 240, 241);
            numberic_Age.Font = new Font("Segoe UI", 15F);
            numberic_Age.ForeColor = Color.FromArgb(44, 62, 80);
            numberic_Age.Location = new Point(301, 320);
            numberic_Age.Margin = new Padding(3, 4, 3, 4);
            numberic_Age.Name = "numberic_Age";
            numberic_Age.Size = new Size(337, 41);
            numberic_Age.TabIndex = 54;
            // 
            // tb_Address
            // 
            tb_Address.BackColor = Color.FromArgb(236, 240, 241);
            tb_Address.Font = new Font("Segoe UI", 15F);
            tb_Address.ForeColor = Color.FromArgb(44, 62, 80);
            tb_Address.Location = new Point(301, 430);
            tb_Address.Margin = new Padding(3, 4, 3, 4);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(337, 41);
            tb_Address.TabIndex = 55;
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_Address.ForeColor = Color.FromArgb(44, 62, 80);
            lb_Address.Location = new Point(179, 430);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(83, 25);
            lb_Address.TabIndex = 53;
            lb_Address.Text = "Address";
            // 
            // lb_Age
            // 
            lb_Age.AutoSize = true;
            lb_Age.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_Age.ForeColor = Color.FromArgb(44, 62, 80);
            lb_Age.Location = new Point(179, 317);
            lb_Age.Name = "lb_Age";
            lb_Age.Size = new Size(47, 25);
            lb_Age.TabIndex = 52;
            lb_Age.Text = "Age";
            // 
            // tb_Email
            // 
            tb_Email.BackColor = Color.FromArgb(236, 240, 241);
            tb_Email.Font = new Font("Segoe UI", 15F);
            tb_Email.ForeColor = Color.FromArgb(44, 62, 80);
            tb_Email.Location = new Point(301, 218);
            tb_Email.Margin = new Padding(3, 4, 3, 4);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(335, 41);
            tb_Email.TabIndex = 51;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_email.ForeColor = Color.FromArgb(44, 62, 80);
            lb_email.Location = new Point(178, 236);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(67, 25);
            lb_email.TabIndex = 50;
            lb_email.Text = "E-mail";
            // 
            // tb_UserName
            // 
            tb_UserName.BackColor = Color.FromArgb(236, 240, 241);
            tb_UserName.Font = new Font("Segoe UI", 15F);
            tb_UserName.ForeColor = Color.FromArgb(44, 62, 80);
            tb_UserName.Location = new Point(301, 106);
            tb_UserName.Margin = new Padding(3, 4, 3, 4);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(335, 41);
            tb_UserName.TabIndex = 49;
            // 
            // lb_UserName
            // 
            lb_UserName.AutoSize = true;
            lb_UserName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lb_UserName.ForeColor = Color.FromArgb(44, 62, 80);
            lb_UserName.Location = new Point(179, 124);
            lb_UserName.Name = "lb_UserName";
            lb_UserName.Size = new Size(104, 25);
            lb_UserName.TabIndex = 48;
            lb_UserName.Text = "UserName";
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(52, 152, 219);
            lb_welcomeLogin.Location = new Point(363, 27);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(156, 57);
            lb_welcomeLogin.TabIndex = 47;
            lb_welcomeLogin.Text = "Profile";
            // 
            // AdminProfileManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 863);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(btn_changePassword);
            Controls.Add(lb_checkAge);
            Controls.Add(lb_checkPassword);
            Controls.Add(lb_checkUserName);
            Controls.Add(lb_checkEmail);
            Controls.Add(btn_updateProfile);
            Controls.Add(numberic_Age);
            Controls.Add(tb_Address);
            Controls.Add(lb_Address);
            Controls.Add(lb_Age);
            Controls.Add(tb_Email);
            Controls.Add(lb_email);
            Controls.Add(tb_UserName);
            Controls.Add(lb_UserName);
            Controls.Add(lb_welcomeLogin);
            Name = "AdminProfileManagementForm";
            Text = "AdminProfileManagementForm";
            Load += AdminProfileManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)numberic_Age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Button btn_logout;
        private Button btn_changePassword;
        private Label lb_checkAge;
        private Label lb_checkPassword;
        private Label lb_checkUserName;
        private Label lb_checkEmail;
        private Button btn_updateProfile;
        private NumericUpDown numberic_Age;
        private TextBox tb_Address;
        private Label lb_Address;
        private Label lb_Age;
        private TextBox tb_Email;
        private Label lb_email;
        private TextBox tb_UserName;
        private Label lb_UserName;
        private Label lb_welcomeLogin;
    }
}