namespace Bewerber_CH_CIT
{
    partial class UserControl_ProductDGV
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
            this.DGV_Product = new System.Windows.Forms.DataGridView();
            this.Artikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Einzelpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lagerbestand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Product
            // 
            this.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikelnummer,
            this.Beschreibung,
            this.Einzelpreis,
            this.Lagerbestand});
            this.DGV_Product.Location = new System.Drawing.Point(20, 360);
            this.DGV_Product.Name = "DGV_Product";
            this.DGV_Product.Size = new System.Drawing.Size(700, 150);
            this.DGV_Product.TabIndex = 0;
            this.DGV_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Product_CellContentClick);
            // 
            // Artikelnummer
            // 
            this.Artikelnummer.HeaderText = "Artikelnummer";
            this.Artikelnummer.Name = "Artikelnummer";
            // 
            // Beschreibung
            // 
            this.Beschreibung.HeaderText = "Beschreibung";
            this.Beschreibung.Name = "Beschreibung";
            // 
            // Einzelpreis
            // 
            this.Einzelpreis.HeaderText = "Einzelpreis";
            this.Einzelpreis.Name = "Einzelpreis";
            // 
            // Lagerbestand
            // 
            this.Lagerbestand.HeaderText = "Lagerbestand";
            this.Lagerbestand.Name = "Lagerbestand";
            // 
            // UserControl_ProductDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV_Product);
            this.Name = "UserControl_ProductDGV";
            this.Size = new System.Drawing.Size(980, 530);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Einzelpreis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lagerbestand;
    }
}
