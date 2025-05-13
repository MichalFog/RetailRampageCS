using DO;
using DalApi;
using System.Runtime.CompilerServices;
using Dal;

namespace DalTest;

public static class Initialization
{
    private static IDal? s_dal;
    private static void creatSale()
    {
        s_dal.Sale.Create(new Sale(1,0, 5, 3, true, new DateTime(1 / 3 / 2025), new DateTime(1 / 4 / 2025)));
        s_dal.Sale.Create(new Sale(2,1, 10, 5, true, new DateTime(1 / 3 / 2025), new DateTime(1 / 4 / 2025)));
        s_dal.Sale.Create(new Sale(3,2, 5, 3, true, new DateTime(1 / 3 / 2025), new DateTime(1 / 4 / 2025)));
        s_dal.Sale.Create(new Sale(4,3, 5, 3, true, new DateTime(1 / 3 / 2025), new DateTime(1 / 4 / 2025)));
    }
    private static void creatProduct()
    {
        s_dal.Product.Create(new Product(100, "חלב", Category.milky, 5.5, 50));
        s_dal.Product.Create(new Product(200, "גבינה", Category.milky, 5.9, 50));
        s_dal.Product.Create(new Product(300, "לבן", Category.milky, 5.9, 50));
        s_dal.Product.Create(new Product(400, "מלפפון", Category.vegetables, 5.9, 50));
        s_dal.Product.Create(new Product(500, "סוכריה", Category.sweet, 5.9, 50));
        s_dal.Product.Create(new Product(600, "עוף", Category.meaty, 5.9, 50));

    }
    public static void creatCustomers()
    {
      s_dal.Customer.Create(new Customer(035454223, "שלמה", "שלמה המלך 7", "0556787414"));
      s_dal.Customer.Create(new Customer(234525343, "שבי", "רבי עקיבא 6", "0556791242"));
      s_dal.Customer.Create(new Customer(034534567, "אפרת", "מסילת יוסף 15", "0556791242"));
      s_dal.Customer.Create(new Customer(032123443, "דוד", "יהודה הנשיא 34", "0556791242"));
      s_dal.Customer.Create(new Customer(034545343, "מיכל", "המסגר 52", "0556791242"));
      s_dal.Customer.Create(new Customer(037655343, "יוסי", "קהילות יעקב 2", "0556791242"));
    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        creatCustomers();
        creatProduct();
        creatSale();
    }

}


