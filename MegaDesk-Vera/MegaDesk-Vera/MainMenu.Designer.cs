namespace MegaDesk_Vera
{
    partial class MainMenu
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
            this.addNewQuoteButtom = new System.Windows.Forms.Button();
            this.viewQuotesButtom = new System.Windows.Forms.Button();
            this.searchQuotesButtom = new System.Windows.Forms.Button();
            this.exitButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewQuoteButtom
            // 
            this.addNewQuoteButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuoteButtom.Location = new System.Drawing.Point(85, 41);
            this.addNewQuoteButtom.Name = "addNewQuoteButtom";
            this.addNewQuoteButtom.Size = new System.Drawing.Size(183, 63);
            this.addNewQuoteButtom.TabIndex = 0;
            this.addNewQuoteButtom.Text = "Add New Quote";
            this.addNewQuoteButtom.UseVisualStyleBackColor = true;
            this.addNewQuoteButtom.Click += new System.EventHandler(this.addNewQuoteButtom_Click);
            // 
            // viewQuotesButtom
            // 
            this.viewQuotesButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotesButtom.Location = new System.Drawing.Point(85, 110);
            this.viewQuotesButtom.Name = "viewQuotesButtom";
            this.viewQuotesButtom.Size = new System.Drawing.Size(183, 63);
            this.viewQuotesButtom.TabIndex = 1;
            this.viewQuotesButtom.Text = "View Quotes";
            this.viewQuotesButtom.UseVisualStyleBackColor = true;
            this.viewQuotesButtom.Click += new System.EventHandler(this.viewQuotesButtom_Click);
            // 
            // searchQuotesButtom
            // 
            this.searchQuotesButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesButtom.Location = new System.Drawing.Point(85, 179);
            this.searchQuotesButtom.Name = "searchQuotesButtom";
            this.searchQuotesButtom.Size = new System.Drawing.Size(183, 63);
            this.searchQuotesButtom.TabIndex = 2;
            this.searchQuotesButtom.Text = "Search Quotes";
            this.searchQuotesButtom.UseVisualStyleBackColor = true;
            this.searchQuotesButtom.Click += new System.EventHandler(this.searchQuotesButtom_Click);
            // 
            // exitButtom
            // 
            this.exitButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtom.Location = new System.Drawing.Point(85, 248);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(183, 63);
            this.exitButtom.TabIndex = 3;
            this.exitButtom.Text = "Exit";
            this.exitButtom.UseVisualStyleBackColor = true;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.exitButtom);
            this.Controls.Add(this.searchQuotesButtom);
            this.Controls.Add(this.viewQuotesButtom);
            this.Controls.Add(this.addNewQuoteButtom);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuoteButtom;
        private System.Windows.Forms.Button viewQuotesButtom;
        private System.Windows.Forms.Button searchQuotesButtom;
        private System.Windows.Forms.Button exitButtom;
    }
}

