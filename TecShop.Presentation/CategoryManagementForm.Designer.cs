namespace TecShop.Presentation
{
    partial class CategoryManagementForm
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
            label1 = new Label();
            txt_categoryName = new TextBox();
            dgv_categories = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(6, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 52;
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
            btn_logout.TabIndex = 51;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.LightSkyBlue;
            btn_update.Font = new Font("Segoe UI", 10F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(579, 223);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(100, 35);
            btn_update.TabIndex = 50;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.LightGreen;
            btn_add.Font = new Font("Segoe UI", 10F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(739, 223);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 35);
            btn_add.TabIndex = 49;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.LightCoral;
            btn_delete.Font = new Font("Segoe UI", 10F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(409, 223);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(100, 35);
            btn_delete.TabIndex = 48;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 108);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 45;
            label1.Text = "Category Name";
            // 
            // txt_categoryName
            // 
            txt_categoryName.Font = new Font("Segoe UI", 10F);
            txt_categoryName.Location = new Point(147, 105);
            txt_categoryName.Name = "txt_categoryName";
            txt_categoryName.Size = new Size(200, 30);
            txt_categoryName.TabIndex = 42;
            // 
            // dgv_categories
            // 
            dgv_categories.BackgroundColor = Color.White;
            dgv_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categories.GridColor = Color.LightGray;
            dgv_categories.Location = new Point(12, 316);
            dgv_categories.Name = "dgv_categories";
            dgv_categories.RowHeadersWidth = 51;
            dgv_categories.Size = new Size(889, 200);
            dgv_categories.TabIndex = 41;
            dgv_categories.RowHeaderMouseDoubleClick += dgv_categories_RowHeaderMouseDoubleClick;
            // 
            // CategoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 528);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_delete);
            Controls.Add(label1);
            Controls.Add(txt_categoryName);
            Controls.Add(dgv_categories);
            Name = "CategoryManagementForm";
            Text = "CategoryManagementForm";
            Load += CategoryManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_categories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Button btn_logout;
        private Button btn_update;
        private Button btn_add;
        private Button btn_delete;
        private Label label1;
        private TextBox txt_categoryName;
        private DataGridView dgv_categories;
    }
}