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
 * Version: 0.2 - Added ImperialButton_Click and MetrixButton_Click
 */

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        // Private variables

        private string _calculator;

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
            _calculator = "Imperial";

            MyHeightLabel.Text = "Inches";
            MyWeightLabel.Text = "Pounds";
        }

        private void MetrixButton_Click(object sender, EventArgs e)
        {
            _calculator = "Metrix";

            MyHeightLabel.Text = "Meters";
            MyWeightLabel.Text = "Kg";
        }
    }
}
