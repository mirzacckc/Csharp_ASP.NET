using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_28012022
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Pizza p1 = new Pizza();
            p1.ad = "Akdenizli";
            p1.aciklama = "Alın yiyin Ekonomiye can verin";
            p1.kBoyFiyat = 50;
            p1.oBoyFiyat = 60;
            p1.bBoyFiyat = 70;

            string[] urunler = { "kekik", "kimyon" };

            Pizza p2 = new Pizza("Kaburgalı", "Ye Ye çıtır çıtır", 50, 85, 98, urunler );
            p2.IndirimUygula(0.25);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //AKDENİZLİ
            Response.Redirect("PizzaDetay.aspx?UrunKodu=1");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //DOPDOLU SUCUKLU
            Response.Redirect("PizzaDetay.aspx?UrunKodu=2");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //KABURGALI
            Response.Redirect("PizzaDetay.aspx?UrunKodu=3");
        }
    }
}