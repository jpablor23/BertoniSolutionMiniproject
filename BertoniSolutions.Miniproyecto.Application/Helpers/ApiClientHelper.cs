using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BertoniSolutions.Miniproyecto.Application.Helpers
{
    public class ApiClientHelper
    {
        public static async Task<IEnumerable<T>> GetAll<T>(string url)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            client.DefaultRequestHeaders.Add("user-agent", "Bertoni Solutions - Miniproyecto");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var contentText = await response.Content.ReadAsStringAsync();
            var items = JsonConvert.DeserializeObject<T[]>(contentText);

            return items;
        }
    }
}
