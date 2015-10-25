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

namespace NaturalHazards
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public ObjectClass getearthquakeprob(string zip, string radius)
        {
                string BASE_SITE = "http://api.openhazards.com/GetEarthquakeProbability?q=";
                string URL = BASE_SITE + zip + "&r=" + radius;
                
                HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(URL);

                HttpWebResponse httpResponse = (HttpWebResponse)httpReq.GetResponse();

                StreamReader streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream());

                string xmlData = streamReader.ReadToEnd();

                XmlReader xRead = XmlReader.Create(new StringReader(xmlData));
                StringBuilder sb = new StringBuilder();
                ObjectClass obj = new ObjectClass();
   
            try{
                xRead.ReadToFollowing("location");
                xRead.ReadToFollowing("place");
                obj.city = xRead.ReadElementContentAsString();

                xRead.ReadToFollowing("forecast");
                xRead.ReadToFollowing("prob");

                obj.probability = xRead.ReadElementContentAsString();
            }
            catch(Exception)
            {
                obj.city = null;
                obj.probability = null;
             
            }

            return obj;
        }
    }
}
