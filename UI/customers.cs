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

    }
}
