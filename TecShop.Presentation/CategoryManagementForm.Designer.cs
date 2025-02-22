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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManagementForm));
            btn_update = new Button();
            btn_add = new Button();
            btn_delete = new Button();
            label1 = new Label();
            txt_categoryName = new TextBox();
            dgv_categories = new DataGridView();
            pc_LogOut = new PictureBox();
            ic_back = new PictureBox();
            lb_close = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(123, 143, 164);
            btn_update.Font = new Font("Segoe UI", 10F);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(195, 216);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(119, 64);
            btn_update.TabIndex = 50;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(123, 143, 164);
            btn_add.Font = new Font("Segoe UI", 10F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(195, 148);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(119, 63);
            btn_add.TabIndex = 49;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(229, 27, 27);
            btn_delete.Font = new Font("Segoe UI", 10F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(195, 289);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(119, 63);
            btn_delete.TabIndex = 48;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(3, 103);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 45;
            label1.Text = "Category Name";
            // 
            // txt_categoryName
            // 
            txt_categoryName.Font = new Font("Segoe UI", 10F);
            txt_categoryName.Location = new Point(130, 95);
            txt_categoryName.Name = "txt_categoryName";
            txt_categoryName.Size = new Size(183, 30);
            txt_categoryName.TabIndex = 42;
            // 
            // dgv_categories
            // 
            dgv_categories.BackgroundColor = Color.White;
            dgv_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categories.GridColor = Color.LightGray;
            dgv_categories.Location = new Point(338, 95);
            dgv_categories.Name = "dgv_categories";
            dgv_categories.RowHeadersWidth = 51;
            dgv_categories.Size = new Size(317, 257);
            dgv_categories.TabIndex = 41;
            dgv_categories.RowHeaderMouseDoubleClick += dgv_categories_RowHeaderMouseDoubleClick;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(600, 394);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(78, 61);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 89;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // ic_back
            // 
            ic_back.Image = Properties.Resources.iconBack;
            ic_back.Location = new Point(14, 15);
            ic_back.Margin = new Padding(3, 4, 3, 4);
            ic_back.Name = "ic_back";
            ic_back.Size = new Size(50, 67);
            ic_back.SizeMode = PictureBoxSizeMode.Zoom;
            ic_back.TabIndex = 88;
            ic_back.TabStop = false;
            ic_back.Click += ic_back_Click;
            // 
            // lb_close
            // 
            lb_close.Image = Properties.Resources.Close;
            lb_close.Location = new Point(626, 15);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(39, 41);
            lb_close.SizeMode = PictureBoxSizeMode.Zoom;
            lb_close.TabIndex = 90;
            lb_close.TabStop = false;
            // 
            // CategoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(677, 467);
            ControlBox = false;
            Controls.Add(lb_close);
            Controls.Add(pc_LogOut);
            Controls.Add(ic_back);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_delete);
            Controls.Add(label1);
            Controls.Add(txt_categoryName);
            Controls.Add(dgv_categories);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CategoryManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryManagementForm";
            Load += CategoryManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)lb_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_update;
        private Button btn_add;
        private Button btn_delete;
        private Label label1;
        private TextBox txt_categoryName;
        private DataGridView dgv_categories;
        private PictureBox pc_LogOut;
        private PictureBox ic_back;
        private PictureBox lb_close;
    }
}