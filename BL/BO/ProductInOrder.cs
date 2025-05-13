using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int id { get; init; }
        public string name { get; set; }
        public double basePrice { get; set; }
        public int amount { get; set; }
        public List<BO.SaleInProduct> sales { get; set; }
        public double finalPrice { get; set; }
        public ProductInOrder(int id, string name, double basePrice, int amount, List<BO.SaleInProduct> sales, double finalPrice)
        {
            this.id = id;
            this.name = name;
            this.basePrice = basePrice;
            this.amount = amount;
            this.sales = sales;
            this.finalPrice = finalPrice;
        }

    }
}
