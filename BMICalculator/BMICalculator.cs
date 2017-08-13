using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Name: Taeho Kim
 * Date: Aug 12, 2017
 * Description: BMI Calculator Project
 * Version: 0.6 - Implement BMIevaluation method
 */

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        // Private variables

        private string _calculator;
        private double _height;
        private double _weight;
        private double _bmi;

        // Private Properties

        private string Calculator
        {
            get
            {
                return this._calculator;
            }
            set
            {
                this._calculator = value;
            }
        }

        private double height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }

        private double weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }

        private double bmi
        {
            get
            {
                return this._bmi;
            }
            set
            {
                this._bmi = value;
            }
        }

        public BMICalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event handler for the "FormClosing" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ImperialButton_Click(object sender, EventArgs e)
        {
            Calculator = "Imperial";

            MyHeightLabel.Text = "Inches";
            MyWeightLabel.Text = "Pounds";
        }

        private void MetrixButton_Click(object sender, EventArgs e)
        {
            Calculator = "Metrix";

            MyHeightLabel.Text = "Meters";
            MyWeightLabel.Text = "Kg";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImperialButton.Checked || MetrixButton.Checked)
                {
                    ResultBox.Clear();

                    height = Convert.ToDouble(HeightBox.Text);
                    weight = Convert.ToDouble(WeightBox.Text);

                    switch (Calculator)
                    {
                        case "Imperial":
                            bmi = weight * 703 / Math.Pow(height, 2);
                            break;
                        case "Metrix":
                            bmi = weight / Math.Pow(height, 2);
                            break;
                        default:
                            break;
                    }

                    ResultBox.Text = bmi.ToString();
                    BMIevaluation(bmi);
                }
                else
                {
                    throw new Exception("Error: You have to pick a calculator.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Those two method "HeightBox_KeyPress" and "WeightBox_KeyPress"
        /// Control input value which only allows digit, backspace, and a decimal point
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && HeightBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
            
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == '.')) 
            {
                e.Handled = true;
            }
        }

        private void WeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && WeightBox.Text.Contains('.'))
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightBox.Text = "";
            WeightBox.Text = "";
            ResultBox.Text = "";
            MultilineTextBox.Text = "";
            MultilineTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// This method makes MultilineTextBox-color changed by bmi result
        /// </summary>
        /// <param name="bmi"></param>
        private void BMIevaluation(double bmi)
        {
            if (bmi < 18.5)
            {
                MultilineTextBox.Text = "Underweight";
                MultilineTextBox.ForeColor = Color.White;
                MultilineTextBox.BackColor = Color.MidnightBlue;

            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                MultilineTextBox.Text = "Normal";
                MultilineTextBox.ForeColor = Color.White;
                MultilineTextBox.BackColor = Color.Lime;
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                MultilineTextBox.Text = "Overweight";
                MultilineTextBox.ForeColor = Color.White;
                MultilineTextBox.BackColor = Color.Crimson;

            }
            else if (bmi > 30)
            {
                MultilineTextBox.Text = "Obese";
                MultilineTextBox.ForeColor = Color.White;
                MultilineTextBox.BackColor = Color.Red;
            }
        }
    }
}
