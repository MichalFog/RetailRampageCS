using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;

namespace Dal
{
    internal sealed class DalXml : IDal
    {
        private static DalXml instance { get; } = new DalXml();
        public static DalXml Instance
        {
            get
            {
                return instance;
            }
        }
        public Icustomer Customer => new CustomerImplementation();

        public Iproduct Product => new ProductImplementation();

        public Isale Sale => new SaleImplementation();
        private DalXml()
        {
        }
    }
}
