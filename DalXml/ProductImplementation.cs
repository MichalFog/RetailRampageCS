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
    internal class ProductImplementation : Iproduct
    {
        private static string filePath = @"../xml/products.xml";
        private XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        private List<Product> products;
        public int Create(Product item)
        {
            int index = Config.IndexProductId;
            products = ReadAll();
            products.Add(new Product(index,
                                            item.product_name,
                                            item.category,
                                            item.price,
                                            item.amount));

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, products);
            }
            return index;
        }

        public void Delete(int id)
        {
            Product curProduct = Read(id);
            products = ReadAll();
            products.Remove(curProduct);
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, products);
            }
        }

        public Product? Read(int id)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                products = ReadAll();
                Product product = products.FirstOrDefault(s => s.id == id);
                if (product == null)
                    throw new DalNotFound("Id Not Found In Products");
                return product;
            }
        }

        public Product? Read(Func<Product, bool> filtre)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                products = ReadAll();
                Product product = products.FirstOrDefault(filtre);
                if (product == null)
                    throw new DalNotFound("Product Not Found In Products");
                return product;
            }
        }

        //public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        //{
        //    using (StreamReader sr = new StreamReader(filePath))
        //    {
        //        products = serializer.Deserialize(sr) as List<Product>;
        //        if (filter == null)
        //            return products;
        //        return products.Where(filter).ToList();
        //    }
        //}

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            if (!File.Exists(filePath))
                return new List<Product?>(); // או לזרוק חריגה

            using (StreamReader sr = new StreamReader(filePath))
            {
                try
                {
                    var deserialized = serializer.Deserialize(sr);
                    products = deserialized as List<Product>;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("שגיאה בקריאת הקובץ: " + ex.Message);
                    return new List<Product?>(); // או טיפול חריגה אחר
                }

                if (products == null)
                    return new List<Product?>();

                return filter == null ? products : products.Where(filter).ToList();
            }
        }


        public void Update(Product item)
        {
            Delete(item.id);
            products = ReadAll();
            products.Add(new Product(item.id, item.product_name, item.category, item.price, item.amount));
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, products);
            }
        }
    }
}
