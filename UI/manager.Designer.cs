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
            prevPage = new Button();
            SuspendLayout();
            // 
            // products
            // 
            products.Location = new Point(73, 107);
            products.Margin = new Padding(3, 4, 3, 4);
            products.Name = "products";
            products.Size = new Size(245, 225);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // customers
            // 
            customers.Location = new Point(343, 107);
            customers.Margin = new Padding(3, 4, 3, 4);
            customers.Name = "customers";
            customers.Size = new Size(245, 225);
            customers.TabIndex = 1;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // sales
            // 
            sales.Location = new Point(615, 107);
            sales.Margin = new Padding(3, 4, 3, 4);
            sales.Name = "sales";
            sales.Size = new Size(245, 225);
            sales.TabIndex = 2;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // prevPage
            // 
            prevPage.Location = new Point(37, 439);
            prevPage.Name = "prevPage";
            prevPage.Size = new Size(158, 80);
            prevPage.TabIndex = 3;
            prevPage.Text = "לעמוד הקודם";
            prevPage.UseVisualStyleBackColor = true;
            prevPage.Click += prevPage_Click;
            // 
            // manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(prevPage);
            Controls.Add(sales);
            Controls.Add(customers);
            Controls.Add(products);
            Margin = new Padding(3, 4, 3, 4);
            Name = "manager";
            Text = "manager";
            Load += manager_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button products;
        private Button customers;
        private Button sales;
        private Button prevPage;
    }
}