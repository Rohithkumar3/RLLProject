using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace BusBookingSystem
{
    public partial class BookingHistory : System.Web.UI.Page
    {
        string strconn = "Data Source=LAPTOP-S16135GT;Initial Catalog = OnlineBusBookingDb;Integrated Security = True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e) //Booking History Button
        {
            if (UserBox.Text == "")
            {
                Response.Write("<script>alert('Please enter Username !!!!');</script>");
            }
            else
            {
                if (checkid())
                {
                    Bind();
                }
                else
                {
                    Response.Write("<script>alert('No Booking Details Found !!!!');</script>");

                }
            }
        }
        protected void Bind()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * from BusBookingDetails WHERE UserName='" + UserBox.Text + "';", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Button2_Click(object sender, EventArgs e) //Ticket Cancellation
        {

            if (UserBox.Text == "" || TicketIDBox.Text == "")
            {
                Response.Write("<script>alert('Please enter both fields !!!!');</script>");
            }
            else
            {
                if (checkuseridticketid())
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(strconn);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("update BusBookingDetails SET PaymentStatus = @PaymentStatus, TicketStatus = @TicketStatus WHERE UserName='" + UserBox.Text + "' and TicketID='" + TicketIDBox.Text + "';", con);
                        cmd.Parameters.AddWithValue("@PaymentStatus", "Refund");
                        cmd.Parameters.AddWithValue("@TicketStatus", "Cancelled");


                        cmd.ExecuteNonQuery();
                        con.Close();
                        Bind();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('" + ex.Message + "');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Wrong Username or Ticket Id provided. Please Check !!!!');</script>");
                }
            }
        }
        bool checkuseridticketid() //checking busid
        {
            try
            {
                SqlConnection con = new SqlConnection(strconn);

                SqlCommand cmd = new SqlCommand("SELECT username,TicketID from BusBookingDetails WHERE UserName='" + UserBox.Text + "' and TicketID='" + TicketIDBox.Text + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        bool checkid() //checking busid
        {
            try
            {
                SqlConnection con = new SqlConnection(strconn);

                SqlCommand cmd = new SqlCommand("SELECT * from BusBookingDetails WHERE username='" + UserBox.Text + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

       
    }
}
