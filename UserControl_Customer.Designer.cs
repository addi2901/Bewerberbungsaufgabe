namespace Bewerber_CH_CIT
{
    partial class UserControl_Customer
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
            this.lbl_CustomerID = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_CustomerName = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_CustomerLastname = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_CustomerMail = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_CustomerAdress = new MaterialSkin.Controls.MaterialLabel();
            this.tb_CustomerID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_CustomerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_CustomerLastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_CustomerMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_CustomerAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_CustomerAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_CustomerDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_CustomerUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lbl_CustomerID
            // 
            this.lbl_CustomerID.AutoSize = true;
            this.lbl_CustomerID.Depth = 0;
            this.lbl_CustomerID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CustomerID.Location = new System.Drawing.Point(30, 30);
            this.lbl_CustomerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CustomerID.Name = "lbl_CustomerID";
            this.lbl_CustomerID.Size = new System.Drawing.Size(72, 19);
            this.lbl_CustomerID.TabIndex = 0;
            this.lbl_CustomerID.Text = "KundenID";
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Depth = 0;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CustomerName.Location = new System.Drawing.Point(30, 70);
            this.lbl_CustomerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(70, 19);
            this.lbl_CustomerName.TabIndex = 0;
            this.lbl_CustomerName.Text = "Vorname";
            // 
            // lbl_CustomerLastname
            // 
            this.lbl_CustomerLastname.AutoSize = true;
            this.lbl_CustomerLastname.Depth = 0;
            this.lbl_CustomerLastname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CustomerLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CustomerLastname.Location = new System.Drawing.Point(30, 110);
            this.lbl_CustomerLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CustomerLastname.Name = "lbl_CustomerLastname";
            this.lbl_CustomerLastname.Size = new System.Drawing.Size(81, 19);
            this.lbl_CustomerLastname.TabIndex = 0;
            this.lbl_CustomerLastname.Text = "Nachname";
            // 
            // lbl_CustomerMail
            // 
            this.lbl_CustomerMail.AutoSize = true;
            this.lbl_CustomerMail.Depth = 0;
            this.lbl_CustomerMail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CustomerMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CustomerMail.Location = new System.Drawing.Point(30, 150);
            this.lbl_CustomerMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CustomerMail.Name = "lbl_CustomerMail";
            this.lbl_CustomerMail.Size = new System.Drawing.Size(51, 19);
            this.lbl_CustomerMail.TabIndex = 0;
            this.lbl_CustomerMail.Text = "E-Mail";
            // 
            // lbl_CustomerAdress
            // 
            this.lbl_CustomerAdress.AutoSize = true;
            this.lbl_CustomerAdress.Depth = 0;
            this.lbl_CustomerAdress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_CustomerAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_CustomerAdress.Location = new System.Drawing.Point(30, 190);
            this.lbl_CustomerAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CustomerAdress.Name = "lbl_CustomerAdress";
            this.lbl_CustomerAdress.Size = new System.Drawing.Size(64, 19);
            this.lbl_CustomerAdress.TabIndex = 0;
            this.lbl_CustomerAdress.Text = "Adresse";
            // 
            // tb_CustomerID
            // 
            this.tb_CustomerID.Depth = 0;
            this.tb_CustomerID.Hint = "";
            this.tb_CustomerID.Location = new System.Drawing.Point(130, 26);
            this.tb_CustomerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CustomerID.Name = "tb_CustomerID";
            this.tb_CustomerID.PasswordChar = '\0';
            this.tb_CustomerID.SelectedText = "";
            this.tb_CustomerID.SelectionLength = 0;
            this.tb_CustomerID.SelectionStart = 0;
            this.tb_CustomerID.Size = new System.Drawing.Size(215, 23);
            this.tb_CustomerID.TabIndex = 1;
            this.tb_CustomerID.UseSystemPasswordChar = false;
            this.tb_CustomerID.Click += new System.EventHandler(this.tb_CustomerID_Click);
            // 
            // tb_CustomerName
            // 
            this.tb_CustomerName.Depth = 0;
            this.tb_CustomerName.Hint = "";
            this.tb_CustomerName.Location = new System.Drawing.Point(130, 66);
            this.tb_CustomerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CustomerName.Name = "tb_CustomerName";
            this.tb_CustomerName.PasswordChar = '\0';
            this.tb_CustomerName.SelectedText = "";
            this.tb_CustomerName.SelectionLength = 0;
            this.tb_CustomerName.SelectionStart = 0;
            this.tb_CustomerName.Size = new System.Drawing.Size(215, 23);
            this.tb_CustomerName.TabIndex = 1;
            this.tb_CustomerName.UseSystemPasswordChar = false;
            this.tb_CustomerName.Click += new System.EventHandler(this.tb_CustomerName_Click);
            // 
            // tb_CustomerLastname
            // 
            this.tb_CustomerLastname.Depth = 0;
            this.tb_CustomerLastname.Hint = "";
            this.tb_CustomerLastname.Location = new System.Drawing.Point(130, 106);
            this.tb_CustomerLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CustomerLastname.Name = "tb_CustomerLastname";
            this.tb_CustomerLastname.PasswordChar = '\0';
            this.tb_CustomerLastname.SelectedText = "";
            this.tb_CustomerLastname.SelectionLength = 0;
            this.tb_CustomerLastname.SelectionStart = 0;
            this.tb_CustomerLastname.Size = new System.Drawing.Size(215, 23);
            this.tb_CustomerLastname.TabIndex = 1;
            this.tb_CustomerLastname.UseSystemPasswordChar = false;
            this.tb_CustomerLastname.Click += new System.EventHandler(this.tb_CustomerLastname_Click);
            // 
            // tb_CustomerMail
            // 
            this.tb_CustomerMail.Depth = 0;
            this.tb_CustomerMail.Hint = "";
            this.tb_CustomerMail.Location = new System.Drawing.Point(130, 146);
            this.tb_CustomerMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CustomerMail.Name = "tb_CustomerMail";
            this.tb_CustomerMail.PasswordChar = '\0';
            this.tb_CustomerMail.SelectedText = "";
            this.tb_CustomerMail.SelectionLength = 0;
            this.tb_CustomerMail.SelectionStart = 0;
            this.tb_CustomerMail.Size = new System.Drawing.Size(215, 23);
            this.tb_CustomerMail.TabIndex = 1;
            this.tb_CustomerMail.UseSystemPasswordChar = false;
            this.tb_CustomerMail.Click += new System.EventHandler(this.tb_CustomerMail_Click);
            // 
            // tb_CustomerAdress
            // 
            this.tb_CustomerAdress.Depth = 0;
            this.tb_CustomerAdress.Hint = "";
            this.tb_CustomerAdress.Location = new System.Drawing.Point(130, 186);
            this.tb_CustomerAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_CustomerAdress.Name = "tb_CustomerAdress";
            this.tb_CustomerAdress.PasswordChar = '\0';
            this.tb_CustomerAdress.SelectedText = "";
            this.tb_CustomerAdress.SelectionLength = 0;
            this.tb_CustomerAdress.SelectionStart = 0;
            this.tb_CustomerAdress.Size = new System.Drawing.Size(215, 23);
            this.tb_CustomerAdress.TabIndex = 1;
            this.tb_CustomerAdress.UseSystemPasswordChar = false;
            this.tb_CustomerAdress.Click += new System.EventHandler(this.tb_CustomerAdress_Click);
            // 
            // btn_CustomerAdd
            // 
            this.btn_CustomerAdd.AutoSize = true;
            this.btn_CustomerAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CustomerAdd.Depth = 0;
            this.btn_CustomerAdd.Location = new System.Drawing.Point(365, 20);
            this.btn_CustomerAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CustomerAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CustomerAdd.Name = "btn_CustomerAdd";
            this.btn_CustomerAdd.Primary = false;
            this.btn_CustomerAdd.Size = new System.Drawing.Size(143, 36);
            this.btn_CustomerAdd.TabIndex = 2;
            this.btn_CustomerAdd.Text = "Kunde hinzufügen";
            this.btn_CustomerAdd.UseVisualStyleBackColor = true;
            this.btn_CustomerAdd.Click += new System.EventHandler(this.btn_CustomerAdd_Click);
            // 
            // btn_CustomerDelete
            // 
            this.btn_CustomerDelete.AutoSize = true;
            this.btn_CustomerDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CustomerDelete.Depth = 0;
            this.btn_CustomerDelete.Location = new System.Drawing.Point(365, 100);
            this.btn_CustomerDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CustomerDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CustomerDelete.Name = "btn_CustomerDelete";
            this.btn_CustomerDelete.Primary = false;
            this.btn_CustomerDelete.Size = new System.Drawing.Size(121, 36);
            this.btn_CustomerDelete.TabIndex = 2;
            this.btn_CustomerDelete.Text = "Kunde löschen";
            this.btn_CustomerDelete.UseVisualStyleBackColor = true;
            this.btn_CustomerDelete.Click += new System.EventHandler(this.btn_CustomerAdd_Click);
            // 
            // btn_CustomerUpdate
            // 
            this.btn_CustomerUpdate.AutoSize = true;
            this.btn_CustomerUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CustomerUpdate.Depth = 0;
            this.btn_CustomerUpdate.Location = new System.Drawing.Point(365, 60);
            this.btn_CustomerUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CustomerUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CustomerUpdate.Name = "btn_CustomerUpdate";
            this.btn_CustomerUpdate.Primary = false;
            this.btn_CustomerUpdate.Size = new System.Drawing.Size(161, 36);
            this.btn_CustomerUpdate.TabIndex = 2;
            this.btn_CustomerUpdate.Text = "Kunde aktualisieren";
            this.btn_CustomerUpdate.UseVisualStyleBackColor = true;
            this.btn_CustomerUpdate.Click += new System.EventHandler(this.btn_CustomerAdd_Click);
            // 
            // UserControl_Customer
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
            this.Name = "UserControl_Customer";
            this.Size = new System.Drawing.Size(930, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_CustomerID;
        private MaterialSkin.Controls.MaterialLabel lbl_CustomerName;
        private MaterialSkin.Controls.MaterialLabel lbl_CustomerLastname;
        private MaterialSkin.Controls.MaterialLabel lbl_CustomerMail;
        private MaterialSkin.Controls.MaterialLabel lbl_CustomerAdress;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CustomerID;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CustomerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CustomerLastname;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CustomerMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_CustomerAdress;
        private MaterialSkin.Controls.MaterialFlatButton btn_CustomerAdd;
        private MaterialSkin.Controls.MaterialFlatButton btn_CustomerDelete;
        private MaterialSkin.Controls.MaterialFlatButton btn_CustomerUpdate;
    }
}
