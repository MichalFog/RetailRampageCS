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
    public partial class saleMenu : Form
    {
        private static IBl s_bl = Factory.Get();

        public saleMenu()
        {
            InitializeComponent();
        }

        private void SaleMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            panel1.Visible = false;
            fullList(s_bl.Sale.ReadAll());
        }


        public void fullList(List<BO.Sale> s, ListBox l = null)
        {
            if (l == null)
                l = showSale;
            s.ForEach(s =>
            {
                l.Items.Add("מזהה מבצע : " + s.id);
                l.Items.Add("מזהה מוצר: " + s.product_id);
                l.Items.Add("מחיר להנחה: " + s.price_sale);

                l.Items.Add("כמות מוצרים המשתתפים במבצע: " + s.amount_for_sale);
                l.Items.Add(" ללקוחות במועדון: " + s.for_who);
                l.Items.Add("תאריך התחלה: " + s.start_sale);
                l.Items.Add("תאריך סיום: " + s.end_sale);
                l.Items.Add("-------------");
            });
        }
        private void showSale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addSale_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Sale s = new BO.Sale();

                // בדיקה: האם מזהה מוצר הוא מספר שלם
                if (!int.TryParse(nameBox.Text, out int productId))
                {
                    MessageBox.Show("יש להזין מזהה מוצר מספרי תקין.");
                    return;
                }

                // בדיקה: האם כמות למבצע היא מספר שלם
                if (!int.TryParse(textBox4.Text, out int quantity))
                {
                    MessageBox.Show("יש להזין כמות תקינה.");
                    return;
                }
                if (!double.TryParse(priceBox.Text, out double salePrice))
                {
                    MessageBox.Show("יש להזין מחיר תקין.");
                    return;
                }


                DateTime start = DateTime.Now;
                DateTime end = dateTimeEnd.Value;

                if (end < start)
                {
                    MessageBox.Show("תאריך סיום המבצע לא יכול להיות לפני היום.");
                    return;
                }
                s.id = productId;
                s.amount_for_sale = quantity;
                s.for_who = favorite.Checked;
                s.start_sale = start;
                s.end_sale = end;
                s.price_sale = salePrice;

                s_bl.Sale.Create(s);
                MessageBox.Show("המבצע נוסף בהצלחה!");
                fullList(s_bl.Sale.ReadAll());
            }
            catch (BL_NoExistException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה: " + ex.Message);
            }
        }

        private void deleteButten_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(idDelete.Text, out int result);
            MessageBox.Show(result.ToString() + " the num");
            if (!isNumber)
            {
                MessageBox.Show("נא להזין מספר תקין בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idDelete.Text = string.Empty;
            }
            else
            {
                try
                {
                    s_bl.Sale.Delete(result);
                    MessageBox.Show("המבצע נמחק בהצלחה");
                    fullList(s_bl.Sale.ReadAll());

                }
                catch (BO.BL_NoExistException)
                {
                    MessageBox.Show("המוצר לא קיים במערכת , אנא הכנס מזהה מוצר תקין");
                }
            }
        }

        private void changeButten_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (!int.TryParse(saleForChangeBox.Text, out int saleId))
            {
                MessageBox.Show("יש להכניס מספר תקין!");
                return;
            }
            try
            {
                BO.Sale s = s_bl.Sale.Read(saleId);
                textBox3.Text = s.id.ToString();
                textBox2.Text = s.price_sale.ToString();
                textBox1.Text = s.amount_for_sale.ToString();
                checkBox1.Checked = (bool)s.for_who;
                dateTimePicker2.Value = (DateTime)s.start_sale;
                dateTimePicker1.Value = (DateTime)s.end_sale;
            }
            catch (BL_NoExistException ex)
            {
                MessageBox.Show("יש להכניס מזהה מבצע תקין");
            }
        }

        private void filterButten_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(filter.Text, out int saleId))
            {
                MessageBox.Show("יש להזין מזהה מוצר מספרי תקין.");
                return;
            }
            BO.Sale s = s_bl.Sale.Read((s) => s.id == saleId);
            if (s == null)
            {
                MessageBox.Show("מוצר לא קיים");
            }
            else
            {
                showSaleBySearch.Items.Clear();
                showSaleBySearch.Visible = true;
                showSaleBySearch.Items.Add("מזהה מבצע : " + s.id);
                showSaleBySearch.Items.Add("מזהה מוצר: " + s.product_id);
                showSaleBySearch.Items.Add("שם מוצר: " + s.price_sale);
                showSaleBySearch.Items.Add("כמות מוצרים המשתתפים במבצע: " + s.amount_for_sale);
                showSaleBySearch.Items.Add(" ללקוחות במועדון: " + s.for_who);
                showSaleBySearch.Items.Add("תאריך התחלה: " + s.start_sale);
                showSaleBySearch.Items.Add("תאריך סיום: " + s.end_sale);
                showSaleBySearch.Items.Add("-------------");
            }

        }

        private void display_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prevPage_Click(object sender, EventArgs e)
        {
            manager menu = new manager();
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
