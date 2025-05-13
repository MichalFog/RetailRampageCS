using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DalList:IDal
    {
        public Icustomer Customer=>new Customrimplamentation();
        public Isale Sale=>new Saleimplamentation();
        public Iproduct Product=>new Productimplamentation();

    }
}
