using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 secondForm = new Form2();


        private void button1_Click(object sender, EventArgs e)
        {
            //Simply displays next form
            //secondForm.Show();

            //Modal Form
            // A Modal form is one where you have to deal with it before you can continue. Run your programme to test it out. Click the button and a new form appears. Move it out of the way and try to click the button again. You won't be able to.
            secondForm.ShowDialog();




        }
    }
}
