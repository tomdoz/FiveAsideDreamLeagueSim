using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FiveAsideUI
{
    public partial class playerInputForm : Form
    {
        public playerInputForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void topTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShootingSlider_Scroll(object sender, EventArgs e)
        {
            int ShootingVal = ShootingSlider.Value; //change to public int where component intialises
        }

        private void sliderValueUpdater_Tick(object sender, EventArgs e)
        {
            currentShooting = Convert.ToString(ShootingVal)
        }
    }
}
