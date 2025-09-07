using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public partial class Dates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Kathigitis k=new Kathigitis();
            List<string[]> dates=k.GetDates(Request.QueryString["id"]);
            foreach (string[] d in dates)
            {
                TableCell name, date;
                name = new TableCell();
                name.Text = d[0];
                date = new TableCell();
                date.Text = d[1];
                TableRow tr=new TableRow();
                tr.Cells.Add(name);
                tr.Cells.Add(date);
                dates_table.Rows.Add(tr);
            }
        }
    }
}