using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_16032022
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Veritabani vt = new Veritabani();
                DataTable tablo = vt.FiloGoruntule();
                Repeater1.DataSource = tablo;
                Repeater1.DataBind();
            }
        }
    }
}