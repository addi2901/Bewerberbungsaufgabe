namespace Bewerber_CH_CIT
{
    partial class UserControl_Invoice
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
            this.lbl_InvoiceNum = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_InvoiceAmount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_InvoiceTotalprice = new MaterialSkin.Controls.MaterialLabel();
            this.tb_InvoiceNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_InvoiceAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_InvoiceTotalprice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_InvoiceCreate = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_InvoiceEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_InvoiceDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lbl_InvoiceNum
            // 
            this.lbl_InvoiceNum.AutoSize = true;
            this.lbl_InvoiceNum.Depth = 0;
            this.lbl_InvoiceNum.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_InvoiceNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_InvoiceNum.Location = new System.Drawing.Point(30, 30);
            this.lbl_InvoiceNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_InvoiceNum.Name = "lbl_InvoiceNum";
            this.lbl_InvoiceNum.Size = new System.Drawing.Size(137, 19);
            this.lbl_InvoiceNum.TabIndex = 0;
            this.lbl_InvoiceNum.Text = "Rechnungsnummer";
            // 
            // lbl_InvoiceAmount
            // 
            this.lbl_InvoiceAmount.AutoSize = true;
            this.lbl_InvoiceAmount.Depth = 0;
            this.lbl_InvoiceAmount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_InvoiceAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_InvoiceAmount.Location = new System.Drawing.Point(30, 70);
            this.lbl_InvoiceAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_InvoiceAmount.Name = "lbl_InvoiceAmount";
            this.lbl_InvoiceAmount.Size = new System.Drawing.Size(54, 19);
            this.lbl_InvoiceAmount.TabIndex = 0;
            this.lbl_InvoiceAmount.Text = "Menge";
            // 
            // lbl_InvoiceTotalprice
            // 
            this.lbl_InvoiceTotalprice.AutoSize = true;
            this.lbl_InvoiceTotalprice.Depth = 0;
            this.lbl_InvoiceTotalprice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_InvoiceTotalprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_InvoiceTotalprice.Location = new System.Drawing.Point(30, 110);
            this.lbl_InvoiceTotalprice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_InvoiceTotalprice.Name = "lbl_InvoiceTotalprice";
            this.lbl_InvoiceTotalprice.Size = new System.Drawing.Size(94, 19);
            this.lbl_InvoiceTotalprice.TabIndex = 0;
            this.lbl_InvoiceTotalprice.Text = "Gesamtpreis";
            // 
            // tb_InvoiceNum
            // 
            this.tb_InvoiceNum.Depth = 0;
            this.tb_InvoiceNum.Hint = "";
            this.tb_InvoiceNum.Location = new System.Drawing.Point(173, 26);
            this.tb_InvoiceNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_InvoiceNum.Name = "tb_InvoiceNum";
            this.tb_InvoiceNum.PasswordChar = '\0';
            this.tb_InvoiceNum.SelectedText = "";
            this.tb_InvoiceNum.SelectionLength = 0;
            this.tb_InvoiceNum.SelectionStart = 0;
            this.tb_InvoiceNum.Size = new System.Drawing.Size(215, 23);
            this.tb_InvoiceNum.TabIndex = 1;
            this.tb_InvoiceNum.UseSystemPasswordChar = false;
            // 
            // tb_InvoiceAmount
            // 
            this.tb_InvoiceAmount.Depth = 0;
            this.tb_InvoiceAmount.Hint = "";
            this.tb_InvoiceAmount.Location = new System.Drawing.Point(173, 66);
            this.tb_InvoiceAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_InvoiceAmount.Name = "tb_InvoiceAmount";
            this.tb_InvoiceAmount.PasswordChar = '\0';
            this.tb_InvoiceAmount.SelectedText = "";
            this.tb_InvoiceAmount.SelectionLength = 0;
            this.tb_InvoiceAmount.SelectionStart = 0;
            this.tb_InvoiceAmount.Size = new System.Drawing.Size(215, 23);
            this.tb_InvoiceAmount.TabIndex = 1;
            this.tb_InvoiceAmount.UseSystemPasswordChar = false;
            // 
            // tb_InvoiceTotalprice
            // 
            this.tb_InvoiceTotalprice.Depth = 0;
            this.tb_InvoiceTotalprice.Hint = "";
            this.tb_InvoiceTotalprice.Location = new System.Drawing.Point(173, 106);
            this.tb_InvoiceTotalprice.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_InvoiceTotalprice.Name = "tb_InvoiceTotalprice";
            this.tb_InvoiceTotalprice.PasswordChar = '\0';
            this.tb_InvoiceTotalprice.SelectedText = "";
            this.tb_InvoiceTotalprice.SelectionLength = 0;
            this.tb_InvoiceTotalprice.SelectionStart = 0;
            this.tb_InvoiceTotalprice.Size = new System.Drawing.Size(215, 23);
            this.tb_InvoiceTotalprice.TabIndex = 1;
            this.tb_InvoiceTotalprice.UseSystemPasswordChar = false;
            // 
            // btn_InvoiceCreate
            // 
            this.btn_InvoiceCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_InvoiceCreate.Depth = 0;
            this.btn_InvoiceCreate.Location = new System.Drawing.Point(400, 20);
            this.btn_InvoiceCreate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_InvoiceCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_InvoiceCreate.Name = "btn_InvoiceCreate";
            this.btn_InvoiceCreate.Primary = false;
            this.btn_InvoiceCreate.Size = new System.Drawing.Size(175, 30);
            this.btn_InvoiceCreate.TabIndex = 2;
            this.btn_InvoiceCreate.Text = "Rechnung erstellen";
            this.btn_InvoiceCreate.UseVisualStyleBackColor = true;
            // 
            // btn_InvoiceEdit
            // 
            this.btn_InvoiceEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_InvoiceEdit.Depth = 0;
            this.btn_InvoiceEdit.Location = new System.Drawing.Point(400, 60);
            this.btn_InvoiceEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_InvoiceEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_InvoiceEdit.Name = "btn_InvoiceEdit";
            this.btn_InvoiceEdit.Primary = false;
            this.btn_InvoiceEdit.Size = new System.Drawing.Size(175, 30);
            this.btn_InvoiceEdit.TabIndex = 3;
            this.btn_InvoiceEdit.Text = "Rechnung bearbeiten";
            this.btn_InvoiceEdit.UseVisualStyleBackColor = true;
            // 
            // btn_InvoiceDelete
            // 
            this.btn_InvoiceDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_InvoiceDelete.Depth = 0;
            this.btn_InvoiceDelete.Location = new System.Drawing.Point(400, 100);
            this.btn_InvoiceDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_InvoiceDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_InvoiceDelete.Name = "btn_InvoiceDelete";
            this.btn_InvoiceDelete.Primary = false;
            this.btn_InvoiceDelete.Size = new System.Drawing.Size(175, 35);
            this.btn_InvoiceDelete.TabIndex = 4;
            this.btn_InvoiceDelete.Text = "Rechnung löschen";
            this.btn_InvoiceDelete.UseVisualStyleBackColor = true;
            // 
            // UserControl_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.Controls.Add(this.btn_InvoiceDelete);
            this.Controls.Add(this.btn_InvoiceEdit);
            this.Controls.Add(this.btn_InvoiceCreate);
            this.Controls.Add(this.tb_InvoiceTotalprice);
            this.Controls.Add(this.tb_InvoiceAmount);
            this.Controls.Add(this.tb_InvoiceNum);
            this.Controls.Add(this.lbl_InvoiceTotalprice);
            this.Controls.Add(this.lbl_InvoiceAmount);
            this.Controls.Add(this.lbl_InvoiceNum);
            this.Name = "UserControl_Invoice";
            this.Size = new System.Drawing.Size(930, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_InvoiceNum;
        private MaterialSkin.Controls.MaterialLabel lbl_InvoiceAmount;
        private MaterialSkin.Controls.MaterialLabel lbl_InvoiceTotalprice;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_InvoiceNum;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_InvoiceAmount;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_InvoiceTotalprice;
        private MaterialSkin.Controls.MaterialFlatButton btn_InvoiceCreate;
        private MaterialSkin.Controls.MaterialFlatButton btn_InvoiceEdit;
        private MaterialSkin.Controls.MaterialFlatButton btn_InvoiceDelete;
    }
}
