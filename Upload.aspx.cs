using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FileUpload1.FileName))
            {
                string id = Request.QueryString["id"];
                string filename = FileUpload1.FileName;
                FileUpload1.SaveAs("C:\\Users\\99pth\\Desktop\\SystimaDiaxeirisisPtyxiakwn\\" + filename);
                Ptyxiaki p = new Ptyxiaki();
                p.upload_file(id, filename);
                Response.Write("<script>alert('Aναρτηση επιτυχής.');</script>");
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("<script>alert('Παρακαλώ ανάρτησε αρχείο.');</script>");
            }
        }
    }
}