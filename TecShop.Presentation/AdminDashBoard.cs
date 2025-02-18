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
        public AdminDashBoard()
        {
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
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
            this.Close();
        }

        private void btn_manageProducts_Click(object sender, EventArgs e)
        {
            ProductManagementForm productManagementForm = new ProductManagementForm();
            productManagementForm.Show();
            this.Close();
        }

        private void btn_manageCategories_Click(object sender, EventArgs e)
        {
            CategoryManagementForm categoryManagementForm = new CategoryManagementForm();
            categoryManagementForm.Show();
            this.Close();
        }
    }
}
