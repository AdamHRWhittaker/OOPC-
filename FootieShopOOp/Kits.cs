using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootieShopOOp
{
    public abstract class Kits
    {
        public int KitNumber { get; set; }
        public Club Club { get; set; }
        public string PlayerName { get; set; }
        public ShirtSize ShirtSize { get; set; } //will use decorator design pattern
        public virtual decimal Price { get; set; }
    }

    public class Shirt : Kits {
        //public Club Club { get; set; }
        //public string PlayerName { get; set; }
        //public ShirtSize ShirtSize { get; set; } //will use decorator design pattern
        public override decimal Price { get; set; }

    }

    public class Shorts : Kits {
        //public Club Club { get; set; }
        public override decimal Price { get; set; }
        //public ShortSize ShortSize { get; set; }
    }

    public class Socks : Kits {
        //public Club Club { get; set; }
        public override decimal Price { get; set; }
        //public SockSize SockSize { get; set; }

    }

    public enum Club {
        Chelsea,
        Liverpool,
        ManU,
        ManCity
    }

    public enum ShirtSize {
        XS,
        S,
        M,
        L,
        XL,
        XXL,
        XXXL
    }

    public enum ShortSize
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL,
        XXXL
    }

    public enum KitType {
        Home,
        Away,
        Alternative
    }

    public enum SockSize {
        XS,
        S,
        M,
        L,
        XL
    }













}

