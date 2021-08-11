/*
Name- Saimen Preet Singh
Project Name- Lab 3
Description- the system takes cases of diseases for 3 different regions and calculates the average
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }
        private static int counter = 0;
        double sum1 = 0;
        double sum2 = 0;
        double sum3 = 0;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                counter++;
                if (counter > 7)
                {
                    txtInput.Clear();
                    lblResult1.Text = "Average: " + (sum1 / 7).ToString("F2");
                }

                else if (counter > 14)
                {
                    txtInput.Clear();
                    lblResult2.Text = "Average: " + (sum2 / 7).ToString("F2");

                }
                
                else if (counter > 21)
                {
                    btnEnter.Enabled = false;
                    txtInput.ReadOnly = true;
                    txtInput.Clear();
                    lblResult3.Text = "Average: " + (sum3 / 7).ToString("F2");
                }

                else
                {
                    if (counter < 8)
                    {
                        int value = int.Parse(txtInput.Text);
                        sum1 += value;
                        txtRegion1.AppendText(value + "\r\n");
                        txtInput.Clear();
                    }

                    else
                    {
                        int value2 = int.Parse(txtInput.Text);
                        sum2 += value2;
                        txtRegion2.AppendText(value2 + "\r\n");
                        txtInput.Clear();
                    }
                    
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnEnter.Enabled = true;
            txtInput.ReadOnly = false;
            txtRegion1.Clear();
            txtRegion2.Clear();
            txtRegion3.Clear();
            lblResult1.ResetText();
            lblResult2.ResetText();
            lblResult3.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCases_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
