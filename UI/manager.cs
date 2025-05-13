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
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        private void products_Click(object sender, EventArgs e)
        {
            
        }

        private void customers_Click(object sender, EventArgs e)
        {
            customers menu = new customers();
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
