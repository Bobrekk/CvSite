using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace CvEntityProje
{
    public partial class YetenekGüncelle : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);

            if (!Page.IsPostBack)
            {
                var ytnk = db.Tbl_Yetenekler.Find(id);
                TextBox1.Text = ytnk.Yetenek;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            var ytnk = db.Tbl_Yetenekler.Find(id);
            ytnk.Yetenek = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}