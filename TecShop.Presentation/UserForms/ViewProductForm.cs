using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ViewProductForm : Form
    {
        FavoriteService favoriteService;
        ProductService productService;
        DataTable User;
        public ViewProductForm(DataTable user)
        {
            favoriteService = new FavoriteService(ConfigurationManager.ConnectionStrings["TechShop"].ConnectionString);
            productService = new ProductService(ConfigurationManager.ConnectionStrings["TechShop"].ConnectionString);
            InitializeComponent();
            User = user;
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
        int id;
        private void ViewProductForm_Load(object sender, EventArgs e)
        {
            DataRow userRow = User.Rows[0];
            id = Convert.ToInt32(userRow["UserId"]);
            loadData();
        }
        private void loadData()
        {
            btn_addFav.Hide();
            dgv_products.DataSource = productService.ProductDataFavorite(id);
        }

        private int selectedProductId;

        private void dgv_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_addFav.Show();
                DataGridViewRow selectedRow = dgv_products.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);

            }

        }

        private void btn_addFav_Click(object sender, EventArgs e)
        {
            int rowsAffected = favoriteService.addFav(selectedProductId, id);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Product added to favorites!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Failed to add product to favorites.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
