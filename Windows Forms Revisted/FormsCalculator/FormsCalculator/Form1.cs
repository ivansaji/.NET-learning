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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Calculator Part Begins
        string txt=null;
        //TextBox
        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxstate()
        {
            textBox.Text = txt;
            textBox.Focus();
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
            txt = txt + 'x';
            textboxstate();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txt = txt + '/';
            textboxstate();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

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
