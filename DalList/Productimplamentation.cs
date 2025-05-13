namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using System.Reflection;
using Tools;

public class Productimplamentation : Iproduct
{
    public int Create(Product item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"insert product in  id:{item.id}");
        foreach (Product? i in DataSource.products)
        {
            if (i.id == item.id)
                throw new DalIdExsist("The Sale is already exist");
            else
            {
                Console.WriteLine("The Product Add");
                DataSource.products.Add(i);
                Product P = item with { id = DataSource.Config.productNextNum };
            }

        }
        return item.id;
    }
    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete product in id:{id}");
        DataSource.products.Remove(Read(id));
    }
    public Product? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read product int id: {id}");
        Product pr = DataSource.products.FirstOrDefault(p => p.id == id);
        if (pr == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"not found  product in this id: {id}");
            throw new DalNotFound("product not found");
        }
        return pr;
    }

    public Product? Read(Func<Product, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read product");
        return DataSource.products.FirstOrDefault(filter);
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read all products");
        if (filter == null)
            return DataSource.products;
        return DataSource.products.Where((c) => filter(c)).ToList();
    }

    public void Update(Product item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update product in id: {item.id}");
            Delete(item.id);
            DataSource.products.Add(item);
    }
}
