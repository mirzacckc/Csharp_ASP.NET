using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_16032022
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TabloGuncelle();
                Session["KullaniciGuncelle"] = false;
                TabloPasifGuncelle();
            }



        }

        public void TabloGuncelle()
        {
            Veritabani vt = new Veritabani();
            DataTable tablo = vt.KullaniciBilgileriListele();
            GridView1.DataSource = tablo;
            GridView1.DataBind();
        }

        public void TabloPasifGuncelle()
        {
            Veritabani vt = new Veritabani();
            DataTable tablo = vt.KullaniciBilgileriListelePasif();
            GridView2.DataSource = tablo;
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txt_eposta.Enabled = true;
            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;
            string tc = txt_tc.Text;
            string eposta = txt_eposta.Text;
            string surucu = txt_surucu.Text;
            string dogum = txt_dogum.Text;
            string tel = txt_tel.Text;

            if (Convert.ToBoolean(Session["KullaniciGuncelle"]))
            // Convert.ToBoolean(Session["KullaniciGuncelle"] ) == True
            {
                Veritabani vt = new Veritabani();
                vt.KullaniciGuncelle(eposta, tc, tel, ad, soyad, dogum, surucu);
                Session["KullaniciGuncelle"] = false;
            }
            else   // Yeni Kullanıcı Kaydet
            {
                ////Mirza Can Çiçekçi mirzacancicekci5 gibi randon kullanıcı adı oluştursun
                //string kullaniciAdi = ad + soyad; //Mirza Can Çiçekçi
                //kullaniciAdi = kullaniciAdi.ToLower(); //mirza can çiçekçi
                //kullaniciAdi = kullaniciAdi.Replace(" ", ""); //mirzacançiçekçi

                //string turkceKarakter = "ğüışöç";  //char dizi char[] turkceKarakter = {'ğ', 'ü' , ...}
                //string normal = "guisoc";

                //for (int i = 0; i < turkceKarakter.Length; i++)
                //{
                //    kullaniciAdi = kullaniciAdi.Replace(turkceKarakter[i], normal[i]);   //mirzacancicekci
                //}

                //Random rastgele = new Random();
                //kullaniciAdi = kullaniciAdi + rastgele.Next(10, 99); //mirzacancicekci12 gibi bir değer atar
                //lbl_sonuc.Text = kullaniciAdi;

                Random rastgele = new Random();
                string sifreKarakterleri = "işüğpçöjhajsash,s$£.<qwerxcvb</123456789_0&%#+-*/-";
                string sifre = "";
                int sayi = 0;
                for (int i = 0; i < 6; i++)
                {
                    sayi = rastgele.Next(0, sifreKarakterleri.Length);
                    sifre = sifre + sifreKarakterleri[sayi];

                }

                lbl_sonuc.Text += " Şifresi:" + sifre;

                Veritabani vt = new Veritabani();
                vt.KullaniciKaydet(eposta, tc, tel, ad, soyad, sifre, dogum, surucu);

            }

            TabloGuncelle();
            Temizle();

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Guncelle") //Update
            {
                int index = Convert.ToInt32(e.CommandArgument);
                txt_eposta.Text = GridView1.Rows[index].Cells[2].Text;
                txt_eposta.Enabled = false;
                txt_tel.Text = GridView1.Rows[index].Cells[3].Text;
                txt_ad.Text = HttpUtility.HtmlDecode(GridView1.Rows[index].Cells[5].Text);
                txt_soyad.Text = HttpUtility.HtmlDecode(GridView1.Rows[index].Cells[6].Text);
                txt_tc.Text = GridView1.Rows[index].Cells[7].Text;
                txt_surucu.Text = Convert.ToDateTime(GridView1.Rows[index].Cells[8].Text).ToString("yyyy-MM-dd");
                txt_dogum.Text = Convert.ToDateTime(GridView1.Rows[index].Cells[9].Text).ToString("yyyy-MM-dd");
                Session["KullaniciGuncelle"] = true;

            }
            else //Delete, Silme
            {
                Veritabani vt = new Veritabani();
                int index = Convert.ToInt32(e.CommandArgument);
                vt.KullaniciSil(GridView1.Rows[index].Cells[2].Text);
                TabloGuncelle();
                TabloPasifGuncelle();
            }
        }

        public void Temizle()
        {
            txt_eposta.Text = "";
            txt_tel.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_tc.Text = "";
            txt_surucu.Text = "";
            txt_dogum.Text = "";
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            Veritabani vt = new Veritabani();
            vt.SilinenKullaniciEkle(GridView2.Rows[index].Cells[1].Text);
            TabloGuncelle();
            TabloPasifGuncelle();
        }
    }
}