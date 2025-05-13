using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public int id { get; set; }
        public string? product_name { get; set; }
        public double? price { get; set; }
        public int? amount { get; set; }
        public Category? category { get; set; }
        public List<BO.SaleInProduct> sales { get; set; }

        public Product(int id, string? product_name, double? price, int? amount, Category? category)
        {
            this.id = id;
            this.product_name = product_name;
            this.price = price;
            this.amount = amount;
            this.category = category;
            this.sales = new List<SaleInProduct>();
        }
        public Product()
        {
            this.id = id;
            this.product_name = product_name;
            this.price = price;
            this.amount = amount;
            this.category = category;
            this.sales = new List<SaleInProduct>();
        }
    }
}
