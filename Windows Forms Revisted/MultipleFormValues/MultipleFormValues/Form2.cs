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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            //Checks action Ok

            this.DialogResult = DialogResult.OK;
            //getting the value stored in public textbox tb to a local variable changeCase
            string changeCase = Form1.tb.Text;

            //Now checking case of radio buttons
            if (radioButton1.Checked == true)
            {
                changeCase = changeCase.ToUpper();
            }
            else if (radioButton2.Checked == true)
            {
                changeCase = changeCase.ToLower();
            }

            // after action is done... the value is transffered to the textbox
            Form1.tb.Text = changeCase;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
