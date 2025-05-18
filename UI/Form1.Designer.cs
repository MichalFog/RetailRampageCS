namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            manager = new Button();
            banker = new Button();
            SuspendLayout();
            // 
            // manager
            // 
            manager.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            manager.Location = new Point(397, 65);
            manager.Margin = new Padding(3, 4, 3, 4);
            manager.Name = "manager";
            manager.Size = new Size(491, 217);
            manager.TabIndex = 0;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = true;
            manager.Click += button1_Click;
            // 
            // banker
            // 
            banker.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point);
            banker.Location = new Point(927, 65);
            banker.Margin = new Padding(3, 4, 3, 4);
            banker.Name = "banker";
            banker.Size = new Size(493, 217);
            banker.TabIndex = 1;
            banker.Text = "קופאי";
            banker.UseVisualStyleBackColor = true;
            banker.Click += banker_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1432, 701);
            Controls.Add(banker);
            Controls.Add(manager);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button manager;
        private Button banker;
    }
}
