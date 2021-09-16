using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FiveAsideUI
{
    public partial class DataOutputForm : Form
    {
        public int statisticPicked = -1; 
        public DataOutputForm()
        {
            InitializeComponent();
        }

        private void statisticPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            statisticPicked = statisticPicker.SelectedIndex; //assigns a zero-based index of which stat is picked, -1 returned if no value selected
        }
        //updates the label on the form to reflect the option chosen in the comboBox
        private void statisticDisplayerUpdater_tick(object sender, EventArgs e)
        {
            if (statisticPicked == 0)
            {
                dataOutputLabel.ForeColor = Color.DarkOrange;
                dataOutputLabel.Text = ("The modal top goal scorer across all \r\n the seasons you simulated was: \r\n");
            }

            if (statisticPicked == 1)
            {
                dataOutputLabel.ForeColor = Color.BlueViolet;
                dataOutputLabel.Text = ("The team that was most likely to \r\n win the league was: \r\n");
            }
            
            if (statisticPicked == 2)
            {
                dataOutputLabel.ForeColor = Color.ForestGreen;
                dataOutputLabel.Text = ("The average final position in the \r\n league of your 5-aside dream team was: \r\n");
            }
        }

        private void goToLB_Click(object sender, EventArgs e)
        {
            Leaderboards leaderboards = new Leaderboards();
            leaderboards.Show();
            this.Hide();
        }
    }
}
