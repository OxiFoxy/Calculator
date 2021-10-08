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
        string expression = "";
        string memory = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expression += "1";
            textBoxExpression.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            expression += "2";
            textBoxExpression.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            expression += "3";
            textBoxExpression.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            expression += "4";
            textBoxExpression.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expression += "5";
            textBoxExpression.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            expression += "6";
            textBoxExpression.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            expression += "7";
            textBoxExpression.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            expression += "8";
            textBoxExpression.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            expression += "9";
            textBoxExpression.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            expression += "0";
            textBoxExpression.Text += "0";
        }

        private void buttonABS_Click(object sender, EventArgs e)
        {

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            expression += "/";
            textBoxExpression.Text += "/";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            expression += "*";
            textBoxExpression.Text += "*";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            expression += "-";
            textBoxExpression.Text += "-";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            expression += "+";
            textBoxExpression.Text += "+";
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {

        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            memory = textBoxExpression.Text;
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory = "0";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            // textBoxResult.Text = Analaizer.Estimate();
        }

        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            expression += "(";
            textBoxExpression.Text += "(";
        }

        private void buttonCloseBracket_Click(object sender, EventArgs e)
        {
            expression += ")";
            textBoxExpression.Text += ")";
        }

        private void buttonBS_Click(object sender, EventArgs e)
        {
            expression = expression.Substring(0, expression.Length - 1);
            textBoxExpression.Text = textBoxExpression.Text.Substring(0, expression.Length - 1);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            expression = string.Empty;
            textBoxExpression.Text = string.Empty;
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            expression += "%";
            textBoxExpression.Text += "%";
        }

       
    }
}
