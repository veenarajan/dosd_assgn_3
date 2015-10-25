using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Json;

namespace CurrencyConverter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string currencyconverter(string currency, string amount)
        {
            String URL = "http://www.apilayer.net/api/live?access_key=acfce3ec71e8089b0a81b1f3b5d5d3c0&format=1";
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(URL);

            HttpWebResponse httpResponse = (HttpWebResponse)httpReq.GetResponse();

            StreamReader streamReader = new System.IO.StreamReader(httpResponse.GetResponseStream());

            string json_str = streamReader.ReadToEnd();
            JObject res = JObject.Parse(json_str);

            if (currency == String.Empty || amount == String.Empty)
            {
                return "Please Enter Valid inputs";
            }

            try
            {
                string r = res["quotes"][("USD" + currency).ToString()].ToString();
                double rate = ((1.0) / Convert.ToDouble(r)) * Convert.ToDouble(amount);
                return (rate.ToString("#.000") + "USD");
            }
            catch(Exception)
            {
                return "Please Enter Valid Input";
            }
        }
    }
}
