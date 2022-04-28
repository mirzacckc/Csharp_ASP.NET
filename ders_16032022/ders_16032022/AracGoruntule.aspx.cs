using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_16032022
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TabloGuncelle();
                TabloPasifGuncelle();
                Session["AracGuncelleId"] = 0;

            }
        }

        public void TabloGuncelle()
        {
            Veritabani vt = new Veritabani();
            DataTable tablo = vt.AracBilgileriListele();
            GridView1.DataSource = tablo;
            GridView1.DataBind();
        }

        public void TabloPasifGuncelle()
        {
            Veritabani vt = new Veritabani();
            DataTable tablo = vt.AracBilgileriListelePasif();
            GridView2.DataSource = tablo;
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string model = txt_model.Text;
            string aciklama = txt_aciklama.Text;
            string kapasite = txt_kapasite.Text;
            string kapi = txt_kapi.Text;
            int yasSiniri = Convert.ToInt32(txt_yas.Text);
            int ehliyetSinir = Convert.ToInt32(txt_ehliyetSinir.Text);

            bool kilima = chck_kilima.Checked;

            bool abs = chck_abs.Checked;

            bool airbag = chck_airbag.Checked;

            string vitesTuru = "";
            if (DropDownList1.SelectedIndex != 0)
            {
                vitesTuru = DropDownList1.SelectedValue;
            }

            string yakitTuru = "";
            if (DropDownList2.SelectedIndex != 0)
            {
                yakitTuru = DropDownList2.SelectedValue;
            }

            string resimYolu = "";
            if (FileUpload1.HasFile)
            {
                resimYolu = "araclar/" + FileUpload1.FileName;
                //resimyolu = resimler/arkaplan.jpg
                FileUpload1.SaveAs(Server.MapPath("~/" + resimYolu));
            }

            Veritabani vt = new Veritabani();

            if (Convert.ToInt32(Session["AracGuncelleId"]) > 0)  //Güncelleme
            {
                vt.AracGuncelleme(model, aciklama, kilima, kapasite, kapi,
                    yasSiniri, ehliyetSinir, abs, airbag, vitesTuru,
                    yakitTuru, resimYolu, Convert.ToInt32(Session["AracGuncelleId"]));
                Session["AracGuncelleId"] = 0;
            }
            else if (Convert.ToInt32(Session["AracGuncelleId"]) == 0)  //Yeni Kayıt         
            {
                vt.AracKaydet(model, aciklama, kilima, kapasite,
                    kapi, yasSiniri, ehliyetSinir, abs, airbag, vitesTuru, yakitTuru, resimYolu);

            }

            TabloGuncelle();
            Temizle();

        }

        public void Temizle()
        {
            txt_aciklama.Text = "";
            txt_ehliyetSinir.Text = "";
            txt_kapasite.Text = "5";
            txt_kapi.Text = "5";
            txt_model.Text = "";
            txt_yas.Text = "21";
            chck_abs.Checked = false;
            chck_airbag.Checked = false;
            chck_kilima.Checked = false;
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Guncelle")
            {

                int index = Convert.ToInt32(e.CommandArgument);
                txt_aciklama.Text = HttpUtility.HtmlDecode(GridView1.Rows[index].Cells[5].Text);
                txt_ehliyetSinir.Text = GridView1.Rows[index].Cells[12].Text;
                txt_kapasite.Text = GridView1.Rows[index].Cells[9].Text;
                txt_kapi.Text = GridView1.Rows[index].Cells[10].Text;
                txt_model.Text = HttpUtility.HtmlDecode(GridView1.Rows[index].Cells[3].Text);
                txt_yas.Text = GridView1.Rows[index].Cells[11].Text;
                //chck_abs.Checked = false;
                //chck_airbag.Checked = false;
                //chck_kilima.Checked = false;
                if (GridView1.Rows[index].Cells[7].Text.Equals("Otomatik"))
                {
                    DropDownList1.SelectedIndex = 1;
                }
                else if (GridView1.Rows[index].Cells[7].Text.Equals("Manuel"))
                {
                    DropDownList1.SelectedIndex = 2;
                }
                if (GridView1.Rows[index].Cells[8].Text.Equals("Benzin"))
                {
                    DropDownList2.SelectedIndex = 1;
                }
                else if (GridView1.Rows[index].Cells[8].Text.Equals("LPG"))
                {
                    DropDownList2.SelectedIndex = 2;
                }
                else if (GridView1.Rows[index].Cells[8].Text.Equals("Dizel"))
                {
                    DropDownList2.SelectedIndex = 3;
                }
                else if (GridView1.Rows[index].Cells[8].Text.Equals("Hybrid"))
                {
                    DropDownList2.SelectedIndex = 4;
                }

                Session["AracGuncelleId"] = GridView1.Rows[index].Cells[2].Text;
            }
            else  //sil butonuna basılmış
            {
                Veritabani vt = new Veritabani();
                int index = Convert.ToInt32(e.CommandArgument);
                vt.AraciSil(Convert.ToInt32(GridView1.Rows[index].Cells[2].Text));
                TabloGuncelle();
                TabloPasifGuncelle();
            }

        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            Veritabani vt = new Veritabani();
            vt.SilinenAraciEkle(Convert.ToInt32(GridView2.Rows[index].Cells[1].Text));
            TabloGuncelle();
            TabloPasifGuncelle();
        }
    }
}