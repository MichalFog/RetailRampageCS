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
    }
}
