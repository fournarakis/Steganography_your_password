using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region numbers
        private void button_0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }
        #endregion

        #region Operations

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                if (textBox.Text == string.Empty)
                {
                    textBox.Text = "0.";
                }
                else
                    textBox.Text = textBox.Text + ".";
            }

        }
        private void button_plus_Click(object sender, EventArgs e)
        {
            if (check_for_operator())
            {
                result();
                textBox.Text = textBox.Text + "+";
            }
            else
                textBox.Text = textBox.Text + "+";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (check_for_operator())
            {
                result();
                textBox.Text = textBox.Text + "-";
            }
            else
                textBox.Text = textBox.Text + "-";
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (check_for_operator())
            {
                result();
                textBox.Text = textBox.Text + "*";
            }
            else
                textBox.Text = textBox.Text + "*";
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            if (check_for_operator())
            {
                result();
                textBox.Text = textBox.Text + "/";
            }
            else
                textBox.Text = textBox.Text + "/";
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            result();
        }

        private void result()
        {
            try
            {
                string[] number = new string[1];
                if(textBox.Text.Contains("+"))
                {
                    number = textBox.Text.Split('+');
                    if (number[1] != "")
                    {
                        textBox.Text = (Double.Parse(number[0]) + Double.Parse(number[1])).ToString();
                    }
                }
                if (textBox.Text.Contains("-"))
                {
                    number = textBox.Text.Split('-');
                    if (number[1] != "")
                    {
                        textBox.Text = (Double.Parse(number[0]) - Double.Parse(number[1])).ToString();
                    }
                }
                if (textBox.Text.Contains("*"))
                {
                    number = textBox.Text.Split('*');
                    if (number[1] != "")
                    {
                        textBox.Text = (Double.Parse(number[0]) * Double.Parse(number[1])).ToString();
                    }
                }
                if (textBox.Text.Contains("/"))
                {
                    number = textBox.Text.Split('/');
                    if ((number[1] != "")&(number[1]!="0")) // Division by zero! Do nothing..
                    {
                        textBox.Text = (Double.Parse(number[0]) / Double.Parse(number[1])).ToString();
                    }
                }

            }
            catch
            {
            }
        } 
        private bool check_for_operator()
        {
            if (textBox.Text.Contains("+"))
            {
                return true;
            }
            if (textBox.Text.Contains("-"))
            {
                return true;
            }
            if (textBox.Text.Contains("*"))
            {
                return true;
            }
            if (textBox.Text.Contains("/"))
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
