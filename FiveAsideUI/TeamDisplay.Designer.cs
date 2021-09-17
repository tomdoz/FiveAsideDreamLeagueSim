
namespace FiveAsideUI
{
    partial class TeamDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamDisplay));
            this.topTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topTitleLabel
            // 
            this.topTitleLabel.AutoSize = true;
            this.topTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.topTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.topTitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.topTitleLabel.Location = new System.Drawing.Point(207, 9);
            this.topTitleLabel.Name = "topTitleLabel";
            this.topTitleLabel.Size = new System.Drawing.Size(1449, 142);
            this.topTitleLabel.TabIndex = 2;
            this.topTitleLabel.Text = "Five-A-Side Dream League";
            // 
            // TeamDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.topTitleLabel);
            this.Name = "TeamDisplay";
            this.Text = "Team Display";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topTitleLabel;
    }
}