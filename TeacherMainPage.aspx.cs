using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public partial class TeacherMainPage : System.Web.UI.Page
    {
        private string id;
        private string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            id=Request.QueryString["id"];
            name=Request.QueryString["name"];
            NameLabel.Text = "Καλωσηλθάτε " + name;
            view_dates.NavigateUrl = "Dates.aspx?id=" + id;
            grade.NavigateUrl = "Grade.aspx?id=" + id;
        }
    }
}