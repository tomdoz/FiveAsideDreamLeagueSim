
namespace FiveAsideUI
{
    partial class playerInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerInputForm));
            this.playerInputTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.enterTeamTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enterTeamName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.topTitleLabel = new System.Windows.Forms.Label();
            this.lastNameForm = new System.Windows.Forms.Label();
            this.Shooting = new System.Windows.Forms.Label();
            this.ShootingSlider = new System.Windows.Forms.TrackBar();
            this.lastNameTXT = new System.Windows.Forms.TextBox();
            this.playerInputTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShootingSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // playerInputTabs
            // 
            this.playerInputTabs.Controls.Add(this.tabPage1);
            this.playerInputTabs.Controls.Add(this.tabPage2);
            this.playerInputTabs.Controls.Add(this.tabPage3);
            this.playerInputTabs.Controls.Add(this.tabPage4);
            this.playerInputTabs.Controls.Add(this.tabPage5);
            this.playerInputTabs.Controls.Add(this.tabPage6);
            this.playerInputTabs.Controls.Add(this.tabPage7);
            this.playerInputTabs.Location = new System.Drawing.Point(72, 205);
            this.playerInputTabs.Name = "playerInputTabs";
            this.playerInputTabs.SelectedIndex = 0;
            this.playerInputTabs.Size = new System.Drawing.Size(1163, 572);
            this.playerInputTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.enterTeamTXT);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.enterTeamName);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1000);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1000);
            this.tabPage1.Size = new System.Drawing.Size(1147, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Instructions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // enterTeamTXT
            // 
            this.enterTeamTXT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.enterTeamTXT.Location = new System.Drawing.Point(375, 445);
            this.enterTeamTXT.Name = "enterTeamTXT";
            this.enterTeamTXT.Size = new System.Drawing.Size(441, 40);
            this.enterTeamTXT.TabIndex = 2;
            this.enterTeamTXT.Text = "e.g. Gangster\'s Allardyce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter team name:";
            // 
            // enterTeamName
            // 
            this.enterTeamName.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterTeamName.Location = new System.Drawing.Point(13, 22);
            this.enterTeamName.Name = "enterTeamName";
            this.enterTeamName.Size = new System.Drawing.Size(1065, 397);
            this.enterTeamName.TabIndex = 0;
            this.enterTeamName.Text = resources.GetString("enterTeamName.Text");
            this.enterTeamName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lastNameTXT);
            this.tabPage2.Controls.Add(this.ShootingSlider);
            this.tabPage2.Controls.Add(this.Shooting);
            this.tabPage2.Controls.Add(this.lastNameForm);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.DescriptionLabel);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1147, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Team Captain";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 40);
            this.textBox1.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 13);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(149, 32);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "First Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(8, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1147, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Player 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(8, 46);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1147, 518);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Player 3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(8, 46);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1147, 518);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Player 4";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(8, 46);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1147, 518);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Player 5";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(8, 46);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1147, 518);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Substitute 1";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // topTitleLabel
            // 
            this.topTitleLabel.AutoSize = true;
            this.topTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.topTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.topTitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.topTitleLabel.Location = new System.Drawing.Point(282, 34);
            this.topTitleLabel.Name = "topTitleLabel";
            this.topTitleLabel.Size = new System.Drawing.Size(1083, 106);
            this.topTitleLabel.TabIndex = 2;
            this.topTitleLabel.Text = "Five-A-Side Dream League";
            // 
            // lastNameForm
            // 
            this.lastNameForm.AutoSize = true;
            this.lastNameForm.Location = new System.Drawing.Point(6, 67);
            this.lastNameForm.Name = "lastNameForm";
            this.lastNameForm.Size = new System.Drawing.Size(145, 32);
            this.lastNameForm.TabIndex = 2;
            this.lastNameForm.Text = "Last Name:";
            // 
            // Shooting
            // 
            this.Shooting.AutoSize = true;
            this.Shooting.Location = new System.Drawing.Point(23, 134);
            this.Shooting.Name = "Shooting";
            this.Shooting.Size = new System.Drawing.Size(128, 32);
            this.Shooting.TabIndex = 3;
            this.Shooting.Text = "Shooting;";
            // 
            // ShootingSlider
            // 
            this.ShootingSlider.Location = new System.Drawing.Point(157, 119);
            this.ShootingSlider.Name = "ShootingSlider";
            this.ShootingSlider.Size = new System.Drawing.Size(205, 90);
            this.ShootingSlider.TabIndex = 4;
            // 
            // lastNameTXT
            // 
            this.lastNameTXT.Location = new System.Drawing.Point(157, 64);
            this.lastNameTXT.Name = "lastNameTXT";
            this.lastNameTXT.Size = new System.Drawing.Size(212, 40);
            this.lastNameTXT.TabIndex = 5;
            // 
            // playerInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1696, 847);
            this.Controls.Add(this.topTitleLabel);
            this.Controls.Add(this.playerInputTabs);
            this.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "playerInputForm";
            this.Text = "Input your team!";
            this.playerInputTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShootingSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl playerInputTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox enterTeamTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label enterTeamName;
        private System.Windows.Forms.Label topTitleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox lastNameTXT;
        private System.Windows.Forms.TrackBar ShootingSlider;
        private System.Windows.Forms.Label Shooting;
        private System.Windows.Forms.Label lastNameForm;
    }
}