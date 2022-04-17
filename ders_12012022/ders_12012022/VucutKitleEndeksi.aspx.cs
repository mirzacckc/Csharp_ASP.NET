using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_12012022
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lbl_sonucBaslik.Visible = true;
            lbl_sonucIcerik.Visible = true;

            int kilo = Convert.ToInt32(TextBox1.Text);
            int boy = Convert.ToInt32(TextBox2.Text);
            double oran = 0;

            if (kilo>0 && boy>0)
            {
                oran = kilo / (boy * boy*0.0001);
                if (oran<18.4)
                {
                    lbl_sonucBaslik.Text = "Zayıfsın";
                    lbl_sonucIcerik.Text = "Kişinin boyuna oranla ağırlığının yetersiz olduğunu ifade eden bu değer ile karşılaşılması durumunda kişinin diyetisyen eşliğinde sağlıklı bir şekilde kilo alması önerilir.";
                }
                else if (oran<=24.9 && oran>18.4)
                {
                    lbl_sonucBaslik.Text = "Normal";
                    lbl_sonucIcerik.Text = "Bu değer aralığı kişinin ideal kiloda olduğunu gösterir. Bu değere sahip olan kişilerin düzenli, dengeli ve sağlıklı beslenmeye devam etmeleri önerilir.";
                }
                else if (oran<30 && oran>24.9)
                {
                    lbl_sonucBaslik.Text = "Fazla Kilolu";
                    lbl_sonucIcerik.Text = "Kişinin boyuna oranla kilosunun fazla olduğunu gösteren bu değer aralığında kişinin uygun diyet ile fazla kilolarından kurtulması önerilir.";
                }
                else if (oran<35 && oran>=30)
                {
                    lbl_sonucBaslik.Text = "Şişman";
                    lbl_sonucIcerik.Text = " Birinci derece obez kategorisinde değerlendiren değer aralığında, kişinin kilosunun sağlık açısından risk oluşturabilecek düzeyde olduğu anlaşılır. Bu kişilerin diyetisyen yardımıyla kilo vermesi önerilir.";
                }
                else if (oran<45 && oran>=35)
                {
                    lbl_sonucBaslik.Text = "Şişman";
                    lbl_sonucIcerik.Text = "İkinci derece obez olarak tanımlanan bu değerlere sahip olan kişilerde kalp ve damar hastalıkları bakımından risk artar. Kişinin kilo vermek için diyetisyene başvurması önerilir.";
                }
                else
                {
                    lbl_sonucBaslik.Text = "Aşırı Şişman";
                    lbl_sonucIcerik.Text = "Üçüncü derece obez kategorisinde olan bu kişilerde hastalık gelişme riski çok yüksektir. Hekim ve diyetisyen eşliğinde kilo verilmesi önerilir.";
                }
            }
            else
            {
                lbl_sonucBaslik.Text = "Hata!!!!";
                lbl_sonucIcerik.Text = "Kilo ve Boy bilgisi 0'dan büyük olmalı!!";
            }

       
        }
    }
}