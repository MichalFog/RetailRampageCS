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
    }
}
