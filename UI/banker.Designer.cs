namespace UI
{
    partial class banker
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
            newOrder = new Button();
            prevPage = new Button();
            SuspendLayout();
            // 
            // newOrder
            // 
            newOrder.Location = new Point(295, 353);
            newOrder.Margin = new Padding(3, 4, 3, 4);
            newOrder.Name = "newOrder";
            newOrder.Size = new Size(313, 231);
            newOrder.TabIndex = 0;
            newOrder.Text = "לביצוע הזמנה חדשה";
            newOrder.UseVisualStyleBackColor = true;
            newOrder.Click += newOrder_Click;
            // 
            // prevPage
            // 
            prevPage.Location = new Point(744, 504);
            prevPage.Name = "prevPage";
            prevPage.Size = new Size(158, 80);
            prevPage.TabIndex = 4;
            prevPage.Text = "לעמוד הקודם";
            prevPage.UseVisualStyleBackColor = true;
            prevPage.Click += prevPage_Click;
            // 
            // banker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(prevPage);
            Controls.Add(newOrder);
            Margin = new Padding(3, 4, 3, 4);
            Name = "banker";
            Text = "banker";
            Load += banker_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button newOrder;
        private Button prevPage;
    }
}