using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public partial class ViewProgress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ptyxiaki p=new Ptyxiaki();
            string[] ptyxiaki = p.get_ptyxiaki(Request.QueryString["id"]);
            title.Text=ptyxiaki[0];
            desc.Text=ptyxiaki[1];
            grade.Text="<b>"+ptyxiaki[2]+"</b>";
        }
    }
}