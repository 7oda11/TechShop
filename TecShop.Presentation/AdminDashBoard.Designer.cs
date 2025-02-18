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
            lb_welcomeLogin = new Label();
            btn_manageUsers = new Button();
            btn_manageProducts = new Button();
            btn_manageCategories = new Button();
            btn_logout = new Button();
            btn_adminProfile = new Button();
            SuspendLayout();
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(52, 152, 219);
            lb_welcomeLogin.Location = new Point(228, 9);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(365, 57);
            lb_welcomeLogin.TabIndex = 14;
            lb_welcomeLogin.Text = "Welcome Admin!";
            // 
            // btn_manageUsers
            // 
            btn_manageUsers.BackColor = Color.FromArgb(52, 152, 219);
            btn_manageUsers.FlatAppearance.BorderSize = 0;
            btn_manageUsers.FlatStyle = FlatStyle.Flat;
            btn_manageUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_manageUsers.ForeColor = Color.White;
            btn_manageUsers.Location = new Point(86, 222);
            btn_manageUsers.Name = "btn_manageUsers";
            btn_manageUsers.Size = new Size(204, 40);
            btn_manageUsers.TabIndex = 15;
            btn_manageUsers.Text = "Manage Users";
            btn_manageUsers.UseVisualStyleBackColor = false;
            btn_manageUsers.Click += btn_manageUsers_Click;
            // 
            // btn_manageProducts
            // 
            btn_manageProducts.BackColor = Color.FromArgb(52, 152, 219);
            btn_manageProducts.FlatAppearance.BorderSize = 0;
            btn_manageProducts.FlatStyle = FlatStyle.Flat;
            btn_manageProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_manageProducts.ForeColor = Color.White;
            btn_manageProducts.Location = new Point(296, 222);
            btn_manageProducts.Name = "btn_manageProducts";
            btn_manageProducts.Size = new Size(204, 40);
            btn_manageProducts.TabIndex = 16;
            btn_manageProducts.Text = "Manage Products";
            btn_manageProducts.UseVisualStyleBackColor = false;
            btn_manageProducts.Click += btn_manageProducts_Click;
            // 
            // btn_manageCategories
            // 
            btn_manageCategories.BackColor = Color.FromArgb(52, 152, 219);
            btn_manageCategories.FlatAppearance.BorderSize = 0;
            btn_manageCategories.FlatStyle = FlatStyle.Flat;
            btn_manageCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_manageCategories.ForeColor = Color.White;
            btn_manageCategories.Location = new Point(508, 222);
            btn_manageCategories.Name = "btn_manageCategories";
            btn_manageCategories.Size = new Size(204, 40);
            btn_manageCategories.TabIndex = 17;
            btn_manageCategories.Text = "Manage Categories";
            btn_manageCategories.UseVisualStyleBackColor = false;
            btn_manageCategories.Click += btn_manageCategories_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(231, 76, 60);
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(694, 398);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 40);
            btn_logout.TabIndex = 18;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_adminProfile
            // 
            btn_adminProfile.BackColor = Color.FromArgb(52, 152, 219);
            btn_adminProfile.FlatAppearance.BorderSize = 0;
            btn_adminProfile.FlatStyle = FlatStyle.Flat;
            btn_adminProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_adminProfile.ForeColor = Color.White;
            btn_adminProfile.Location = new Point(296, 282);
            btn_adminProfile.Name = "btn_adminProfile";
            btn_adminProfile.Size = new Size(204, 40);
            btn_adminProfile.TabIndex = 19;
            btn_adminProfile.Text = "Manage Profile";
            btn_adminProfile.UseVisualStyleBackColor = false;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_adminProfile);
            Controls.Add(btn_logout);
            Controls.Add(btn_manageCategories);
            Controls.Add(btn_manageProducts);
            Controls.Add(btn_manageUsers);
            Controls.Add(lb_welcomeLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashBoard";
            Text = "AdminDashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_welcomeLogin;
        private Button btn_manageUsers;
        private Button btn_manageProducts;
        private Button btn_manageCategories;
        private Button btn_logout;
        private Button btn_adminProfile;
    }
}