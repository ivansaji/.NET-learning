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
        //create an object of form 2 on form 1
        Form2 secondForm = new Form2();
        //creating a public object tb of Textbox so that it can be used in different forms
        public static TextBox tb = new TextBox();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //no need
        }

        private void changeCase_Click(object sender, EventArgs e)
        {
            //used to give importance to form 2 when it is activated and to prevent form 1 from getting focus
            //form 1 will be obtained after form 2 is complete
            secondForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Transfering the private Textbox(Form 1 only) named 'txtChangeCase' to public variable tb so that it can be accessed at differnet forms
            //the textbox is made public
            tb = txtChangeCase;
            //now tb gets the textbox and it can be controlled outside
            //rest action goes in FOrm 2
        }
    }
}
