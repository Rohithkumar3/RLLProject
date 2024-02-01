using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusBookingSystem
{
    public partial class AdminMemberManagment : System.Web.UI.Page
    {
        string strconn = "Data Source=LAPTOP-S16135GT;Initial Catalog = OnlineBusBookingDb;Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
            Bind1();
        }
        protected void Button4_Click(object sender, EventArgs e) //go button
        {
            go();
        }
        protected void Bind()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select username,fullname from usersignup ", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        void go() ///gobutton
        {
            try
            {
                SqlConnection con = new SqlConnection(strconn);


                SqlCommand cmd = new SqlCommand("SELECT * from usersignup where username='" + TextBox1.Text + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox1.Text = dt.Rows[0]["username"].ToString();
                    TextBox2.Text = dt.Rows[0]["fullname"].ToString();
                    TextBox8.Text = dt.Rows[0]["dob"].ToString();
                    TextBox3.Text = dt.Rows[0]["mobile"].ToString();
                    TextBox4.Text = dt.Rows[0]["email"].ToString();
                    TextBox9.Text = dt.Rows[0]["stat"].ToString();
                    TextBox10.Text = dt.Rows[0]["city"].ToString();
                    TextBox11.Text = dt.Rows[0]["pincode"].ToString();
                    TextBox6.Text = dt.Rows[0]["adress"].ToString();


                }
                else
                {
                    Response.Write("<script>alert('Invalid User ID. Please check!!');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        protected void Bind1()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from BusBookingDetails where username= '" + TextBox1.Text + "';", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
    }
}