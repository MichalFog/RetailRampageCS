using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int id { get; set; }
        public int amount { get; set; }
        public double price { get; set; }
        public bool for_who { get; set; }
        public SaleInProduct(int id, int amount, double price, bool for_who)
        {
            this.id = id;
            this.amount = amount;
            this.price = price;
            this.for_who = for_who;
        }
    }
}
