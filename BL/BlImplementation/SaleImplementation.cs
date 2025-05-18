using BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Sale item)
        {
            try
            {
                return _dal.Sale.Create(BO.Tools.ConvertSaleToDO(item));
            }
            catch
            {
                throw new Exception("");
            }
        }

        public void Delete(int id)
        {
            try
            { _dal.Sale.Delete(id); }

            catch
            { throw new Exception(""); }
        }

        public BO.Sale? Read(int id)
        {
            try
            {
                return BO.Tools.ConvertSaleToBO(_dal.Sale.Read(id));
            }
            catch (DalNotFound ex)
            {
                throw new BL_NoExistException("There is no such ID in the system.", ex);
            }
        }

        public BO.Sale? Read(Func<BO.Sale, bool> filtre)
        {
            try
            {
                return BO.Tools.ConvertSaleToBO(_dal.Sale.Read(doSale => filtre(BO.Tools.ConvertSaleToBO(doSale))));
            }
            catch
            { throw new Exception(""); }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                List<DO.Sale> doSales;
                if (filter == null)
                    doSales = _dal.Sale.ReadAll();
                else
                    doSales = _dal.Sale.ReadAll(doSale => filter(BO.Tools.ConvertSaleToBO(doSale)));
                return doSales.Select(x => BO.Tools.ConvertSaleToBO(x)).ToList();
            }
            catch
            { throw new Exception(""); }
        }

        public void Update(BO.Sale item)
        {
            _dal.Sale.Update(BO.Tools.ConvertSaleToDO(item));
        }
    }
}
