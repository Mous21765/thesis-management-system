using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public partial class StudentMainPage : System.Web.UI.Page
    {
        private string id;
        private string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
            name = Request.QueryString["name"];
            NameLabel.Text = "Καλωσηλθάτε " + name;
            HyperLink2.NavigateUrl = "Upload.aspx?id=" + id;
            HyperLink4.NavigateUrl = "ArrangeDate.aspx?id=" + id;
            HyperLink3.NavigateUrl = "ViewProgress.aspx?id=" + id;
        } 
    }
}