using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ders_16032022
{
    public class Veritabani
    {
        SqlConnection ok = new SqlConnection();
        public void Baglan()
        {
            string machineName = HttpContext.Current.Server.MachineName;
            string baglantiCumlesi = "Data Source="+machineName+"; Initial Catalog=AracKiralama; Integrated Security=True; ";

            ok.ConnectionString = baglantiCumlesi;
            ok.Open();

        }

        public DataTable AracBilgileriListelePasif()
        {

            string sqlkomutu = @"SELECT [id]
                              ,[model]
                              ,[resimYolu]
                              ,[aciklama]
                              ,[klima]
                              ,[vites]
                              ,[yakitTuru]
                              ,[kapasite]
                              ,[kapi]
                              ,[yasSiniri]
                              ,[ehliyetSureSiniri]
                              ,[absOzelligi]
                              ,[yolcuAirbag]                             
                               FROM [AracTablosu] where isAktif=0";

            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = sqlkomutu;
            //komut.Connection = ok;

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = komut;

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //ok.Close();

            return Listeleme(sqlkomutu);
        }

        public DataTable AracBilgileriListele()
        {

            string sqlkomutu = @"SELECT [id]
                              ,[model]
                              ,[resimYolu]
                              ,[aciklama]
                              ,[klima]
                              ,[vites]
                              ,[yakitTuru]
                              ,[kapasite]
                              ,[kapi]
                              ,[yasSiniri]
                              ,[ehliyetSureSiniri]
                              ,[absOzelligi]
                              ,[yolcuAirbag]                             
                               FROM [AracTablosu] where isAktif=1";

            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = sqlkomutu;
            //komut.Connection = ok;

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = komut;

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //ok.Close();

            return Listeleme(sqlkomutu);
        }

        public DataTable VitesListele()
        {
            string sorgu = "SELECT [id],[aciklama] FROM [t_vitesTuru]";
            return Listeleme(sorgu);
        }

        public DataTable YakitTuruListele()
        {
            string sorgu = "SELECT [id],[aciklama] FROM [t_yakitTuru]";
            return Listeleme(sorgu);
        }

        public DataTable Listeleme(string sqlkomutu)
        {

            Baglan();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sqlkomutu;
            komut.Connection = ok;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = komut;

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ok.Close();

            return dataTable;
        }

        public DataTable KullaniciBilgileriListele()
        {

            string sqlkomutu = @"SELECT [eposta] as Eposta
                              ,[tel] as Telefon
                              ,[kullaniciAdi] as 'Kullanıcı Adı'
                              ,[ad] as Ad
                              ,[soyad] as Soyad
                              ,[tc] as 'TC Kimlik No'
                              ,[surucuBelgesiTarihi] as 'Sürücü Belgesi Tarihi'
                              ,[dogumTarihi] as 'Doğum Tarihi'
                               FROM[AracKiralama].[dbo].[Kullanici] where isAktif=1";

            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = sqlkomutu;
            //komut.Connection = ok;

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = komut;

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //ok.Close();

            return Listeleme(sqlkomutu);
        }

        public DataTable KullaniciBilgileriListelePasif()
        {

            string sqlkomutu = @"SELECT [eposta] as Eposta
                              ,[tel] as Telefon
                              ,[kullaniciAdi] as 'Kullanıcı Adı'
                              ,[ad] as Ad
                              ,[soyad] as Soyad
                              ,[tc] as 'TC Kimlik No'
                              ,[surucuBelgesiTarihi] as 'Sürücü Belgesi Tarihi'
                              ,[dogumTarihi] as 'Doğum Tarihi'
                               FROM[AracKiralama].[dbo].[Kullanici] where isAktif=0";

            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = sqlkomutu;
            //komut.Connection = ok;

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = komut;

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //ok.Close();

            return Listeleme(sqlkomutu);
        }

        public void KullaniciKaydet(string eposta, string tc, string tel, string ad, string soyad, string sifre,
                                    string dogum, string surucu)
        {
            sifre = Sifreleme.HashSHA1(sifre);
            string kullaniciAdi = ad + soyad;
            kullaniciAdi = kullaniciAdi.ToLower();
            kullaniciAdi = kullaniciAdi.Replace(" ", "");

            string turkceKarakter = "ğüışöç";
            string normal = "guisoc";

            for (int i = 0; i < turkceKarakter.Length; i++)
            {
                kullaniciAdi = kullaniciAdi.Replace(turkceKarakter[i], normal[i]);
            }

            Random rastgele = new Random();
            kullaniciAdi = kullaniciAdi + rastgele.Next(10, 9999);
            string komutText = @"INSERT INTO[Kullanici]
                               ([eposta]
                               ,[tel]
                               ,[kullaniciAdi]
                               ,[ad]
                               ,[soyad]
                               ,[sifre]
                               ,[tc]
                               ,[surucuBelgesiTarihi]
                               ,[dogumTarihi]
                               ,[isAktif])
                         VALUES
                            ('" + eposta + "', '" + tel + "','" + kullaniciAdi + "','" + ad + "','" + soyad + "','" + sifre + "','" + tc
                             + "','" + surucu + "','" + dogum + "', 1)";

            //Baglan();
            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = komutText;
            //komut.Connection = ok;

            //komut.ExecuteNonQuery();
            //ok.Close();

            EklemeGuncelleme(komutText);
            MailGonder mail = new MailGonder();
            mail.Gonder("Kullanıcı Kayıt İşlemi", "Hoşgeldin " + ad, eposta);


        }

        public void AracKaydet(string model, string aciklama, bool kilima, string kapasite, string kapi, int yasSiniri,
            int surucuSiniri, bool abs, bool airbag, string vitesTuru, string yakit, string resimYolu)
        {

            string komutText = @"INSERT INTO[dbo].[AracTablosu]
                               ([model]
                               ,[resimYolu]
                               ,[aciklama]
                               ,[klima]
                               ,[vites]
                               ,[yakitTuru]
                               ,[kapasite]
                               ,[kapi]
                               ,[yasSiniri]
                               ,[ehliyetSureSiniri]
                               ,[absOzelligi]
                               ,[yolcuAirbag]
                               ,[isAktif])
                         VALUES
                               ('" + model + "', '" + resimYolu + "', '" + aciklama + "', '" + kilima + "', '" + vitesTuru + "', '" + yakit + "', '" + kapasite + "', '" + kapi + "'," + yasSiniri
                               + ", " + surucuSiniri + ", '" + abs + "', '" + airbag + "', 1)";

            //Baglan();
            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = komutText;
            //komut.Connection = ok;
            
            
            //komut.ExecuteNonQuery();
            //ok.Close();

            EklemeGuncelleme(komutText);

        }

        public void EklemeGuncelleme(string komutText)
        {
            Baglan();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = komutText;
            //string userName = "";
            //komut.Parameters.AddWithValue("@username", userName);
            komut.Connection = ok;

            komut.ExecuteNonQuery();
            ok.Close();
        }

        public void KullaniciGuncelle(string eposta, string tc, string tel, string ad, string soyad,
                                    string dogum, string surucu)
        {
            string komutString = @"update Kullanici set tel='" + tel + "', ad='" + ad + "', soyad='" + soyad + "', tc='" + tc + "', surucuBelgesiTarihi='" + surucu + "', dogumTarihi='" + dogum + "' where eposta='" + eposta + "'";

            EklemeGuncelleme(komutString);
        }

        public void KullaniciSil(string eposta)
        {
            string sorgu = "update Kullanici set isAktif=0 where eposta='" + eposta + "'";
            EklemeGuncelleme(sorgu);
        }

        public void SilinenKullaniciEkle(string eposta)
        {
            string sorgu = "update Kullanici set isAktif=1 where eposta='" + eposta + "'";
            EklemeGuncelleme(sorgu);
        }

        public void AracGuncelleme(string model, string aciklama, bool kilima, string kapasite, string kapi, int yasSiniri,
            int surucuSiniri, bool abs, bool airbag, string vitesTuru, string yakit, string resimYolu, int id)
        {
            string sorgu = @"update AracTablosu set model='" + model + "', resimYolu='" + resimYolu + "', aciklama='" + aciklama
                + "', klima='" + kilima + "',vites = '" + vitesTuru + "', yakitTuru = '" + yakit + "', kapasite = " + kapasite
                + ", kapi = " + kapi + ", yasSiniri = " + yasSiniri + ", ehliyetSureSiniri = " + surucuSiniri
                + ", absOzelligi = '" + abs + "',yolcuAirbag = '" + airbag + "' where id =" + id;

            EklemeGuncelleme(sorgu);
        }

        public void AraciSil(int id)
        {
            string sorgu = "update AracTablosu set isAktif=0 where id=" + id;

            EklemeGuncelleme(sorgu);
        }

        public void SilinenAraciEkle(int id)
        {
            string sorgu = "update AracTablosu set isAktif=1 where id=" + id;

            EklemeGuncelleme(sorgu);
        }

        public DataTable FiloGoruntule()
        {
            string sorgu = @"SELECT [model]
                          ,[resimYolu]
                          , t1.[aciklama]
                          ,[klima]
                          ,t_vitesTuru.aciklama as Vites
                          ,t_yakitTuru.aciklama as Yakit
                          ,[kapasite]
                          ,[kapi]
                          ,[yasSiniri]
                          ,[ehliyetSureSiniri]
                          ,[absOzelligi]
                          ,[yolcuAirbag]
                          ,t_Aractipi.aciklama

                          From(select * FROM[AracTablosu] where isAktif = 1) as t1

                          inner join t_vitesTuru on t_vitesTuru.id = t1.vitesId

                          inner join t_yakitTuru on t_yakitTuru.id = t1.yakitId

                          inner join t_Aractipi on t_Aractipi.id = t1.aractipiId";

            return Listeleme(sorgu);
        }

        public DataTable AlanListele()
        {
            string sorgu = "SELECT  id, [aciklama] FROM [t_Alanlar]";
            return Listeleme(sorgu);
        }

        public DataTable EkHizmetlerListele()
        {
            string sorgu = @"SELECT[id]
                          ,[ad]
                          ,[aciklama]
                          ,[tutar]
                          ,[gunluk]
                          , case when gunluk=1 then 'Günlük'
	                              else 'Tek seferlik'
	                              END AS odeme
                                FROM[t_EkHizmetler]";
            return Listeleme(sorgu);
        }

        public string sorguUreten(List<string> veri)
        {
            string sorgu = "";
            if (veri.Count >= 1)
            {
                sorgu += " where aciklama='" + veri[0] + "' ";
                for (int i = 1; i < veri.Count; i++)
                {
                    sorgu += " or aciklama='" + veri[i] + "' ";
                }
            }
            return sorgu;
        }

        public DataTable FiloGoruntuleSorgu(List<string> vites, List<string> yakit)
        {
            string vitesSorgusu = sorguUreten(vites);
            string yakitSorgusu = sorguUreten(yakit);

            string sorgu = @"SELECT
                        [model]
                      ,[resimyolu]
                      , t1.[aciklama]
                      ,[klima]
                      ,table1.aciklama as vites
                      ,table2.aciklama as yakit
                      ,[kapasite]
                      ,[kapi]
                      ,[yasSiniri]
                      ,[ehliyetSureSiniri]
                      ,[absOzelligi]
                      ,[yolcuairbag]
                      ,t_Aractipi.aciklama
                      From(select * FROM[AracTablosu] where  isAktif = 1) as t1
                      inner join(select* from t_vitesTuru "+vitesSorgusu+@") as table1 on table1.id = t1.vitesId
                      inner join(select* from t_yakitTuru "+yakitSorgusu+@") as table2 on table2.id = t1.yakitId
                      inner join t_Aractipi on t_Aractipi.id = t1.aractipiId";

            return Listeleme(sorgu);

        }

        public string KisiyiBul(string bilgi, string sifre)
        {
            sifre = Sifreleme.HashSHA1(sifre);
            string sorgu = @"SELECT * FROM [Kullanici] where (eposta='"+bilgi+"' or tel='"+bilgi+"' or kullaniciAdi='"+bilgi
                +"')and sifre = '"+sifre+ "' and isAktif=1";

            Baglan();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sorgu;
            komut.Connection = ok;

            SqlDataReader reader = komut.ExecuteReader();

            string kAdi = "Kullanıcı Bulunamadı";
            if (reader.Read())
            {
                kAdi = reader["kullaniciAdi"].ToString();
            }
            ok.Close();
            return kAdi;
        }

    }
}
