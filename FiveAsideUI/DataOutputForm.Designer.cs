
namespace FiveAsideUI
{
    partial class DataOutputForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataOutputForm));
            this.topTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statisticPicker = new System.Windows.Forms.ComboBox();
            this.dataOutputLabel = new System.Windows.Forms.Label();
            this.statisticDisplayerUpdater = new System.Windows.Forms.Timer(this.components);
            this.goToLB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topTitleLabel
            // 
            this.topTitleLabel.AutoSize = true;
            this.topTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.topTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.topTitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.topTitleLabel.Location = new System.Drawing.Point(185, 9);
            this.topTitleLabel.Name = "topTitleLabel";
            this.topTitleLabel.Size = new System.Drawing.Size(1083, 106);
            this.topTitleLabel.TabIndex = 3;
            this.topTitleLabel.Text = "Five-A-Side Dream League";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 144);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose statistic to \r\nbe outputted:";
            // 
            // statisticPicker
            // 
            this.statisticPicker.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statisticPicker.FormattingEnabled = true;
            this.statisticPicker.Items.AddRange(new object[] {
            "Top goalscorer",
            "Team most likely to win the league",
            "User\'s team average final position"});
            this.statisticPicker.Location = new System.Drawing.Point(553, 204);
            this.statisticPicker.Name = "statisticPicker";
            this.statisticPicker.Size = new System.Drawing.Size(895, 79);
            this.statisticPicker.TabIndex = 5;
            this.statisticPicker.SelectedIndexChanged += new System.EventHandler(this.statisticPicker_SelectedIndexChanged);
            // 
            // dataOutputLabel
            // 
            this.dataOutputLabel.AutoSize = true;
            this.dataOutputLabel.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataOutputLabel.Location = new System.Drawing.Point(290, 485);
            this.dataOutputLabel.Name = "dataOutputLabel";
            this.dataOutputLabel.Size = new System.Drawing.Size(837, 72);
            this.dataOutputLabel.TabIndex = 6;
            this.dataOutputLabel.Text = "You need to choose a statistic:";
            this.dataOutputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statisticDisplayerUpdater
            // 
            this.statisticDisplayerUpdater.Enabled = true;
            this.statisticDisplayerUpdater.Tick += new System.EventHandler(this.statisticDisplayerUpdater_tick);
            // 
            // goToLB
            // 
            this.goToLB.Font = new System.Drawing.Font("Segoe UI Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goToLB.Location = new System.Drawing.Point(553, 622);
            this.goToLB.Name = "goToLB";
            this.goToLB.Size = new System.Drawing.Size(345, 145);
            this.goToLB.TabIndex = 7;
            this.goToLB.Text = "Access Leaderboards";
            this.goToLB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.goToLB.UseVisualStyleBackColor = true;
            this.goToLB.Click += new System.EventHandler(this.goToLB_Click);
            // 
            // DataOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1470, 847);
            this.Controls.Add(this.goToLB);
            this.Controls.Add(this.dataOutputLabel);
            this.Controls.Add(this.statisticPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topTitleLabel);
            this.Name = "DataOutputForm";
            this.Text = "League Simulation Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statisticPicker;
        private System.Windows.Forms.Label dataOutputLabel;
        private System.Windows.Forms.Timer statisticDisplayerUpdater;
        private System.Windows.Forms.Button goToLB;
    }
}