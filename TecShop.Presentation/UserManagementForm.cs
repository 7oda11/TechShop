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
    public partial class UserManagementForm : Form
    {
        DataTable User;
        UserService userService;
        public UserManagementForm(DataTable user)
        {
            userService = new UserService(ConfigurationManager.ConnectionStrings["TechShop"].ConnectionString);
            InitializeComponent();
            User = user;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {

            //dvg_users.DataSource = userService.getAllUsers();
            loadDataOnGridView();
            cb_role.Items.Add("Admin");
            cb_role.Items.Add("User");
            cb_role.SelectedIndex = 0;
            btn_add.Show();
            btn_update.Hide();
            btn_delete.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard(User);
            adminDashBoard.Show();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                int rowsAffected = userService.addUser(
                    txt_userName.Text,
                    txt_password.Text,
                    txt_email.Text,
                    (int)nud_age.Value,
                    txt_address.Text,
                    cb_role.SelectedItem.ToString() // Ensure role is converted to string
                );

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearInputs(); // Clear fields after successful addition
                    loadDataOnGridView();
                }
                else
                {
                    MessageBox.Show("Failed to add user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validateInputs()
        {
            // Check if UserName is empty
            if (string.IsNullOrWhiteSpace(txt_userName.Text))
            {
                MessageBox.Show("Username cannot be empty.");
                return false;
            }

            // Check if Email is empty
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Email cannot be empty.");
                return false;
            }

            // Validate Email format
            if (!IsValidEmail(txt_email.Text))
            {
                MessageBox.Show("Invalid email format.");
                return false;
            }

            // Check if Password is empty
            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Password cannot be empty.");
                return false;
            }

            // Check if Address is empty
            if (string.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("Address cannot be empty.");
                return false;
            }

            // Check if Age is selected (greater than 0)
            if (nud_age.Value <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return false;
            }

            // Check if a role is selected
            if (cb_role.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.");
                return false;
            }

            return true; // If all validations pass
        }

        // Function to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void clearInputs()
        {
            txt_userName.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_address.Text = string.Empty;
            nud_age.Value = 0; 
            cb_role.SelectedIndex = -1; 
        }
        int id;
        private void loadDataOnGridView()
        {
            DataRow userRow = User.Rows[0];
            //MessageBox.Show(userRow.ToString());
            id = Convert.ToInt32(userRow["UserId"]);
            btn_add.Show();
            btn_delete.Hide();
            btn_update.Hide();
            dvg_users.DataSource = userService.getAllUsers(id);

        }

        private void dvg_users_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ensure the user has selected a valid row
            if (e.RowIndex >= 0)
            {
                btn_add.Hide();
                btn_delete.Show();
                btn_update.Show();
                // Get the selected row
                DataGridViewRow row = dvg_users.Rows[e.RowIndex];

                // Populate input fields with data from the selected row
                txt_userName.Text = row.Cells["UserName"].Value?.ToString();
                txt_password.Text = row.Cells["Password"].Value?.ToString();
                txt_email.Text = row.Cells["Email"].Value?.ToString();
                nud_age.Value = row.Cells["Age"].Value != null ? Convert.ToInt32(row.Cells["Age"].Value) : 0;
                txt_address.Text = row.Cells["Address"].Value?.ToString();

                // Ensure selected role exists in the ComboBox before setting it
                string selectedRole = row.Cells["Role"].Value?.ToString();
                if (cb_role.Items.Contains(selectedRole))
                {
                    cb_role.SelectedItem = selectedRole;
                }
            }
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                txt_password.UseSystemPasswordChar = false;
            else
                txt_password.UseSystemPasswordChar = true;
        }

        int userId;
        private void btn_update_Click(object sender, EventArgs e)
        {
            // Ensure inputs are valid before proceeding
            if (validateInputs())
            {
                // Get selected user ID from the DataGridView (assuming there's an ID column)
                if (dvg_users.SelectedRows.Count > 0)
                {
                    userId = Convert.ToInt32(dvg_users.SelectedRows[0].Cells["UserID"].Value);

                    // Call the update method from the userService
                    int rowsAffected = userService.updateUser(
                        userId,
                        txt_userName.Text,
                        txt_password.Text,
                        txt_email.Text,
                        (int)nud_age.Value,
                        txt_address.Text,
                        cb_role.SelectedItem.ToString()
                    );

                    // Check if the update was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInputs(); // Clear input fields after successful update
                        loadDataOnGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a user to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Ensure that a user is selected from the DataGridView
            if (dvg_users.SelectedRows.Count > 0)
            {
                // Get the UserID of the selected user
                userId = Convert.ToInt32(dvg_users.SelectedRows[0].Cells["UserID"].Value);

                // Ask for confirmation before deleting
                var confirmation = MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Proceed with deletion if user confirms
                if (confirmation == DialogResult.Yes)
                {
                    // Call the delete method in the userService
                    int rowsAffected = userService.deleteUser(userId);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInputs();
                        loadDataOnGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pc_LogOut_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void lb_close_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard(User);
            adminDashBoard.Show();
            this.Close();
        }

        private void ic_back_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard(User);
            adminDashBoard.Show();
            this.Close();
        }
    }
}
