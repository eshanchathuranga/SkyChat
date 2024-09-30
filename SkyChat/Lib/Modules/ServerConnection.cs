using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace SkyChat.Lib.Modules
{
    internal class ServerConnection
    {
        public ServerConnection() { }

        public async Task<string> PostDataAsync(string routName, string data)
        {
            try
            {
                string url = $"http://localhost:3000/{routName}";
                using (HttpClient client = new HttpClient())
                {
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Data posted successfully
                        string responseData = await response.Content.ReadAsStringAsync();
                        return responseData;
                    }
                    else
                    {
                        // Handle error
                        return null;
                    }
                }
            } catch (Exception ex)
            {
                return null;

            }
        }

        // Post params data to the server
       
    }
}
