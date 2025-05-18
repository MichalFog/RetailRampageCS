namespace UI
{
    partial class NewOrder
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
            button1 = new Button();
            showProducts = new ListBox();
            cart = new ListBox();
            addToOrder = new Button();
            countForOrder = new Label();
            countForOrderUpDown = new NumericUpDown();
            selectFromList = new Button();
            textBox1 = new TextBox();
            productOrder = new Label();
            prevPage = new Button();
            ((System.ComponentModel.ISupportInitialize)countForOrderUpDown).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(66, 445);
            button1.Name = "button1";
            button1.Size = new Size(172, 79);
            button1.TabIndex = 18;
            button1.Text = "לתשלום";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // showProducts
            // 
            showProducts.FormattingEnabled = true;
            showProducts.ItemHeight = 20;
            showProducts.Location = new Point(473, 286);
            showProducts.Name = "showProducts";
            showProducts.Size = new Size(242, 184);
            showProducts.TabIndex = 17;
            showProducts.SelectedIndexChanged += showProducts_SelectedIndexChanged;
            // 
            // cart
            // 
            cart.FormattingEnabled = true;
            cart.ItemHeight = 20;
            cart.Location = new Point(50, 47);
            cart.Name = "cart";
            cart.Size = new Size(304, 324);
            cart.TabIndex = 16;
            cart.SelectedIndexChanged += cart_SelectedIndexChanged;
            // 
            // addToOrder
            // 
            addToOrder.Location = new Point(473, 207);
            addToOrder.Name = "addToOrder";
            addToOrder.Size = new Size(150, 29);
            addToOrder.TabIndex = 15;
            addToOrder.Text = "הוסף להזמנה";
            addToOrder.UseVisualStyleBackColor = true;
            addToOrder.Click += addToOrder_Click;
            // 
            // countForOrder
            // 
            countForOrder.AutoSize = true;
            countForOrder.Location = new Point(654, 162);
            countForOrder.Name = "countForOrder";
            countForOrder.Size = new Size(95, 20);
            countForOrder.TabIndex = 14;
            countForOrder.Text = "כמות להזמנה";
            // 
            // countForOrderUpDown
            // 
            countForOrderUpDown.Location = new Point(473, 155);
            countForOrderUpDown.Name = "countForOrderUpDown";
            countForOrderUpDown.Size = new Size(157, 27);
            countForOrderUpDown.TabIndex = 13;
            countForOrderUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            countForOrderUpDown.ValueChanged += countForOrderUpDown_ValueChanged;
            // 
            // selectFromList
            // 
            selectFromList.Location = new Point(473, 93);
            selectFromList.Name = "selectFromList";
            selectFromList.Size = new Size(203, 34);
            selectFromList.TabIndex = 12;
            selectFromList.Text = "בחירה מתוך רשימה";
            selectFromList.UseVisualStyleBackColor = true;
            selectFromList.Click += selectFromList_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(473, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // productOrder
            // 
            productOrder.AutoSize = true;
            productOrder.Location = new Point(674, 47);
            productOrder.Name = "productOrder";
            productOrder.Size = new Size(65, 20);
            productOrder.TabIndex = 10;
            productOrder.Text = "קוד מוצר";
            // 
            // prevPage
            // 
            prevPage.Location = new Point(913, 497);
            prevPage.Name = "prevPage";
            prevPage.Size = new Size(158, 80);
            prevPage.TabIndex = 19;
            prevPage.Text = "לעמוד הקודם";
            prevPage.UseVisualStyleBackColor = true;
            prevPage.Click += prevPage_Click;
            // 
            // NewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 615);
            Controls.Add(prevPage);
            Controls.Add(button1);
            Controls.Add(showProducts);
            Controls.Add(cart);
            Controls.Add(addToOrder);
            Controls.Add(countForOrder);
            Controls.Add(countForOrderUpDown);
            Controls.Add(selectFromList);
            Controls.Add(textBox1);
            Controls.Add(productOrder);
            Name = "NewOrder";
            Text = "NewOrder";
            Load += NewOrder_Load;
            ((System.ComponentModel.ISupportInitialize)countForOrderUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox showProducts;
        private ListBox cart;
        private Button addToOrder;
        private Label countForOrder;
        private NumericUpDown countForOrderUpDown;
        private Button selectFromList;
        private TextBox textBox1;
        private Label productOrder;
        private Button prevPage;
    }
}