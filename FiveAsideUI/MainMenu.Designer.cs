
namespace FiveAsideUI
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.topTitleLabel = new System.Windows.Forms.Label();
            this.bottomTitleLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topTitleLabel
            // 
            this.topTitleLabel.AutoSize = true;
            this.topTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.topTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.topTitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.topTitleLabel.Location = new System.Drawing.Point(42, 34);
            this.topTitleLabel.Name = "topTitleLabel";
            this.topTitleLabel.Size = new System.Drawing.Size(1406, 106);
            this.topTitleLabel.TabIndex = 0;
            this.topTitleLabel.Text = "Five-A-Side Fantasy Dream League";
            // 
            // bottomTitleLabel
            // 
            this.bottomTitleLabel.AutoSize = true;
            this.bottomTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.bottomTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bottomTitleLabel.ForeColor = System.Drawing.Color.Gold;
            this.bottomTitleLabel.Location = new System.Drawing.Point(374, 140);
            this.bottomTitleLabel.Name = "bottomTitleLabel";
            this.bottomTitleLabel.Size = new System.Drawing.Size(704, 142);
            this.bottomTitleLabel.TabIndex = 1;
            this.bottomTitleLabel.Text = "SIMULATOR";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.White;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpButton.Location = new System.Drawing.Point(235, 372);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(456, 179);
            this.signUpButton.TabIndex = 2;
            this.signUpButton.Text = "Sign up now! Create your dream team...";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(801, 372);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(456, 179);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Already played? Log in to your account here!";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1470, 847);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.bottomTitleLabel);
            this.Controls.Add(this.topTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainMenuForm";
            this.Text = "Five-A-Side Dream League Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topTitleLabel;
        private System.Windows.Forms.Label bottomTitleLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button loginButton;
    }
}

