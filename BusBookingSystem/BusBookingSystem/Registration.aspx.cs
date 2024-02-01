using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Management;
using System.Threading;

namespace BusBookingSystem
{
    public partial class Registration : System.Web.UI.Page
    {
        string strconn = "Data Source=LAPTOP-S16135GT;Initial Catalog = OnlineBusBookingDb; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (idexists())
            {
                Response.Write("<script>alert('ID already exists. Please change ID !!!!');</script>");
            }

            else
            {
                signup();
            }
        }
        bool idexists()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from usersignup where username ='" + TextBox8.Text + "';", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                da.Fill(dtt);

                if (dtt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exx)
            {
                Response.Write("<script>alert('" + exx.Message + "');</script>");
                return false;
            }
        }
        void signup()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("pros_usersignup", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fullname1", TextBox1.Text);
                cmd.Parameters.AddWithValue("@dob1", TextBox2.Text);
                cmd.Parameters.AddWithValue("@mobile1", TextBox3.Text);
                cmd.Parameters.AddWithValue("@email1", TextBox4.Text);
                cmd.Parameters.AddWithValue("@stat1", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@city1", TextBox6.Text);
                cmd.Parameters.AddWithValue("@pincode1", TextBox7.Text);
                cmd.Parameters.AddWithValue("@adress1", TextBox5.Text);
                cmd.Parameters.AddWithValue("@username1", TextBox8.Text);
                cmd.Parameters.AddWithValue("@pswrd1", TextBox9.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Details Submitted. Login now !!!!');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                DropDownList1.SelectedItem.Value = "";

            }
            catch (Exception exx)
            {
                Response.Write("<script>alert('" + exx.Message + "');</script>");
            }
        }
    }
}