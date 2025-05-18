namespace UI
{
    partial class customers
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
            add = new Button();
            update = new Button();
            delete = new Button();
            dataGridView1 = new DataGridView();
            Tz = new DataGridViewTextBoxColumn();
            Costumer_name = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            prevPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // add
            // 
            add.Location = new Point(104, 81);
            add.Margin = new Padding(3, 4, 3, 4);
            add.Name = "add";
            add.Size = new Size(168, 131);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // update
            // 
            update.Location = new Point(366, 81);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(168, 131);
            update.TabIndex = 1;
            update.Text = "עידכון";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(624, 81);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(168, 131);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tz, Costumer_name, Address, phone });
            dataGridView1.Location = new Point(149, 241);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(549, 270);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Tz
            // 
            Tz.HeaderText = "תעודת זהות";
            Tz.MinimumWidth = 6;
            Tz.Name = "Tz";
            Tz.Width = 125;
            // 
            // Costumer_name
            // 
            Costumer_name.HeaderText = "שם לקוח";
            Costumer_name.MinimumWidth = 6;
            Costumer_name.Name = "Costumer_name";
            Costumer_name.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "כתובת";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // phone
            // 
            phone.HeaderText = "טלפון";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 125;
            // 
            // prevPage
            // 
            prevPage.Location = new Point(744, 488);
            prevPage.Name = "prevPage";
            prevPage.Size = new Size(158, 80);
            prevPage.TabIndex = 4;
            prevPage.Text = "לעמוד הקודם";
            prevPage.UseVisualStyleBackColor = true;
            prevPage.Click += prevPage_Click;
            // 
            // customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(prevPage);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(add);
            Margin = new Padding(3, 4, 3, 4);
            Name = "customers";
            Text = "customers";
            Load += customers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button add;
        private Button update;
        private Button delete;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Tz;
        private DataGridViewTextBoxColumn Costumer_name;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn phone;
        private Button prevPage;
    }
}