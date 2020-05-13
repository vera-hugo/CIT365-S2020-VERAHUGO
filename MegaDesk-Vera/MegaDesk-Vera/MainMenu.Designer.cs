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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addNewQuoteButtom = new System.Windows.Forms.Button();
            this.viewQuotesButtom = new System.Windows.Forms.Button();
            this.searchQuotesButtom = new System.Windows.Forms.Button();
            this.exitButtom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewQuoteButtom
            // 
            this.addNewQuoteButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuoteButtom.Location = new System.Drawing.Point(60, 50);
            this.addNewQuoteButtom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNewQuoteButtom.Name = "addNewQuoteButtom";
            this.addNewQuoteButtom.Size = new System.Drawing.Size(244, 78);
            this.addNewQuoteButtom.TabIndex = 0;
            this.addNewQuoteButtom.Text = "Add New Quote";
            this.addNewQuoteButtom.UseVisualStyleBackColor = true;
            this.addNewQuoteButtom.Click += new System.EventHandler(this.addNewQuoteButtom_Click);
            // 
            // viewQuotesButtom
            // 
            this.viewQuotesButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotesButtom.Location = new System.Drawing.Point(60, 135);
            this.viewQuotesButtom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewQuotesButtom.Name = "viewQuotesButtom";
            this.viewQuotesButtom.Size = new System.Drawing.Size(244, 78);
            this.viewQuotesButtom.TabIndex = 1;
            this.viewQuotesButtom.Text = "View Quotes";
            this.viewQuotesButtom.UseVisualStyleBackColor = true;
            this.viewQuotesButtom.Click += new System.EventHandler(this.viewQuotesButtom_Click);
            // 
            // searchQuotesButtom
            // 
            this.searchQuotesButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesButtom.Location = new System.Drawing.Point(60, 220);
            this.searchQuotesButtom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchQuotesButtom.Name = "searchQuotesButtom";
            this.searchQuotesButtom.Size = new System.Drawing.Size(244, 78);
            this.searchQuotesButtom.TabIndex = 2;
            this.searchQuotesButtom.Text = "Search Quotes";
            this.searchQuotesButtom.UseVisualStyleBackColor = true;
            this.searchQuotesButtom.Click += new System.EventHandler(this.searchQuotesButtom_Click);
            // 
            // exitButtom
            // 
            this.exitButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButtom.Location = new System.Drawing.Point(60, 305);
            this.exitButtom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(244, 78);
            this.exitButtom.TabIndex = 3;
            this.exitButtom.Text = "Exit";
            this.exitButtom.UseVisualStyleBackColor = true;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButtom);
            this.Controls.Add(this.searchQuotesButtom);
            this.Controls.Add(this.viewQuotesButtom);
            this.Controls.Add(this.addNewQuoteButtom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Desk Application";
            //this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewQuoteButtom;
        private System.Windows.Forms.Button viewQuotesButtom;
        private System.Windows.Forms.Button searchQuotesButtom;
        private System.Windows.Forms.Button exitButtom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

