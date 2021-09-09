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
        //player 2 attribute variables
        public int p2ShootingVal = 0;
        public int p2DribblingVal = 0;
        public int p2PaceVal = 0;
        public int p2PhysicalVal = 0;
        public int p2ReliableVal = 0;
        public int p2TackleVal = 0;
        public int p2AggroVal = 0;
        //player 3 attribute variables;
        public int p3ShootingVal = 0;
        public int p3DribblingVal = 0;
        public int p3PaceVal = 0;
        public int p3PhysicalVal = 0;
        public int p3ReliableVal = 0;
        public int p3TackleVal = 0;
        public int p3AggroVal = 0;
        //player 4 attribute variables;
        public int p4ShootingVal = 0;
        public int p4DribblingVal = 0;
        public int p4PaceVal = 0;
        public int p4PhysicalVal = 0;
        public int p4ReliableVal = 0;
        public int p4TackleVal = 0;
        public int p4AggroVal = 0;
        //player 5 attribute variables;
        public int p5ShootingVal = 0;
        public int p5DribblingVal = 0;
        public int p5PaceVal = 0;
        public int p5PhysicalVal = 0;
        public int p5ReliableVal = 0;
        public int p5TackleVal = 0;
        public int p5AggroVal = 0;
        //substitute attribute variables
        public int subShootingVal = 0;
        public int subDribblingVal = 0;
        public int subPaceVal = 0;
        public int subPhysicalVal = 0;
        public int subReliableVal = 0;
        public int subTackleVal = 0;
        public int subAggroVal = 0;
        public playerInputForm()
        {
            InitializeComponent();
        }

        private void sliderValueUpdater_Tick(object sender, EventArgs e)
        {
            //Updating captain current labels and remaining points
            currentShooting.Text = Convert.ToString(p1ShootingVal);
            currentDribbling.Text = Convert.ToString(p1DribblingVal);
            currentPhysical.Text = Convert.ToString(p1PhysicalVal);
            currentReliability.Text = Convert.ToString(p1ReliableVal);     
            label1.Text = Convert.ToString(p1TackleVal);
            currentAgrression.Text = Convert.ToString(p1AggroVal);
            currentPace.Text = Convert.ToString(p1PaceVal);
            pointsRemainingNum.Text = Convert.ToString(500 - ShootingSlider.Value - dribblingSlider.Value - passingSlider.Value - physicalitySlider.Value - ReliableSlider.Value - aggressionSlider.Value - tackleSlider.Value);
            //CAPTAIN: if no skill points are remaining reset the sliders to 0
            if (Convert.ToInt32(pointsRemainingNum.Text) < 0)
            {
                ShootingSlider.Value = 0;
                dribblingSlider.Value = 0;
                passingSlider.Value = 0;
                physicalitySlider.Value = 0;
                ReliableSlider.Value = 0;
                tackleSlider.Value = 0;
                aggressionSlider.Value = 0;
                currentShooting.Text = "0";
                currentDribbling.Text = "0";
                currentPhysical.Text = "0";
                currentReliability.Text = "0";
                label1.Text = "0";
                currentAgrression.Text = "0";
                currentPace.Text = "0";
            }

            //PLAYER 2 SLIDER UPDATES
            p2CurrShooting.Text = Convert.ToString(p2ShootingVal);
            p2CurrDribbling.Text = Convert.ToString(p2DribblingVal);
            p2CurrPace.Text = Convert.ToString(p2PaceVal);
            p2CurrPhysical.Text = Convert.ToString(p2PhysicalVal);
            p2CurrAgression.Text = Convert.ToString(p2AggroVal);
            p2CurrReliable.Text = Convert.ToString(p2ReliableVal);
            p2CurrTackle.Text = Convert.ToString(p2TackleVal);


        }
        //for team captain
        private void ShootingSlider_Scroll(object sender, EventArgs e)
        {
            p1ShootingVal = ShootingSlider.Value;
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

        //Player 2 Slider events
        private void p2ShootingSlider_Scroll(object sender, EventArgs e)
        {
            p2ShootingVal = p2ShootingSlider.Value;
        }

        private void p2DribblingSlider_Scroll(object sender, EventArgs e)
        {
            p2DribblingVal = p2DribblingSlider.Value;
        }

        private void p2PaceSlider_Scroll(object sender, EventArgs e)
        {
            p2PaceVal = p2PaceSlider.Value;
        }

        private void p2PhysicalitySlider_Scroll(object sender, EventArgs e)
        {
            p2PhysicalVal = p2PhysicalitySlider.Value;
        }

        private void p2ReliableSlider_Scroll(object sender, EventArgs e)
        {
            p2ReliableVal = p2ReliableSlider.Value;
        }

        private void p2TackleSlider_Scroll(object sender, EventArgs e)
        {
            p2TackleVal = p2TackleSlider.Value;
        }

        private void p2AggressionSlider_Scroll(object sender, EventArgs e)
        {
            p2AggroVal = p2AggressionSlider.Value;
        }
    }
}
