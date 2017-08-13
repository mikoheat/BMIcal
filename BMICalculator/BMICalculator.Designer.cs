namespace BMICalculator
{
    partial class BMICalculator
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetrixButton = new System.Windows.Forms.RadioButton();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MultilineTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.ImperialButton, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.MetrixButton, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.WeightBox, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.HeightBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.CalculateButton, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.ResultBox, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.MyWeightLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.ResetButton, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.MyHeightLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.MultilineTextBox, 0, 5);
            this.tableLayoutPanel.Location = new System.Drawing.Point(18, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(272, 418);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // ImperialButton
            // 
            this.ImperialButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Location = new System.Drawing.Point(4, 3);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.Click += new System.EventHandler(this.ImperialButton_Click);
            // 
            // MetrixButton
            // 
            this.MetrixButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MetrixButton.AutoSize = true;
            this.MetrixButton.Location = new System.Drawing.Point(151, 3);
            this.MetrixButton.Name = "MetrixButton";
            this.MetrixButton.Size = new System.Drawing.Size(105, 35);
            this.MetrixButton.TabIndex = 2;
            this.MetrixButton.TabStop = true;
            this.MetrixButton.Text = "Metrix";
            this.MetrixButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MetrixButton.UseVisualStyleBackColor = true;
            this.MetrixButton.Click += new System.EventHandler(this.MetrixButton_Click);
            // 
            // WeightBox
            // 
            this.WeightBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightBox.Location = new System.Drawing.Point(139, 146);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(130, 38);
            this.WeightBox.TabIndex = 6;
            // 
            // HeightBox
            // 
            this.HeightBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightBox.Location = new System.Drawing.Point(139, 63);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(130, 38);
            this.HeightBox.TabIndex = 4;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(3, 251);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(130, 56);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.SetColumnSpan(this.ResultBox, 2);
            this.ResultBox.Enabled = false;
            this.ResultBox.Location = new System.Drawing.Point(3, 210);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(266, 38);
            this.ResultBox.TabIndex = 7;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Location = new System.Drawing.Point(19, 134);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(98, 62);
            this.MyWeightLabel.TabIndex = 5;
            this.MyWeightLabel.Text = "My Weight";
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetButton.Location = new System.Drawing.Point(139, 251);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(130, 56);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Location = new System.Drawing.Point(21, 51);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(93, 62);
            this.MyHeightLabel.TabIndex = 3;
            this.MyHeightLabel.Text = "My Height";
            // 
            // MultilineTextBox
            // 
            this.MultilineTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.SetColumnSpan(this.MultilineTextBox, 2);
            this.MultilineTextBox.Enabled = false;
            this.MultilineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultilineTextBox.Location = new System.Drawing.Point(3, 316);
            this.MultilineTextBox.Name = "MultilineTextBox";
            this.MultilineTextBox.Size = new System.Drawing.Size(266, 96);
            this.MultilineTextBox.TabIndex = 11;
            this.MultilineTextBox.Text = "";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetrixButton;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.RichTextBox MultilineTextBox;
    }
}

