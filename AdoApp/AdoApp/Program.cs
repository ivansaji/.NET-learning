﻿using System;
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
                //Opening Connection
                con.Open();

                // writing sql query  
                SqlCommand cm = new SqlCommand("Select * from student", con);
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]); // Displaying Record  
                }

                //Displaying a message
                Console.WriteLine("Printed Successfully"); 
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Printing failed    " + e);
                Console.ReadKey();
            }
            //closing Connection
            finally
            {
                con.Close();
            }
        }
    }
}
