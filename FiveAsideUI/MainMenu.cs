using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveAsideUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpOpen = new SignUpForm();
            signUpOpen.Show();                  //opens the sign up window for user to create account
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginMenu loginForm = new LoginMenu();
            loginForm.Show();       //opens LoginMenu page, closes main menu
            this.Hide();
        }
    }
}
