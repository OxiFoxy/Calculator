using CalcClassBr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphInterface
{
    public partial class Form1 : Form
    {
      public static  string expression = "";
        int memory = 0;
        string result = "0";
        private bool nonNumberEntered = false;
        int timercount = 0;
        bool IstimeOut = false;
        public Form1()
        {
            InitializeComponent();
            if (expression != "")
                textBoxExpression.Text = expression;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "0";
        }

        private void buttonABS_Click(object sender, EventArgs e)
        {
            int count = 0;
            char sign = ' ';
            if (IstimeOut == false)
            {
                char temp = Convert.ToChar(textBoxExpression.Text.Substring(textBoxExpression.Text.Length - 1));
                bool check = isNumber(temp);
                long a = 0;
                string numberToConvert = "";

                if (check == true)
                {
                    count++;
                    numberToConvert += temp;
                    while (check == true && textBoxExpression.Text.Length > count)
                    {
                        int from = textBoxExpression.Text.Length - count - 1;
                        temp = textBoxExpression.Text.Substring(from).First();
                        check = isNumber(temp);
                        if (check == true)
                        {
                            numberToConvert = temp + numberToConvert;
                            count++;
                        }
                        else sign = temp;
                    }

                    a = long.Parse(numberToConvert);
                }
                // int number = 0;
                if (sign == '*' || sign == '/')
                {
                    // number = CalcClass.IABS(a);
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count) + "m" + a;
                }
                else if (sign == '+')
                {
                    //number = CalcClass.IABS(a);
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count-1) + "-" + a;
                }
                else if (sign == '-')
                {
                    //number = CalcClass.IABS(a);
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count-1) + "+" + a;
                }
                else if (sign == 'p')
                {
                    //number = CalcClass.IABS(a);
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count - 1) + "m" + a;
                }
                else if (sign == 'm')
                {
                    //number = CalcClass.IABS(a);
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count - 1) + "p" + a;
                }
                else if(sign == '(')
                {
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count) + "m" + a;
                }
                else if (sign == ')')
                {
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count) + "-" + a;
                }
                else if (sign == ' ')
                {
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count) + "-" + a;
                }
                timer1.Start();
                timer1.Interval = 1000;
            }
            else
            {
                if(textBoxExpression.Text.Substring(0).FirstOrDefault()=='+')
                textBoxExpression.Text = "-"+"(" + expression+")";
                else if (textBoxExpression.Text.Substring(0).FirstOrDefault() == '-')
                    textBoxExpression.Text = expression;
            }

           

        }
        private bool isNumber(char number)
        {
            if (number == '0' || number == '1' || number == '2' || number == '3' ||
           number == '4' || number == '5' || number == '6' || number == '7' || number == '8' || number == '9')
                return true;
            else return false;
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "/";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "*";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "-";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "+";
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = memory.ToString();
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {

            int checkResult = 0;
            bool isNumber = int.TryParse(result, out checkResult);
            //TryParse переконвертовує введене стрінгове значення в Int32, та заодно перевіряє чи воно інтове, повертає
            //true або false
            if (isNumber == true)
                memory += checkResult;
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            //Analizer.Expression = textBoxExpression.Text;
            // textBoxResult.Text = Analaizer.Estimate();
        }

        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "(";
        }

        private void buttonCloseBracket_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += ")";
        }

        private void buttonBS_Click(object sender, EventArgs e)
        {
            if (expression.Length == 1)
            {
                textBoxExpression.Text = "";
            }
            else if (expression.Length > 1 && textBoxExpression.Text.Length > 1)
            {
                textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - 1);
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = string.Empty;
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "%";
        }

        private void textBoxExpression_TextChanged(object sender, EventArgs e)
        {
            if(IstimeOut==true)
            expression = textBoxExpression.Text;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
         //   textBoxExpression.Focus();           
            nonNumberEntered = false;
            if (e.KeyValue == (char)Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyValue == (char)Keys.Enter)
            {
                buttonEqual_Click(sender, e);
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode != Keys.Multiply &&
                    e.KeyCode == Keys.Oemplus ||
                    e.KeyCode == Keys.OemOpenBrackets ||
                    e.KeyCode == Keys.OemCloseBrackets 
                //    e.KeyCode == Keys.Oem102 ||
                //    e.KeyCode == Keys.Oem5
                    )
                {
                   // MessageBox.Show(e.KeyCode.ToString());
                    nonNumberEntered = true;
               }
            }
            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back&&
                    e.KeyCode != Keys.OemMinus&&
                    e.KeyCode != Keys.Divide&&
                    e.KeyCode != Keys.OemBackslash       
                    )
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }                     
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            result = textBoxResult.Text;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timercount <3)
            {
                IstimeOut = false;
                timercount++;
                this.Text = timercount.ToString();
            }
            else
            {
                timer1.Stop();
                timercount = 0;
                IstimeOut = true;               
            }
        }
    }
}
