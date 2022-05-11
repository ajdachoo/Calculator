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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double result = 0;
        char option;
        Button lastClick;

        private void ClearScreen()
        {
            if (lastClick == buttonAdd || lastClick == buttonDot || lastClick == buttonSub || lastClick == buttonMultiply || lastClick == buttonDivide || lastClick == buttonResult) 
            {
                textBoxResult.ResetText();
            }
        }

        private void Insert(Button button)
        {
            lastClick = button;
            
            if (textBoxResult.Text == "0")
                textBoxResult.ResetText();

            if (textBoxResult.TextLength < 10)
                textBoxResult.Text += button.Text;
        }
        
        private void button0_Click(object sender, EventArgs e)
        {
            ClearScreen();
            if (textBoxResult.TextLength < 10 && textBoxResult.Text != "0")
                textBoxResult.Text += button0.Text;
            lastClick = button0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearScreen();
            Insert(button1);
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = null;
            result = 0;
            lastClick = buttonCE;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearScreen();
            Insert(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearScreen();
            Insert(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearScreen();
            Insert(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearScreen();
            Insert(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearScreen();
            Insert(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearScreen();
            Insert(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClearScreen();
            Insert(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClearScreen();
            Insert(button9);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "" || lastClick == buttonResult)
            {
                textBoxResult.Text = "0,";
            }
            else
            {
                textBoxResult.Text += ",";
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            lastClick = buttonResult;
            switch (option)
            {
                case '+':
                    result += Convert.ToDouble(textBoxResult.Text);
                    break;
                case '-':
                    result -= Convert.ToDouble(textBoxResult.Text);
                    break;
                case '*':
                    result *= Convert.ToDouble(textBoxResult.Text);
                    break;
                case '/':
                    if (Convert.ToDouble(textBoxResult.Text) == 0)
                    {
                        textBoxResult.Text = "ERROR!";
                        return;
                    }
                    else
                    {
                        result /= Convert.ToDouble(textBoxResult.Text);
                    }
                    break;
            }
            textBoxResult.Text = Convert.ToString(result);
            result = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            lastClick = buttonAdd;
            result = Convert.ToDouble(textBoxResult.Text);
            option = '+';
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            lastClick = buttonMultiply;
            result = Convert.ToDouble(textBoxResult.Text);
            option = '*';
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            lastClick = buttonSub;
            result = Convert.ToDouble(textBoxResult.Text);
            option = '-';
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            lastClick = buttonDivide;
            result = Convert.ToDouble(textBoxResult.Text);
            option = '/';
        }
    }
}
