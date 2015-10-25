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

namespace CrimeRate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       public string getcrimerate(string zipcode)
        {
           string BASE_SITE = "http://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?includecrimedata=true&zipcode=";
           string URL = BASE_SITE + zipcode;

           HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(URL);
           HttpWebResponse httpResponse = (HttpWebResponse)httpReq.GetResponse();
           StreamReader streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream());
           string xmlData = streamReader.ReadToEnd();
           XmlReader xRead = XmlReader.Create(new StringReader(xmlData));
           StringBuilder sb = new StringBuilder();

           try
           {
               xRead.ReadToFollowing("State");
               sb.Append("Location: State:" + xRead.ReadElementContentAsString());

               xRead.ReadToFollowing("City");
               sb.AppendLine("City:" + xRead.ReadElementContentAsString());

               xRead.ReadToFollowing("ViolentCrime");
               sb.AppendLine("Violent Crime : " + xRead.ReadElementContentAsString());


               xRead.ReadToFollowing("MurderAndManslaughter");
               sb.AppendLine("Murder and man slaughter : " + xRead.ReadElementContentAsString());

               xRead.ReadToFollowing("ForcibleRape");
               sb.AppendLine("Forcible Rape : " + xRead.ReadElementContentAsString());

               xRead.ReadToFollowing("Robbery");
               sb.AppendLine("Robbery : " + xRead.ReadElementContentAsString());

               xRead.ReadToFollowing("PropertyCrime");
               sb.AppendLine("PropertyCrime : " + xRead.ReadElementContentAsString());

               xRead.ReadToFollowing("Burglary");
               sb.AppendLine("Burglary : " + xRead.ReadElementContentAsString());
               


           }
           catch(Exception)
           {
               sb.AppendLine("Enter a valid zipcode, location not found.");
           }
           return sb.ToString();
            
        }
    }
}
