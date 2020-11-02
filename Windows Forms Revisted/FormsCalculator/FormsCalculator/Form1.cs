using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCalculator
{
    public partial class Karthika_kanakk_kooti_yenthram : Form
    {
        public Karthika_kanakk_kooti_yenthram()
        {
            InitializeComponent();
            textBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Calculator Part Begins
        string txt=null;
        string exp = null;
        string[] numbers_string;
        float firstnum,secondnum,result;
        //TextBox
        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxstate()
        {
            textBox.Focus();
            textBox.Text = txt;
        }
        private void splitexp(string y,char x)
        {
            numbers_string = y.Split(x);
            firstnum = float.Parse(numbers_string[0]);
            secondnum = float.Parse(numbers_string[1]);
            
        }
        //Operation Buttons

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txt = txt + '+';
            textboxstate();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txt = txt + '-';
            textboxstate();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txt = txt + '*';
            textboxstate();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txt = txt + '/';
            textboxstate();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            exp = textBox.Text;
            if (exp.Contains('+'))
            {
                splitexp(exp, '+');
                result = firstnum + secondnum;
            }
            if (exp.Contains('-'))
            {
                splitexp(exp, '-');
                result = firstnum - secondnum;
            }
            if (exp.Contains('*'))
            {
                splitexp(exp, '*');
                result = firstnum * secondnum;
            }
            if (exp.Contains('/'))
            {
                splitexp(exp, '/');
                result = firstnum / secondnum;
            }

            textBox.Clear();
            textBox.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            txt = null;
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            txt = txt + '.';
            textboxstate();
        }
        // Numerical Buttons
        private void btnZero_Click(object sender, EventArgs e)
        {
            txt = txt + '0';
            textboxstate();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txt = txt + '1';
            textboxstate();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txt = txt + '2';
            textboxstate();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txt = txt + '3';
            textboxstate();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txt = txt + '4';
            textboxstate();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txt = txt + '5';
            textboxstate();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txt = txt + '6';
            textboxstate();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txt = txt + '7';
            textboxstate();
        }

 
        private void btnEight_Click(object sender, EventArgs e)
        {
            txt = txt + '8';
            textboxstate();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txt = txt + '9';
            textboxstate();
        }
    }
}
