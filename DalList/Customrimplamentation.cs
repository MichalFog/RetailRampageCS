namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using Tools;
using System.Reflection;

internal class Customrimplamentation : Icustomer
{
    public int Create(Customer item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"insert customer in id:{item.Tz}");
        Customer curCustomer = DataSource.customers.FirstOrDefault(customer => customer.Tz == item.Tz);
        if (curCustomer != null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "This customer exists in this Tz");
            throw new DalIdExsist("Already exists");
        }

        DataSource.customers.Add(item);
        return item.Tz;
    }
    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete customer in id:{id}");
        DataSource.customers.Remove(Read(id));
    }

    public void Update(Customer item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update customer in id:{item.Tz}");
        Delete(item.Tz);
        DataSource.customers.Add(item);
    }
    public Customer? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read customer in id: {id}");
        Customer curCustomer = DataSource.customers.FirstOrDefault(customer => customer.Tz == id);
        if (curCustomer == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"not found  customer in this id: {id}");
            throw new DalNotFound("Customer not found");
        }
        return curCustomer;
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read all customers");
        if (filter == null)
            return DataSource.customers;
        return DataSource.customers.Where((c) => filter(c)).ToList();
    }

    public Customer? Read(Func<Customer, bool> filtre)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read customer");
        return DataSource.customers.FirstOrDefault(filtre);
    }
}
