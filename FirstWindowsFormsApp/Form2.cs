using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApp
{
    public partial class EmreFormSecondHello : Form
    {
        public EmreFormSecondHello()
        {
            InitializeComponent();
            radioFemale.Checked = false;
            radioMale.Checked = false;
        }

        //Declare variables inside scope so can be accessible for future modifications!

        double height = 0;
        double weight = 0;
        double bmi = 0;

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!radioFemale.Checked && !radioMale.Checked)
                {
                    MessageBox.Show("Choose gender please!");
                }
                else
                {
                    weight = Convert.ToDouble(textWeight.Text.Replace(".",","));
                    height = Convert.ToDouble(textheight.Text.Replace(".", ","));
                    if (height < 0 || weight < 0)
                    {
                        throw new Exception("Weight and height must be greater than zero!"); 
                    }
                    //BMI calculation: weight / (height * height)
                    //Multiply bmi for male 1.1, for woman 1.07.
                    bmi = weight / Math.Pow(height, 2);
                    bmi *= radioMale.Checked ? 1.1 : 1.07;
                    MessageBox.Show($"BMI for given weight and height: {bmi.ToString("0.000")}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }

        }
    }
}
