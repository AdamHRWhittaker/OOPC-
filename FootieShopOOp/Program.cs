using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootieShopOOp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up stock data.
            StockData stockData = new StockData();
            var stock = stockData.GenerateStockData();
            StockManager stockManager = new StockManager(stock);

            //Get info to display to the user on the front end.
            var clubs = Enum.GetValues(typeof(Club)).Cast<Club>();
            var shirtQuantityResponseList = new List<ShirtQuantityResponse>();
            foreach (var club in clubs)
            {
                var shirtQuantity = stockManager.GetShirtQuantity(club);
                var shirtQuantityResponse = new ShirtQuantityResponse {
                    Club = club,
                    Quantity = shirtQuantity
                };

                shirtQuantityResponseList.Add(shirtQuantityResponse);
            }


            //Replicate somebody adding an item to the basket.

            Basket basket = new Basket();
            Kits shirt = new Shirt();

            basket.Add(shirt);
            stockManager.RemoveStock();






        }


    }

    public class ShirtQuantityResponse {
        public int Quantity { get; set; }
        public Club Club { get; set; }
    }

}
