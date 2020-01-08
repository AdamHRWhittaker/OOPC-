using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootieShopOOp
{
    public class Stock
    {
        public IList<Shirt> Shirt { get; set; }
        public IList<Shorts> Shorts { get; set; }
        public IList<Socks> Socks { get; set; }
    }
}
