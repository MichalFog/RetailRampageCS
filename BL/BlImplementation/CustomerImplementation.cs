using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation;

internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Customer item)
    {
        try
        {
            return _dal.Customer.Create(BO.Tools.ConvertToCustomerDO(item));
        }
        catch(DO.DalIdExsist ex)
        {
            throw new BL_ExistException("the customer is exist already.",ex);
        }
    }

    public void Delete(int id)
    {
        try
        { _dal.Customer.Delete(id); }

        catch { throw new Exception(""); }
    }
    public BO.Customer? Read(int id)
    {
        try
        {
            return BO.Tools.ConvertCustomerToBO(_dal.Customer.Read(id));
        }
        catch (DO.DalNotFound ex)
        { throw new BO.BL_NoExistException("the order not found", ex); }
    }

    public BO.Customer? Read(Func<BO.Customer, bool> filter)
    {
        try
        {
            return BO.Tools.ConvertCustomerToBO(_dal.Customer.Read(doSale => filter(BO.Tools.ConvertCustomerToBO(doSale))));
        }
        catch (DO.DalNotFound ex)
        { throw new BO.BL_NoExistException("the order not found", ex); }
    }
    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        try
        {
            List<DO.Customer> doCustomres;
            if (filter == null)
                doCustomres = _dal.Customer.ReadAll();
            else
                doCustomres = _dal.Customer.ReadAll(doCustomres => filter(BO.Tools.ConvertCustomerToBO(doCustomres)));
            return doCustomres.Select(x => BO.Tools.ConvertCustomerToBO(x)).ToList();
        }
        catch
        { throw new Exception(""); }
    }
    public void Update(BO.Customer item)
    {
        try
        {
            _dal.Customer.Update(BO.Tools.ConvertToCustomerDO(item));
        }
        catch (DO.DalNotFound ex) { throw new BO.BL_NoExistException("the order not found", ex); }
    }
}
