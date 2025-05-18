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
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int id, int count)
        {
            // 1. שליפת המוצר מה-DAL
            DO.Product product = _dal.Product.Read(id) ?? throw new Exception("המוצר לא קיים במערכת");
            // 2. בדיקה אם המוצר כבר נמצא בהזמנה
            BO.ProductInOrder productInOrder = order.products.FirstOrDefault(i => i.id == id);
            if (productInOrder != null) // אם קיים
            {
                int newAmount = productInOrder.amount + count;//שמירת הכמות הסופית

                if (newAmount < 0)
                    throw new Exception("לא ניתן להסיר יותר כמות ממה שיש בהזמנה");

                if (product.amount < newAmount)
                    throw new BL_OperationFailedException("אין מספיק מלאי במוצר");

                productInOrder.amount = newAmount;
            }
            else // אם לא קיים
            {
                if (count < 0)
                    throw new Exception("לא ניתן להוסיף מוצר עם כמות שלילית");

                if (product.amount < count)
                    throw new BL_OperationFailedException("אין מספיק מלאי במוצר");

                // 3. יצירת מוצר חדש להזמנה
                productInOrder = new BO.ProductInOrder(product.id, product.product_name ?? "",
                      product.price ?? 0, count, new List<BO.SaleInProduct>(), 0);
                order.products.Add(productInOrder);
            }
            // 4. חיפוש מבצעים תקפים למוצר
            SearchSaleForProduct(productInOrder, order.prefer);
            // 5. חישוב המחיר הסופי למוצר כולל מבצעים
            CalcTotalPriceForProduct(productInOrder);
            // 6. חישוב המחיר הכולל של ההזמנה
            CalcTotalPrice(order);
            // 7. החזרת רשימת המבצעים שמומשו
            return productInOrder.sales;
        }


        //public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int quantity)
        //{
        //    if (quantity < 1)
        //    {
        //        throw new BL_InvalidInputException("Invalid Quantity");
        //    }
        //    DO.Product p;
        //    try
        //    {
        //        p = _dal.Product.Read(productId);
        //    }
        //    catch (DalNotFound ex)
        //    {
        //        throw new BL_NoExistException("There is no such ID in the system.", ex);

        //    }
        //    ProductInOrder productInOrder = order.products.FirstOrDefault(o => o.id == productId);

        //    if (productInOrder != null)
        //    {
        //        if (productInOrder.amount + quantity > p.amount)
        //        {
        //            throw new BL_InvalidInputException("Invalid Quantity");
        //        }
        //        productInOrder.amount += quantity;
        //    }
        //    else
        //    {
        //        if (quantity > p.amount)
        //            throw new BL_OperationFailedException("Invalid Quantity");
        //        ProductInOrder productInOrder1 = new ProductInOrder(productId, p.product_name, p.price, quantity, new List<SaleInProduct>());
        //        productInOrder = productInOrder1;
        //        order.listProduct.Add(productInOrder);

        //    }

        //    SearchSaleForProduct(productInOrder, order.favoriteCustomer);
        //    CalcTotalPriceForProduct(productInOrder);
        //    CalcTotalPrice(order);

        //    return productInOrder._saleList;
        //}



        public void CalcTotalPrice(BO.Order order)
        {
            order.finalPrice = order.products.Sum(s => s.finalPrice);
        }

        //public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
        //{

        //    int count = productInOrder.amount;
        //    double price = 0;
        //    List<SaleInProduct> sales = new List<SaleInProduct>();//רשימה של מבצעים

        //    foreach (var item in productInOrder.sales)//עובר על המבצעים של המוצרים בהזמנה
        //    {
        //        if (count >= productInOrder.amount)//אם יש כמות מספקת בשביל המבצע
        //        {
        //            price += (count / productInOrder.amount) * (item.price);
        //            sales.Add(item);
        //            count = count % productInOrder.amount;
        //        }
        //        if (count == 0)
        //            break;
        //    }
        //    price = price * count;//מעדכן את המחיר של כמה שנשאר שלא במבצע
        //    productInOrder.sales = sales;
        //    productInOrder.finalPrice = price;
        //}


        public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
        {

            int count = 0;
            if (productInOrder.sales.ToArray().Length == 0)
            {

                productInOrder.finalPrice = productInOrder.basePrice * productInOrder.amount;
                count = productInOrder.amount;
                return;
            }
            else
            {
                List<BO.SaleInProduct> mySales = new List<BO.SaleInProduct>();
                count = productInOrder.amount;
                productInOrder.finalPrice = 0;
                foreach (var item in productInOrder.sales)
                {
                    if (count == 0)
                        break;
                    if (count >= item.amount)
                    {
                        int amount = count / item.amount;
                        count = count % item.amount;
                        mySales.Add(item);
                        productInOrder.finalPrice += (amount * item.amount * productInOrder.basePrice) - amount * item.price;
                    }
                }
                productInOrder.finalPrice += count * productInOrder.basePrice;
                foreach (var item in mySales)
                {
                    productInOrder.sales.Add(item);
                }
            }
        }

        public void DoOrder(BO.Order order)
        {
            foreach (var productInOrder in order.products) // מעבר על כל מוצר בהזמנה
            {
                // שליפת המוצר המקורי מה-DAL (לפי מזהה)
                DO.Product product = _dal.Product.Read(productInOrder.id) ?? throw new Exception($"המוצר עם מזהה {productInOrder.id} לא נמצא במערכת.");
                // בדיקה שיש מספיק מלאי (למקרה שבינתיים השתנה)
                if (product.amount < productInOrder.amount)
                    throw new Exception($"אין מספיק מלאי למוצר {product.product_name}. נותרו במלאי: {product.amount}, נדרשים: {productInOrder.amount}");
                // הורדת הכמות מהמלאי
                int updatedAmount = product.amount.Value - productInOrder.amount;
                // יצירת מוצר חדש עם כמות מעודכנת (לפי סוג ה-Record שלך ב-DO)
                DO.Product updatedProduct = product with { amount = updatedAmount };
                // עדכון המוצר ב-DAL
                _dal.Product.Update(updatedProduct);
            }
        }
        public void SearchSaleForProduct(BO.ProductInOrder product, bool isPreferredCustomer)
        {
            product.sales = _dal.Sale.ReadAll(s => s.product_id == product.id && s.start_sale <= DateTime.Now && s.end_sale >= DateTime.Now && s.amount_for_sale <= product.amount && (isPreferredCustomer || (s.for_who ?? true)))
                .Select(s => new SaleInProduct(s.id, s.amount_for_sale ?? 0, s.price_sale ?? 0, s.for_who ?? true)).OrderBy(x => x.price / x.amount).ToList();
        }

    }
}
