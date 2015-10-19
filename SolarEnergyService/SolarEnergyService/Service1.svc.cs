using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Net;
using System.Xml;

namespace SolarEnergyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public decimal GetSolarIntensity(decimal latitude, decimal longitude)
        {
            decimal Intensity = 0;
            string URL = "http://developer.nrel.gov/api/solar/solar_resource/v1.xml?api_key=DEMO_KEY&lat=" + latitude + "&lon=" + longitude;
            
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(URL);
            
            HttpWebResponse httpResponse = (HttpWebResponse)httpReq.GetResponse();
            
            StreamReader streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream());
            
            string xmlData = streamReader.ReadToEnd();
            
            XmlReader xRead = XmlReader.Create(new StringReader(xmlData));
            try
            {
                xRead.ReadToFollowing("avg-dni");

                if ((xRead.NodeType == XmlNodeType.Element) && (xRead.NodeType != XmlNodeType.EndElement))
                {
                    xRead.ReadToFollowing("annual");
                    Intensity = Convert.ToDecimal(xRead.ReadString());
                }
            }
            catch(Exception)
            {
                Intensity = 0;
            }
            
            return Intensity;

        }

    }
}
