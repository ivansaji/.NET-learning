using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import for using SQL CLient
using System.Data.SqlClient;

namespace AdoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling Constructor so that automatic table creation occurs
            new Program().CreateTable();
        }

        //method for creating Table
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                //creating Connection
                con = new SqlConnection("data source=.; database=Student; integrated security = SSPI");
                //writing sql query
                SqlCommand cm = new SqlCommand("create table student(id not null,name varchar(100), email varchar(50), join_date date)", con);
                //Opening Connection
                con.Open();
                //Executing the Query
                cm.ExecuteNonQuery();
                //Displaying a message
                Console.WriteLine("Table Created Successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine("Table Creation failed    " + e);
            }
            //closing Connection
            finally
            {
                con.Close();
            }
        }
    }
}
