using Microsoft.VisualBasic.Logging;
using System.Configuration;
using TechShop.BusinessLogic;

namespace TecShop.Presentation
{
    public partial class WelcomeScreen : Form
    {
        UserService _userService;

        public WelcomeScreen()
        {
            InitializeComponent();
            _userService = new UserService(ConfigurationManager.ConnectionStrings["TechShop"].ConnectionString);
        }
        private void lb_closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
            //Login login = new Login();
            //login.Show();
            //this.Hide();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SinUpSCreen sinUpSCreen = new SinUpSCreen();
            sinUpSCreen.Show();
            this.Hide();
            //SignUp signUp = new SignUp();
            //signUp.Show();
            //this.Hide();
        }
    }
}
