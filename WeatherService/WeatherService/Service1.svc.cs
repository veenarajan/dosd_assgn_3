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
namespace WeatherService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string get5dayweather(string location_zipcode)
        {
            string APIKEY = "99179e84c6e032b89141533f097ff0cb";

            string BASE_SITE = "http://api.openweathermap.org/data/2.5/forecast/daily?";
            string param = "zip="+location_zipcode+"&mode=xml&units=metric&cnt=5&APPID=" + APIKEY;

            string URL = BASE_SITE + param;

            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(URL);
           
            HttpWebResponse httpResponse = (HttpWebResponse)httpReq.GetResponse();
            
            StreamReader streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream());
            
            string xmlData = streamReader.ReadToEnd();
            
            XmlReader xRead = XmlReader.Create(new StringReader(xmlData));
            
            StringBuilder sb = new StringBuilder();
            try
            {
                xRead.ReadToFollowing("location");
                xRead.ReadToFollowing("name");
                sb.AppendLine("Location : " + xRead.ReadElementContentAsString());

                xRead.ReadToFollowing("forecast");
                for (int i = 0; i < 5; i++)
                {
                    xRead.ReadToFollowing("time");
                    sb.AppendLine("Date : " + xRead.GetAttribute("day"));

                    xRead.ReadToFollowing("windSpeed");
                    sb.AppendLine("The wind speed : " + xRead.GetAttribute("name"));
                    xRead.ReadToFollowing("temperature");
                    sb.AppendLine("Average Temperature is : " + xRead.GetAttribute("day") + " Min : " + xRead.GetAttribute("min")
                        + " Max :  " + xRead.GetAttribute("max"));

                    xRead.ReadToFollowing("humidity");
                    sb.AppendLine("Humidity (%):" + xRead.GetAttribute("value"));

                    xRead.ReadToFollowing("clouds");
                    sb.AppendLine("Clouds :" + xRead.GetAttribute("value"));

                    sb.AppendLine("<br />");
                }
            }
            catch(Exception)
            {
                sb.Append("Please Enter Valid Zip Code");
            }


            return sb.ToString();

        }
    }
}
