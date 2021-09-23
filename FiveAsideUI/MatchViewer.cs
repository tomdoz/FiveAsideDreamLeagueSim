using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FiveAsideUI
{
    public partial class MatchViewer : Form
    {
        public int userSHO;
        public int userDRI;
        public int userPAC;
        public int userPHY;
        public int userREL;
        public int userTAC;
        public int userAGG;
        public int cpuSHO;
        public int cpuDRI;
        public int cpuPAC;
        public int cpuPHY;
        public int cpuREL;
        public int cpuTAC;
        public int cpuAGG;
        public int userScoreChance;
        public int cpuScoreChance;


        public MatchViewer()
        {
            InitializeComponent();
            LoadTeams();
        }

        public void LoadTeams()
        {
            //need to add the proper hiding and showing settings for labels saying which team is home and away
            //need to add the loading of team names to the labels and proper iteration through the teams from CPU
        }

        public void ScoreGoalCheck()
        {
            Random random = new Random();
            int rollUserProbabilities = random.Next(0, 100);
            int rollCPUProbabilities = random.Next(0, 100);
            if (rollUserProbabilities <= userScoreChance)
            {
                UserScoreGoal();   
            }
            if (rollCPUProbabilities <= cpuScoreChance)
            {
                CPUScoreGoal();
            }
        }

        public void UserScoreGoal()
        {
            userScoreLabel.Text = Convert.ToString(Convert.ToInt32(userScoreLabel.Text) + 1);
            string userScoreMsg = "Your team has scored. The score is now " + userScoreLabel.Text + " - " + cpuScoreLabel.Text;
            string userScoreMsgTitle = "GOAL!";
            MessageBox.Show(userScoreMsg, userScoreMsgTitle);
        }

        public void CPUScoreGoal()
        {
            cpuScoreLabel.Text = Convert.ToString(Convert.ToInt32(cpuScoreLabel.Text) + 1);
            string cpuScoreMsg = "Your team has scored. The score is now " + userScoreLabel.Text + " - " + cpuScoreLabel.Text;
            string cpuScoreMsgTitle = "GOAL!";
            MessageBox.Show(cpuScoreMsg, cpuScoreMsgTitle);
        }

        
    }
}
