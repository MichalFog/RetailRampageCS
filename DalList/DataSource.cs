using DO;
using System.Diagnostics.Metrics;

namespace Dal;

internal static class DataSource
{
    static internal List<Customer?> customers = new List<Customer?>();
    static internal List<Product?> products = new List<Product?>();
    static internal List<Sale?> sales = new List<Sale?>();

    static internal class Config
    {
        internal const int MIN_NUM = 0;
        internal const int MIN_NUM2 = 0;
        private static int SaleNextNum = MIN_NUM;
        private static int ProductNextNum = MIN_NUM2;
        public static int saleNextNum
        {
            get
            {
                return SaleNextNum++;
            }
        }
        public static int productNextNum
        {
            get
            {
                return ProductNextNum++;
            }
        }
    }
}
