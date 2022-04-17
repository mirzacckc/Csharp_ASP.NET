using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_07012022
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        //string kullaniciAdi = "Mirza";
        //char cinsiyetBilgisi = 'e';
        //int hisettiginYas;

        protected void Page_Load(object sender, EventArgs e)
        {
            //hisettiginYas = 105;
            //double benzinFiyati = 13.50;
            //bool hayatPahali = true;     //bool ve Boolean aynı işlevi görür

            //Label1.Text = kullaniciAdi;
            //TextBox1.Text = Convert.ToString(hisettiginYas);
            ////TextBox2.Text = "" + benzinFiyati;



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string isim = txt_ad.Text;
            char cinsiyet = Convert.ToChar(txt_cinsiyet.Text);

            if (cinsiyet == 'k')
            {
                lbl_sonuc.Text = "Hoşgeldiniz " + isim + " Hanım :D";
            }
            if (cinsiyet == 'e')
            {
                lbl_sonuc.Text = "Hoşgeldiniz " + isim + " Bey :D";

            }

            //string textboxOku = TextBox2.Text;

            ////Label1.Text = textboxOku + " " + kullaniciAdi + " " + cinsiyetBilgisi + " " + hisettiginYas;

            //if (cinsiyetBilgisi == 'k')
            //{
            //    Label1.Text = "Hoşgeldiniz " + textboxOku + " Hanım";
            //}
            //if (cinsiyetBilgisi == 'e')
            //{
            //    Label1.Text = "Hoşgeldiniz " + textboxOku + " Bey";
            //}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(txt_yas.Text);

            if (yas > 14)
            {
                lbl_sonuc.Text = "Welcome to Chamber of Secret";
            }
            if (yas <= 14)
            {
                lbl_sonuc.Text = "Ruh emiciler tarafından engellendin Heri Pıttır";
            }
        }
    }
}