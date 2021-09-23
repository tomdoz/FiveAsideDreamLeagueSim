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
        public int cpuScoreChance = 8;
        public bool matchEnded = false;
        public int gameClockIncrementer = 0;
        public bool userAtHome = true;

        public MatchViewer()
        {
            InitializeComponent();
            LoadTeams();
            matchTimer.Enabled = true;
        }

        public void LoadTeams()
        {
            //need to add the loading of team names to the labels and proper iteration through the teams from CPU
            //Still need to pull who is home and who is away from fixture table to then control this variable
            if(userAtHome == false)
            {
                leftHome.Hide();
                leftAway.Show();
                rightAway.Hide();
                rightHome.Show();
            }
           //userScoreChance = UserChanceGenerator();
           //cpuScoreChance = CPUChanceGenerator();
        }

        public int UserChanceGenerator()
        {
            userScoreChance = Convert.ToInt32(((0.6 * userSHO) + (0.5 * userPAC) + (0.3 * userDRI) + (0.1 * userPHY)) / 4); //loading the user attacking attribute stats into weighted average equation
            userScoreChance = userScoreChance - Convert.ToInt32(((0.5 * cpuTAC) + (0.4 * cpuPHY) + (0.2 * cpuAGG) + (0.2 * cpuREL)) / 4); //weighted average then found using CPU defensive attribute stats
            return userScoreChance;
        }

        public int CPUChanceGenerator()
        {
            cpuScoreChance = Convert.ToInt32(((0.6 * cpuSHO) + (0.5 * cpuPAC) + (0.3 * cpuDRI) + (0.1 * cpuPHY)) / 4); //loading the CPU attacking attribute stats into weighted average equation
            cpuScoreChance = cpuScoreChance - Convert.ToInt32(((0.5 * userTAC) + (0.4 * userPHY) + (0.2 * userAGG) + (0.2 * userREL)) / 4); //weighted average then found using user defensive attribute stats
            return cpuScoreChance;
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
            string userScoreMsgTitle = TimerLabel + " GOAL!";
            matchTimer.Stop();
            MessageBox.Show(userScoreMsg, userScoreMsgTitle);
            matchTimer.Start();
        }

        public void CPUScoreGoal()
        {
            cpuScoreLabel.Text = Convert.ToString(Convert.ToInt32(cpuScoreLabel.Text) + 1);
            string cpuScoreMsg = "The opposition team has scored. The score is now " + userScoreLabel.Text + " - " + cpuScoreLabel.Text;
            string cpuScoreMsgTitle = TimerLabel.Text + " GOAL!";
            matchTimer.Stop();
            MessageBox.Show(cpuScoreMsg, cpuScoreMsgTitle);
            matchTimer.Start();
        }

        private void matchTimer_Tick(object sender, EventArgs e)
        {
           if (matchEnded == false)
           {
                TimerLabel.Text = Convert.ToString(gameClockIncrementer + 5) + "'";
                gameClockIncrementer += 5;
                ScoreGoalCheck();
                if (gameClockIncrementer == 90)
                {
                    matchEnded = true;
                    string matchEndMsg = "The Match has ended, the game finished " + userScoreLabel.Text + " - " + cpuScoreLabel.Text;
                    string matchEndMsgTitle = "Match Ended";
                    MessageBox.Show(matchEndMsg, matchEndMsgTitle);
                }

           }
        }
    }
}
