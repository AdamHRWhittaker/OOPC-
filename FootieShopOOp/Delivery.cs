using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootieShopOOp
{
    class Delivery
    {
        public DeliveryType DeliveryType { get; set; }

        public decimal GetDeliveryPrice()
        {
            switch (DeliveryType)
            {
                case DeliveryType.NextDay:
                    return 6.95M;
                case DeliveryType.Standard:
                    return 3.00M;
                default:
                    return 3.00M;
            }
        }
    }

    public enum DeliveryType
    {
        NextDay,
        Standard
    }


}
