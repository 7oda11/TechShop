using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechShop.BusinessLogic;

namespace TecShop.Presentation
{
    public partial class SinUpSCreen : Form
    {
        UserService _userService;

        public SinUpSCreen()
        {
            InitializeComponent();
            _userService = new UserService(ConfigurationManager.ConnectionStrings["TechShop"].ConnectionString);
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                tb_Password.UseSystemPasswordChar = false;
            else
                tb_Password.UseSystemPasswordChar = true;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            tb_UserName.Text = string.Empty;
            tb_Email.Text = string.Empty;
            tb_Password.Text = string.Empty;
            numberic_Age.Value = 0;
            tb_Address.Text = string.Empty;
        }

        private void lb_closeSignUp_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                try
                {
                    int rowAffetcted = _userService.addUser(tb_UserName.Text, tb_Password.Text, tb_Email.Text, (int)numberic_Age.Value, tb_Address.Text);
                    if (rowAffetcted > 0)
                    {
                        MessageBox.Show("SignUp Suceess", "Suceess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //login.Show();
                        //this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private bool validateInputs()
        {
            bool isValid = true;

            // Username Validation
            if (string.IsNullOrWhiteSpace(tb_UserName.Text))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Email Validation (Regex Check)
            if (!Regex.IsMatch(tb_Email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Password Validation (Min Length 6)
            if (tb_Password.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Age Validation (Must be 18 or older)
            if (numberic_Age.Value < 18)
            {
                MessageBox.Show("You must be at least 18 years old to sign up.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Address Validation
            if (string.IsNullOrWhiteSpace(tb_Address.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            return isValid;
        }

        private void lb_LoginHere_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
