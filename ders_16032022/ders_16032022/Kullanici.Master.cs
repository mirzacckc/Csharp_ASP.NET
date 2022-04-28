using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_16032022
{
    public partial class Kullanici : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"]!=null)
            {
                lbl_user.Visible = true;
                lbl_user.Text = Session["KullaniciAdi"].ToString();
                btn_giris.Text = "Çıkış Yap";
            }
            else
            {
                lbl_user.Visible = false;
            }
        }
    }
}