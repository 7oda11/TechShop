using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecShop.Presentation
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_UserName.Text = string.Empty;
            tb_Password.Text = string.Empty;
        }

        private void lb_closeLogin_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lb_SignUp_Click(object sender, EventArgs e)
        {
            SinUpSCreen sinUpSCreen = new SinUpSCreen();
            sinUpSCreen.Show();
            this.Close();
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                tb_Password.UseSystemPasswordChar = false;
            else
                tb_Password.UseSystemPasswordChar = true;
        }
    }
}
