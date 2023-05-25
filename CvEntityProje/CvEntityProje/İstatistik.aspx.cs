using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class İstatistik : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.Tbl_Yetenekler.Count().ToString();
            Label2.Text = db.Tbl_Iletisim.Count().ToString();
            Label3.Text = db.Tbl_Yetenekler.Average(x => x.Derece).ToString();
            Label4.Text = db.Tbl_Yetenekler.Max(x => x.Derece).ToString();
        }
    }
}