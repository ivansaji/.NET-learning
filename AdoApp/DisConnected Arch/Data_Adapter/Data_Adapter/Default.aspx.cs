using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//User Imports
using System.Data.SqlClient;
using System.Data;

namespace Data_Adapter
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source=.; database=Employee; integrated security=SSPI"))
            {
                SqlDataAdapter sde = new SqlDataAdapter("Select * from Employee_List", con);
                DataSet ds = new DataSet();
                sde.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
    }
}