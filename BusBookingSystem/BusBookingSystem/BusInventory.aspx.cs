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
    public partial class BusInventory : System.Web.UI.Page
    {

        string strconn = "Data Source=LAPTOP-S16135GT;Initial Catalog = OnlineBusBookingDb;Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //add button
            if (checkid())
            {
                Response.Write("<script>alert('Bus Id already exists. Please change ID !!!!');</script>");

            }
            else
            {
                string BusId = TextBox1.Text;
                string BusName = TextBox2.Text;
                string BusCategory = Textboxtb2.Text;
                string Availability_Seats = Textboxtb23.Text;
                string Boarding = Textboxb1.Text;
                string Departure= Textboxtb23.Text;
                string StartTime= TextBox3.Text;
                string EndTime = TextBox9.Text;
                string Price = TextBox10.Text;
                
                if (BusId == "" || BusName == "" || BusCategory == "" || Availability_Seats == "" || Boarding == "" || Departure == ""
                    || StartTime == "" || EndTime == "" || Price == "" )
                {
                    Response.Write("<script>alert('Please enter all the fields to add the Bus Details !!!!');</script>");

                }
                else
                {
                    add();
                }
            }
        }
        protected void Bind()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select BusId,BusName,Availability_Seats,StartTime,EndTime,Price from BusInventory", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            // go button
            if (checkid())
            {
                go();
            }
            else
            {
                Response.Write("<script>alert('Id nout found. Please change ID !!!!');</script>");
            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {    //update button

            if (checkid())
            {
                string BusId = TextBox1.Text;
                string BusName = TextBox2.Text;
                string BusCategory = Textboxtb2.Text;
                string Availability_Seats = Textboxtb23.Text;
                string Boarding = Textboxb1.Text;
                string Departure = TextBox3.Text;
                string StartTime = TextBox3.Text;
                string EndTime = TextBox9.Text;
                string Price = TextBox10.Text;


                if (BusId == "" || BusName == "" || BusCategory == "" || Availability_Seats == "" || Boarding == "" || Departure == ""
                   || StartTime == "" || EndTime == "" || Price == "")
                {
                    Response.Write("<script>alert('Please enter all the fields to update the bus Details !!!!');</script>");

                }

                else
                {
                    update();
                }
                

            }
            else
            {
                Response.Write("<script>alert('Id not found. Please change ID !!!!');</script>");
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            //del button
            if (checkid())
            {     
                    del();          
            }
            else
            {
                Response.Write("<script>alert('BusID Not found. Please change ID !!!!');</script>");
            }
        }
        void go() ///gobutton
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
                    TextBox2.Text = dt.Rows[0][1].ToString();
                    Textboxtb2.Text = dt.Rows[0][2].ToString();
                    Textboxt32.Text = dt.Rows[0][3].ToString();
                    Textboxb1.Text = dt.Rows[0][4].ToString();
                    Textboxtb23.Text = dt.Rows[0][5].ToString();
                    TextBox3.Text = dt.Rows[0][6].ToString();
                    TextBox9.Text = dt.Rows[0][7].ToString();
                    TextBox10.Text = dt.Rows[0][8].ToString();


                }
                else
                {
                    Response.Write("<script>alert('Invalid Bus ID. Please check!!');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void update()
        {
            try
            {
                SqlConnection con = new SqlConnection(strconn);
                con.Open();
                SqlCommand cmd = new SqlCommand("update BusInventory set BusName='" + TextBox2.Text + "',BusCategory='" + Textboxtb2.Text +
                    "',Availability_Seats='" + Textboxt32.Text + "',Boarding='" + Textboxb1.Text + "',Departure='" + Textboxtb23.Text + "'," +
                    "StartTime='" + TextBox3.Text + "',EndTime='" + TextBox9.Text + "',Price='" + TextBox10.Text + "' where BusId='" + TextBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Bind();

                Response.Write("<script>alert('Bus Details Updated Successfully');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                Textboxtb2.Text = "";
                Textboxtb23.Text = "";
                Textboxt32.Text = "";
                Textboxb1.Text = "";
                TextBox3.Text = "";
                TextBox3.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        void add()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strconn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Spec_BusInventory",conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BusId", TextBox1.Text);
                cmd.Parameters.AddWithValue("@BusName", TextBox2.Text);
                cmd.Parameters.AddWithValue("@BusCategory", Textboxtb2.Text);
                cmd.Parameters.AddWithValue("@Availability_Seats",Textboxt32.Text);
                cmd.Parameters.AddWithValue("@Boarding", Textboxb1.Text);
                cmd.Parameters.AddWithValue("@Departure", Textboxtb23.Text);
                cmd.Parameters.AddWithValue("@StartTime", TextBox3.Text);
                cmd.Parameters.AddWithValue("@EndTime", TextBox9.Text);
                cmd.Parameters.AddWithValue("@Price", TextBox10.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                
                Response.Write("<script>alert('Bus Details Added Successfully !!!!');</script>");
                TextBox1.Text="";
                TextBox2.Text="";
                Textboxtb2.Text="";
                Textboxtb23.Text="";
                Textboxt32.Text = "";
                Textboxb1.Text="";
                TextBox3.Text="";
                TextBox3.Text="";
                TextBox9.Text="";
                TextBox10.Text="";
            }
            catch (Exception exx)
            {
                Response.Write("<script>alert('" + exx.Message + "');</script>");
            }
        }


        void del()
        {
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from BusInventory where BusId='" + TextBox1.Text + "'", con);
            int i = cmd.ExecuteNonQuery();
            GridView1.DataBind();
            Bind();
            con.Close();
            Response.Write("<script>alert('Bus Details Deleted !!!!');</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            Textboxtb2.Text = "";
            Textboxtb23.Text = "";
            Textboxt32.Text = "";
            Textboxb1.Text = "";
            TextBox3.Text = "";
            TextBox3.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

        }

        bool checkid() //checking busid
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
        


    }
}