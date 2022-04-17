using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_19012022
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string[] aractipi = { "Seçiniz", "Otomobil", "Motosiklet", "Minibüs", "Panel Van Ve Motorlu Karavanlar", "Otobüs", "Kamyonet,Kamyon ve Çekici" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // sayfa ilk defa yükleniyorsa
            {
                
                for (int i = 0; i < aractipi.Length; i++)
                {
                    DropDownList1.Items.Add(aractipi[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            DropDownList3.Items.Clear();
            DropDownList4.Items.Clear();
            DropDownList3.Visible = true;
            lbl_ikinci.Visible = true;
            DropDownList4.Visible = false;
            lbl_ucuncu.Visible = false;
           

            string aracTipiSecimi = DropDownList1.SelectedValue;

            if (aracTipiSecimi == aractipi[1])
            {
                DropDownList4.Visible = true;
                lbl_ucuncu.Visible = true;
                lbl_birinci.Text = "Motor Silindir Hacmi (cm³)";

                string[] otomobilMotorSilindirHacmi = { "1300 cm³ ve aşağısı", "1301 - 1600 cm³'e kadar", "1601 - 1800 cm³'e kadar", "1801 - 2000 cm³'e kadar", "2001 - 2500 cm³'e kadar", "2501 - 3000 cm³'e kadar", "3001 - 3500 cm³'e kadar", "3501 - 4000 cm³'e kadar", "4001 cm³ ve yukarısı" };

                for (int i = 0; i < otomobilMotorSilindirHacmi.Length; i++)
                {
                    DropDownList2.Items.Add(otomobilMotorSilindirHacmi[i]);
                }

                lbl_ikinci.Text = "Araç Yaşı";

                string[] otomobilyas = { "1-3 yaş", "4-6 yaş", "7-11 yaş", "12-15 yaş", "16 ve yukarı yaş" };

                for (int i = 0; i < otomobilyas.Length; i++)
                {
                    DropDownList3.Items.Add(otomobilyas[i]);
                }

                lbl_ucuncu.Text = "Araç Tescil Yılı";

                string[] tescilyil = { "2018 yılından önce", "2018 yılından sonra" };

                for (int i = 0; i < tescilyil.Length; i++)
                {
                    DropDownList4.Items.Add(tescilyil[i]);
                }
            }
            else if (aracTipiSecimi == aractipi[2])   //(aracTipiSecimi == "Motosiklet")
            {
                lbl_birinci.Text = "Motor Silindir Hacmi (cm³)";

                string[] motosikletlMotorSilindirHacmi = { "100 - 250 cm³'e kadar", "251 - 650 cm³'e kadar", "651 - 1200 cm³'e kadar", "1201 cm³ ve yukarısı" };

                for (int i = 0; i < motosikletlMotorSilindirHacmi.Length; i++)
                {
                    DropDownList2.Items.Add(motosikletlMotorSilindirHacmi[i]);
                }

                lbl_ikinci.Text = "Araç Yaşı";

                string[] motoryas = { "1-3 yaş", "4-6 yaş", "7-11 yaş", "12-15 yaş", "16 ve yukarı yaş" };

                for (int i = 0; i < motoryas.Length; i++)
                {
                    DropDownList3.Items.Add(motoryas[i]);
                }
            }
            else if (aracTipiSecimi == aractipi[3])
            {
                lbl_birinci.Text = "Araç Yaşı";

                string[] minibusyas = { "1 - 6 yaş", "7 - 15 yaş", "16 ve yukarı yaş" };

                for (int i = 0; i < minibusyas.Length; i++)
                {
                    DropDownList2.Items.Add(minibusyas[i]);
                }

                DropDownList3.Visible = false;
                lbl_ikinci.Visible = false;
            }
            else if (aracTipiSecimi == aractipi[4])
            {
                lbl_birinci.Text = "Motor Silindir Hacmi (cm³)";

                DropDownList2.Items.Add("1900 cm³ ve aşağısı");
                DropDownList2.Items.Add("1901 cm³ ve yukarısı");

                lbl_ikinci.Text = "Araç Yaşı";

                string[] panelyas = { "1 - 6 yaş", "7 - 15 yaş", "16 ve yukarı yaş" };

                for (int i = 0; i < panelyas.Length; i++)
                {
                    DropDownList3.Items.Add(panelyas[i]);
                }
            }

            else if (aracTipiSecimi == aractipi[5])
            {
                lbl_birinci.Text = "Oturma Yeri";

                string[] oturmaYeri = { "25 kişiye kadar", "26 - 35 kişiye kadar", "36 - 45 kişiye kadar", "46 kişi ve yukarısı" };

                for (int i = 0; i < oturmaYeri.Length; i++)
                {
                    DropDownList2.Items.Add(oturmaYeri[i]);
                }

                lbl_ikinci.Text = "Araç Yaşı";

                string[] otobusyas = { "1 - 6 yaş", "7 - 15 yaş", "16 ve yukarı yaş" };

                for (int i = 0; i < otobusyas.Length; i++)
                {
                    DropDownList3.Items.Add(otobusyas[i]);
                }
            }
            else
            {
                lbl_birinci.Text = "Azami Toplam Ağırlık";

                string[] azamiAgırlık = { "1.500 kg'a kadar", "1.501 - 3.500 kg'a kadar", "3.501 - 5.000 kg'a kadar", "5.001 - 10.000 kg'a kadar", "10.001 - 20.000 kg'a kadar", "20.001 kg ve yukarısı" };

                for (int i = 0; i < azamiAgırlık.Length; i++)
                {
                    DropDownList2.Items.Add(azamiAgırlık[i]);
                }
                lbl_ikinci.Text = "Araç Yaşı";

                string[] kamyonyas = { "1 - 6 yaş", "7 - 15 yaş", "16 ve yukarı yaş" };

                for (int i = 0; i < kamyonyas.Length; i++)
                {
                    DropDownList3.Items.Add(kamyonyas[i]);
                }
            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aracyılsecimi = DropDownList3.SelectedValue;
            //DropDownList4.Visible = true;
            //lbl_ucuncu.Visible = true;

            if (aracyılsecimi == "1-3 yaş")
            {
                DropDownList4.Visible = true;
                lbl_ucuncu.Visible = true;

            }
            else
            {
                DropDownList4.Visible = false;
                lbl_ucuncu.Visible = false;
                DropDownList5.Visible = false;
                lbl_dorduncu.Visible = false;
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList5.Visible = false;
            lbl_dorduncu.Visible = false;
            //DropDownList5.Items.Clear();
            string secilenTescilYili = DropDownList4.SelectedValue;

            lbl_dorduncu.Text = "Araç Değeri";

            if (secilenTescilYili == "2018 yılından sonra")
            {
                DropDownList5.Visible = true;
                lbl_dorduncu.Visible = true;

                //DropDownList5.Items.Add("56.500'i aşmayanlar");
                //DropDownList5.Items.Add("56.500'i aşıp 99.000'i aşmayanlar");
                //DropDownList5.Items.Add("99.000 aşanlar");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int secilenyasIndeksi = DropDownList3.SelectedIndex;
            int secilenMotorSilindirIndeksi = DropDownList2.SelectedIndex;
            int index = 5 * secilenMotorSilindirIndeksi + secilenyasIndeksi;
            // secilen durumlara göre tutarları yazdırma

            if (DropDownList1.SelectedValue == "Otomobil")
            {


                int[] otomobilVergi = { 1313, 916, 512, 386, 136, 2287, 1715, 995, 703, 270, 4042, 3157, 1860, 1132, 438, 6368, 4908, 2882, 1715, 676, 9550, 6933, 4332, 2587, 1023, 13318, 11585, 7237, 3891, 1428, 20282, 18250, 10992, 5486, 2012, 31891, 27537, 16217, 7237, 2882, 52195, 39140, 23180, 10416, 4042 };

                lbl_sonuc.Text = otomobilVergi[index] + " ₺";
                //if (DropDownList2.SelectedValue == "1300 cm³ ve aşağısı")
                //{
                //    int[] ms1300veasagisi = { 964,672,376,286,101};                    
                //    lbl_sonuc.Text = "Ödenmesi Gereken MTV Tutarı: " + ms1300veasagisi[secilenyasIndeksi];
                //}
                //else if (DropDownList2.SelectedValue == "1301 - 1600 cm³'e kadar")
                //{
                //    int[] ms13001601arasi = { 1600, 1259, 731, 516, 190 };
                //    lbl_sonuc.Text = "Ödenmesi Gereken MTV Tutarı: " + ms13001601arasi[secilenyasIndeksi];
                //}
            }
            else if (DropDownList1.SelectedValue == aractipi[2])  //Motosiklet
            {
                int[] motorVergi = { 245, 183, 135, 83, 32, 506, 383, 245, 135, 83, 1306, 776, 383, 245, 135, 3168, 2093, 1306, 1037, 506 };

                lbl_sonuc.Text = motorVergi[index] + " ₺";
            }
            else if (DropDownList1.SelectedValue == aractipi[3]) //Minibüs
            {
                int[] minibusVergi = { 1570, 1037, 506 };
                index = secilenMotorSilindirIndeksi;
                lbl_sonuc.Text = minibusVergi[index] + " ₺";
            }
            else if (DropDownList1.SelectedValue == aractipi[4]) //Panelvan
            {
                int[] panelvanVergi = { 2093, 1306, 776, 3151, 2093, 1306 };
                index = 3 * secilenMotorSilindirIndeksi + secilenyasIndeksi;
                lbl_sonuc.Text = panelvanVergi[index] + " ₺";
            }
            else if (DropDownList1.SelectedValue == aractipi[5]) //Otobüs
            {
                int[] otobusVergi = { 3965, 2368, 1037, 4755, 3965, 1570, 5292, 4488, 2093, 6348, 5292, 3168 };
                index = 3 * secilenMotorSilindirIndeksi + secilenyasIndeksi;
                lbl_sonuc.Text = otobusVergi[index] + " ₺";
            }
            else
            {
                int[] kamyonVergi = { 1408, 935, 458, 2851, 1652, 935, 4283, 3565, 1408, 4750, 4038, 1893, 5715, 4755, 2851, 7148, 5715, 3321 };
                index = 3 * secilenMotorSilindirIndeksi + secilenyasIndeksi;
                lbl_sonuc.Text = kamyonVergi[index] + " ₺";
            }
            
                 
        }
    }
}