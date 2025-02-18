namespace TecShop.Presentation
{
    partial class ProductManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_back = new Button();
            btn_logout = new Button();
            btn_update = new Button();
            btn_add = new Button();
            btn_delete = new Button();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            cb_category = new ComboBox();
            nud_price = new NumericUpDown();
            txt_productName = new TextBox();
            dvg_products = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nud_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_products).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 40;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(231, 76, 60);
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(807, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 40);
            btn_logout.TabIndex = 39;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.LightSkyBlue;
            btn_update.Font = new Font("Segoe UI", 10F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(601, 220);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(100, 35);
            btn_update.TabIndex = 38;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.LightGreen;
            btn_add.Font = new Font("Segoe UI", 10F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(761, 220);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 35);
            btn_add.TabIndex = 37;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.LightCoral;
            btn_delete.Font = new Font("Segoe UI", 10F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(431, 220);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(100, 35);
            btn_delete.TabIndex = 36;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(54, 172);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 35;
            label6.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(75, 119);
            label5.Name = "label5";
            label5.Size = new Size(47, 23);
            label5.TabIndex = 34;
            label5.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(54, 60);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 30;
            label1.Text = "Product Name";
            // 
            // cb_category
            // 
            cb_category.Font = new Font("Segoe UI", 10F);
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(181, 172);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(200, 31);
            cb_category.TabIndex = 29;
            // 
            // nud_price
            // 
            nud_price.Font = new Font("Segoe UI", 10F);
            nud_price.Location = new Point(181, 117);
            nud_price.Name = "nud_price";
            nud_price.Size = new Size(200, 30);
            nud_price.TabIndex = 28;
            // 
            // txt_productName
            // 
            txt_productName.Font = new Font("Segoe UI", 10F);
            txt_productName.Location = new Point(181, 60);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(200, 30);
            txt_productName.TabIndex = 24;
            // 
            // dvg_products
            // 
            dvg_products.BackgroundColor = Color.White;
            dvg_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_products.GridColor = Color.LightGray;
            dvg_products.Location = new Point(12, 310);
            dvg_products.Name = "dvg_products";
            dvg_products.RowHeadersWidth = 51;
            dvg_products.Size = new Size(889, 200);
            dvg_products.TabIndex = 23;
            dvg_products.RowHeaderMouseDoubleClick += dvg_products_RowHeaderMouseDoubleClick;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 532);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_delete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(cb_category);
            Controls.Add(nud_price);
            Controls.Add(txt_productName);
            Controls.Add(dvg_products);
            Name = "ProductManagementForm";
            Text = "ProductManagementForm";
            Load += ProductManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)nud_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_products).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_back;
        private Button btn_logout;
        private Button btn_update;
        private Button btn_add;
        private Button btn_delete;
        private Label label6;
        private Label label5;
        private Label label1;
        private ComboBox cb_category;
        private NumericUpDown nud_price;
        private TextBox txt_productName;
        private DataGridView dvg_products;
    }
}