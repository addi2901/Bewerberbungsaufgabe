namespace Bewerber_CH_CIT
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_Invoice = new System.Windows.Forms.Button();
            this.userControl_InvoiceDGV1 = new Bewerber_CH_CIT.UserControl_InvoiceDGV();
            this.userControl_ProductDGV1 = new Bewerber_CH_CIT.UserControl_ProductDGV();
            this.userControl_CustomerDGV1 = new Bewerber_CH_CIT.UserControl_CustomerDGV();
            this.SuspendLayout();
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(94)))), ((int)(((byte)(100)))));
            this.btn_Customer.FlatAppearance.BorderSize = 0;
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.Location = new System.Drawing.Point(0, 0);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(330, 62);
            this.btn_Customer.TabIndex = 0;
            this.btn_Customer.Text = "Kunden";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(94)))), ((int)(((byte)(100)))));
            this.btn_Product.FlatAppearance.BorderSize = 0;
            this.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Product.Location = new System.Drawing.Point(327, 0);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(330, 62);
            this.btn_Product.TabIndex = 0;
            this.btn_Product.Text = "Artikel";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Invoice
            // 
            this.btn_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(94)))), ((int)(((byte)(100)))));
            this.btn_Invoice.FlatAppearance.BorderSize = 0;
            this.btn_Invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Invoice.Location = new System.Drawing.Point(654, 0);
            this.btn_Invoice.Name = "btn_Invoice";
            this.btn_Invoice.Size = new System.Drawing.Size(330, 62);
            this.btn_Invoice.TabIndex = 0;
            this.btn_Invoice.Text = "Rechnung";
            this.btn_Invoice.UseVisualStyleBackColor = false;
            this.btn_Invoice.Click += new System.EventHandler(this.btn_Invoice_Click);
            // 
            // userControl_InvoiceDGV1
            // 
            this.userControl_InvoiceDGV1.Location = new System.Drawing.Point(4, 68);
            this.userControl_InvoiceDGV1.Name = "userControl_InvoiceDGV1";
            this.userControl_InvoiceDGV1.Size = new System.Drawing.Size(980, 530);
            this.userControl_InvoiceDGV1.TabIndex = 1;
            // 
            // userControl_ProductDGV1
            // 
            this.userControl_ProductDGV1.Location = new System.Drawing.Point(4, 69);
            this.userControl_ProductDGV1.Name = "userControl_ProductDGV1";
            this.userControl_ProductDGV1.Size = new System.Drawing.Size(980, 530);
            this.userControl_ProductDGV1.TabIndex = 2;
            // 
            // userControl_CustomerDGV1
            // 
            this.userControl_CustomerDGV1.Location = new System.Drawing.Point(4, 68);
            this.userControl_CustomerDGV1.Name = "userControl_CustomerDGV1";
            this.userControl_CustomerDGV1.Size = new System.Drawing.Size(980, 530);
            this.userControl_CustomerDGV1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.userControl_CustomerDGV1);
            this.Controls.Add(this.userControl_ProductDGV1);
            this.Controls.Add(this.userControl_InvoiceDGV1);
            this.Controls.Add(this.btn_Invoice);
            this.Controls.Add(this.btn_Product);
            this.Controls.Add(this.btn_Customer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_Invoice;
        private UserControl_InvoiceDGV userControl_InvoiceDGV1;
        private UserControl_ProductDGV userControl_ProductDGV1;
        private UserControl_CustomerDGV userControl_CustomerDGV1;
    }
}

