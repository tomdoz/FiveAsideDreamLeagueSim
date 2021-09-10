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

        private void statisticDisplayerUpdater_tick(object sender, EventArgs e)
        {
            if (statisticPicked == -1)
            {
                dataOutputLabel.Text = ("You need to choose a statistic:");
            }

            if (statisticPicked == 0)
            {
                dataOutputLabel.Text = ("The modal top goal scorer across all \r\n the seasons you simulated was: \r\n");
            }

            if (statisticPicked == 1)
            {
                dataOutputLabel.Text = ("The team that was most likely to \r\n win the league was: \r\n");
            }
            
            if (statisticPicked == 2)
            {
                dataOutputLabel.Text = ("The average final position in the \r\n league of your 5-aside dream team was: \r\n");
            }
        }
    }
}
