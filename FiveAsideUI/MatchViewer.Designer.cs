
namespace FiveAsideUI
{
    partial class MatchViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchViewer));
            this.label1 = new System.Windows.Forms.Label();
            this.team1Name = new System.Windows.Forms.Label();
            this.leftHome = new System.Windows.Forms.Label();
            this.leftAway = new System.Windows.Forms.Label();
            this.cpuTeamLabel = new System.Windows.Forms.Label();
            this.rightHome = new System.Windows.Forms.Label();
            this.rightAway = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(672, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Match Viewer";
            // 
            // team1Name
            // 
            this.team1Name.AutoSize = true;
            this.team1Name.BackColor = System.Drawing.Color.Transparent;
            this.team1Name.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.team1Name.ForeColor = System.Drawing.Color.White;
            this.team1Name.Location = new System.Drawing.Point(755, 151);
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(186, 45);
            this.team1Name.TabIndex = 1;
            this.team1Name.Text = "User Team";
            // 
            // leftHome
            // 
            this.leftHome.AutoSize = true;
            this.leftHome.BackColor = System.Drawing.Color.Transparent;
            this.leftHome.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftHome.ForeColor = System.Drawing.Color.White;
            this.leftHome.Location = new System.Drawing.Point(698, 151);
            this.leftHome.Name = "leftHome";
            this.leftHome.Size = new System.Drawing.Size(72, 45);
            this.leftHome.TabIndex = 2;
            this.leftHome.Text = "(H)";
            // 
            // leftAway
            // 
            this.leftAway.AutoSize = true;
            this.leftAway.BackColor = System.Drawing.Color.Transparent;
            this.leftAway.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftAway.ForeColor = System.Drawing.Color.White;
            this.leftAway.Location = new System.Drawing.Point(698, 151);
            this.leftAway.Name = "leftAway";
            this.leftAway.Size = new System.Drawing.Size(70, 45);
            this.leftAway.TabIndex = 3;
            this.leftAway.Text = "(A)";
            // 
            // cpuTeamLabel
            // 
            this.cpuTeamLabel.AutoSize = true;
            this.cpuTeamLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuTeamLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpuTeamLabel.ForeColor = System.Drawing.Color.White;
            this.cpuTeamLabel.Location = new System.Drawing.Point(1020, 151);
            this.cpuTeamLabel.Name = "cpuTeamLabel";
            this.cpuTeamLabel.Size = new System.Drawing.Size(180, 45);
            this.cpuTeamLabel.TabIndex = 4;
            this.cpuTeamLabel.Text = "CPU Team";
            // 
            // rightHome
            // 
            this.rightHome.AutoSize = true;
            this.rightHome.BackColor = System.Drawing.Color.Transparent;
            this.rightHome.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightHome.ForeColor = System.Drawing.Color.White;
            this.rightHome.Location = new System.Drawing.Point(963, 151);
            this.rightHome.Name = "rightHome";
            this.rightHome.Size = new System.Drawing.Size(72, 45);
            this.rightHome.TabIndex = 5;
            this.rightHome.Text = "(H)";
            // 
            // rightAway
            // 
            this.rightAway.AutoSize = true;
            this.rightAway.BackColor = System.Drawing.Color.Transparent;
            this.rightAway.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightAway.ForeColor = System.Drawing.Color.White;
            this.rightAway.Location = new System.Drawing.Point(963, 151);
            this.rightAway.Name = "rightAway";
            this.rightAway.Size = new System.Drawing.Size(70, 45);
            this.rightAway.TabIndex = 6;
            this.rightAway.Text = "(A)";
            // 
            // MatchViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.cpuTeamLabel);
            this.Controls.Add(this.rightAway);
            this.Controls.Add(this.team1Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftHome);
            this.Controls.Add(this.leftAway);
            this.Controls.Add(this.rightHome);
            this.Name = "MatchViewer";
            this.Text = "MatchViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label team1Name;
        private System.Windows.Forms.Label leftHome;
        private System.Windows.Forms.Label leftAway;
        private System.Windows.Forms.Label cpuTeamLabel;
        private System.Windows.Forms.Label rightHome;
        private System.Windows.Forms.Label rightAway;
    }
}