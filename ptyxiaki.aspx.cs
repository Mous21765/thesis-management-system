using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public partial class ptyxiaki : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Accounts acc=new Accounts();
            List<string[]> kathigites = acc.kathigites();
            foreach (string[] k in kathigites)
            {
                kathigites_list.Items.Add(k[0] + "," + k[1]);
            }
        }

        protected void b_Click(object sender, EventArgs e)
        {
            Ptyxiaki p=new Ptyxiaki();
            if (string.IsNullOrEmpty(idf.Text))
            {
                Response.Write("<script>alert('Συμπλήρωσε όλα τα πεδία')</script>");
            }
            else
            {
                string idp=kathigites_list.Text.Split(',')[1];
                int res=p.createPtyxiaki(idf.Text, idp,title.Text,desc.Text);
                if (res == 0)
                {
                    Response.Write("<script>alert('Έχεις ήδη δηλώσει πτυχιακή')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Eπιτυχής Δήλωση.')</script>");
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}