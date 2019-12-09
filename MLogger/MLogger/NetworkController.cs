using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MLogger
{
    class NetworkController
    {
        public static async Task SendUserDataAsync()
        {
            HttpClient client = new HttpClient();

            object userObject = new
            {
                timeStamp = DateTime.Now.ToUniversalTime().ToString() ,
                macAddress = SystemDetails.GetMAC(),
                systemInfo = SystemDetails.GetSystemInfo() 
            };

            string jsonContent = JsonConvert.SerializeObject(userObject);

            var request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:8080/user");
            request.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.SendAsync(request);

            Console.WriteLine(await response.Content.ReadAsStringAsync());

            client.Dispose();

        }
    }
}
