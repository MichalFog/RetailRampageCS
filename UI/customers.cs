using BO;
using DO;
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
    public partial class customers : Form
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        public customers()
        {
            InitializeComponent();
        }
        private string selectedTz = null;

        private void customers_Load(object sender, EventArgs e)
        {
            /*this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;*/
            var customers = s_bl.Customer.ReadAll()
                .Select(c => new
                {
                    c.Tz,
                    c.Costumer_name,
                    c.Address,
                    c.phone
                }).ToList();


            // חיבור בין עמודה ל־property
            dataGridView1.Columns["Tz"].DataPropertyName = "Tz";
            dataGridView1.Columns["Costumer_name"].DataPropertyName = "Costumer_name";
            dataGridView1.Columns["Address"].DataPropertyName = "Address";
            dataGridView1.Columns["phone"].DataPropertyName = "phone";

            dataGridView1.DataSource = customers;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string tzString = dataGridView1.CurrentRow.Cells["Tz"].Value.ToString();
                if (int.TryParse(tzString, out int tz))
                {
                    try
                    {
                        s_bl.Customer.Delete(tz);
                        MessageBox.Show("הלקוח נמחק בהצלחה");
                        customers_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("שגיאה במחיקה: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("תעודת הזהות אינה חוקית");
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form addCustomerForm = new Form();
            addCustomerForm.Text = "הוסף לקוח חדש";

            Label tzLabel = new Label { Text = "תעודת זהות", Location = new Point(10, 10) };
            Label customerNameLabel = new Label { Text = "שם לקוח", Location = new Point(10, 40) };
            Label addressLabel = new Label { Text = "כתובת", Location = new Point(10, 70) };
            Label phoneLabel = new Label { Text = "טלפון", Location = new Point(10, 100) };

            TextBox tzTextBox = new TextBox { Name = "tzTextBox", Location = new Point(120, 10), Width = 200 };
            TextBox customerNameTextBox = new TextBox { Name = "customerNameTextBox", Location = new Point(120, 40), Width = 200 };
            TextBox addressTextBox = new TextBox { Name = "addressTextBox", Location = new Point(120, 70), Width = 200 };
            TextBox phoneTextBox = new TextBox { Name = "phoneTextBox", Location = new Point(120, 100), Width = 200 };

            Button saveButton = new Button { Text = "שמור", Location = new Point(120, 130) };
            saveButton.Click += (s, args) =>
            {
                string tzString = tzTextBox.Text;
                string customerName = customerNameTextBox.Text;
                string address = addressTextBox.Text;
                string phone = phoneTextBox.Text;

                if (int.TryParse(tzString, out int tz))
                {
                    try
                    {
                        BO.Customer newCustomer = new BO.Customer(tz, customerName, address, phone);

                        s_bl.Customer.Create(newCustomer);

                        MessageBox.Show("הלקוח נוסף בהצלחה");

                        addCustomerForm.Close();

                        customers_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("שגיאה בהוספה: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("תעודת הזהות אינה חוקית");
                }
            };

            addCustomerForm.Controls.Add(tzLabel);
            addCustomerForm.Controls.Add(customerNameLabel);
            addCustomerForm.Controls.Add(addressLabel);
            addCustomerForm.Controls.Add(phoneLabel);
            addCustomerForm.Controls.Add(tzTextBox);
            addCustomerForm.Controls.Add(customerNameTextBox);
            addCustomerForm.Controls.Add(addressTextBox);
            addCustomerForm.Controls.Add(phoneTextBox);
            addCustomerForm.Controls.Add(saveButton);

            addCustomerForm.ShowDialog();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("בחר לקוח לעדכון");
                return;
            }

            // שליפת הנתונים מהשורה שנבחרה
            string tzString = dataGridView1.CurrentRow.Cells["Tz"].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells["Costumer_name"].Value.ToString();
            string address = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            string phone = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();

            if (!int.TryParse(tzString, out int tz))
            {
                MessageBox.Show("תעודת זהות לא חוקית");
                return;
            }

            // פתיחת הטופס עם הנתונים הקיימים
            Form updateCustomerForm = new Form();
            updateCustomerForm.Text = "עדכן לקוח";

            Label customerNameLabel = new Label { Text = "שם לקוח", Location = new Point(10, 40) };
            Label addressLabel = new Label { Text = "כתובת", Location = new Point(10, 70) };
            Label phoneLabel = new Label { Text = "טלפון", Location = new Point(10, 100) };

            TextBox customerNameTextBox = new TextBox
            {
                Name = "customerNameTextBox",
                Location = new Point(120, 40),
                Width = 200,
                Text = name
            };
            TextBox addressTextBox = new TextBox
            {
                Name = "addressTextBox",
                Location = new Point(120, 70),
                Width = 200,
                Text = address
            };
            TextBox phoneTextBox = new TextBox
            {
                Name = "phoneTextBox",
                Location = new Point(120, 100),
                Width = 200,
                Text = phone
            };

            Button saveButton = new Button
            {
                Text = "שמור",
                Location = new Point(120, 130)
            };

            saveButton.Click += (s, args) =>
            {
                string updatedName = customerNameTextBox.Text;
                string updatedAddress = addressTextBox.Text;
                string updatedPhone = phoneTextBox.Text;

                // שימוש בלוגיקה שלך
                BO.Customer updatedCustomer = new BO.Customer();
                updatedCustomer.Tz = tz;
                updatedCustomer.Costumer_name = updatedName;
                updatedCustomer.Address = updatedAddress;
                updatedCustomer.phone = updatedPhone;

                try
                {
                    s_bl.Customer.Update(updatedCustomer);
                    MessageBox.Show("הלקוח עודכן בהצלחה");
                    s_bl.Customer.Delete(tz);
                    updateCustomerForm.Close();
                    customers_Load(null, null); // רענון טבלת לקוחות
                }
                catch (BL_ExistException)
                {
                    MessageBox.Show("מצטערים אך קיים כבר לקוח עם מזהה זה");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("שגיאה בעדכון: " + ex.Message);
                }
            };

            updateCustomerForm.Controls.Add(customerNameLabel);
            updateCustomerForm.Controls.Add(addressLabel);
            updateCustomerForm.Controls.Add(phoneLabel);
            updateCustomerForm.Controls.Add(customerNameTextBox);
            updateCustomerForm.Controls.Add(addressTextBox);
            updateCustomerForm.Controls.Add(phoneTextBox);
            updateCustomerForm.Controls.Add(saveButton);

            updateCustomerForm.ShowDialog();
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
