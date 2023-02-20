using System.Net.Http.Headers;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace protfolio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apiKey = "your_api_key_here";
            var apiSecret = "your_api_secret_here";
            var url = "https://api.coinbase.com/v2/user";
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            httpClient.DefaultRequestHeaders.Add("CB-ACCESS-SIGN", apiSecret);
            httpClient.DefaultRequestHeaders.Add("CB-ACCESS-TIMESTAMP", DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString());
            httpClient.DefaultRequestHeaders.Add("CB-ACCESS-PASSPHRASE", "your_passphrase_here");

            var response = httpClient.GetAsync(url).Result;
            var responseBody = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseBody);
        }
    }
}
