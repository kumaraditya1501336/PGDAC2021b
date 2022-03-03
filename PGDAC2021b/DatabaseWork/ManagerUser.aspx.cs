using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PGDAC2021b.DatabaseWork
{
    public partial class ManagerUser : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-3VR953M;database=pgdacsepdb;uid=sa;pwd=123");
        DataSet ds;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader dtr;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillGrid();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //working with parametrize queries
            //string searchQry = "select username, fullname, mobile where user_id=" + txtUserID.Text;
            string searchQry = "select username, fullname, mobile from user_master where user_id=@";
            cmd = new SqlCommand(searchQry, con);
            //binding parameter values
            cmd.Parameters.AddWithValue("@id", txtUserID.Text);

            con.Open();

            //fetching data using DataReader
            dtr = cmd.ExecuteReader();

            //dtr.HasRows
            if (dtr.Read())
            {
                //txtUserName.Text = dtr[0].ToString();
                //txtName.Text = dtr[1].ToString();
                //txtMobile.Text = dtr[2].ToString();
                txtUserName.Text = dtr.GetString(0);
                //dtr.Close();
                txtName.Text = dtr.GetString(1);
                txtMobile.Text = dtr.GetDecimal(2).ToString();
                Label1.Text = "";

            }
            else
            {
                Label1.Text = "No Record found";
                Label1.Forecolor = System.Drawing.Color.Red;
            }
            con.Close();

        }

        protected async void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQry = "update user_master set " +
                "username=@uname,fullname=@name,mobile=@mobile where user_id=@id";
            cmd = new SqlCommand(updateQry, con);
            //cmd.Parameters.AddWithValue("@id", txtUserID.Text);
            //cmd.Parameters.AddWithValue("@uname", txtUserName.Text);
            //cmd.Parameters.AddWithValue("@name", txtName.Text);
            //cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);



            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", txtUserID.Text),
                new SqlParameter("@uname", txtUserName.Text),
                new SqlParameter("@name", txtName.Text),
                new SqlParameter("@mobile", txtMobile.Text)
            };

            cmd.Parameters.AddRange(parameters);
            await con.OpenAsync(); //asynchronous open call

            Task<int> res = await cmd.ExecuteNonQueryAsync();//asynchronous ExecuteNonQuery call
            if (res > 0)
            {
                Label1.Text = "User details Updated Successfully";
            }
            con.Close();
        }

        void FillGrid()
        {
            string qry = "select user_id,username,fullname,mobile from user_master";

            adapter = new SqlDataAdapter(qry, con);
            ds = new DataSet();
            adapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}