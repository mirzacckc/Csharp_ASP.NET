using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_14012022
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string secilenMenu = e.Item.Value;    //secilen itemin value degerini secilen Menu degiskenine atar

            if (secilenMenu == "mesaj")
            {
                Response.Redirect("mesaj.aspx");
            }
            else if (secilenMenu == "hakkimizda")
            {
                Response.Redirect("Hakkimizda.aspx");
            }
            else
            {
                Response.Redirect("default.aspx");

            }
        }
    }
}