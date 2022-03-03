using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using  System.Data;
using System.Data.SqlClient;

namespace PGDAC2021b.DatabaseWork
{
    public partial class AdaptorDemp : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //logic to fetch all users and display in Gridview
        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("server=DESKTOP-3VR953M;database=pgdacsepdb;uid=sa;pwd=123");
            SqlConnection con = new SqlConnection("server=DESKTOP-3VR953M;database=collegedb;uid=sa;pwd=123");

            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            //string qry = "select user_id,username,fullname, mobile from user_master";
            string qry = "select CourseId,CourseName,Location,FacultyID from Course";

            //initialize adapter with query and connection
            SqlDataAdapter adapter = new SqlDataAdapter(qry,con);
            //call adapter fill() method to get data from database and fill it into database
            //adapter.Fill(ds);
            adapter.Fill(dt);

            //Label1.Text = "Total Record found: " + ds.Tables[0].Rows.Count;
            Label1.Text = "Total Record found: " + dt.Rows.Count;
            //Response.Write("<br/>username: " + ds.Tables[0].Rows[0][1]);

            //Binding data with Gridview
            //GridView1.DataSource = ds;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}