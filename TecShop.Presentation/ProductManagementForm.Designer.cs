﻿namespace TecShop.Presentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagementForm));
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
            lb_close = new PictureBox();
            pc_LogOut = new PictureBox();
            ic_back = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nud_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(123, 143, 164);
            btn_update.Font = new Font("Segoe UI", 10F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(526, 287);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(136, 73);
            btn_update.TabIndex = 38;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(123, 143, 164);
            btn_add.Font = new Font("Segoe UI", 10F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(373, 287);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(136, 73);
            btn_add.TabIndex = 37;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(229, 27, 27);
            btn_delete.Font = new Font("Segoe UI", 10F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(681, 287);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(136, 73);
            btn_delete.TabIndex = 36;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(15, 211);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 35;
            label6.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(15, 164);
            label5.Name = "label5";
            label5.Size = new Size(47, 23);
            label5.TabIndex = 34;
            label5.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(11, 107);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 30;
            label1.Text = "Product Name";
            // 
            // cb_category
            // 
            cb_category.Font = new Font("Segoe UI", 10F);
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(142, 211);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(201, 31);
            cb_category.TabIndex = 29;
            // 
            // nud_price
            // 
            nud_price.Font = new Font("Segoe UI", 10F);
            nud_price.Location = new Point(142, 156);
            nud_price.Name = "nud_price";
            nud_price.Size = new Size(200, 30);
            nud_price.TabIndex = 28;
            // 
            // txt_productName
            // 
            txt_productName.Font = new Font("Segoe UI", 10F);
            txt_productName.Location = new Point(142, 99);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(201, 30);
            txt_productName.TabIndex = 24;
            // 
            // dvg_products
            // 
            dvg_products.BackgroundColor = Color.White;
            dvg_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_products.GridColor = Color.LightGray;
            dvg_products.Location = new Point(373, 83);
            dvg_products.Name = "dvg_products";
            dvg_products.RowHeadersWidth = 51;
            dvg_products.Size = new Size(445, 193);
            dvg_products.TabIndex = 23;
            dvg_products.RowHeaderMouseDoubleClick += dvg_products_RowHeaderMouseDoubleClick;
            // 
            // lb_close
            // 
            lb_close.Image = Properties.Resources.Close;
            lb_close.Location = new Point(795, 12);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(39, 41);
            lb_close.SizeMode = PictureBoxSizeMode.Zoom;
            lb_close.TabIndex = 93;
            lb_close.TabStop = false;
            lb_close.Click += lb_close_Click;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(729, 380);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(78, 61);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 92;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // ic_back
            // 
            ic_back.Image = Properties.Resources.iconBack;
            ic_back.Location = new Point(8, 4);
            ic_back.Margin = new Padding(3, 4, 3, 4);
            ic_back.Name = "ic_back";
            ic_back.Size = new Size(50, 67);
            ic_back.SizeMode = PictureBoxSizeMode.Zoom;
            ic_back.TabIndex = 91;
            ic_back.TabStop = false;
            ic_back.Click += ic_back_Click;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(846, 459);
            ControlBox = false;
            Controls.Add(lb_close);
            Controls.Add(pc_LogOut);
            Controls.Add(ic_back);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductManagementForm";
            Load += ProductManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)nud_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private PictureBox lb_close;
        private PictureBox pc_LogOut;
        private PictureBox ic_back;
    }
}