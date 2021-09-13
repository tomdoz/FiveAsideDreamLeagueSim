using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FiveAsideUI
{
    public partial class SimulationStarter : Form
    {
        public int numSeasons;

        public SimulationStarter()
        {
            InitializeComponent();
        }

        private void numSeasonsUpDown_ValueChanged(object sender, EventArgs e)
        {
            numSeasons = Convert.ToInt32(numSeasonsUpDown.Value);
        }

        private void startSimulationButton_Click(object sender, EventArgs e)
        {
            //StartSimulation();
            DataOutputForm data = new DataOutputForm();
            data.Show();
            this.Hide();
        }
    }
}
