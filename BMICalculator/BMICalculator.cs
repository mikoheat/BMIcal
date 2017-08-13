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
 * Date: Aug 8, 2017
 * Description: BMI Calculator Project
 * Version: 0.3 - Implemented "calculate bmi" function
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
    }
}
