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
    public partial class ViewFavoritesForm : Form
    {
        FavoriteService favoriteService;
        ProductService productService;
        DataTable User;
        public ViewFavoritesForm(DataTable user)
        {
            favoriteService = new FavoriteService(ConfigurationManager.ConnectionStrings["TechShop"].ConnectionString);
            productService = new ProductService(ConfigurationManager.ConnectionStrings["TechShop"].ConnectionString);
            InitializeComponent();
            User = user;
        }
        int id;
        private void ViewFavoritesForm_Load(object sender, EventArgs e)
        {
            DataRow userRow = User.Rows[0];
            id = Convert.ToInt32(userRow["UserId"]);
            loadData();
        }
        private void loadData()
        {
            btn_deleteFav.Hide();
            dgv_fav.DataSource = productService.ProductDataFavoriteExist(id);
        }

        private int selectedProductId;

        private void dgv_fav_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_deleteFav.Show();
                DataGridViewRow selectedRow = dgv_fav.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);

            }
        }

        private void btn_deleteFav_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to remove this product from favorites?",
         "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                int rowsAffected = favoriteService.deleteFav(selectedProductId, id);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product removed from favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Failed to remove product from favorites. It may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            UserDashBoard userDashBoard = new UserDashBoard(User);
            userDashBoard.Show();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }
    }
}
