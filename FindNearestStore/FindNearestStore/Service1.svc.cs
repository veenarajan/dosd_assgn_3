using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SimpleOAuth;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Json;

namespace FindNearestStore
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string findneareststore(string location_zipcode, string storeName)
        {
            String CONSUMER_KEY = "pUTMgIxveWvWbKTzaH8sAA";
            String CONSUMER_SECRET = "gFNrbj3C9JuYGZGyO-XRADBjsDI";
            String TOKEN = "nYHQC0lfIKOn0PMco3UqZ1qZnw3ine4f";
            String TOKEN_SECRET = "8WIMc2NWG7JSU0-ONZ0IyhRqz1o";
           
            string BASE_SITE = "http://api.yelp.com";

            string SEARCH_EXTENSION = "/v2/search/";
            string URL = BASE_SITE + SEARCH_EXTENSION;

            var query = System.Web.HttpUtility.ParseQueryString(String.Empty);
            
            query["term"] = storeName;

            query["location"] = location_zipcode;
          
            query["limit"] = "5";


            UriBuilder uriBuilder = new UriBuilder(URL);
           
            uriBuilder.Query = query.ToString();

            var request = WebRequest.Create(uriBuilder.ToString());
            request.Method = "GET";

            request.SignRequest(
                new Tokens
                {
                    ConsumerKey = CONSUMER_KEY,
                    ConsumerSecret = CONSUMER_SECRET,
                    AccessToken = TOKEN,
                    AccessTokenSecret = TOKEN_SECRET
                }
            ).WithEncryption(EncryptionMethod.HMACSHA1).InHeader();

            HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
       
            StreamReader readerobj = new System.IO.StreamReader(resp.GetResponseStream(), Encoding.UTF8);
            
            string json = readerobj.ReadToEnd();

            JObject result = JObject.Parse(json);
           
            StringBuilder sb = new StringBuilder();

            int i = 0;
       
            sb.AppendLine("Store name :" + result["businesses"][0]["name"]);
            
            while(i<5)
            {
                if (result["businesses"][i] != null)
                {
                    
                    sb.Append("Store Address :" + result["businesses"][i]["location"]["display_address"]);
                    sb.AppendLine("<br/>");
                }

                i++;
            }

            return sb.ToString();

        }
    }
}
