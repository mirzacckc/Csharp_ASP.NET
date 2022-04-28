using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_16032022
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string machineName = HttpContext.Current.Server.MachineName;
            //Response.Write(machineName+" Makine Adı");

            if (!IsPostBack)
            {
                Veritabani vt = new Veritabani();
                DataTable dt = vt.VitesListele();
                rpter_vites.DataSource = dt;
                rpter_vites.DataBind();

                rpter_yakit.DataSource = vt.YakitTuruListele();
                rpter_yakit.DataBind();

                rpter_araclar.DataSource = vt.FiloGoruntule();
                rpter_araclar.DataBind();

            }
        }

        protected void btn_ara_Click(object sender, EventArgs e)
        {
            lbl_uyari.Visible = false;
            int min = 0, max = 0;
            if (txt_min.Text!=null && txt_min.Text!="")
            {
               min = Convert.ToInt32(txt_min.Text);
            }
            if (txt_max.Text != null && txt_max.Text != "")
            {
               max = Convert.ToInt32(txt_max.Text );
            }
            List<string> vitesSecilen = new List<string>();
            List<string> yakitSecilen = new List<string>();
            for (int i = 0; i < rpter_vites.Items.Count; i++)
            {
                CheckBox ch = rpter_vites.Items[i].FindControl("CheckBox1") as CheckBox;
                if (ch.Checked)
                {
                    vitesSecilen.Add(ch.Text);
                }
            }
            for (int i = 0; i < rpter_yakit.Items.Count; i++)
            {
                CheckBox ch = rpter_yakit.Items[i].FindControl("CheckBox2") as CheckBox;
                if (ch.Checked)
                {
                    yakitSecilen.Add(ch.Text);
                }
            }
            Veritabani vt = new Veritabani();
            rpter_araclar.DataSource = vt.FiloGoruntuleSorgu(vitesSecilen, yakitSecilen);
            rpter_araclar.DataBind();

            if (rpter_araclar.Items.Count == 0)
            {
                lbl_uyari.Text = "Sonuç Bulunamadı ";
                lbl_uyari.Visible = true;

            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string alisadresi = DropDownList1.SelectedValue;
            string alisTarihi = txt_alisTarihi.Text;
            string teslimTarihi = txt_teslimTarhi.Text;
            Session["secimBigisi"] = alisadresi + ", " + alisTarihi + " , " + teslimTarihi;
            Response.Redirect("SecimSayfasi.aspx");

        }
    }
}