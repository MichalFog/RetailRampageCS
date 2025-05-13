using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class CustomerImplementation : Icustomer
    {
        private static string path = @"../xml/customers.xml";
        const string CUSTOMER = "Customer";
        const string CUSTOMER_ID = "CustomerId";
        const string CUSTOMER_NAME = "CustomerName";
        const string ADDRESS = "Address";
        const string PHONE = "Phone";

        public int Create(Customer item)
        {
            XElement file =XElement.Load(path);//טעינת הקובץ XML
            object customer = file.Descendants(CUSTOMER).FirstOrDefault(c=>int.Parse(c.Element(CUSTOMER_ID).Value)==item.Tz);
            if (customer!=null)
                throw new Exception("already exist");
            file.Add(new XElement(CUSTOMER, 
                new XElement(CUSTOMER_ID ,item.Tz),
                new XElement(CUSTOMER_NAME,item.Costumer_name),
                new XElement(ADDRESS,item.Address),
                new XElement(PHONE,item.phone)));
            file.Save(path);
            return item.Tz;
        }

        public void Delete(int id)
        {
            XElement file = XElement.Load(path);//טעינת הקובץ XML
            object customer = file.Descendants(CUSTOMER).FirstOrDefault(c=>int.Parse(c.Element(CUSTOMER_ID).Value)==id);
            if (customer==null)
                throw new Exception("custumer not exist");
            file.Descendants(CUSTOMER_ID).FirstOrDefault(x => int.Parse(x.Value) == (id)).Parent.Remove();
            file.Save(path);
        }

        public Customer? Read(int id)
        {
            XElement file = XElement.Load(path);
            XElement customer = file.Descendants(CUSTOMER).FirstOrDefault(c => int.Parse(c.Element(CUSTOMER_ID).Value) == (id));
            if (customer == null)
                throw new DalNotFound("Id Not Found In Customers");

            return new Customer(int.Parse(customer.Element(CUSTOMER_ID).Value),
                                customer.Element(CUSTOMER_NAME).Value,
                                customer.Element(ADDRESS).Value,
                                customer.Element(PHONE).Value);
        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            XElement file = XElement.Load(path);
            Customer customer = ReadAll().FirstOrDefault(filter);

            if (customer == null)
                throw new DalNotFound("Customer Not Found In Customers");

            return customer;
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            XElement file = XElement.Load(path);
            List<Customer> customer = file.Descendants(CUSTOMER).Select(c => new Customer()
            {
                Tz = int.Parse(c.Element(CUSTOMER_ID).Value),
                Costumer_name = c.Element(CUSTOMER_NAME).Value,
                Address = c.Element(ADDRESS).Value,
                phone = c.Element(PHONE).Value
            }
            ).ToList();

            if (filter == null)
                return customer;

            return customer.Where(filter).ToList();
        }

        public void Update(Customer item)
        {
            XElement file = XElement.Load(path);

            Delete(item.Tz);

            file.Add(new XElement(CUSTOMER,
                new XElement(CUSTOMER_ID, item.Tz),
            new XElement(CUSTOMER_NAME, item.Costumer_name),
            new XElement(ADDRESS, item.Address),
            new XElement(PHONE, item.phone)));

            file.Save(path);
        }
    }
}
