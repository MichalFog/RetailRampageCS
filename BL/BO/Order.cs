using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool prefer { get; set; }
        public List<BO.ProductInOrder> products { get; set; }
        public double finalPrice { get; set; }
        public Order()
        {
            prefer = false;
            products = new List<BO.ProductInOrder>();
            finalPrice = 0;
        }
        public Order(bool prefer)
        {
            this.prefer = prefer;
            products = new List<BO.ProductInOrder>();
            finalPrice = 0;
        }
    }
}
