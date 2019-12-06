using MLogger.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MLogger
{
    class NetworkController
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task SendUserDataAsync()
        {
            var values = new Dictionary<string, string>
            {
                { "timeStamp", "1" },
                { "macAddress", "2" },
                { "systemInfo", "3" }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://localhost:8080/user", content);

            var responseString = await response.Content.ReadAsStringAsync();

        }
    }
}
