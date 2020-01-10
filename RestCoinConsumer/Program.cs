using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestCoinConsumer
{
    class Program
    {
        private static string CoinUri = "https://localhost:44340/api/Coin/";

        static void Main(string[] args)
        {
            HttpRequests();

            Console.ReadKey();
        }

        public static async void HttpRequests()
        {
            Console.WriteLine("GET ALL COINS REQUEST");
            List<Coin> coinList = GetCoinsAsync().Result;

            foreach (Coin coin in coinList)
            {
                Console.WriteLine(coin);
            }

            Console.WriteLine();
            Console.WriteLine("GET ONE COIN REQUEST");

            Coin getOneCoin = GetOneCoinAsync(4).Result;
            Console.WriteLine("Coin to get: " + getOneCoin);
        }

        public static async Task<List<Coin>> GetCoinsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(CoinUri);
                List<Coin> cList = JsonConvert.DeserializeObject<List<Coin>>(content);
                return cList;
            }
        }

        public static async Task<Coin> GetOneCoinAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(CoinUri + id);
                Coin coin = JsonConvert.DeserializeObject<Coin>(content);
                return coin;
            }
        }
    }
}
