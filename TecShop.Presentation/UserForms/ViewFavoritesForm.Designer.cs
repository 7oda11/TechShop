namespace TecShop.Presentation.UserForms
{
    partial class ViewFavoritesForm
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
            btn_deleteFav = new Button();
            dgv_fav = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_fav).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 11);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 29);
            btn_back.TabIndex = 64;
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
            btn_logout.Location = new Point(849, 11);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 40);
            btn_logout.TabIndex = 63;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_deleteFav
            // 
            btn_deleteFav.BackColor = Color.Red;
            btn_deleteFav.Font = new Font("Segoe UI", 10F);
            btn_deleteFav.ForeColor = Color.White;
            btn_deleteFav.Location = new Point(701, 236);
            btn_deleteFav.Name = "btn_deleteFav";
            btn_deleteFav.Size = new Size(220, 35);
            btn_deleteFav.TabIndex = 62;
            btn_deleteFav.Text = "Delete From Favorites";
            btn_deleteFav.UseVisualStyleBackColor = false;
            btn_deleteFav.Click += btn_deleteFav_Click;
            // 
            // dgv_fav
            // 
            dgv_fav.BackgroundColor = Color.White;
            dgv_fav.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_fav.GridColor = Color.LightGray;
            dgv_fav.Location = new Point(33, 317);
            dgv_fav.Name = "dgv_fav";
            dgv_fav.RowHeadersWidth = 51;
            dgv_fav.Size = new Size(889, 200);
            dgv_fav.TabIndex = 61;
            dgv_fav.RowHeaderMouseDoubleClick += dgv_fav_RowHeaderMouseDoubleClick;
            // 
            // ViewFavoritesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 528);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(btn_deleteFav);
            Controls.Add(dgv_fav);
            Name = "ViewFavoritesForm";
            Text = "ViewFavoritesForm";
            Load += ViewFavoritesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_fav).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private Button btn_logout;
        private Button btn_deleteFav;
        private DataGridView dgv_fav;
    }
}