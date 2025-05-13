namespace UI
{
    partial class manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            products = new Button();
            customers = new Button();
            sales = new Button();
            orders = new Button();
            SuspendLayout();
            // 
            // products
            // 
            products.Location = new Point(64, 80);
            products.Name = "products";
            products.Size = new Size(214, 169);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // customers
            // 
            customers.Location = new Point(300, 80);
            customers.Name = "customers";
            customers.Size = new Size(214, 169);
            customers.TabIndex = 1;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // sales
            // 
            sales.Location = new Point(538, 80);
            sales.Name = "sales";
            sales.Size = new Size(214, 169);
            sales.TabIndex = 2;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            // 
            // orders
            // 
            orders.Location = new Point(300, 269);
            orders.Name = "orders";
            orders.Size = new Size(214, 169);
            orders.TabIndex = 3;
            orders.Text = "הזמנות";
            orders.UseVisualStyleBackColor = true;
            // 
            // manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(orders);
            Controls.Add(sales);
            Controls.Add(customers);
            Controls.Add(products);
            Name = "manager";
            Text = "manager";
            ResumeLayout(false);
        }

        #endregion

        private Button products;
        private Button customers;
        private Button sales;
        private Button orders;
    }
}