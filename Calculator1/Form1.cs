using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        double currentVal = 0;
        bool currentOperation = false;
        String typeOfButton = "";
        public Form1()
        {
            InitializeComponent();
            btnRCM.Enabled = false;
            btnCTR.Enabled = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
          
            currentVal = Double.Parse(inputTextBox.Text);
            typeOfButton = "Minus";
            currentOperation = true;
            currentOperation = true;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            currentVal = 0; 
            inputTextBox.Text = "0";

        }
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            
            inputTextBox.Text = "0";
        }

        double memoryOp = 0; 
        private void btnMplus_Click(object sender, EventArgs e)
        {
            btnRCM.Enabled = true;
            btnCTR.Enabled = true;
            memoryOp += Double.Parse(inputTextBox.Text);
            inputTextBox.Clear(); 
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {
            btnRCM.Enabled = true;
            btnCTR.Enabled = true;
            memoryOp -= Double.Parse(inputTextBox.Text);
            inputTextBox.Clear();
        }
       
        private void btnRCM_Click(object sender, EventArgs e)
        {
            
            inputTextBox.Text = memoryOp.ToString();
            
        }
       
        private void btnCTR_Click(object sender, EventArgs e)
        {
            memoryOp = 0;
            btnRCM.Enabled = false;
            btnCTR.Enabled = false;
            inputTextBox.Clear(); 
        }

        double vall;
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            vall = Double.Parse(inputTextBox.Text);
            inputTextBox.Text = Math.Sqrt(vall).ToString();
            currentOperation = true;
        }

        

      

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (currentVal != 0)
            {
                btnEqual.PerformClick();
            }
            else
            {
                currentVal = Double.Parse(inputTextBox.Text);
                
            }
            typeOfButton = "Plus";
            currentOperation = true;
        }
        
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (currentVal != 0)
            {
                btnEqual.PerformClick();
            }
            else
            {
                currentVal = Double.Parse(inputTextBox.Text);

            }
            typeOfButton = "Multiply";
            currentOperation = true;
           
        }
      
        private void btnDivision_Click(object sender, EventArgs e) //ima za opravqne
        {

            if (currentVal != 0)
            {
                btnEqual.PerformClick();
            }
            else
            {
                currentVal = Double.Parse(inputTextBox.Text);

            }
            typeOfButton = "Division";
            currentOperation = true;
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            

            if (typeOfButton == "Plus")
            {
                inputTextBox.Text = (currentVal + Double.Parse(inputTextBox.Text)).ToString();
            } 
            else if (typeOfButton == "Multiply")
            {
                inputTextBox.Text = (currentVal * Double.Parse(inputTextBox.Text)).ToString();
            }
            else if (typeOfButton == "Division")
            {
                inputTextBox.Text = (currentVal / Double.Parse(inputTextBox.Text)).ToString();
            }
            else if (typeOfButton == "Minus")
            {
                inputTextBox.Text = (currentVal - Double.Parse(inputTextBox.Text)).ToString();
            }
            currentVal = Double.Parse(inputTextBox.Text);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "0" || currentOperation)
            {
                inputTextBox.Clear();
                currentOperation = false; 
            }
            inputTextBox.Text = inputTextBox.Text + '9';
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "0" || currentOperation)
            {
                inputTextBox.Clear();
                currentOperation = false;
            }
            inputTextBox.Text = inputTextBox.Text + '8';
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "0" || currentOperation)
            {
                inputTextBox.Clear();
                currentOperation = false;
            }
            inputTextBox.Text = inputTextBox.Text + '7';
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            
            if (!inputTextBox.Text.Contains(","))
            {
                inputTextBox.Text = inputTextBox.Text + ',';
            }
            
        }
       
        private void btnThree_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "0" || currentOperation)
            {
                inputTextBox.Clear();
                currentOperation = false;
            }
            inputTextBox.Text = inputTextBox.Text + '3';
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "0" || currentOperation)
            {
                inputTextBox.Clear();
                currentOperation = false;
            }
            inputTextBox.Text = inputTextBox.Text + '6';
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "0" || currentOperation)
            {
                inputTextBox.Clear();
                currentOperation = false;
            }
            inputTextBox.Text = inputTextBox.Text + '5';
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "0" || currentOperation)
            {
                inputTextBox.Clear();
                currentOperation = false;
            }
            inputTextBox.Text = inputTextBox.Text + '4';
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "0" || currentOperation)
            {
                inputTextBox.Clear();
                currentOperation = false;
            }
            inputTextBox.Text = inputTextBox.Text + '1'; 
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "0" || currentOperation)
            {
                inputTextBox.Clear();
                currentOperation = false;
            }
            inputTextBox.Text = inputTextBox.Text + '2';
        }

        private void btnNull_Click(object sender, EventArgs e)
        {

            if (inputTextBox.Text == "0" || currentOperation)
            {
                inputTextBox.Clear();
                currentOperation = false;
            }
            
            inputTextBox.Text = inputTextBox.Text + "0";
        }
        
        private void negative_Click(object sender, EventArgs e)
        {
            double nValue = Double.Parse(inputTextBox.Text); 
            if(nValue > 0)
            {
                inputTextBox.Text = "-" + inputTextBox.Text; 
            } else if (nValue < 0)
            {
                nValue = Math.Abs(nValue);
                inputTextBox.Text = nValue.ToString(); 
            }
        }
    }
}
