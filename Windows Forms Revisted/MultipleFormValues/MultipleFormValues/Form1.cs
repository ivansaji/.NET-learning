using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleFormValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 secondForm = new Form2();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void changeCase_Click(object sender, EventArgs e)
        {
            secondForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
