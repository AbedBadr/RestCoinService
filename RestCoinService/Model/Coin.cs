using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCoinService.Model
{
    public class Coin
    {
        public int Id { get; set; }
        public string Genstand { get; set; }
        public int Bud { get; set; }
        public string Navn
        {
            get { return Navn; }
            set
            {
                if (string.IsNullOrEmpty(Navn))
                {
                    Navn = "Auction";
                }

                Navn = value;
            }
        }

        public Coin(int id, string genstand, int bud, string navn)
        {
            Id = id;
            Genstand = genstand;
            Bud = bud;
            Navn = navn;
        }

        public Coin()
        {
            
        }
    }
}
