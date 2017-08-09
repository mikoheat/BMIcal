namespace BMICalculator
{
    partial class SplashForm
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
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // SplashFormLabel
            // 
            this.SplashFormLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SplashFormLabel.AutoSize = true;
            this.SplashFormLabel.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashFormLabel.Location = new System.Drawing.Point(23, 93);
            this.SplashFormLabel.Name = "SplashFormLabel";
            this.SplashFormLabel.Size = new System.Drawing.Size(285, 43);
            this.SplashFormLabel.TabIndex = 0;
            this.SplashFormLabel.Text = "BMI CALCULATOR";
            this.SplashFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::BMICalculator.Properties.Resources.splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.ControlBox = false;
            this.Controls.Add(this.SplashFormLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashFormTimer;
        private System.Windows.Forms.Label SplashFormLabel;
    }
}