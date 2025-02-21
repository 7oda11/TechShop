namespace TecShop.Presentation
{
    partial class AdminDashBoard
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
        //    lb_welcomeLogin = new Label();
        //    btn_manageUsers = new Button();
        //    btn_manageProducts = new Button();
        //    btn_manageCategories = new Button();
        //    btn_logout = new Button();
        //    SuspendLayout();
        //    // 
        //    // lb_welcomeLogin
        //    // 
        //    lb_welcomeLogin.AutoSize = true;
        //    lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
        //    lb_welcomeLogin.ForeColor = Color.FromArgb(52, 152, 219);
        //    lb_welcomeLogin.Location = new Point(228, 9);
        //    lb_welcomeLogin.Name = "lb_welcomeLogin";
        //    lb_welcomeLogin.Size = new Size(365, 57);
        //    lb_welcomeLogin.TabIndex = 14;
        //    lb_welcomeLogin.Text = "Welcome Admin!";
        //    // 
        //    // btn_manageUsers
        //    // 
        //    btn_manageUsers.Location = new Point(113, 225);
        //    btn_manageUsers.Name = "btn_manageUsers";
        //    btn_manageUsers.Size = new Size(167, 29);
        //    btn_manageUsers.TabIndex = 15;
        //    btn_manageUsers.Text = "Manage Users";
        //    btn_manageUsers.UseVisualStyleBackColor = true;
        //    // 
        //    // btn_manageProducts
        //    // 
        //    btn_manageProducts.Location = new Point(298, 225);
        //    btn_manageProducts.Name = "btn_manageProducts";
        //    btn_manageProducts.Size = new Size(144, 29);
        //    btn_manageProducts.TabIndex = 16;
        //    btn_manageProducts.Text = "Manage Products";
        //    btn_manageProducts.UseVisualStyleBackColor = true;
        //    // 
        //    // btn_manageCategories
        //    // 
        //    btn_manageCategories.Location = new Point(473, 225);
        //    btn_manageCategories.Name = "btn_manageCategories";
        //    btn_manageCategories.Size = new Size(175, 29);
        //    btn_manageCategories.TabIndex = 17;
        //    btn_manageCategories.Text = "Manage Categories";
        //    btn_manageCategories.UseVisualStyleBackColor = true;
        //    // 
        //    // btn_logout
        //    // 
        //    btn_logout.Location = new Point(694, 409);
        //    btn_logout.Name = "btn_logout";
        //    btn_logout.Size = new Size(94, 29);
        //    btn_logout.TabIndex = 18;
        //    btn_logout.Text = "Logout";
        //    btn_logout.UseVisualStyleBackColor = true;
        //    // 
        //    // AdminDashBoard
        //    // 
        //    AutoScaleDimensions = new SizeF(8F, 20F);
        //    AutoScaleMode = AutoScaleMode.Font;
        //    ClientSize = new Size(800, 450);
        //    Controls.Add(btn_logout);
        //    Controls.Add(btn_manageCategories);
        //    Controls.Add(btn_manageProducts);
        //    Controls.Add(btn_manageUsers);
        //    Controls.Add(lb_welcomeLogin);
        //    Name = "AdminDashBoard";
        //    Text = "AdminDashBoard";
        //    ResumeLayout(false);
        //    PerformLayout();
        //}
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            lb_welcomeLogin = new Label();
            btn_manageUsers = new Button();
            btn_manageProducts = new Button();
            btn_manageCategories = new Button();
            btn_adminProfile = new Button();
            lb_close = new PictureBox();
            pc_LogOut = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)lb_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            SuspendLayout();
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(32, 88, 138);
            lb_welcomeLogin.Location = new Point(71, 18);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(294, 46);
            lb_welcomeLogin.TabIndex = 14;
            lb_welcomeLogin.Text = "Welcome Admin!";
            // 
            // btn_manageUsers
            // 
            btn_manageUsers.BackColor = Color.FromArgb(123, 143, 164);
            btn_manageUsers.FlatAppearance.BorderSize = 0;
            btn_manageUsers.FlatStyle = FlatStyle.Flat;
            btn_manageUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_manageUsers.ForeColor = Color.White;
            btn_manageUsers.Location = new Point(33, 92);
            btn_manageUsers.Margin = new Padding(3, 2, 3, 2);
            btn_manageUsers.Name = "btn_manageUsers";
            btn_manageUsers.Size = new Size(176, 76);
            btn_manageUsers.TabIndex = 15;
            btn_manageUsers.Text = "Manage Users";
            btn_manageUsers.UseVisualStyleBackColor = false;
            btn_manageUsers.Click += btn_manageUsers_Click;
            // 
            // btn_manageProducts
            // 
            btn_manageProducts.BackColor = Color.FromArgb(123, 143, 164);
            btn_manageProducts.FlatAppearance.BorderSize = 0;
            btn_manageProducts.FlatStyle = FlatStyle.Flat;
            btn_manageProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_manageProducts.ForeColor = Color.White;
            btn_manageProducts.Location = new Point(245, 92);
            btn_manageProducts.Margin = new Padding(3, 2, 3, 2);
            btn_manageProducts.Name = "btn_manageProducts";
            btn_manageProducts.Size = new Size(176, 76);
            btn_manageProducts.TabIndex = 16;
            btn_manageProducts.Text = "Manage Products";
            btn_manageProducts.UseVisualStyleBackColor = false;
            btn_manageProducts.Click += btn_manageProducts_Click;
            // 
            // btn_manageCategories
            // 
            btn_manageCategories.BackColor = Color.FromArgb(123, 143, 164);
            btn_manageCategories.FlatAppearance.BorderSize = 0;
            btn_manageCategories.FlatStyle = FlatStyle.Flat;
            btn_manageCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_manageCategories.ForeColor = Color.White;
            btn_manageCategories.Location = new Point(245, 187);
            btn_manageCategories.Margin = new Padding(3, 2, 3, 2);
            btn_manageCategories.Name = "btn_manageCategories";
            btn_manageCategories.Size = new Size(176, 77);
            btn_manageCategories.TabIndex = 17;
            btn_manageCategories.Text = "Manage Categories";
            btn_manageCategories.UseVisualStyleBackColor = false;
            btn_manageCategories.Click += btn_manageCategories_Click;
            // 
            // btn_adminProfile
            // 
            btn_adminProfile.BackColor = Color.FromArgb(123, 143, 164);
            btn_adminProfile.FlatAppearance.BorderSize = 0;
            btn_adminProfile.FlatStyle = FlatStyle.Flat;
            btn_adminProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_adminProfile.ForeColor = Color.White;
            btn_adminProfile.Location = new Point(33, 187);
            btn_adminProfile.Margin = new Padding(3, 2, 3, 2);
            btn_adminProfile.Name = "btn_adminProfile";
            btn_adminProfile.Size = new Size(176, 77);
            btn_adminProfile.TabIndex = 19;
            btn_adminProfile.Text = "Manage Profile";
            btn_adminProfile.UseVisualStyleBackColor = false;
            btn_adminProfile.Click += btn_adminProfile_Click;
            // 
            // lb_close
            // 
            lb_close.Image = Properties.Resources.Close;
            lb_close.Location = new Point(387, 18);
            lb_close.Margin = new Padding(3, 2, 3, 2);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(34, 31);
            lb_close.SizeMode = PictureBoxSizeMode.Zoom;
            lb_close.TabIndex = 68;
            lb_close.TabStop = false;
            lb_close.Click += lb_close_Click;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(312, 281);
            pc_LogOut.Margin = new Padding(3, 2, 3, 2);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(109, 46);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 67;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(436, 338);
            ControlBox = false;
            Controls.Add(lb_close);
            Controls.Add(pc_LogOut);
            Controls.Add(btn_adminProfile);
            Controls.Add(btn_manageCategories);
            Controls.Add(btn_manageProducts);
            Controls.Add(btn_manageUsers);
            Controls.Add(lb_welcomeLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminDashBoard";
            Text = "AdminDashBoard";
            Load += AdminDashBoard_Load;
            ((System.ComponentModel.ISupportInitialize)lb_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_welcomeLogin;
        private Button btn_manageUsers;
        private Button btn_manageProducts;
        private Button btn_manageCategories;
        private Button btn_adminProfile;
        private PictureBox lb_close;
        private PictureBox pc_LogOut;
    }
}