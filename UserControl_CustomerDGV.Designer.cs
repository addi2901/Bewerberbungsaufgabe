namespace Bewerber_CH_CIT
{
    partial class UserControl_CustomerDGV
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
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.btn_CustomerUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_CustomerDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_CustomerAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.tb_CustomerAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_CustomerMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_CustomerLastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_CustomerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_CustomerID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_CustomerAdress = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_CustomerMail = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_CustomerLastname = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_CustomerName = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_CustomerID = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Location = new System.Drawing.Point(20, 360);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.Size = new System.Drawing.Size(700, 150);
            this.DGV_Customer.TabIndex = 0;
            this.DGV_Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_CellContentClick);
            // 
            // btn_CustomerUpdate
            // 
            this.btn_CustomerUpdate.AutoSize = true;
            this.btn_CustomerUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CustomerUpdate.Depth = 0;
            this.btn_CustomerUpdate.Location = new System.Drawing.Point(355, 62);
            this.btn_CustomerUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CustomerUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CustomerUpdate.Name = "btn_CustomerUpdate";
            this.btn_CustomerUpdate.Primary = false;
            this.btn_CustomerUpdate.Size = new System.Drawing.Size(121, 36);
            this.btn_CustomerUpdate.TabIndex = 13;
            this.btn_CustomerUpdate.Text = "Kunde updaten";
            this.btn_CustomerUpdate.UseVisualStyleBackColor = true;
            this.btn_CustomerUpdate.Click += new System.EventHandler(this.btn_CustomerUpdate_Click);
            // 
            // btn_CustomerDelete
            // 
            this.btn_CustomerDelete.AutoSize = true;
            this.btn_CustomerDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CustomerDelete.Depth = 0;
            this.btn_CustomerDelete.Location = new System.Drawing.Point(355, 102);
            this.btn_CustomerDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CustomerDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CustomerDelete.Name = "btn_CustomerDelete";
            this.btn_CustomerDelete.Primary = false;
            this.btn_CustomerDelete.Size = new System.Drawing.Size(121, 36);
            this.btn_CustomerDelete.TabIndex = 14;
            this.btn_CustomerDelete.Text = "Kunde löschen";
            this.btn_CustomerDelete.UseVisualStyleBackColor = true;
            this.btn_CustomerDelete.Click += new System.EventHandler(this.btn_CustomerDelete_Click);
            // 
            // btn_CustomerAdd
            // 
            this.btn_CustomerAdd.AutoSize = true;
            this.btn_CustomerAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CustomerAdd.Depth = 0;
            this.btn_CustomerAdd.Location = new System.Drawing.Point(355, 22);
            this.btn_CustomerAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CustomerAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CustomerAdd.Name = "btn_CustomerAdd";
            this.btn_CustomerAdd.Primary = false;
            this.btn_CustomerAdd.Size = new System.Drawing.Size(143, 36);
            this.btn_CustomerAdd.TabIndex = 15;
            this.btn_CustomerAdd.Text = "Kunde hinzufügen";
            this.btn_CustomerAdd.UseVisualStyleBackColor = true;
            this.btn_CustomerAdd.Click += new System.EventHandler(this.btn_CustomerAdd_Click);
            // 
            // tb_CustomerAdress
            // 
            this.tb_CustomerAdress.Depth = 0;
            this.tb_CustomerAdress.Hint = "";
            this.tb_CustomerAdress.Location = new System.Drawing.Point(120, 188);
            this.tb_CustomerAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CustomerAdress.Name = "tb_CustomerAdress";
            this.tb_CustomerAdress.PasswordChar = '\0';
            this.tb_CustomerAdress.SelectedText = "";
            this.tb_CustomerAdress.SelectionLength = 0;
            this.tb_CustomerAdress.SelectionStart = 0;
            this.tb_CustomerAdress.Size = new System.Drawing.Size(215, 23);
            this.tb_CustomerAdress.TabIndex = 8;
            this.tb_CustomerAdress.UseSystemPasswordChar = false;
            // 
            // tb_CustomerMail
            // 
            this.tb_CustomerMail.Depth = 0;
            this.tb_CustomerMail.Hint = "";
            this.tb_CustomerMail.Location = new System.Drawing.Point(120, 148);
            this.tb_CustomerMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CustomerMail.Name = "tb_CustomerMail";
            this.tb_CustomerMail.PasswordChar = '\0';
            this.tb_CustomerMail.SelectedText = "";
            this.tb_CustomerMail.SelectionLength = 0;
            this.tb_CustomerMail.SelectionStart = 0;
            this.tb_CustomerMail.Size = new System.Drawing.Size(215, 23);
            this.tb_CustomerMail.TabIndex = 9;
            this.tb_CustomerMail.UseSystemPasswordChar = false;
            // 
            // tb_CustomerLastname
            // 
            this.tb_CustomerLastname.Depth = 0;
            this.tb_CustomerLastname.Hint = "";
            this.tb_CustomerLastname.Location = new System.Drawing.Point(120, 108);
            this.tb_CustomerLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CustomerLastname.Name = "tb_CustomerLastname";
            this.tb_CustomerLastname.PasswordChar = '\0';
            this.tb_CustomerLastname.SelectedText = "";
            this.tb_CustomerLastname.SelectionLength = 0;
            this.tb_CustomerLastname.SelectionStart = 0;
            this.tb_CustomerLastname.Size = new System.Drawing.Size(215, 23);
            this.tb_CustomerLastname.TabIndex = 10;
            this.tb_CustomerLastname.UseSystemPasswordChar = false;
            // 
            // tb_CustomerName
            // 
            this.tb_CustomerName.Depth = 0;
            this.tb_CustomerName.Hint = "";
            this.tb_CustomerName.Location = new System.Drawing.Point(120, 68);
            this.tb_CustomerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CustomerName.Name = "tb_CustomerName";
            this.tb_CustomerName.PasswordChar = '\0';
            this.tb_CustomerName.SelectedText = "";
            this.tb_CustomerName.SelectionLength = 0;
            this.tb_CustomerName.SelectionStart = 0;
            this.tb_CustomerName.Size = new System.Drawing.Size(215, 23);
            this.tb_CustomerName.TabIndex = 11;
            this.tb_CustomerName.UseSystemPasswordChar = false;
            // 
            // tb_CustomerID
            // 
            this.tb_CustomerID.Depth = 0;
            this.tb_CustomerID.Hint = "";
            this.tb_CustomerID.Location = new System.Drawing.Point(120, 28);
            this.tb_CustomerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CustomerID.Name = "tb_CustomerID";
            this.tb_CustomerID.PasswordChar = '\0';
            this.tb_CustomerID.SelectedText = "";
            this.tb_CustomerID.SelectionLength = 0;
            this.tb_CustomerID.SelectionStart = 0;
            this.tb_CustomerID.Size = new System.Drawing.Size(215, 23);
            this.tb_CustomerID.TabIndex = 12;
            this.tb_CustomerID.UseSystemPasswordChar = false;
            // 
            // lbl_CustomerAdress
            // 
            this.lbl_CustomerAdress.AutoSize = true;
            this.lbl_CustomerAdress.Depth = 0;
            this.lbl_CustomerAdress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CustomerAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CustomerAdress.Location = new System.Drawing.Point(20, 192);
            this.lbl_CustomerAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CustomerAdress.Name = "lbl_CustomerAdress";
            this.lbl_CustomerAdress.Size = new System.Drawing.Size(64, 19);
            this.lbl_CustomerAdress.TabIndex = 3;
            this.lbl_CustomerAdress.Text = "Adresse";
            // 
            // lbl_CustomerMail
            // 
            this.lbl_CustomerMail.AutoSize = true;
            this.lbl_CustomerMail.Depth = 0;
            this.lbl_CustomerMail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CustomerMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CustomerMail.Location = new System.Drawing.Point(20, 152);
            this.lbl_CustomerMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CustomerMail.Name = "lbl_CustomerMail";
            this.lbl_CustomerMail.Size = new System.Drawing.Size(51, 19);
            this.lbl_CustomerMail.TabIndex = 4;
            this.lbl_CustomerMail.Text = "E-Mail";
            // 
            // lbl_CustomerLastname
            // 
            this.lbl_CustomerLastname.AutoSize = true;
            this.lbl_CustomerLastname.Depth = 0;
            this.lbl_CustomerLastname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CustomerLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CustomerLastname.Location = new System.Drawing.Point(20, 112);
            this.lbl_CustomerLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CustomerLastname.Name = "lbl_CustomerLastname";
            this.lbl_CustomerLastname.Size = new System.Drawing.Size(81, 19);
            this.lbl_CustomerLastname.TabIndex = 5;
            this.lbl_CustomerLastname.Text = "Nachname";
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Depth = 0;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CustomerName.Location = new System.Drawing.Point(20, 72);
            this.lbl_CustomerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(70, 19);
            this.lbl_CustomerName.TabIndex = 6;
            this.lbl_CustomerName.Text = "Vorname";
            // 
            // lbl_CustomerID
            // 
            this.lbl_CustomerID.AutoSize = true;
            this.lbl_CustomerID.Depth = 0;
            this.lbl_CustomerID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CustomerID.Location = new System.Drawing.Point(20, 32);
            this.lbl_CustomerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CustomerID.Name = "lbl_CustomerID";
            this.lbl_CustomerID.Size = new System.Drawing.Size(72, 19);
            this.lbl_CustomerID.TabIndex = 7;
            this.lbl_CustomerID.Text = "KundenID";
            // 
            // UserControl_CustomerDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(86)))), ((int)(((byte)(92)))));
            this.Controls.Add(this.btn_CustomerUpdate);
            this.Controls.Add(this.btn_CustomerDelete);
            this.Controls.Add(this.btn_CustomerAdd);
            this.Controls.Add(this.tb_CustomerAdress);
            this.Controls.Add(this.tb_CustomerMail);
            this.Controls.Add(this.tb_CustomerLastname);
            this.Controls.Add(this.tb_CustomerName);
            this.Controls.Add(this.tb_CustomerID);
            this.Controls.Add(this.lbl_CustomerAdress);
            this.Controls.Add(this.lbl_CustomerMail);
            this.Controls.Add(this.lbl_CustomerLastname);
            this.Controls.Add(this.lbl_CustomerName);
            this.Controls.Add(this.lbl_CustomerID);
            this.Controls.Add(this.DGV_Customer);
            this.Name = "UserControl_CustomerDGV";
            this.Size = new System.Drawing.Size(980, 530);
            this.Load += new System.EventHandler(this.UserControl_CustomerDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Customer;
        private MaterialSkin.Controls.MaterialFlatButton btn_CustomerUpdate;
        private MaterialSkin.Controls.MaterialFlatButton btn_CustomerDelete;
        private MaterialSkin.Controls.MaterialFlatButton btn_CustomerAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CustomerAdress;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CustomerMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CustomerLastname;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CustomerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CustomerID;
        private MaterialSkin.Controls.MaterialLabel lbl_CustomerAdress;
        private MaterialSkin.Controls.MaterialLabel lbl_CustomerMail;
        private MaterialSkin.Controls.MaterialLabel lbl_CustomerLastname;
        private MaterialSkin.Controls.MaterialLabel lbl_CustomerName;
        private MaterialSkin.Controls.MaterialLabel lbl_CustomerID;
    }
}
