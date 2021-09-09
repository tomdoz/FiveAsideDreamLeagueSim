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
        //captain attribute variables
        public int p1ShootingVal = 0;
        public int p1DribblingVal = 0;
        public int p1PaceVal = 0;
        public int p1PhysicalVal = 0;
        public int p1ReliableVal = 0;
        public int p1TackleVal = 0;
        public int p1AggroVal = 0;
        public playerInputForm()
        {
            InitializeComponent();
        }

        private void ShootingSlider_Scroll(object sender, EventArgs e)
        {
            p1ShootingVal = ShootingSlider.Value; 
        }

        private void sliderValueUpdater_Tick(object sender, EventArgs e)
        {
            currentShooting.Text = Convert.ToString(p1ShootingVal);
            currentDribbling.Text = Convert.ToString(p1DribblingVal);
            currentPhysical.Text = Convert.ToString(p1PhysicalVal);
            currentReliability.Text = Convert.ToString(p1ReliableVal);
            label1.Text = Convert.ToString(p1TackleVal);
            currentAgrression.Text = Convert.ToString(p1AggroVal);
            currentPace.Text = Convert.ToString(p1PaceVal);

        }

        private void dribblingSlider_Scroll(object sender, EventArgs e)
        {
            p1DribblingVal = dribblingSlider.Value;
        }

        private void physicalitySlider_Scroll(object sender, EventArgs e)
        {
            p1PhysicalVal = physicalitySlider.Value;
        }

        private void ReliableSlider_Scroll(object sender, EventArgs e)
        {
            p1ReliableVal = ReliableSlider.Value;
        }

        private void tackleSlider_Scroll(object sender, EventArgs e)
        {
            p1TackleVal = tackleSlider.Value;
        }

        private void aggressionSlider_Scroll(object sender, EventArgs e)
        {
            p1AggroVal = aggressionSlider.Value;
        }

        private void paceSlider_Scroll(object sender, EventArgs e)
        {
            p1PaceVal = passingSlider.Value;
        }
    }
}
