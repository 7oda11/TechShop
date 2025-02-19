using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TecShop.Presentation.UserForms;

namespace TecShop.Presentation
{
    public partial class UserDashBoard : Form
    {
        DataTable User;
        public UserDashBoard(DataTable user)
        {
            InitializeComponent();
            User = user;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void btn_viewProduucts_Click(object sender, EventArgs e)
        {
            ViewProductForm viewProductForm = new ViewProductForm(User);
            viewProductForm.Show();
            this.Close();
        }

        private void btn_manageFavorites_Click(object sender, EventArgs e)
        {
            ViewFavoritesForm viewFav = new ViewFavoritesForm(User);
            viewFav.Show();
            this.Close();
        }

        private void btn_manageUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileManagementForm userProfileManagementForm = new UserProfileManagementForm(User);  
            userProfileManagementForm.Show();
            this.Close();
        }
    }
}
