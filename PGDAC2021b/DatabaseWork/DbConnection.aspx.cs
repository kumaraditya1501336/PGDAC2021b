using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data; //for ConnectionState enum
using System.Data.SqlClient;

namespace PGDAC2021b.DatabaseWork
{
    public partial class DbConnection : System.Web.UI.Page
    {
        static SqlConnection con;
        String connectionString = "server=DESKTOP-3VR953M;database=pgdacsepdb;uid=sa;pwd=123";
        //String connectionString = "server=DESKTOP-3VR953M;database=pgdacsepdb;integrated security=true";

        //ASP.NET Page Life Cycle
        /*
        Page_PreInit
        Page_Init
        Page_Load
        Page_Render
        Page_Unload
         */

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("preint called<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("init called<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            Response.Write("load called<br/>");
            if (!Page.IsPostBack)
            {
                con = new SqlConnection(connectionString);
            }
        }
        
        //Connect with database
        protected void Button1_Click(object sender, EventArgs e)
        {
            //con = new SqlConnection(connectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                Response.Write("<b>Connected with Database server successfull</b>!!!");
            }
            else
            {
                Response.Write("<b>Already connected with database</b>!!!");
            }    
                                           
        }

        //disconnect from database
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                Response.Write("<b>DisConnected with Database server successful!!!</b>");
            }
            else
            {
                Response.Write("<b>Already disconnected with database!!!</b>");
            }          
                           
        }        

        //check connection state
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                Response.Write("<b>Connection is open!!!</b>");
            }
            else
                Response.Write("<b>Connection is closed!!!</b>");
        }
    }
}