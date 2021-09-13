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

        //temporary button to allow access to test
        private void button1_Click(object sender, EventArgs e)
        {
            SimulationStarter test = new SimulationStarter();
            DataOutputForm test2 = new DataOutputForm();
            test2.Show();
            test.Show();
            this.Hide();
        }
    }
}
