using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCoinService.Model;

namespace RestCoinService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinController : ControllerBase
    {
        static List<Coin> coinList = new List<Coin>()
        {
            new Coin(1, "Gold DK 1640", 2500, "Mike"),
            new Coin(2, "Gold NL 1764", 5000, "Anbo"),
            new Coin(3, "Gold FR 1644", 35000, "Hammer"),
            new Coin(4, "Gold FR 1644", 0, "Auction"),
            new Coin(5, "Silver GR 333", 2500, "Mike")
        };

        // GET: api/Coin
        [HttpGet]
        public IEnumerable<Coin> GetCoins()
        {
            return coinList;
        }

        // GET: api/Coin/5
        [HttpGet("{id}")]
        public Coin GetOneCoin(int id)
        {
            return coinList.Find(c => c.Id == id);
        }

        // POST: api/Coin
        [HttpPost]
        public void Post(Coin newCoin)
        {
            coinList.Add(newCoin);
        }
    }
}
