﻿namespace TecShop.Presentation.UserForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProductForm));
            btn_addFav = new Button();
            dgv_products = new DataGridView();
            ic_back = new PictureBox();
            pc_LogOut = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            SuspendLayout();
            // 
            // btn_addFav
            // 
            btn_addFav.BackColor = Color.FromArgb(123, 143, 164);
            btn_addFav.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_addFav.ForeColor = Color.White;
            btn_addFav.Location = new Point(12, 100);
            btn_addFav.Margin = new Padding(3, 2, 3, 2);
            btn_addFav.Name = "btn_addFav";
            btn_addFav.Size = new Size(155, 58);
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
            dgv_products.Location = new Point(187, 88);
            dgv_products.Margin = new Padding(3, 2, 3, 2);
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 51;
            dgv_products.Size = new Size(463, 179);
            dgv_products.TabIndex = 53;
            dgv_products.RowHeaderMouseDoubleClick += dgv_products_RowHeaderMouseDoubleClick;
            // 
            // ic_back
            // 
            ic_back.Image = Properties.Resources.iconBack;
            ic_back.Location = new Point(12, 10);
            ic_back.Name = "ic_back";
            ic_back.Size = new Size(44, 50);
            ic_back.SizeMode = PictureBoxSizeMode.Zoom;
            ic_back.TabIndex = 61;
            ic_back.TabStop = false;
            ic_back.Click += ic_back_Click;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(541, 11);
            pc_LogOut.Margin = new Padding(3, 2, 3, 2);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(109, 46);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 66;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // ViewProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(668, 285);
            ControlBox = false;
            Controls.Add(pc_LogOut);
            Controls.Add(ic_back);
            Controls.Add(btn_addFav);
            Controls.Add(dgv_products);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewProductForm";
            Load += ViewProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_addFav;
        private DataGridView dgv_products;
        private PictureBox ic_back;
        private PictureBox pc_LogOut;
    }
}