﻿using Microsoft.VisualBasic.ApplicationServices;
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

namespace TecShop.Presentation.UserForms
{
    public partial class UserChangePasswordForm : Form
    {
        UserService userService;
        DataTable User;
        public UserChangePasswordForm(DataTable user)
        {
            userService = new UserService(ConfigurationManager.ConnectionStrings["TechShop"].ConnectionString);
            User = user;
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            UserProfileManagementForm userProfileManagementForm = new UserProfileManagementForm(User);
            userProfileManagementForm.Show();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void cb_oldPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_oldPassword.Checked)
                txt_oldPassword.UseSystemPasswordChar = false;
            else
                txt_oldPassword.UseSystemPasswordChar = true;
        }

        private void cb_newPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_newPassword.Checked)
                txt_newPassword.UseSystemPasswordChar = false;
            else
                txt_newPassword.UseSystemPasswordChar = true;
        }

        private void cb_confirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_confirmPassword.Checked)
                txt_confirmPassword.UseSystemPasswordChar = false;
            else
                txt_confirmPassword.UseSystemPasswordChar = true;
        }

        private void btn_updateProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_oldPassword.Text) ||
               string.IsNullOrWhiteSpace(txt_newPassword.Text) ||
               string.IsNullOrWhiteSpace(txt_confirmPassword.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_newPassword.Text != txt_confirmPassword.Text)
            {
                MessageBox.Show("New Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow userRow = User.Rows[0];
            int id = Convert.ToInt32(userRow["UserId"]);

            string userName = userRow["Username"].ToString();
            string oldPassword = txt_oldPassword.Text;
            string newPassword = txt_newPassword.Text;
            string confirmPassword = txt_confirmPassword.Text;

            if (!userService.authenticateUser(userName, oldPassword))
            {
                MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsAffected = userService.UpdateUserPassword(id, userName, newPassword);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInputs();
            }
            else
            {
                MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearInputs()
        {
            txt_oldPassword.Clear();
            txt_newPassword.Clear();
            txt_confirmPassword.Clear();
        }
    }

}
