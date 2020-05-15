using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
        
    {
        // Declaring variables for later use
        double firstNum;
        double secondNum;
        double result;
        string operation;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Ensures textbox only accepts numbers
        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }

            else
            { e.Handled = e.KeyChar != (char)Keys.Back; }
        }

        // Validates and accepts user input

        // Numbers:
        // 1
        private void n1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "1";
            }
            else
            {
                txtResult.Text = txtResult.Text + "1";
            }

            label1.Focus();
        }

        // 2
        private void n2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text = txtResult.Text + "2";
            }

            label1.Focus();
        }

        // 3
        private void n3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "3";
            }
            else
            {
                txtResult.Text = txtResult.Text + "3";
            }

            label1.Focus();
        }

        // 4
        private void n4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "4";
            }
            else
            {
                txtResult.Text = txtResult.Text + "4";
            }

            label1.Focus();
        }

        // 5
        private void n5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text = txtResult.Text + "5";
            }

            label1.Focus();
        }

        // 6
        private void n6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text = txtResult.Text + "6";
            }

            label1.Focus();
        }

        // 7
        private void n7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "7";
            }
            else
            {
                txtResult.Text = txtResult.Text + "7";
            }

            label1.Focus();
        }

        // 8
        private void n8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text = txtResult.Text + "8";
            }

            label1.Focus();
        }

        // 9
        private void n9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text = txtResult.Text + "9";
            }

            label1.Focus();
        }

        // 0
        private void n0_Click(object sender, EventArgs e)
        {
            // Only adds zero if the current input is greater than zero  
            if (!(txtResult.Text == "0"))
            {
                txtResult.Text = txtResult.Text + "0";
            }

            label1.Focus();
        }

        // Operations:
        // Add      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "+";
            label1.Focus();
        }

        // Subtract
        private void btnSubt_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "-";
            label1.Focus();
        }

        // Multiply
        private void btnMult_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "x";
            label1.Focus();
        }

        // Divide
        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "÷";
            label1.Focus();
        }

        // Percentage
        private void btnPercent_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "%";
            label1.Focus();
        }

        // Square root
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtResult.Text);
            result = Math.Sqrt(firstNum);
            txtResult.Text = Convert.ToString(result);
            label1.Focus();
        }

        // Square
        private void btnSqr_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtResult.Text);
            result = Math.Pow(firstNum, 2);
            txtResult.Text = Convert.ToString(result);
            label1.Focus();
        }

        // Power
        private void btnPow_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "^";
            label1.Focus();
        }

        // Clears and restarts calculator
        private void btnClr_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            firstNum = 0;
            secondNum = 0;
            result = 0;
            operation = "";
            label1.Focus();
        }

        // Clears only current entry
        private void btnClrEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            label1.Focus();
        }

        // Dot
        private void nPoint_Click(object sender, EventArgs e)
        {
            // Only allows one dot to be inserted per number
            if (!txtResult.Text.Contains('.'))
            {
                txtResult.Text = txtResult.Text + ".";
            }

            label1.Focus();
        }

        // Equal button 
        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(txtResult.Text);

            // Add
            if (operation == "+")
            {
                result = (firstNum + secondNum);
                txtResult.Text = Convert.ToString(result);
                firstNum = result;
            }

            // Subtract 
            if (operation == "-")
            {
                result = (firstNum - secondNum);
                txtResult.Text = Convert.ToString(result);
                firstNum = result;
            }

            // Multiply
            if (operation == "x")
            {
                result = (firstNum * secondNum);
                txtResult.Text = Convert.ToString(result);
                firstNum = result;
            }

            // Divide
            if (operation == "÷")
            {
                // Only divides if the second number is greater than zero
                if (secondNum == 0)
                {
                    txtResult.Text = "Cannot divide by zero";
                }

                else
                {
                    result = (firstNum / secondNum);
                    txtResult.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }

            // Percentage
            if (operation == "%")
            {
                result = ((firstNum / secondNum) * 100);
                txtResult.Text = Convert.ToString(result);
                firstNum = result;
            }

            // Power
            if (operation == "^")
            {
                result = Math.Pow(firstNum, secondNum);
                txtResult.Text = Convert.ToString(result);
                firstNum = result;
            }

            label1.Focus();
        }

        // Delete button - allows to backspace
        private void btnDel_Click(object sender, EventArgs e)
        {
            // Allows to backspace only if textbox has input other than zero
            if ((txtResult.Text.Length > 0) && !(txtResult.Text == "0"))
            {
                // If number is single digit, replaces it with zero
                if (txtResult.Text.Length == 1)
                {
                    txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
                    txtResult.Text = "0";
                }
                
                // If not single digit, removes last single digit in input
                else
                {
                    txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
                }

                label1.Focus();
            }
        }

        // +/- button 
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            // Adds a minus if there isn't one already and the number is greater than zero 
            if (!txtResult.Text.Contains('-') && !(txtResult.Text == "0"))
            {
                txtResult.Text = "-" + txtResult.Text;
            }

            // Removes the minus if there is one already 
            else
            {
                txtResult.Text = txtResult.Text.Trim('-');
            }

            label1.Focus();
        }
    }
}