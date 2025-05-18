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
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product product)
        {
            try
            {
                return _dal.Product.Create(BO.Tools.ConvertProductToDO(product));
            }
            catch { throw new Exception(""); }
        }
        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (DO.DalNotFound ex)
            {
                throw new BL_NoExistException("There is no such ID in the system.", ex);

            }
        }
        public void GetActiveSales(ProductInOrder product, bool isPreferredCustomer)
        {
            product.sales = _dal.Sale.ReadAll(s => s.product_id == product.id && s.start_sale <= DateTime.Now && s.end_sale >= DateTime.Now && s.amount_for_sale <= product.amount && (isPreferredCustomer || (s.for_who ?? true)))
                .Select(s => new SaleInProduct(s.id, s.amount_for_sale ?? 0, s.price_sale ?? 0, s.for_who ?? true)).OrderBy(x => x.price / x.amount).ToList();
        }
        public BO.Product? Read(int id)
        {
            try
            {
                return BO.Tools.ConvertProductToBO(_dal.Product.Read(id));
            }
            catch (DO.DalNotFound ex)
            {
                throw new BL_NoExistException("There is no such ID in the system.", ex);
            }

        }
        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {

            List<DO.Product> doProduct;
            if (filter == null)
                doProduct = _dal.Product.ReadAll();
            else
                doProduct = _dal.Product.ReadAll(doProduct => filter(BO.Tools.ConvertProductToBO(doProduct)));
            return doProduct.Select(x => BO.Tools.ConvertProductToBO(x)).ToList();

        }
        public void Update(BO.Product product)
        {
            _dal.Product.Update(BO.Tools.ConvertProductToDO(product));
        }
    }
}
