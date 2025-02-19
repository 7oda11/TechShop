using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechShop.BusinessLogic;

namespace TecShop.Presentation
{
    public partial class AdminProfileManagementForm : Form
    {
        UserService userService;
        DataTable User;
        public AdminProfileManagementForm(DataTable user)
        {
            userService = new UserService(ConfigurationManager.ConnectionStrings["TechShop"].ConnectionString);
            User = user;
            InitializeComponent();
        }
        int id;
        private void AdminProfileManagementForm_Load(object sender, EventArgs e)
        {
            if (User != null && User.Rows.Count > 0)
            {
                DataRow userRow = User.Rows[0];
                //MessageBox.Show(userRow.ToString());
                id = Convert.ToInt32(userRow["UserId"]);
                tb_Email.Text = userRow["Email"].ToString();
                tb_UserName.Text = userRow["Username"].ToString();
                tb_Address.Text = userRow["Address"].ToString();
                numberic_Age.Value = Convert.ToInt32(userRow["Age"]);
            }
            else
            {
                MessageBox.Show("User data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashBoard dashBoard = new AdminDashBoard(User);
            dashBoard.Show();
            this.Close();
        }

        string userName;
        string email;
        string address;
        int age;
        private void btn_updateProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_UserName.Text) ||
                string.IsNullOrWhiteSpace(tb_Email.Text) ||
                string.IsNullOrWhiteSpace(tb_Address.Text) ||
                numberic_Age.Value <= 0)
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            userName = tb_UserName.Text.Trim();
            email = tb_Email.Text.Trim();
            address = tb_Address.Text.Trim();
            age = (int)numberic_Age.Value;
            int rowsAffected = userService.updateUserProfile(id, userName, email, age, address);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                User = userService.authenticateAdminData(userName, email);
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            AdminChangePasswordForm adminChangePassword=new AdminChangePasswordForm(User);
            adminChangePassword.Show();
            this.Close();
        }
    }
}
