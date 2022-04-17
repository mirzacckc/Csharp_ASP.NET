using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_26012022
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //string ad = TextBox1.Text;

            if (DropDownList1.SelectedIndex == 0)
            {
                lbl_sonuc.Text = "Hoşgeldiniz " + TextBox1.Text + " Hanım";
                lbl_sonuc.CssClass = "alert alert-danger";
            }
            else
            {
                lbl_sonuc.Text = "Hoşgeldiniz " + TextBox1.Text + " Bey";
                lbl_sonuc.CssClass = "alert alert-primary";
            }
        }
    }
}