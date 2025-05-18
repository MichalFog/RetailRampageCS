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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class banker : Form
    {
        public banker()
        {
            InitializeComponent();
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            NewOrder order = new NewOrder(new BO.Customer(), new Order(false));
            this.Hide();//הסתרת המסך הנוכחי
            order.FormClosed += Menu_FormClosed;//רישום לאירוע של סגירת המסך המשני
            order.Show();

        }

        private void Menu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void banker_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void prevPage_Click(object sender, EventArgs e)
        {

            Form1 menu = new Form1();
            this.Hide();//הסתרת המסך הנוכחי
            menu.FormClosed += Menu_FormClosed;//רישום לאירוע של סגירת המסך המשני
            menu.Show();
        }
    }
}
