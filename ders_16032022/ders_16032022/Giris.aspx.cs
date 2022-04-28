using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_16032022
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kullaniciBilgi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;
            Veritabani vt = new Veritabani();

            string kullaniciAdi = vt.KisiyiBul(kullaniciBilgi, sifre);

            if (kullaniciAdi.Equals("Kullanıcı Bulunamadı"))
            {
                lbl_sonuc.Text = kullaniciAdi;
                lbl_sonuc.CssClass = "alert alert-danger";

            }
            else
            {
                Session["KullaniciAdi"] = kullaniciAdi;
                Response.Redirect("Anasayfa.aspx");
            }

        }
    }
}