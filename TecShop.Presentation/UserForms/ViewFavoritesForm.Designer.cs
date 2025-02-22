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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFavoritesForm));
            btn_deleteFav = new Button();
            dgv_fav = new DataGridView();
            pc_LogOut = new PictureBox();
            ic_back = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_fav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).BeginInit();
            SuspendLayout();
            // 
            // btn_deleteFav
            // 
            btn_deleteFav.BackColor = Color.Red;
            btn_deleteFav.Font = new Font("Segoe UI", 10F);
            btn_deleteFav.ForeColor = Color.White;
            btn_deleteFav.Location = new Point(14, 103);
            btn_deleteFav.Name = "btn_deleteFav";
            btn_deleteFav.Size = new Size(181, 79);
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
            dgv_fav.Location = new Point(250, 103);
            dgv_fav.Name = "dgv_fav";
            dgv_fav.RowHeadersWidth = 51;
            dgv_fav.Size = new Size(382, 200);
            dgv_fav.TabIndex = 61;
            dgv_fav.RowHeaderMouseDoubleClick += dgv_fav_RowHeaderMouseDoubleClick;
            // 
            // pc_LogOut
            // 
            pc_LogOut.Image = (Image)resources.GetObject("pc_LogOut.Image");
            pc_LogOut.Location = new Point(529, 17);
            pc_LogOut.Name = "pc_LogOut";
            pc_LogOut.Size = new Size(125, 61);
            pc_LogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pc_LogOut.TabIndex = 68;
            pc_LogOut.TabStop = false;
            pc_LogOut.Click += pc_LogOut_Click;
            // 
            // ic_back
            // 
            ic_back.Image = Properties.Resources.iconBack;
            ic_back.Location = new Point(14, 11);
            ic_back.Margin = new Padding(3, 4, 3, 4);
            ic_back.Name = "ic_back";
            ic_back.Size = new Size(50, 67);
            ic_back.SizeMode = PictureBoxSizeMode.Zoom;
            ic_back.TabIndex = 67;
            ic_back.TabStop = false;
            ic_back.Click += ic_back_Click;
            // 
            // ViewFavoritesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 230);
            ClientSize = new Size(666, 351);
            ControlBox = false;
            Controls.Add(pc_LogOut);
            Controls.Add(ic_back);
            Controls.Add(btn_deleteFav);
            Controls.Add(dgv_fav);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ViewFavoritesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFavoritesForm";
            Load += ViewFavoritesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_fav).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_LogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_back).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_deleteFav;
        private DataGridView dgv_fav;
        private PictureBox pc_LogOut;
        private PictureBox ic_back;
    }
}