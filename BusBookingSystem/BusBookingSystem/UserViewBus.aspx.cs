using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Drawing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace BusBookingSystem
{
    public partial class UserViewBus : System.Web.UI.Page
    {
        string strconn = "Data Source=LAPTOP-S16135GT;Initial Catalog = OnlineBusBookingDb;Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Book Now
            if (checkbusid())
            {
                string BusID = TextBox1.Text;
                string FullName = Textboxtb2.Text;
                string UserName = Textbox25.Text;
                string Age = Textboxt32.Text;
                string ContactNumber = TextBox10.Text;
                string EmailId = TextBox2.Text;
                string NumberOfTickets = TextBox3.Text;
                string TotalAmount = TextBox4.Text;
                string PaymentMode = TextBox5.Text;
                string Fare = TextBox50.Text;

                if (BusID == "" || FullName == "" || UserName == "" || Age == "" || ContactNumber == "" || EmailId == "" || NumberOfTickets == ""
                    || TotalAmount == "" || Fare == "" || PaymentMode == "")
                {
                    Response.Write("<script>alert('Please enter all the fields to book Tickets !!!!');</script>");

                }

                else
                {
                    if (checkuserid())
                    {
                       if(TextBox3.Text == "0")
                        {
                            Response.Write("<script>alert('Number of tickets should not be zero !!!!');</script>");

                        }

                        else
                        {
                            BookTicket();
                        }
                       
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid UserID. Please Check !!!!');</script>");
                        Textbox25.Text = "";
                    }

                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Bus ID Please Check !!!!');</script>");
                TextBox1.Text = "";
                Textboxtb2.Text = "";
                Textbox25.Text = "";
                Textboxt32.Text = "";
                TextBox10.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox50.Text = "";

            }

        }

        bool checkbusid() //checking busid
        {
            try
            {
                SqlConnection con = new SqlConnection(strconn);

                SqlCommand cmd = new SqlCommand("SELECT * from BusInventory WHERE BusId='" + TextBox1.Text + "';", con);
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

        bool checkuserid() //checking userid
        {
            try
            {
                SqlConnection con = new SqlConnection(strconn);

                SqlCommand cmd = new SqlCommand("SELECT * from usersignup WHERE username='" + Textbox25.Text + "';", con);
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




        void BookTicket() //Ticket Booking
        {

            try
            {
                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Spec_BusBookingDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BusID", TextBox1.Text);
                cmd.Parameters.AddWithValue("@username", Textbox25.Text);
                cmd.Parameters.AddWithValue("@FullName", Textboxtb2.Text);

                //generating random ticket number
                Random rand = new Random();
                int varrandticket = rand.Next(11111, 99999);
                

                cmd.Parameters.AddWithValue("@TicketID", varrandticket.ToString());
                cmd.Parameters.AddWithValue("@Age", Textboxt32.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", TextBox10.Text);
                cmd.Parameters.AddWithValue("@EmailID", TextBox2.Text);
                cmd.Parameters.AddWithValue("@NumberOfTickets", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Fare", TextBox50.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", TextBox4.Text);
                cmd.Parameters.AddWithValue("@PaymentMode", TextBox5.Text);
                cmd.Parameters.AddWithValue("@PaymentStatus", "Paid");
                cmd.Parameters.AddWithValue("@TicketStatus", "Confirmed");

                cmd.ExecuteNonQuery();
                conn.Close();

                Response.Write("<script>alert('Bus Ticket Booked Successfully !!!!');</script>");
                TextBox1.Text = "";
                Textboxtb2.Text = "";
                Textbox25.Text = "";
                Textboxt32.Text = "";
                TextBox10.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox50.Text = "";

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)  //Bus ID TextBox
        {
            try
            {
                SqlConnection con = new SqlConnection(strconn);


                SqlCommand cmd = new SqlCommand("SELECT * from BusInventory where BusId='" + TextBox1.Text + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {

                    TextBox50.Text = dt.Rows[0][8].ToString();

                    if (TextBox3.Text != "")
                    {

                        int Numoftickets, fareamount, totalprice;
                        Int32.TryParse(TextBox3.Text, out Numoftickets);
                        Int32.TryParse(TextBox50.Text, out fareamount);
                        totalprice = Numoftickets * fareamount;
                        TextBox4.Text = totalprice.ToString();
                    }

                }
                else
                {

                    TextBox1.Text = "";
                    TextBox3.Text = "";
                    TextBox50.Text = "";
                    TextBox4.Text = "";
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e) //no of tickets Textbox
        {
            if (TextBox50.Text != "")
            {

                int tickets, fare, totalamount;
                Int32.TryParse(TextBox3.Text, out tickets);
                Int32.TryParse(TextBox50.Text, out fare);
                totalamount = tickets * fare;
                TextBox4.Text = totalamount.ToString();
            }

        }

        
    }

}





