using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
namespace test
{
    class Money
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
           
            var url = @"http://ins-info.ib.gov.tw/opendata/json-05010111.aspx";
            var jsonString = ""; 
            
            using (var webclient = new System.Net.WebClient())
            {
                webclient.Encoding = Encoding.UTF8;
                jsonString = webclient.DownloadString(url);
            }

            JArray jobject = JArray.Parse(jsonString);

            foreach (JObject Jobj in jobject)
            {
                
                Console.Write("INSURER_Name : " + Jobj["INSURER_Name"].ToString() + "\n" +
                              "EstablishDate : " + Jobj["EstablishDate"].ToString() + "\n" +
                              "ManagerName1 : " + Jobj["ManagerName1"].ToString() + "\n" +
                              "ManagerName2 : " + Jobj["ManagerName2"].ToString() + "\n" +
                              "Tel : " + Jobj["Tel"].ToString() + "\n" +
                              "Fax : " + Jobj["Fax"].ToString() + "\n" +
                              "FreeLine : " + Jobj["FreeLine"].ToString() + "\n" +
                              "Address : " + Jobj["Address"].ToString() + "\n" +
                              "WebAddress : " + Jobj["WebAddress"].ToString() + "\n" +
                              "Email : " + Jobj["Email"].ToString() + "\n"
                              );
                Console.WriteLine("--------------------------------\n");
            }


            Console.Read();

        }
    }
}
