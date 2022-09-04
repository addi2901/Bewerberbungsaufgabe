namespace Bewerber_CH_CIT
{
    partial class UserControl_InvoiceDGV
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Invoice = new System.Windows.Forms.DataGridView();
            this.Rechnungsnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kundennummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kundenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gesamtpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Invoice
            // 
            this.DGV_Invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rechnungsnummer,
            this.Kundennummer,
            this.Kundenname,
            this.Artikelnummer,
            this.Menge,
            this.Gesamtpreis});
            this.DGV_Invoice.Location = new System.Drawing.Point(20, 360);
            this.DGV_Invoice.Name = "DGV_Invoice";
            this.DGV_Invoice.Size = new System.Drawing.Size(700, 150);
            this.DGV_Invoice.TabIndex = 0;
            // 
            // Rechnungsnummer
            // 
            this.Rechnungsnummer.HeaderText = "Rechnungsnummer";
            this.Rechnungsnummer.Name = "Rechnungsnummer";
            // 
            // Kundennummer
            // 
            this.Kundennummer.HeaderText = "Kundennummer";
            this.Kundennummer.Name = "Kundennummer";
            // 
            // Kundenname
            // 
            this.Kundenname.HeaderText = "Kundenname";
            this.Kundenname.Name = "Kundenname";
            // 
            // Artikelnummer
            // 
            this.Artikelnummer.HeaderText = "Artikelnummer";
            this.Artikelnummer.Name = "Artikelnummer";
            // 
            // Menge
            // 
            this.Menge.HeaderText = "Menge";
            this.Menge.Name = "Menge";
            // 
            // Gesamtpreis
            // 
            this.Gesamtpreis.HeaderText = "Gesamtpreis";
            this.Gesamtpreis.Name = "Gesamtpreis";
            // 
            // UserControl_InvoiceDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV_Invoice);
            this.Name = "UserControl_InvoiceDGV";
            this.Size = new System.Drawing.Size(980, 530);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Invoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rechnungsnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kundennummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kundenname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gesamtpreis;
    }
}
