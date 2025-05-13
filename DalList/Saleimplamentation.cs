namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using System.Reflection;
using Tools;

public class Saleimplamentation : Isale
{
    public int Create(Sale item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"insert sale in id:{item.amount_for_sale}");
        Sale s = item with { id = DataSource.Config.saleNextNum };
        DataSource.sales.Add(s);
        return s.id;
    }
    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete sale in id:{id}");
        DataSource.sales.Remove(Read(id));
    }
    public Sale? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read sale int id: {id}");
        Sale sale = DataSource.sales.FirstOrDefault(s => s.id == id);
        if (sale == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"not found  sale in this id: {id}");
            throw new DalNotFound("sale not found");
        }
        return sale;
    }

    public Sale? Read(Func<Sale, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read sale");
        return DataSource.sales.FirstOrDefault(filter);
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read all sales");
        if (filter == null)
            return DataSource.sales;
        return DataSource.sales.Where((c) => filter(c)).ToList();
    }

    public void Update(Sale item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update sale in id:{item.amount_for_sale}");
            Delete(item.id);
            DataSource.sales.Add(item);
    }
}