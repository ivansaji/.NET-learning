using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Database
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        string new_entry = null;

        public Form1()
        {
            InitializeComponent();
            listBox.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new_entry = txtBox.Text;
            listBox.Items.Add(new_entry);
        }
    }
}
