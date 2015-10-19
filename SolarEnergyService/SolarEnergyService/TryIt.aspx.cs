using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolarEnergyService
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(TextBox1.Text) || String.IsNullOrEmpty(TextBox2.Text)))
            {
                Service1 client = new Service1();
                decimal output = client.GetSolarIntensity(Convert.ToDecimal(TextBox1.Text), Convert.ToDecimal(TextBox2.Text));
                if (output == 0)
                {
                    Label4.Text = "Please Enter Valid Co-ordinates- The coordinates entered are invalid";
                }
                else
                {
                    Label4.Text = "The annual intensity of sunlight is " + Convert.ToString(output);
                }
            }
            else
            {
                Label4.Text = "Please Enter Correct Coordinates";
            }
        }
    }
}