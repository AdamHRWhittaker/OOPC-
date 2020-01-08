using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootieShopOOp
{
    public class StockData
    {
        private Stock _stock = null;

        public StockData()
        {
          
        }

        public Stock GenerateStockData()
        {
            _stock = new Stock
            {
                Shirt = GenerateShirtData(),
                Shorts = GenerateShortsData(),
                Socks = GenerateSocksData()
            };

            return _stock;
        }

        private IList<Shirt> GenerateShirtData()
        {
            Random randomNumber = new Random();
            var shirtList = new List<Shirt>();
            for (int i = 0; i < 10; i++)
            {
                var shirt = new Shirt
                {
                    ShirtSize = (ShirtSize)randomNumber.Next(0, 6),
                    Club = (Club)randomNumber.Next(0, 3),
                    Price = 79.99M
                };

                shirtList.Add(shirt);
            }

            return shirtList;
        }

        private IList<Shorts> GenerateShortsData() {

            Random randomNumber = new Random();
            var shortsList = new List<Shorts>();
            for (int i = 0; i < 12; i++)
            {
                var shorts = new Shorts
                {
                    ShortSize = (ShortSize)randomNumber.Next(0, 6),
                    Club = (Club)randomNumber.Next(0, 3),
                    Price = 33.00M
                };

                shortsList.Add(shorts);
            }

            return shortsList;

        }

        private IList<Socks> GenerateSocksData()
        {
            Random randomNumber = new Random();
            var socksList = new List<Socks>();
            for (int i = 0; i < 15; i++) {
                var socks = new Socks
                {
                    SockSize = (SockSize)randomNumber.Next(0, 4),
                    Club = (Club)randomNumber.Next(0, 3),
                    Price = 15.99M
                };
                socksList.Add(socks);
            }

            return socksList;
        }

    }
}
