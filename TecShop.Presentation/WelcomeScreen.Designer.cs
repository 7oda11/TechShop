namespace TecShop.Presentation
{
    partial class WelcomeScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lb_closeApp = new Label();
            btn_SignUp = new Button();
            lb_WelcomeScreen = new Label();
            btn_Login = new Button();
            SuspendLayout();
            // 
            // lb_closeApp
            // 
            lb_closeApp.AutoSize = true;
            lb_closeApp.Cursor = Cursors.Hand;
            lb_closeApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_closeApp.ForeColor = Color.FromArgb(200, 50, 50);
            lb_closeApp.Location = new Point(740, 463);
            lb_closeApp.Name = "lb_closeApp";
            lb_closeApp.Size = new Size(48, 28);
            lb_closeApp.TabIndex = 3;
            lb_closeApp.Text = "Exit";
            lb_closeApp.Click += lb_closeApp_Click;
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.FromArgb(50, 150, 100);
            btn_SignUp.FlatAppearance.BorderSize = 0;
            btn_SignUp.FlatStyle = FlatStyle.Flat;
            btn_SignUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_SignUp.ForeColor = Color.White;
            btn_SignUp.Location = new Point(280, 270);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(240, 80);
            btn_SignUp.TabIndex = 2;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // lb_WelcomeScreen
            // 
            lb_WelcomeScreen.AutoSize = true;
            lb_WelcomeScreen.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lb_WelcomeScreen.ForeColor = Color.FromArgb(50, 50, 100);
            lb_WelcomeScreen.Location = new Point(230, 50);
            lb_WelcomeScreen.Name = "lb_WelcomeScreen";
            lb_WelcomeScreen.Size = new Size(399, 50);
            lb_WelcomeScreen.TabIndex = 0;
            lb_WelcomeScreen.Text = "Welcome to TecShop!";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(50, 150, 100);
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(280, 160);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(240, 80);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(800, 500);
            Controls.Add(lb_WelcomeScreen);
            Controls.Add(btn_Login);
            Controls.Add(btn_SignUp);
            Controls.Add(lb_closeApp);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "WelcomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to TecShop";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lb_closeApp;
        private Button btn_SignUp;
        private Label lb_WelcomeScreen;
        private Button btn_Login;

        #endregion
    }
}
