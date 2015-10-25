using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Xml;
using System.Text;

namespace NaturalHazards
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (TextBox1.Text == String.Empty || TextBox2.Text == String.Empty)
            {
                Label2.Text =  "Please Enter Valid Inputs";
                return;
            }
            String BASE_SITE = "http://webstrar15.fulton.asu.edu/page6/Service1.svc/getearthquakeprob?zip=";
            String PARAM = TextBox1.Text + "&radius=" + TextBox2.Text;
          
            String URL = BASE_SITE + PARAM;
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(URL);

            HttpWebResponse httpResponse = (HttpWebResponse)httpReq.GetResponse();

            StreamReader streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream());

            string xmlData = streamReader.ReadToEnd();
            
            
            XmlReader xRead = XmlReader.Create(new StringReader(xmlData));
            string city;
            
            xRead.ReadToFollowing("city");
            city = xRead.ReadElementContentAsString();
            if (city == String.Empty)
            {
                Label2.Text = "Location not found, Enter Valid Location";
                return;
            }
            sb.AppendLine("Location: " + city);
            sb.AppendLine("<br/>");

            xRead = XmlReader.Create(new StringReader(xmlData));
            xRead.ReadToFollowing("probability");
            sb.AppendLine("The probability of earthquake is :" + xRead.ReadElementContentAsString());

            Label2.Text = sb.ToString();
        }
    }
}