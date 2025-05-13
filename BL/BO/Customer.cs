using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Customer
    {
        public int Tz { get; init; }
        public string? Costumer_name { get; set; }
        public string? Address { get; set; }
        public string? phone { get; set; }

        public Customer(int Tz,string Costumer_name,string Address,string phone)
        {
            this.Tz = Tz;
            this.Costumer_name = Costumer_name;
            this.Address = Address;
            this.phone = phone;
        }
    }
}
