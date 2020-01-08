using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootieShopOOp
{
    class Basket
    {
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
        public Delivery Delivery { get; set; }
        public IList<Kits> Items { get; set; }

        public void Add(Kits item)
        {
            Items.Add(item);
        }
    }
}
