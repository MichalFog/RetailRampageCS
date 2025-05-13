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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // add
            // 
            add.Location = new Point(91, 61);
            add.Name = "add";
            add.Size = new Size(147, 98);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            update.Location = new Point(320, 61);
            update.Name = "update";
            update.Size = new Size(147, 98);
            update.TabIndex = 1;
            update.Text = "עידכון";
            update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(546, 61);
            delete.Name = "delete";
            delete.Size = new Size(147, 98);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tz, Costumer_name, Address, phone });
            dataGridView1.Location = new Point(218, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(440, 150);
            dataGridView1.TabIndex = 3;
            // 
            // Tz
            // 
            Tz.HeaderText = "תעודת זהות";
            Tz.Name = "Tz";
            // 
            // Costumer_name
            // 
            Costumer_name.HeaderText = "שם לקוח";
            Costumer_name.Name = "Costumer_name";
            // 
            // Address
            // 
            Address.HeaderText = "כתובת";
            Address.Name = "Address";
            // 
            // phone
            // 
            phone.HeaderText = "טלפון";
            phone.Name = "phone";
            // 
            // customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(add);
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
    }
}