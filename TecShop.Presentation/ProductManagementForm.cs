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
    public partial class ProductManagementForm : Form
    {
        ProductService productService;
        public ProductManagementForm()
        {
            productService = new ProductService(ConfigurationManager.ConnectionStrings["TechShop"].ConnectionString);
            InitializeComponent();
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            loadData();


        }
        private void loadData()
        {
            dvg_products.DataSource = productService.getAllProducts();
            cb_category.DataSource = productService.getCategories();
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "CategoryId";
            btn_add.Show();
            btn_delete.Hide();
            btn_update.Hide();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard();
            adminDashBoard.Show();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();

        }
        private void clearInputs()
        {
            txt_productName.Clear();
            nud_price.Value = 0;
            cb_category.SelectedIndex = -1; // Reset ComboBox selection
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                string productName = txt_productName.Text;
                decimal price = nud_price.Value;
                int category = (int)cb_category.SelectedValue;

                int rowsAffected = productService.addProduct(productName, price, category);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearInputs();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Failed to add product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_productName.Text))
            {
                MessageBox.Show("Product Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nud_price.Value <= 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cb_category.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        int id;
        private void dvg_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ensure a valid row index is clicked
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dvg_products.Rows[e.RowIndex];
                id = Convert.ToInt32(dvg_products.SelectedRows[0].Cells["ProductID"].Value);

                // Assign values to the input fields
                txt_productName.Text = selectedRow.Cells["ProductName"].Value.ToString();
                nud_price.Value = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

                // Ensure the category exists in ComboBox before setting value
                string categoryName = selectedRow.Cells["CategoryName"].Value.ToString();
                cb_category.SelectedIndex = cb_category.FindStringExact(categoryName);
                btn_add.Hide();
                btn_delete.Show();
                btn_update.Show();
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                if (dvg_products.SelectedRows.Count > 0)
                {
                    
                    string productName = txt_productName.Text;
                    decimal price = nud_price.Value;
                    int category = (int)cb_category.SelectedValue;

                    int rowsAffected = productService.updateProduct(productName, price, category, id);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadData();
                        clearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dvg_products.SelectedRows.Count > 0) // Ensure a row is selected
            {
                

                DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this product?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    int rowsAffected = productService.deleteProduct(id);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadData();                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
