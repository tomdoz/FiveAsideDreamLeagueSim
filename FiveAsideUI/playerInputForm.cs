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
        public int p1ShootingVal = 0;
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
            p1ShootingVal = ShootingSlider.Value; 
        }

        private void sliderValueUpdater_Tick(object sender, EventArgs e)
        {
            currentShooting.Text = Convert.ToString(p1ShootingVal);
        }
    }
}
