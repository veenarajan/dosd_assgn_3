using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrimeRate
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1 client = new Service1();
            string res = client.getcrimerate(TextBox1.Text);
            Label2.Text = res.Replace(Environment.NewLine, "<br />");
        }
    }
}