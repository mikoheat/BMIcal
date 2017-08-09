using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Name: Taeho Kim
 * Date: Aug 8, 2017
 * Description: BMI Calculator Project
 * Version: 0.2 - Create an instance of the BMICalculator object
 */

namespace BMICalculator
{
    public static class Program
    {
        // Create Reference to Forms
        public static BMICalculator calculator = new BMICalculator();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
