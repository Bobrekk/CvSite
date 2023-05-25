using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbCvEntityEntities db = new DbCvEntityEntities();
            int x = int.Parse(Request.QueryString["Id"]);
            var mesaj = db.Tbl_Iletisim.Find(x);
            TxtBoxGonderen.Text = mesaj.AdSoyad;
            TxtBoxMail.Text = mesaj.Mail;
            TxtBoxKonu.Text = mesaj.Konu;
            TxtBoxMesaj.Text = mesaj.Mesaj;
        }
    }
}