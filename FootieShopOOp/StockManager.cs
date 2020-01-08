using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootieShopOOp
{
    public class StockManager
    {
        public int KitQuantity { get; set; }

        public int ShirtQuantity { get; set; }
        public int ShortQuantity { get; set; }
        public int SocksQuantity { get; set; }

        Stock _stock = null;
        public StockManager(Stock stock)
        {
            _stock = stock;
        }

        public bool AddStock() {
            return true;
        }

        public bool RemoveStock(Kits item){
            var itemType = item.GetType().ToString();
            Stock filterdList = (Stock)_stock.GetType().GetProperty(itemType).GetValue(_stock, null);

        }

        public bool UpdateStock() {
            return true;
        }

        public bool InsertStock() {
            return true;
        }

        public int GetShirtQuantity(Club club)
        {
             return _stock.Shirt.Where(s => s.Club == club).Count();
        }
    }
}
