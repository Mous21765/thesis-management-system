using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id=TextBox1.Text;
            string password = TextBox2.Text;
            if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                Response.Write("<script>alert('Συμπλήρωσε όλα τα πεδία')</script>");
            }
            else
            {
                Accounts acc=new Accounts();
                int check=acc.Login(id, password);
                if (check == 1)
                {
                    if (acc.Type.Equals("professor"))
                    {
                        Response.Redirect("TeacherMainPage.aspx?id=" + acc.Id + "&name=" + acc.Name);
                    }
                    else
                    {
                        Response.Redirect("StudentMainPage.aspx?id=" + acc.Id + "&name=" + acc.Name);
                    }
                }
                else
                {
                    Response.Write("<script>alert('Αυτός ο λογαριασμός δεν υπάρχει,δοκίμασε ξανά.')</script>");
                }
            }
        }
    }
}