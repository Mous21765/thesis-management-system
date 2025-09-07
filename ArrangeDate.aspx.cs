using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public partial class ArrangeDate : System.Web.UI.Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime d = Calendar1.SelectedDate;
            DateTime f=new DateTime(d.Year,d.Month,d.Day,Int32.Parse(hour.Text),Int32.Parse(minutes.Text),0);
            Kathigitis k=new Kathigitis();
            k.CreateDate(Request.QueryString["id"], new Kathigitis().getProfessorOfThesis(Request.QueryString["id"]), f.ToString("yyyy-MM-dd H:mm:ss"));
            Response.Write("<script>alert('To ραντεβού καταχωρήθηκε με επιτυχία.')</script>");
            Response.Redirect("Login.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string student_id = Request.QueryString["id"];
                string teacher_id = new Kathigitis().getProfessorOfThesis(student_id);
                if (teacher_id.Equals("-"))
                {
                    Response.Write("<script>alert('Πρέπει να δηλωθεί πτυχιακή πρώτα.')</script>");
                }
                Calendar1.SelectedDate=DateTime.Now.Date;
                minutes.Items.Add("00");
                minutes.Items.Add("30");
                for(int i = 11; i < 17; i++)
                {
                    hour.Items.Add(i.ToString());
                }
            }
        }
    }
}