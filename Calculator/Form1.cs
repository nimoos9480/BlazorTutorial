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
        enum Operators {
            None, 
            Add, 
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag =false;
        double firstOperand =0;
        double secondOperand =0;   


        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            secondOperand = double.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }

            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide) 
            {
                if (secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }


        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;  
        }

        private void ButtonMultiple_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Multiply;   
            operatorChangeFlag = true;
        }


        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Divide;     
            operatorChangeFlag = true;
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            string strNum = display.Text += ".";
            double intNum = double.Parse(strNum);
            display.Text = strNum.ToString();
        }


        private void ButtonAC_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = display.Text += "0";
            double intNum = double.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNum = display.Text += "1";
            double intNum = double.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNum = display.Text += "2";
            double intNum = double.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNum = display.Text += "3";
            double intNum = double.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNum = display.Text += "4";
            double intNum = double .Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNum = display.Text += "5";
            double intNum = double.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNum = display.Text += "6";
            double intNum = double.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNum = display.Text += "7";
            double intNum = double.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNum = display.Text += "8";
            double intNum = double.Parse(strNum);
            display.Text = intNum.ToString();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNum = display.Text += "9";
            double intNum = double.Parse(strNum);
            display.Text = intNum.ToString();
        }
    }
}
