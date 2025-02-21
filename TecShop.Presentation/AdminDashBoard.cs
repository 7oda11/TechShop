using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecShop.Presentation
{
    public partial class AdminDashBoard : Form
    {
        DataTable UserData;
        public AdminDashBoard(DataTable user)
        {
            UserData = user;
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void btn_manageUsers_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(UserData);
            userManagementForm.Show();
            this.Close();
        }

        private void btn_manageProducts_Click(object sender, EventArgs e)
        {
            ProductManagementForm productManagementForm = new ProductManagementForm(UserData);
            productManagementForm.Show();
            this.Close();
        }

        private void btn_manageCategories_Click(object sender, EventArgs e)
        {
            CategoryManagementForm categoryManagementForm = new CategoryManagementForm(UserData);
            categoryManagementForm.Show();
            this.Close();
        }

        private void btn_adminProfile_Click(object sender, EventArgs e)
        {
            AdminProfileManagementForm adminProfile = new AdminProfileManagementForm(UserData);
            adminProfile.Show();
            this.Close();
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            lb_welcomeLogin.Text = "Welcome " + UserData.Rows[0]["Username"].ToString();
        }

        private void lb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pc_LogOut_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
