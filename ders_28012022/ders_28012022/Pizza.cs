using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ders_28012022
{
    public class Pizza
    {
        public string ad;
        public string aciklama;
        public double kBoyFiyat;
        public double oBoyFiyat;
        public double bBoyFiyat;
        public string[] urunler;

        public Pizza()
        {

        }
        public Pizza(string pizzaAdi, string aciklama, double kBoyFiyat, double oBoyFiyat, double bBoyFiyat, string[] urunler)
        {
            this.ad = pizzaAdi;
            this.aciklama = aciklama;
            this.kBoyFiyat = kBoyFiyat;
            this.oBoyFiyat = oBoyFiyat;
            this.bBoyFiyat = bBoyFiyat;
            this.urunler = urunler;
        }
        public Pizza(string pizzaAdi, string aciklama, string[] urunler)
        {
            this.ad = pizzaAdi;
            this.aciklama = aciklama;
            this.urunler = urunler;
        }

        public void IndirimUygula(double indirimOrani)
        {
            this.kBoyFiyat *= (1 - indirimOrani);
            this.oBoyFiyat *= (1 - indirimOrani);
            this.bBoyFiyat *= (1 - indirimOrani);
        }



    }
    
}