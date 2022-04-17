using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ders_14012022
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                ListBox1.Items.Add(Convert.ToString(i));
            }

            int k = 100;
            while (k >= 0)
            {
                if (k % 3 == 0)
                {
                    ListBox2.Items.Add("" + k);
                }

                k -= 2;
            }

            int t = 1;

            do
            {
                ListBox3.Items.Add(t.ToString());

                t += 2;
            } while (t <= 100);
        }
    }
}