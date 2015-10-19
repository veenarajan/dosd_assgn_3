using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FindNearestStore
{
    public partial class TryIt1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1 client = new Service1();
            string result = client.findneareststore(TextBox2.Text, TextBox1.Text);
            Label3.Text = result.Replace(Environment.NewLine, "<br />");
        }
    }
}