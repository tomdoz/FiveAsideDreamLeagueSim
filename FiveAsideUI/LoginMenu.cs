using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FiveAsideUI
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SimulationStarter sim = new SimulationStarter();
            sim.Show();
            this.Hide();
        }
    }
}
