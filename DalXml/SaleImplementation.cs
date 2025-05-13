using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal
{
    internal class SaleImplementation : Isale
    {
        private static string filePath = @"../xml/sales.xml";
        private XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        private List<Sale> sales;
        public int Create(Sale item)
        {
            int index = Config.IndexSaleId;
            sales = ReadAll();
            sales.Add(new Sale(index,
                                            item.product_id,
                                            item.amount_for_sale,
                                            item.price_sale,
                                            item.for_who,
                                            item.start_sale,
                                            item.end_sale));
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, sales);
            }
            return index;
        }

        public void Delete(int id)
        {
            Sale curSale = Read(id);
            sales = ReadAll();
            sales.Remove(curSale);
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, sales);
            }
        }

        public Sale? Read(int id)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                sales = ReadAll();
                Sale sale = sales.FirstOrDefault(s => s.id == id);
                if (sale == null)
                    throw new DalNotFound("Id Not Found In Sales");
                return sale;
            }
        }

        public Sale? Read(Func<Sale, bool> filtre)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                sales = ReadAll();
                Sale sale = sales.FirstOrDefault(filtre);
                if (sale == null)
                    throw new DalNotFound("Sale Not Found In Sales");
                return sale;
            }
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                sales = serializer.Deserialize(sr) as List<Sale>;
                if (filter == null)
                    return sales;

                return sales.Where(filter).ToList();
            }
        }

        public void Update(Sale item)
        {
            Delete(item.id);
            sales = ReadAll();
            sales.Add(new Sale(item.id, item.product_id, item.amount_for_sale, item.price_sale, item.for_who, item.start_sale, item.end_sale));
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, sales);
            }
        }
    }
}
