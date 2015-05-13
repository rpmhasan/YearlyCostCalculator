using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearlyCostCalculatorApp
{
    public partial class YearlyCostCalculatorUI : Form
    {
        public YearlyCostCalculatorUI()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (classComboBox.Text=="Class 1" || classComboBox.Text=="Class 2")
            {
                double totalclass1n2 = 10000 + (500 * 12);
                
                
                if (discountCheckBox.Checked)
                {
                    totalclass1n2 = totalclass1n2- (totalclass1n2 * 0.05);
                    MessageBox.Show(Convert.ToString(totalclass1n2));
                }
                else
                {

                    MessageBox.Show(Convert.ToString(totalclass1n2));
                    
                }
            }

            

            else if (classComboBox.Text=="Class 3" || classComboBox.Text=="Class 4" || classComboBox.Text=="Class 5")
            {
                double totalclass3to5 = 10000 + (1000 * 12);
               
                if (discountCheckBox.Checked)
                {
                    totalclass3to5 = totalclass3to5 - (totalclass3to5 * 0.05);
                    MessageBox.Show(Convert.ToString(totalclass3to5));
                }
                else
                {
                    MessageBox.Show(Convert.ToString(totalclass3to5));
                }
            }
            else if (classComboBox.Text=="Class 6" || classComboBox.Text=="Class 7" || classComboBox.Text=="Class 8")
            {
                double totalClass6to8 = 12000 + (1500 * 12);
               
                if (discountCheckBox.Checked)
                {
                    totalClass6to8 = totalClass6to8 - (totalClass6to8 * 0.05);
                    MessageBox.Show(Convert.ToString(totalClass6to8));
                }
                else
                {
                    MessageBox.Show(Convert.ToString(totalClass6to8));
                }
            }
            else if (classComboBox.Text=="Class 9" || classComboBox.Text=="Class 10")
            {
                double totalClass9to10 = 15000 + (2000 * 12);
               
                if (discountCheckBox.Checked)
                {
                    totalClass9to10 = totalClass9to10 - (totalClass9to10 * 0.05);
                    MessageBox.Show(Convert.ToString(totalClass9to10));
                }
                else
                {
                    MessageBox.Show(Convert.ToString(totalClass9to10));
                }
            }
            else if (classComboBox.Text=="Class 11" || classComboBox.Text=="Class 12")
            {
                double totalClass11to12 = 15000 + (2700 * 12);
                
                if (discountCheckBox.Checked)
                {
                    totalClass11to12 = totalClass11to12 - (totalClass11to12 * 0.05);
                    MessageBox.Show(Convert.ToString(totalClass11to12));
                }
                else
                {
                    MessageBox.Show(Convert.ToString(totalClass11to12));
                }
            }


        
        }
    }
}
