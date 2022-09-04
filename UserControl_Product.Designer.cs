namespace Bewerber_CH_CIT
{
    partial class UserControl_Product
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
            this.lbl_ProductNum = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_ProductDescription = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_ProductStock = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_ProductPrice = new MaterialSkin.Controls.MaterialLabel();
            this.tb_ProductNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_ProductDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_ProductStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_ProductPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_ProductAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_ProductUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_ProductDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lbl_ProductNum
            // 
            this.lbl_ProductNum.AutoSize = true;
            this.lbl_ProductNum.Depth = 0;
            this.lbl_ProductNum.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_ProductNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ProductNum.Location = new System.Drawing.Point(30, 30);
            this.lbl_ProductNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ProductNum.Name = "lbl_ProductNum";
            this.lbl_ProductNum.Size = new System.Drawing.Size(108, 19);
            this.lbl_ProductNum.TabIndex = 0;
            this.lbl_ProductNum.Text = "Artikelnummer";
            // 
            // lbl_ProductDescription
            // 
            this.lbl_ProductDescription.AutoSize = true;
            this.lbl_ProductDescription.Depth = 0;
            this.lbl_ProductDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_ProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ProductDescription.Location = new System.Drawing.Point(30, 70);
            this.lbl_ProductDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ProductDescription.Name = "lbl_ProductDescription";
            this.lbl_ProductDescription.Size = new System.Drawing.Size(99, 19);
            this.lbl_ProductDescription.TabIndex = 0;
            this.lbl_ProductDescription.Text = "Beschreibung";
            // 
            // lbl_ProductStock
            // 
            this.lbl_ProductStock.AutoSize = true;
            this.lbl_ProductStock.Depth = 0;
            this.lbl_ProductStock.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_ProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ProductStock.Location = new System.Drawing.Point(30, 110);
            this.lbl_ProductStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ProductStock.Name = "lbl_ProductStock";
            this.lbl_ProductStock.Size = new System.Drawing.Size(99, 19);
            this.lbl_ProductStock.TabIndex = 0;
            this.lbl_ProductStock.Text = "Lagerbestand";
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Depth = 0;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_ProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(30, 150);
            this.lbl_ProductPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(43, 19);
            this.lbl_ProductPrice.TabIndex = 0;
            this.lbl_ProductPrice.Text = "Preis";
            // 
            // tb_ProductNum
            // 
            this.tb_ProductNum.Depth = 0;
            this.tb_ProductNum.Hint = "";
            this.tb_ProductNum.Location = new System.Drawing.Point(156, 26);
            this.tb_ProductNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_ProductNum.Name = "tb_ProductNum";
            this.tb_ProductNum.PasswordChar = '\0';
            this.tb_ProductNum.SelectedText = "";
            this.tb_ProductNum.SelectionLength = 0;
            this.tb_ProductNum.SelectionStart = 0;
            this.tb_ProductNum.Size = new System.Drawing.Size(215, 23);
            this.tb_ProductNum.TabIndex = 1;
            this.tb_ProductNum.UseSystemPasswordChar = false;
            // 
            // tb_ProductDescription
            // 
            this.tb_ProductDescription.Depth = 0;
            this.tb_ProductDescription.Hint = "";
            this.tb_ProductDescription.Location = new System.Drawing.Point(156, 66);
            this.tb_ProductDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_ProductDescription.Name = "tb_ProductDescription";
            this.tb_ProductDescription.PasswordChar = '\0';
            this.tb_ProductDescription.SelectedText = "";
            this.tb_ProductDescription.SelectionLength = 0;
            this.tb_ProductDescription.SelectionStart = 0;
            this.tb_ProductDescription.Size = new System.Drawing.Size(215, 23);
            this.tb_ProductDescription.TabIndex = 1;
            this.tb_ProductDescription.UseSystemPasswordChar = false;
            // 
            // tb_ProductStock
            // 
            this.tb_ProductStock.Depth = 0;
            this.tb_ProductStock.Hint = "";
            this.tb_ProductStock.Location = new System.Drawing.Point(156, 106);
            this.tb_ProductStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_ProductStock.Name = "tb_ProductStock";
            this.tb_ProductStock.PasswordChar = '\0';
            this.tb_ProductStock.SelectedText = "";
            this.tb_ProductStock.SelectionLength = 0;
            this.tb_ProductStock.SelectionStart = 0;
            this.tb_ProductStock.Size = new System.Drawing.Size(215, 23);
            this.tb_ProductStock.TabIndex = 1;
            this.tb_ProductStock.UseSystemPasswordChar = false;
            // 
            // tb_ProductPrice
            // 
            this.tb_ProductPrice.Depth = 0;
            this.tb_ProductPrice.Hint = "";
            this.tb_ProductPrice.Location = new System.Drawing.Point(156, 146);
            this.tb_ProductPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_ProductPrice.Name = "tb_ProductPrice";
            this.tb_ProductPrice.PasswordChar = '\0';
            this.tb_ProductPrice.SelectedText = "";
            this.tb_ProductPrice.SelectionLength = 0;
            this.tb_ProductPrice.SelectionStart = 0;
            this.tb_ProductPrice.Size = new System.Drawing.Size(215, 23);
            this.tb_ProductPrice.TabIndex = 1;
            this.tb_ProductPrice.UseSystemPasswordChar = false;
            // 
            // btn_ProductAdd
            // 
            this.btn_ProductAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ProductAdd.Depth = 0;
            this.btn_ProductAdd.Location = new System.Drawing.Point(380, 20);
            this.btn_ProductAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ProductAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ProductAdd.Name = "btn_ProductAdd";
            this.btn_ProductAdd.Primary = false;
            this.btn_ProductAdd.Size = new System.Drawing.Size(150, 30);
            this.btn_ProductAdd.TabIndex = 2;
            this.btn_ProductAdd.Text = "Artikel hinzufügen";
            this.btn_ProductAdd.UseVisualStyleBackColor = true;
            // 
            // btn_ProductUpdate
            // 
            this.btn_ProductUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ProductUpdate.Depth = 0;
            this.btn_ProductUpdate.Location = new System.Drawing.Point(380, 60);
            this.btn_ProductUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ProductUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ProductUpdate.Name = "btn_ProductUpdate";
            this.btn_ProductUpdate.Primary = false;
            this.btn_ProductUpdate.Size = new System.Drawing.Size(167, 30);
            this.btn_ProductUpdate.TabIndex = 2;
            this.btn_ProductUpdate.Text = "Artikel aktualisieren";
            this.btn_ProductUpdate.UseVisualStyleBackColor = true;
            // 
            // btn_ProductDelete
            // 
            this.btn_ProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ProductDelete.Depth = 0;
            this.btn_ProductDelete.Location = new System.Drawing.Point(380, 100);
            this.btn_ProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ProductDelete.Name = "btn_ProductDelete";
            this.btn_ProductDelete.Primary = false;
            this.btn_ProductDelete.Size = new System.Drawing.Size(150, 30);
            this.btn_ProductDelete.TabIndex = 2;
            this.btn_ProductDelete.Text = "Artikel löschen";
            this.btn_ProductDelete.UseVisualStyleBackColor = true;
            // 
            // UserControl_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.Controls.Add(this.btn_ProductDelete);
            this.Controls.Add(this.btn_ProductUpdate);
            this.Controls.Add(this.btn_ProductAdd);
            this.Controls.Add(this.tb_ProductPrice);
            this.Controls.Add(this.tb_ProductStock);
            this.Controls.Add(this.tb_ProductDescription);
            this.Controls.Add(this.tb_ProductNum);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.lbl_ProductStock);
            this.Controls.Add(this.lbl_ProductDescription);
            this.Controls.Add(this.lbl_ProductNum);
            this.Name = "UserControl_Product";
            this.Size = new System.Drawing.Size(930, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_ProductNum;
        private MaterialSkin.Controls.MaterialLabel lbl_ProductDescription;
        private MaterialSkin.Controls.MaterialLabel lbl_ProductStock;
        private MaterialSkin.Controls.MaterialLabel lbl_ProductPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_ProductNum;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_ProductDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_ProductStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_ProductPrice;
        private MaterialSkin.Controls.MaterialFlatButton btn_ProductAdd;
        private MaterialSkin.Controls.MaterialFlatButton btn_ProductUpdate;
        private MaterialSkin.Controls.MaterialFlatButton btn_ProductDelete;
    }
}
