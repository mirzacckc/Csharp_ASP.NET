using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_28012022
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string urunKodu = Request.QueryString["UrunKodu"].ToString();
                if (urunKodu == "1") //Akdenizli
                {
                    lbl_baslik.Text = "Akdenizli";
                    Image1.ImageUrl = "Pizza_resimleri/web_listeleme_akdenizli_2707.jpg";
                    lbl_icerik.Text = "Pizza Sosu, Mozarella Peyniri, Beyaz Peynir, Küp Domates, Siyah Zeytin, Kekik";
                }
                else if (urunKodu == "2") // Dopdolu
                {
                    lbl_baslik.Text = "Dopdolu";
                    Image1.ImageUrl = "Pizza_resimleri/web_listeleme_dopdolu_sucuklu_2707.jpg";
                    lbl_icerik.Text = "Pizza Sosu, Mozarella Peyniri, Sucuk";
                }
                else if (urunKodu == "3") //Kaburgalı
                {
                    lbl_baslik.Text = "Kaburgalı";
                    Image1.ImageUrl = "Pizza_resimleri/web_listeleme_kaburgali_2707.jpg";
                    lbl_icerik.Text = "Barbekü Sos, Mozarella Peyniri, Fırınlanmış Patlıcan, Füme Kaburga, Soğan, Mantar, Susam, Kekik";
                }
            }
        }
    }
}