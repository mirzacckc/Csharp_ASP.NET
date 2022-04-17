using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_14012022
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] ankaraninIlceleri = { "Akyurt", "Altındağ", "Ayaş", "Balâ", "Beypazarı", "Çamlıdere", "Çankaya", "Çubuk", "Elmadağ", "Etimesgut", "Evren", "Gölbaşı", "Güdül", "Haymana", "Kahramankazan", "Kalecik", "Keçiören", "Kızılcahamam", "Mamak", "Nallıhan", "Polatlı", "Pursaklar", "Sincan", "Şereflikoçhisar", "Yenimahalle" };

            string[] istabulunIlceleri = { "Adalar", "Arnavutköy", "Ataşehir", "Avcılar", "Bağcılar", "Bahçelievler", "Bakırköy", "Başakşehir", "Bayrampaşa", "Beşiktaş", "Beykoz", "Beylikdüzü", "Beyoğlu", "Büyükçekmece", "Çatalca", "Çekmeköy", "Esenler", "Esenyurt", "Eyüpsultan", "Fatih", "Gaziosmanpaşa", "Güngören", "Kadıköy", "Kağıthane", "Kartal", "Küçükçekmece", "Maltepe", "Pendik", "Sancaktepe", "Sarıyer", "Silivri", "Sultanbeyli", "Sultangazi", "Şile", "Şişli", "Tuzla", "Ümraniye", "Üsküdar", "Zeytinburnu" };

            string[] izmirinIlceleri = { "Aliağa", "Balçova", "Bayındır", "Bayraklı", "Bergama", "Beydağ", "Bornova", "Buca", "Çeşme", "Çiğli", "Dikili", "Foça", "Gaziemir", "Güzelbahçe", "Karabağlar", "Karaburun", "Karşıyaka", "Kemalpaşa", "Kınık", "Kiraz", "Konak", "Menderes", "Menemen", "Narlıdere", "Ödemiş", "Seferihisar", "Selçuk", "Tire", "Torbalı", "Urla" };

           
            DropDownList2.Items.Clear();                         // dropdown icindeki listeleri temizler.
            DropDownList2.Items.Add("SEÇİNİZ");

            string secim = DropDownList1.SelectedValue;

            if (secim == "ankara")
            {
                for (int i = 0; i < 25; i++)                       //if ile dizi elemanlarını gezerek dropdown a ekle.
                {
                    DropDownList2.Items.Add(ankaraninIlceleri[i]);
                }
                //DropDownList2.Items.Add("Altındağ");             // dropdowna ekleme yapar.
                //DropDownList2.Items.Add("Keçiören");
                //DropDownList2.Items.Add("Mamak");
                //DropDownList2.Items.Add(ankaraninIlceleri[0]);   // Listeye ekleme yapmak için kullanılır.


            }
            else if (secim == "istanbul")
            {
                //for (int j = 0; j < istabulunIlceleri.Length; j++)
                //{
                //    DropDownList2.Items.Add(istabulunIlceleri[j]);
                //}
                int j = 0;                                        //while ile dizi elemanlarını gezerek dropdown a ekle.
                while (j <= 24)
                {
                    DropDownList2.Items.Add(istabulunIlceleri[j]);

                    j++;
                }
               
            }
            else if (secim == "izmir")
            {
                //for (int k = 0; k < 30; k++)
                //{
                //    DropDownList2.Items.Add(izmirinIlceleri[k]);
                //}
                int k = 0;
                do                                               //do-while ile dizi elemanlarını gezerek dropdown a ekle.
                {
                    DropDownList2.Items.Add(izmirinIlceleri[k]);

                    k++;
                } while (k < 30);
            }
        }        
    }
}