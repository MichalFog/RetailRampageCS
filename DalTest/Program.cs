using DalApi;
namespace DalTest;
using Dal;
using DO;
using System.Diagnostics;

internal class Program
{
    private readonly static IDal s_dal = DalApi.Factory.Get;

    public static void Main(string[] args)
    {
        
        try
        {
            Console.WriteLine("Do you want to initialize data? press 1");
            int Select;
            if (!int.TryParse(Console.ReadLine(), out Select))
                Select = 0;
            if (Select == 1)
                Initialization.Initialize();

            int select = PrintMainMenu();
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        Console.WriteLine("customer");
                        PrintCustomerMenu();//תפריט לקוחות
                        break;
                    case 2:
                        Console.WriteLine("sale");
                        PrintSaleMenu();//תפריט מבצעים
                        break;
                    case 3:
                        Console.WriteLine("product");
                        PrintProductMenu();//תפריט מוצרים
                        break;
                    case 4:
                        Tools.LogManager.ClearLog();
                        break;
                    default:
                        Console.WriteLine("בחירה שגויה");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
    public static int PrintMainMenu()
    {
        Console.WriteLine("for customer press 1");
        Console.WriteLine("for sale press 2");
        Console.WriteLine("for product press 3");
        Console.WriteLine("for exit press 0");
        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }
    public static void PrintSaleMenu()
    {
        int select = printSubMenu("Sale");
        while (select != 0)
        {
            switch (select)
            {
                case 0:
                    PrintMainMenu();
                    break;
                case 1:
                    CreateSale();
                    break;
                case 2:
                    Read<Sale>(s_dal.Sale);
                    break;
                case 3:
                    ReadAll<Sale>(s_dal.Sale);
                    break;
                case 4:
                    UpdateSale();
                    break;
                case 5:
                    Delete<Sale>(s_dal.Sale);
                    break;
                default:
                    Console.WriteLine("בחירה שגויה");
                    break;
            }
            select = printSubMenu("Sale");
        }
        PrintMainMenu();
    }
    public static void PrintCustomerMenu()
    {
        int select = printSubMenu("Customer");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    CreateCustomer();
                    break;
                case 2:
                    Read<Customer>(s_dal.Customer);
                    break;
                case 3:
                    ReadAll<Customer>(s_dal.Customer);
                    break;
                case 4:
                    UpdateCustomer();
                    break;
                case 5:
                    Delete<Customer>(s_dal.Customer);
                    break;
                default:
                    Console.WriteLine("בחירה שגויה");
                    break;
            }
            select = printSubMenu("Customer");
        }

    }
    private static void CreateCustomer()
    {
        try
        {
            Customer c = AskCustomer();
            s_dal.Customer.Create(c);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static Customer AskCustomer(int id = 0)
    {
        if (id == 0)
        {
            Console.WriteLine("Enter CustomerTz ,CustomerName,CustomerAdress, CustomerPhone ");
            int CustomerTz = int.Parse(Console.ReadLine());
            string CustomerName = Console.ReadLine();
            string CustomerAdress = Console.ReadLine();
            string CustomerPhone = Console.ReadLine();
            return new Customer(CustomerTz, CustomerName, CustomerAdress, CustomerPhone);

        }
        else
        {
            Console.WriteLine("Enter CustomerName,CustomerAdress, CustomerPhone ");
            int CustomerTz = id;
            string CustomerName = Console.ReadLine();
            string CustomerAdress = Console.ReadLine();
            string CustomerPhone = Console.ReadLine();
            return new Customer(CustomerTz, CustomerName, CustomerAdress, CustomerPhone);
        }

    }

    private static void UpdateCustomer()
    {
        try
        {
            //קליטה של המזהה לעדכון
            Console.WriteLine("insert id");
            int id = int.Parse(Console.ReadLine());
            Customer c = AskCustomer(id);

            s_dal.Customer.Update(c);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void CreateProduct()
    {
        try
        {
            Product p = AskProduct();
            //זימון של Create
            s_dal.Product.Create(p);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static Product AskProduct(int id = 0)
    {

        Console.WriteLine(" ProductName, CategoryProduct, Price, Amount");
        string ProductName = Console.ReadLine();
        Category CategoryProduct = new Category();
        int Price = int.Parse(Console.ReadLine());
        int Amount = int.Parse(Console.ReadLine());

        return new Product(id, ProductName, CategoryProduct, Price, Amount);
    }
    public static void PrintProductMenu()
    {
        int select = printSubMenu("Product");
        while (select != 0)
        {
            switch (select)
            {
                case 0:
                    PrintMainMenu();
                    break;
                case 1:
                    CreateProduct();
                    break;
                case 2:
                    Read<Product>(s_dal.Product);
                    break;
                case 3:
                    ReadAll<Product>(s_dal.Product);
                    break;
                case 4:
                    UpdateProduct();
                    break;
                case 5:
                    Delete<Product>(s_dal.Product);
                    break;
                default:
                    Console.WriteLine("בחירה שגויה");
                    break;
            }
            select = printSubMenu("Product");
        }
        PrintMainMenu();
    }
    public static int printSubMenu(string s)
    {
        int selection = 1;
        try
        {
            Console.WriteLine($"to add {s} press 1");
            Console.WriteLine($"to show {s} press 2");
            Console.WriteLine($"to show all {s} press 3");
            Console.WriteLine($"to update {s} press 4");
            Console.WriteLine($"to delete {s} press 5");
            Console.WriteLine("to back press 0");

            if (!(int.TryParse(Console.ReadLine(), out selection)))
                selection = -1;
        }
        catch
        {
            Console.WriteLine("error");
        }
        return selection;
    }
    private static void Read<T>(ICrud<T> crud)
    {
        try
        {
            Console.WriteLine("Enter the id for reading");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine(crud.Read(code));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void ReadAll<T>(ICrud<T> crud)
    {
        List<T> items = crud.ReadAll();
        Console.WriteLine(string.Join(", ", items));
    }

    private static void Delete<T>(ICrud<T> crud)
    {
        try
        {
            Console.WriteLine("Enter the id for delete the item");
            int code = int.Parse(Console.ReadLine());
            crud.Delete(code);
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }

    }
    private static void UpdateProduct()
    {
        try
        {
            Console.WriteLine("insert id to update");
            int id = int.Parse(Console.ReadLine());
            Product p = AskProduct(id);

            s_dal.Product.Update(p);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static void CreateSale()
    {
        try
        {
            Sale s = AskSale();
            s_dal.Sale.Create(s);
        }
        catch (Exception ex)
        {
            Console.WriteLine("oppss");
            Console.WriteLine(ex.Message);

        }
    }

    private static Sale AskSale(int SaleId = 0)
    {
        Console.WriteLine("Enter int id, product id, amount_for_sale, price for sale,for_who,start_sale,end_sale");
        SaleId = int.Parse(Console.ReadLine());
        int productId = int.Parse(Console.ReadLine());
        int AmountForSale = int.Parse(Console.ReadLine());
        int PriceForSale = int.Parse(Console.ReadLine());
        bool for_who = bool.Parse(Console.ReadLine());

        int day1 = int.Parse(Console.ReadLine());
        int mounth1 = int.Parse(Console.ReadLine());
        int year1 = int.Parse(Console.ReadLine());

        int day2 = int.Parse(Console.ReadLine());
        int mounth2 = int.Parse(Console.ReadLine());
        int year2 = int.Parse(Console.ReadLine());
        DateTime start_sale = new DateTime(year1, mounth1, day1);
        DateTime end_sale = new DateTime(year2, mounth2, day2);

        return new Sale(SaleId, productId, AmountForSale, PriceForSale, for_who, start_sale, end_sale);
    }
    private static void UpdateSale()
    {
        try
        {
            int id = int.Parse(Console.ReadLine());
            Sale s = AskSale(id);
            s_dal.Sale.Update(s);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}