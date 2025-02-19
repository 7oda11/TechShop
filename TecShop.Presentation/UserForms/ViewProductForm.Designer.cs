namespace TecShop.Presentation.UserForms
{
    partial class ViewProductForm
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
            btn_addFav = new Button();
            dgv_products = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 13);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 60;
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
            btn_logout.Location = new Point(806, 13);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 40);
            btn_logout.TabIndex = 59;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_addFav
            // 
            btn_addFav.BackColor = Color.LightGreen;
            btn_addFav.Font = new Font("Segoe UI", 10F);
            btn_addFav.ForeColor = Color.White;
            btn_addFav.Location = new Point(680, 238);
            btn_addFav.Name = "btn_addFav";
            btn_addFav.Size = new Size(220, 35);
            btn_addFav.TabIndex = 57;
            btn_addFav.Text = "Add To Favorites";
            btn_addFav.UseVisualStyleBackColor = false;
            btn_addFav.Click += btn_addFav_Click;
            // 
            // dgv_products
            // 
            dgv_products.BackgroundColor = Color.White;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.GridColor = Color.LightGray;
            dgv_products.Location = new Point(12, 319);
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 51;
            dgv_products.Size = new Size(889, 200);
            dgv_products.TabIndex = 53;
            dgv_products.RowHeaderMouseDoubleClick += dgv_products_RowHeaderMouseDoubleClick;
            // 
            // ViewProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 531);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(btn_addFav);
            Controls.Add(dgv_products);
            Name = "ViewProductForm";
            Text = "ViewProductForm";
            Load += ViewProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private Button btn_logout;
        private Button btn_addFav;
        private DataGridView dgv_products;
    }
}