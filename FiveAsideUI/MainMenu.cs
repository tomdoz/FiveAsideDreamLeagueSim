﻿using System;
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
        private void signUpButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginMenu loginForm = new LoginMenu();
            loginForm.Show();
        }
    }
}