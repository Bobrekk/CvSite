﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.Tbl_Hakkımda.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.Tbl_Hakkımda.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource = db.Tbl_Hakkımda.ToList();
            Repeater3.DataBind();

            Repeater4.DataSource = db.Tbl_Yetenekler.ToList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Iletisim t = new Tbl_Iletisim();
            t.AdSoyad = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.Konu = TextBox3.Text;
            t.Mesaj = TextBox4.Text;
            db.Tbl_Iletisim.Add(t);
            db.SaveChanges();
        }
    }
}