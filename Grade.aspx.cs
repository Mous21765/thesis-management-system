using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public partial class Grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ptyxiaki p=new Ptyxiaki();
            List<string[]> ptyxiakes = p.get_professor_ptyxiakes(Request.QueryString["id"]);
            foreach(string[] pt in ptyxiakes)
            {
                DropDownList1.Items.Add(pt[2]+","+pt[0]);
            }
            for(double i = 5; i < 10.5; i += 0.5)
            {
                DropDownList2.Items.Add(i.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Kathigitis k = new Kathigitis();
            k.GradeThesis(DropDownList1.Text.Split(',')[1],double.Parse(DropDownList2.Text));
            Response.Write("<script>alert('Ο βαθμός κατατέθηκε επιτυχώς');</script>");
            Response.Redirect("Login.aspx");
        }
    }
}