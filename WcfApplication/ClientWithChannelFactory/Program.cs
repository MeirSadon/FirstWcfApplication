using Newtonsoft.Json;
using PostMethodWcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientWithChannelFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentDetails studForChnnelFac = new StudentDetails
            {
                StudentName = "Chnnel",
                SAddress = "Factory",
                SDepartment = "Channel",
                SMobile = "Factory"
            };

            List<string> studForClientRequests = new List<string>
            {
                "StudentName: Or",
                "SDepartment: WebClient",
                "SAddress: Or",
                "SMobile: HttpClient"
            };
            string jsonObject = CreateJsonObject(studForClientRequests);

            #region Channel Factory
            ChannelFactory<IStudentService> channel = new ChannelFactory<IStudentService>("studentsEndpoint");
            IStudentService proxy = channel.CreateChannel();

            ///
            /// Must Run The Host With Or Before The Client.
            ///
            Console.WriteLine("Channel Factory:");
            string postWithChannelFactory = JsonConvert.SerializeObject(proxy.ReturnSameStudent(studForChnnelFac));
            Console.WriteLine($"Post With Channel Factory = {postWithChannelFactory}");

            string getWithChannelFactory = JsonConvert.SerializeObject(proxy.GetStudentParameter("ChanFac"));
            Console.WriteLine($"Get With Channel Factory = {getWithChannelFactory}");

            channel.Close();
            #endregion

            #region Web Client
            WebClient client1 = new WebClient();

            //Headers.
            client1.Headers["Content-type"] = "application/json";
            client1.Encoding = Encoding.UTF8;
            Console.WriteLine("\n\n\nWebClient:");
            // Post Method.
            string postWithWebClient = client1.UploadString("http://localhost:56811/Service1.svc/SameStudent", "POST", jsonObject);
            Console.WriteLine($"Post With Web Client = {postWithWebClient}");

            // Get Method
            string address = string.Format("http://localhost:56811/Service1.svc/GetParameter/{0}", Uri.EscapeDataString(" WebCli"));
            string getWithWebClient = client1.DownloadString(address);
            Console.WriteLine($"Get With Web Client = {getWithWebClient}");

            #endregion

            #region Http Client
            HttpClient client = new HttpClient();
            Console.WriteLine("\n\n\nHttp Client:");

            // Post Method.
            HttpContent httpContent = new StringContent(jsonObject, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("http://localhost:56811/Service1.svc/SameStudent", httpContent).Result;
            var postWithHttpClient = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"Post With Http Client = {postWithHttpClient}");

            // Get Method.
            string getWithHttpClient = client.GetStringAsync("http://localhost:56811/Service1.svc/GetParameter/ HttpCli").Result;
            Console.WriteLine($"Get With Http Client = {getWithHttpClient}");
            #endregion

            Console.ReadLine();
        }

        static string CreateJsonObject(List<string> props)
        {
            string jsonObject = "{\n";
            props.ForEach((prop) =>
            {
                jsonObject += $"\"{prop.Split(':')[0]}\": \"{prop.Split(':')[1]}\",\n";

            });
            jsonObject.Substring(jsonObject.Length - 2);
            jsonObject += "}";
            return jsonObject;
        }
    }
}
