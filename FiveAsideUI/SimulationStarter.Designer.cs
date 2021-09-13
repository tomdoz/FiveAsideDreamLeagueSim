
namespace FiveAsideUI
{
    partial class SimulationStarter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationStarter));
            this.topTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSeasonsUpDown = new System.Windows.Forms.NumericUpDown();
            this.startSimulationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSeasonsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // topTitleLabel
            // 
            this.topTitleLabel.AutoSize = true;
            this.topTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.topTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.topTitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.topTitleLabel.Location = new System.Drawing.Point(170, 50);
            this.topTitleLabel.Name = "topTitleLabel";
            this.topTitleLabel.Size = new System.Drawing.Size(1083, 106);
            this.topTitleLabel.TabIndex = 1;
            this.topTitleLabel.Text = "Five-A-Side Dream League";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1313, 162);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your team has been saved in the database, and we can now begin \r\n          the le" +
    "ague simulation.  Please enter below the number \r\n                      of seaso" +
    "ns you would like to simulate.";
            // 
            // numSeasonsUpDown
            // 
            this.numSeasonsUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSeasonsUpDown.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numSeasonsUpDown.Location = new System.Drawing.Point(143, 471);
            this.numSeasonsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSeasonsUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSeasonsUpDown.Name = "numSeasonsUpDown";
            this.numSeasonsUpDown.Size = new System.Drawing.Size(553, 116);
            this.numSeasonsUpDown.TabIndex = 3;
            this.numSeasonsUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSeasonsUpDown.ValueChanged += new System.EventHandler(this.numSeasonsUpDown_ValueChanged);
            // 
            // startSimulationButton
            // 
            this.startSimulationButton.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startSimulationButton.Location = new System.Drawing.Point(846, 445);
            this.startSimulationButton.Name = "startSimulationButton";
            this.startSimulationButton.Size = new System.Drawing.Size(407, 154);
            this.startSimulationButton.TabIndex = 4;
            this.startSimulationButton.Text = "Start simulation!";
            this.startSimulationButton.UseVisualStyleBackColor = true;
            this.startSimulationButton.Click += new System.EventHandler(this.startSimulationButton_Click);
            // 
            // SimulationStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1470, 847);
            this.Controls.Add(this.startSimulationButton);
            this.Controls.Add(this.numSeasonsUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topTitleLabel);
            this.Name = "SimulationStarter";
            this.Text = "Preparing to start the simulation...";
            ((System.ComponentModel.ISupportInitialize)(this.numSeasonsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSeasonsUpDown;
        private System.Windows.Forms.Button startSimulationButton;
    }
}