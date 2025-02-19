namespace TecShop.Presentation
{
    partial class UserDashBoard
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
            btn_manageFavorites = new Button();
            btn_manageUserProfile = new Button();
            btn_logout = new Button();
            btn_viewProduucts = new Button();
            SuspendLayout();
            // 
            // lb_welcomeLogin
            // 
            lb_welcomeLogin.AutoSize = true;
            lb_welcomeLogin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lb_welcomeLogin.ForeColor = Color.FromArgb(52, 152, 219);
            lb_welcomeLogin.Location = new Point(234, 9);
            lb_welcomeLogin.Name = "lb_welcomeLogin";
            lb_welcomeLogin.Size = new Size(322, 57);
            lb_welcomeLogin.TabIndex = 14;
            lb_welcomeLogin.Text = "Welcome User!";
            // 
            // btn_manageFavorites
            // 
            btn_manageFavorites.BackColor = Color.FromArgb(52, 152, 219);
            btn_manageFavorites.FlatAppearance.BorderSize = 0;
            btn_manageFavorites.FlatStyle = FlatStyle.Flat;
            btn_manageFavorites.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_manageFavorites.ForeColor = Color.White;
            btn_manageFavorites.Location = new Point(298, 205);
            btn_manageFavorites.Name = "btn_manageFavorites";
            btn_manageFavorites.Size = new Size(204, 40);
            btn_manageFavorites.TabIndex = 18;
            btn_manageFavorites.Text = "Manage Favorites";
            btn_manageFavorites.UseVisualStyleBackColor = false;
            btn_manageFavorites.Click += btn_manageFavorites_Click;
            // 
            // btn_manageUserProfile
            // 
            btn_manageUserProfile.BackColor = Color.FromArgb(52, 152, 219);
            btn_manageUserProfile.FlatAppearance.BorderSize = 0;
            btn_manageUserProfile.FlatStyle = FlatStyle.Flat;
            btn_manageUserProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_manageUserProfile.ForeColor = Color.White;
            btn_manageUserProfile.Location = new Point(520, 205);
            btn_manageUserProfile.Name = "btn_manageUserProfile";
            btn_manageUserProfile.Size = new Size(204, 40);
            btn_manageUserProfile.TabIndex = 19;
            btn_manageUserProfile.Text = "Manage Profile";
            btn_manageUserProfile.UseVisualStyleBackColor = false;
            btn_manageUserProfile.Click += btn_manageUserProfile_Click;
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
            btn_logout.TabIndex = 20;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_viewProduucts
            // 
            btn_viewProduucts.BackColor = Color.FromArgb(52, 152, 219);
            btn_viewProduucts.FlatAppearance.BorderSize = 0;
            btn_viewProduucts.FlatStyle = FlatStyle.Flat;
            btn_viewProduucts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_viewProduucts.ForeColor = Color.White;
            btn_viewProduucts.Location = new Point(76, 205);
            btn_viewProduucts.Name = "btn_viewProduucts";
            btn_viewProduucts.Size = new Size(204, 40);
            btn_viewProduucts.TabIndex = 21;
            btn_viewProduucts.Text = "View Products";
            btn_viewProduucts.UseVisualStyleBackColor = false;
            btn_viewProduucts.Click += btn_viewProduucts_Click;
            // 
            // UserDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_viewProduucts);
            Controls.Add(btn_logout);
            Controls.Add(btn_manageUserProfile);
            Controls.Add(btn_manageFavorites);
            Controls.Add(lb_welcomeLogin);
            Name = "UserDashBoard";
            Text = "UserDashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_welcomeLogin;
        private Button btn_manageFavorites;
        private Button btn_manageUserProfile;
        private Button btn_logout;
        private Button btn_viewProduucts;
    }
}