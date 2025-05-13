using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal static class Tools
    {

        public static BO.Customer ConvertCustomerToBO(DO.Customer customer)
        {
            return new BO.Customer(customer.Tz, customer.Costumer_name, customer.Address, customer.phone);
        }

        public static DO.Customer ConvertToCustomerDO(BO.Customer customer)
        {
            return new DO.Customer(customer.Tz, customer.Costumer_name, customer.Address, customer.phone);
        }

        public static BO.Sale ConvertSaleToBO(DO.Sale sale)
        {
            return new BO.Sale(sale.id, sale.price_sale, sale.amount_for_sale, sale.for_who, sale.start_sale, sale.price_sale);
        }
        public static DO.Sale ConvertSaleToDO(BO.Sale sale)
        {
            return new DO.Sale(sale.id,sale.product_id, sale.amount_for_sale, sale.price_sale, sale.for_who, sale.start_sale, sale.end_sale);
        }

        public static BO.Product ConvertProductToBO(DO.Product product)
        {
            return new BO.Product(product.id, product.product_name, product.price, product.amount, (BO.Category)product.category);
        }
        public static DO.Product ConvertProductToDO(BO.Product product)
        {
            return new DO.Product(product.id, product.product_name, (DO.Category)product.category, product.price, product.amount);
        }
        public static string ToStringProperty<T>(this T obj)
        {
            StringBuilder sb = new StringBuilder();
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (var property in properties)
            {
                object value = property.GetValue(obj);
                if (value != null)
                {
                    if (value is IEnumerable<object> enumerableValue)
                    {
                        sb.AppendLine($"{property.Name}: [{string.Join(", ", enumerableValue)}]");
                    }
                    else
                    {
                        sb.AppendLine($"{property.Name}: {value}");
                    }
                }
                else
                {
                    sb.AppendLine($"{property.Name}: null");
                }
            }
            return sb.ToString();
        }

    }
}
