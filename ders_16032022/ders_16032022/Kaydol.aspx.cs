using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_16032022
{
    public partial class Kaydol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {            
                string ad = txt_ad.Text;
                string soyad = txt_soyad.Text;
                string eposta = txt_eposta.Text;
                string tel = txt_tel.Text;
                string tc = txt_tc.Text;
                string sifre = txt_sifre.Text;
                string surucu = txt_surucu.Text;
                string dogum = txt_dogum.Text;
                Veritabani vt = new Veritabani();
                vt.KullaniciKaydet(eposta, tc, tel, ad, soyad, sifre, dogum, surucu);
                Response.Redirect("Giris.aspx");

                       
        }

    }
}
