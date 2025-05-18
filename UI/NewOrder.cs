using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class NewOrder : Form
    {
        private static IBl s_bl = Factory.Get();
        private Customer customer;
        Order order;
        public NewOrder(Customer _customer, Order _order)
        {
            customer = _customer;
            InitializeComponent();
            order = _order;
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void selectFromList_Click(object sender, EventArgs e)
        {
            showProducts.Visible = true;
            MessageBox.Show("לבחירת מוצר יש ללחוץ על מזהה מוצר");
            products productMenu = new products();
            productMenu.fullList(s_bl.Product.ReadAll(), showProducts);
        }

        private void addToOrder_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(textBox1.Text, out int productId);
            if (!isNumber)
            {
                MessageBox.Show("אנא הכנב ערך מספרי", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                BO.Product product = s_bl.Product.Read(productId);
                List<BO.SaleInProduct> saleInProducts = s_bl.Order.AddProductToOrder(order, productId, (int)countForOrderUpDown.Value);
                fullCart(order.products);

            }
            catch (BL_NoExistException)
            {
                MessageBox.Show("לא קיים מוצר עם קוד זה אנא נסה שנית", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (BL_InvalidInputException)
            {
                MessageBox.Show("הכמות שהתקבלה אינה חוקית", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (BL_OperationFailedException)
            {
                MessageBox.Show("אין מספיק מוצרים במלאי", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fullCart(List<ProductInOrder> productInOrder)
        {
            cart.Items.Clear();
            productInOrder.ForEach(po =>
            {
                cart.Items.Add(" שם מוצר " + po.name);
                cart.Items.Add(" מחיר ליחדה " + po.basePrice);
                cart.Items.Add(" כמות להזמנה " + po.amount);
                cart.Items.Add(" מחיר סופי " + po.finalPrice);
                cart.Items.Add("---------------");

            });
            cart.Items.Add(order.finalPrice + " : סה''כ תשלום להזמנה זה");


        }

        private void showProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showProducts.SelectedItem != null)
            {
                string selectedLine = showProducts.SelectedItem.ToString();

                if (selectedLine.StartsWith("מזהה מוצר:"))
                {
                    string productId = selectedLine.Replace("מזהה מוצר:", "").Trim();
                    textBox1.Text = productId;
                }
            }
        }

        private void countForOrderUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s_bl.Order.DoOrder(order);
            MessageBox.Show("ההזמנה הושלמה בהצלחה!!!");
        }

        private void prevPage_Click(object sender, EventArgs e)
        {
            banker menu = new banker();
            this.Hide();//הסתרת המסך הנוכחי
            menu.FormClosed += Menu_FormClosed;//רישום לאירוע של סגירת המסך המשני
            menu.Show();
        }

        private void Menu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
