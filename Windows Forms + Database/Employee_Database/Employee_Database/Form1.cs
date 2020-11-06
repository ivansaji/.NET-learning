using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Database Header
using System.Data.SqlClient;

namespace Employee_Database
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// Initializations
    
        string new_entry = null;
        string query_string = null;
        //Supporting methods
        private void db_operation(string data, int fun)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =.; database=Employee; integrated security=SSPI");
                //Opening Connection
                con.Open();
                MessageBox.Show("Connection Established");

                if(fun == 1)
                {
                    query_string = "insert into Employee_List (name) values (" + data + ")";
                    SqlCommand cm = new SqlCommand(query_string, con);
                    cm.ExecuteNonQuery();
                    MessageBox("Added Successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Not Connected to DB  " + e);
            }
        }

        public Form1()
        {
            InitializeComponent();
            listBox.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new_entry = txtBox.Text;
            db_operation(new_entry,1);
        }
    }
}
