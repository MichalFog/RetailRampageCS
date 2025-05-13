using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        private double? price_sale1;
        private double? price_sale2;

        public int id { get; init; }
        public int product_id { get; init; }
        public double? price_sale { get; set; }
        public int? amount_for_sale { get; set; }
        public bool? for_who { get; set; }
        public DateTime? start_sale { get; set; }
        public DateTime? end_sale { get; set; }

        public Sale(int id,int product_id,double price_sale,int amount,bool for_who, DateTime start_sale, DateTime end_sale)
        {
            this.id = id;
            this.product_id = product_id;
            this.price_sale = price_sale;
            this.amount_for_sale = amount;
            this.for_who = for_who;
            this.start_sale = start_sale;
            this.end_sale = end_sale;
        }

        public Sale(int id, double? price_sale1, int? amount_for_sale, bool? for_who, DateTime? start_sale, double? price_sale2)
        {
            this.id = id;
            this.price_sale1 = price_sale1;
            this.amount_for_sale = amount_for_sale;
            this.for_who = for_who;
            this.start_sale = start_sale;
            this.price_sale2 = price_sale2;
        }
    }
}
