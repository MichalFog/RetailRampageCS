namespace UI
{
    partial class saleMenu
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
            showSale = new ListBox();
            display = new TabControl();
            tabPage1 = new TabPage();
            dateTimeEnd = new DateTimePicker();
            endSale = new Label();
            beginSale = new Label();
            dateTimeBegin = new DateTimePicker();
            favorite = new CheckBox();
            addSale = new Button();
            textBox4 = new TextBox();
            priceBox = new TextBox();
            quentity = new Label();
            price = new Label();
            nameBox = new TextBox();
            idProduct = new Label();
            update = new TabPage();
            changeButten = new Button();
            saleForChange = new Label();
            saleForChangeBox = new TextBox();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            delete = new TabPage();
            label6 = new Label();
            deleteButten = new Button();
            idDelete = new TextBox();
            tabPage4 = new TabPage();
            showSaleBySearch = new ListBox();
            filterButten = new Button();
            filter = new TextBox();
            saleName = new TextBox();
            display.SuspendLayout();
            tabPage1.SuspendLayout();
            update.SuspendLayout();
            panel1.SuspendLayout();
            delete.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // showSale
            // 
            showSale.FormattingEnabled = true;
            showSale.ItemHeight = 20;
            showSale.Location = new Point(862, 62);
            showSale.Name = "showSale";
            showSale.Size = new Size(261, 364);
            showSale.TabIndex = 3;
            // 
            // display
            // 
            display.Controls.Add(tabPage1);
            display.Controls.Add(update);
            display.Controls.Add(delete);
            display.Controls.Add(tabPage4);
            display.Location = new Point(179, 30);
            display.Name = "display";
            display.SelectedIndex = 0;
            display.Size = new Size(662, 493);
            display.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dateTimeEnd);
            tabPage1.Controls.Add(endSale);
            tabPage1.Controls.Add(beginSale);
            tabPage1.Controls.Add(dateTimeBegin);
            tabPage1.Controls.Add(favorite);
            tabPage1.Controls.Add(addSale);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(priceBox);
            tabPage1.Controls.Add(quentity);
            tabPage1.Controls.Add(price);
            tabPage1.Controls.Add(nameBox);
            tabPage1.Controls.Add(idProduct);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(654, 460);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Location = new Point(166, 251);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(162, 27);
            dateTimeEnd.TabIndex = 28;
            // 
            // endSale
            // 
            endSale.AutoSize = true;
            endSale.Location = new Point(381, 259);
            endSale.Name = "endSale";
            endSale.Size = new Size(123, 20);
            endSale.TabIndex = 27;
            endSale.Text = "תאריך סיום מבצע";
            // 
            // beginSale
            // 
            beginSale.AutoSize = true;
            beginSale.Location = new Point(381, 209);
            beginSale.Name = "beginSale";
            beginSale.Size = new Size(145, 20);
            beginSale.TabIndex = 26;
            beginSale.Text = "תאריך התחלת מבצע";
            // 
            // dateTimeBegin
            // 
            dateTimeBegin.Location = new Point(166, 199);
            dateTimeBegin.Name = "dateTimeBegin";
            dateTimeBegin.Size = new Size(162, 27);
            dateTimeBegin.TabIndex = 25;
            // 
            // favorite
            // 
            favorite.AutoSize = true;
            favorite.Location = new Point(280, 147);
            favorite.Name = "favorite";
            favorite.Size = new Size(170, 24);
            favorite.TabIndex = 24;
            favorite.Text = "המבצע לחברי מועדון?";
            favorite.UseVisualStyleBackColor = true;
            // 
            // addSale
            // 
            addSale.Location = new Point(152, 299);
            addSale.Name = "addSale";
            addSale.Size = new Size(94, 29);
            addSale.TabIndex = 22;
            addSale.Text = "הוסף מבצע";
            addSale.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 95);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 18;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(166, 50);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(125, 27);
            priceBox.TabIndex = 17;
            // 
            // quentity
            // 
            quentity.AutoSize = true;
            quentity.Location = new Point(339, 98);
            quentity.Name = "quentity";
            quentity.Size = new Size(92, 20);
            quentity.TabIndex = 16;
            quentity.Text = "כמות במבצע";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(339, 53);
            price.Name = "price";
            price.Size = new Size(45, 20);
            price.TabIndex = 14;
            price.Text = "הנחה";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(166, 9);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(125, 27);
            nameBox.TabIndex = 13;
            // 
            // idProduct
            // 
            idProduct.AutoSize = true;
            idProduct.Location = new Point(339, 12);
            idProduct.Name = "idProduct";
            idProduct.Size = new Size(79, 20);
            idProduct.TabIndex = 12;
            idProduct.Text = "מזהה מוצר";
            // 
            // update
            // 
            update.Controls.Add(changeButten);
            update.Controls.Add(saleForChange);
            update.Controls.Add(saleForChangeBox);
            update.Controls.Add(panel1);
            update.Location = new Point(4, 29);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(654, 460);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // changeButten
            // 
            changeButten.Location = new Point(213, 51);
            changeButten.Name = "changeButten";
            changeButten.Size = new Size(94, 29);
            changeButten.TabIndex = 6;
            changeButten.Text = "שינוי";
            changeButten.UseVisualStyleBackColor = true;
            // 
            // saleForChange
            // 
            saleForChange.AutoSize = true;
            saleForChange.Location = new Point(341, 15);
            saleForChange.Name = "saleForChange";
            saleForChange.Size = new Size(165, 20);
            saleForChange.TabIndex = 5;
            saleForChange.Text = "הכנס מזהה מבצע לשינוי";
            // 
            // saleForChangeBox
            // 
            saleForChangeBox.Location = new Point(333, 51);
            saleForChangeBox.Name = "saleForChangeBox";
            saleForChangeBox.Size = new Size(125, 27);
            saleForChangeBox.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(89, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 339);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 252);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(162, 27);
            dateTimePicker1.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 257);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 39;
            label1.Text = "תאריך סיום מבצע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 207);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 38;
            label2.Text = "תאריך התחלת מבצע";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(88, 200);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(162, 27);
            dateTimePicker2.TabIndex = 37;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(199, 145);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 24);
            checkBox1.TabIndex = 36;
            checkBox1.Text = "המבצע לחברי מועדון?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(74, 300);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 35;
            button1.Text = "הוסף מבצע";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 96);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 32;
            label3.Text = "כמות במבצע";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 51);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 31;
            label4.Text = "הנחה";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(88, 10);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 10);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 29;
            label5.Text = "מזהה מוצר";
            // 
            // delete
            // 
            delete.Controls.Add(label6);
            delete.Controls.Add(deleteButten);
            delete.Controls.Add(idDelete);
            delete.Location = new Point(4, 29);
            delete.Name = "delete";
            delete.Padding = new Padding(3);
            delete.Size = new Size(654, 460);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 40);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 4;
            label6.Text = "מזהה מבצע למחיקה";
            // 
            // deleteButten
            // 
            deleteButten.Location = new Point(142, 83);
            deleteButten.Name = "deleteButten";
            deleteButten.Size = new Size(94, 29);
            deleteButten.TabIndex = 3;
            deleteButten.Text = "מחק";
            deleteButten.UseVisualStyleBackColor = true;
            // 
            // idDelete
            // 
            idDelete.Location = new Point(259, 83);
            idDelete.Name = "idDelete";
            idDelete.Size = new Size(189, 27);
            idDelete.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(showSaleBySearch);
            tabPage4.Controls.Add(filterButten);
            tabPage4.Controls.Add(filter);
            tabPage4.Controls.Add(saleName);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(654, 460);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "חיפוש";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // showSaleBySearch
            // 
            showSaleBySearch.FormattingEnabled = true;
            showSaleBySearch.ItemHeight = 20;
            showSaleBySearch.Location = new Point(121, 183);
            showSaleBySearch.Name = "showSaleBySearch";
            showSaleBySearch.Size = new Size(347, 164);
            showSaleBySearch.TabIndex = 7;
            // 
            // filterButten
            // 
            filterButten.Location = new Point(266, 115);
            filterButten.Name = "filterButten";
            filterButten.Size = new Size(94, 29);
            filterButten.TabIndex = 6;
            filterButten.Text = "סנן";
            filterButten.UseVisualStyleBackColor = true;
            // 
            // filter
            // 
            filter.Location = new Point(253, 57);
            filter.Name = "filter";
            filter.Size = new Size(125, 27);
            filter.TabIndex = 5;
            // 
            // saleName
            // 
            saleName.Location = new Point(238, 10);
            saleName.Name = "saleName";
            saleName.Size = new Size(173, 27);
            saleName.TabIndex = 4;
            saleName.Text = "הכנס מזהה מבצע";
            // 
            // saleMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 552);
            Controls.Add(showSale);
            Controls.Add(display);
            Name = "saleMenu";
            Text = "saleMenu";
            //Load += this.saleMenu_Load_1;
            display.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox showSale;
        private TabControl display;
        private TabPage tabPage1;
        private DateTimePicker dateTimeEnd;
        private Label endSale;
        private Label beginSale;
        private DateTimePicker dateTimeBegin;
        private CheckBox favorite;
        private Button addSale;
        private TextBox textBox4;
        private TextBox priceBox;
        private Label quentity;
        private Label price;
        private TextBox nameBox;
        private Label idProduct;
        private TabPage update;
        private Button changeButten;
        private Label saleForChange;
        private TextBox saleForChangeBox;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TabPage delete;
        private Label label6;
        private Button deleteButten;
        private TextBox idDelete;
        private TabPage tabPage4;
        private ListBox showSaleBySearch;
        private Button filterButten;
        private TextBox filter;
        private TextBox saleName;
    }
}