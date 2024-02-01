using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BusBookingSystem
{
    public partial class UserForgotPswrd : System.Web.UI.Page
    {
        string strconn = "Data Source=LAPTOP-S16135GT;Initial Catalog = OnlineBusBookingDb; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update usersignup set pswrd='" + TextBox3.Text + "'where username='" + TextBox1.Text + "'and fullname='" + TextBox2.Text + "'", conn);
                int ii = cmd2.ExecuteNonQuery();
                if (ii > 0)
                {
                    string pswrd = TextBox3.Text;
                    string rpswrd = TextBox4.Text;
                    if (pswrd == rpswrd)
                    {
                        conn.Close();
                        Response.Write("<script>alert('Password updated successfully !!!!');</script>");
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                    }
                    else
                    {
                        Response.Write("<script>alert('Password and retype Password does not match!!!!');</script>");
                    }

                }
                else
                {
                    Response.Write("<script>alert('Full name and User id does not Match !!!!');</script>");
                }


            }
            catch (Exception exx)
            {
                Response.Write("<script>alert('" + exx.Message + "');</script>");
                
            }
        }
    }
}
    
