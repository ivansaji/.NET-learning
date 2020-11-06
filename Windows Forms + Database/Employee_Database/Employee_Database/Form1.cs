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
        SqlConnection con = null;
        //Supporting methods
        private void db_conn()
        {
            
            try
            {
                con = new SqlConnection("data source =.; database=Employee; integrated security=SSPI");
                //Opening Connection
                con.Open();
                //MessageBox.Show("Connection Established");
            }
            catch (Exception e)
            {
                MessageBox.Show("Not Connected to DB  " + e);
            }

        }

        private void add_Employee(string data)
        {
            //Add Data to DB
            db_conn();
            query_string = "insert into Employee_List (name) values ('" + data + "');";
            SqlCommand cm = new SqlCommand(query_string, con);
            cm.ExecuteNonQuery();
            MessageBox.Show("Added Successfully");
            con.Close();
        }
        private void get_detail()
        {
            //Retrieve data
            db_conn();
            query_string = "select * from Employee_list";
            SqlCommand cm = new SqlCommand(query_string, con);
            SqlDataReader sdr = cm.ExecuteReader();
            //Iterating through data
            while (sdr.Read())
            {
                listBox.Items.Add(sdr["name"]);
            }
            con.Close();
        }

        public Form1()
        {
            InitializeComponent();
            listBox.Items.Clear();
            get_detail();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new_entry = txtBox.Text;
            add_Employee(new_entry);
            txtBox.Clear();
            listBox.Items.Clear();
            get_detail();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Application Closed Successfully");
            Application.Exit();
        }
    }
}
