namespace Go_Labs_Project
{
    partial class CostumersForm
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
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuickSearch = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.cmbClientNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgClientsInfo = new System.Windows.Forms.DataGridView();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientOcupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientWebSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbContributors = new System.Windows.Forms.GroupBox();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnModifyClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblWorkInfo = new System.Windows.Forms.Label();
            this.txtContactPosition = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtClientWebSite = new System.Windows.Forms.TextBox();
            this.txtClientOcupation = new System.Windows.Forms.TextBox();
            this.txtClientCountry = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientsInfo)).BeginInit();
            this.gbContributors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(1059, 333);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(60, 46);
            this.btnLast.TabIndex = 13;
            this.btnLast.Text = ">>|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(993, 333);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 46);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(927, 333);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 46);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(861, 333);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(60, 46);
            this.btnFirst.TabIndex = 10;
            this.btnFirst.Text = "|<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuickSearch);
            this.groupBox1.Controls.Add(this.txtSearchID);
            this.groupBox1.Controls.Add(this.cmbClientNames);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(616, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 142);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda Rápida";
            // 
            // btnQuickSearch
            // 
            this.btnQuickSearch.Image = global::Go_Labs_Project.Properties.Resources.SearchIcon;
            this.btnQuickSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuickSearch.Location = new System.Drawing.Point(315, 85);
            this.btnQuickSearch.Name = "btnQuickSearch";
            this.btnQuickSearch.Size = new System.Drawing.Size(152, 41);
            this.btnQuickSearch.TabIndex = 4;
            this.btnQuickSearch.Text = "Buscar";
            this.btnQuickSearch.UseVisualStyleBackColor = true;
            this.btnQuickSearch.Click += new System.EventHandler(this.btnQuickSearch_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchID.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchID.Location = new System.Drawing.Point(174, 56);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(293, 20);
            this.txtSearchID.TabIndex = 3;
            this.txtSearchID.Text = "Número de Identificación";
            this.txtSearchID.Enter += new System.EventHandler(this.txtSearchID_Enter);
            this.txtSearchID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchID_KeyPress);
            this.txtSearchID.Leave += new System.EventHandler(this.txtSearchID_Leave);
            // 
            // cmbClientNames
            // 
            this.cmbClientNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientNames.FormattingEnabled = true;
            this.cmbClientNames.Location = new System.Drawing.Point(174, 29);
            this.cmbClientNames.Name = "cmbClientNames";
            this.cmbClientNames.Size = new System.Drawing.Size(293, 21);
            this.cmbClientNames.TabIndex = 2;
            this.cmbClientNames.SelectedIndexChanged += new System.EventHandler(this.cmbClientNames_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por Nombre";
            // 
            // dgClientsInfo
            // 
            this.dgClientsInfo.AllowUserToDeleteRows = false;
            this.dgClientsInfo.AllowUserToResizeColumns = false;
            this.dgClientsInfo.AllowUserToResizeRows = false;
            this.dgClientsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgClientsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.ClientName,
            this.ClientCountry,
            this.ClientOcupation,
            this.ClientWebSite,
            this.ClientContact,
            this.ContactPosition,
            this.ContactEmail});
            this.dgClientsInfo.Location = new System.Drawing.Point(12, 385);
            this.dgClientsInfo.MultiSelect = false;
            this.dgClientsInfo.Name = "dgClientsInfo";
            this.dgClientsInfo.ReadOnly = true;
            this.dgClientsInfo.RowHeadersVisible = false;
            this.dgClientsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientsInfo.Size = new System.Drawing.Size(1126, 245);
            this.dgClientsInfo.TabIndex = 8;
            this.dgClientsInfo.SelectionChanged += new System.EventHandler(this.dgClientsInfo_SelectionChanged);
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "Identificación";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Width = 90;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.HeaderText = "Nombre";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // ClientCountry
            // 
            this.ClientCountry.HeaderText = "País";
            this.ClientCountry.Name = "ClientCountry";
            this.ClientCountry.ReadOnly = true;
            // 
            // ClientOcupation
            // 
            this.ClientOcupation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientOcupation.HeaderText = "Ocupación";
            this.ClientOcupation.Name = "ClientOcupation";
            this.ClientOcupation.ReadOnly = true;
            // 
            // ClientWebSite
            // 
            this.ClientWebSite.HeaderText = "Sitio Web";
            this.ClientWebSite.Name = "ClientWebSite";
            this.ClientWebSite.ReadOnly = true;
            this.ClientWebSite.Width = 150;
            // 
            // ClientContact
            // 
            this.ClientContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientContact.HeaderText = "Nombre de Contacto";
            this.ClientContact.Name = "ClientContact";
            this.ClientContact.ReadOnly = true;
            // 
            // ContactPosition
            // 
            this.ContactPosition.HeaderText = "Puesto de Contacto";
            this.ContactPosition.Name = "ContactPosition";
            this.ContactPosition.ReadOnly = true;
            this.ContactPosition.Width = 150;
            // 
            // ContactEmail
            // 
            this.ContactEmail.HeaderText = "Correo de Contacto";
            this.ContactEmail.Name = "ContactEmail";
            this.ContactEmail.ReadOnly = true;
            this.ContactEmail.Width = 150;
            // 
            // gbContributors
            // 
            this.gbContributors.Controls.Add(this.btnDeleteClient);
            this.gbContributors.Controls.Add(this.btnModifyClient);
            this.gbContributors.Controls.Add(this.btnAddClient);
            this.gbContributors.Controls.Add(this.txtContactEmail);
            this.gbContributors.Controls.Add(this.lblWorkInfo);
            this.gbContributors.Controls.Add(this.txtContactPosition);
            this.gbContributors.Controls.Add(this.txtContactName);
            this.gbContributors.Controls.Add(this.txtClientWebSite);
            this.gbContributors.Controls.Add(this.txtClientOcupation);
            this.gbContributors.Controls.Add(this.txtClientCountry);
            this.gbContributors.Controls.Add(this.txtClientName);
            this.gbContributors.Controls.Add(this.txtClientID);
            this.gbContributors.Controls.Add(this.lblPersonalInfo);
            this.gbContributors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContributors.Location = new System.Drawing.Point(12, 12);
            this.gbContributors.Name = "gbContributors";
            this.gbContributors.Size = new System.Drawing.Size(499, 367);
            this.gbContributors.TabIndex = 7;
            this.gbContributors.TabStop = false;
            this.gbContributors.Text = "Información de Empresa - Contacto";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Image = global::Go_Labs_Project.Properties.Resources.DeleteIcon;
            this.btnDeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClient.Location = new System.Drawing.Point(328, 309);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(152, 41);
            this.btnDeleteClient.TabIndex = 22;
            this.btnDeleteClient.Text = "Eliminar";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.Image = global::Go_Labs_Project.Properties.Resources.ModifyIcon;
            this.btnModifyClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyClient.Location = new System.Drawing.Point(170, 309);
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Size = new System.Drawing.Size(152, 41);
            this.btnModifyClient.TabIndex = 21;
            this.btnModifyClient.Text = "Modificar";
            this.btnModifyClient.UseVisualStyleBackColor = true;
            this.btnModifyClient.Click += new System.EventHandler(this.btnModifyClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Image = global::Go_Labs_Project.Properties.Resources.AddIcon;
            this.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClient.Location = new System.Drawing.Point(13, 309);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(152, 41);
            this.btnAddClient.TabIndex = 20;
            this.btnAddClient.Text = "Agregar";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtContactEmail.Location = new System.Drawing.Point(105, 270);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(293, 20);
            this.txtContactEmail.TabIndex = 17;
            this.txtContactEmail.Text = "Correo Electrónico";
            this.txtContactEmail.Enter += new System.EventHandler(this.txtContactEmail_Enter);
            this.txtContactEmail.Leave += new System.EventHandler(this.txtContactEmail_Leave);
            // 
            // lblWorkInfo
            // 
            this.lblWorkInfo.AutoSize = true;
            this.lblWorkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkInfo.Location = new System.Drawing.Point(60, 195);
            this.lblWorkInfo.Name = "lblWorkInfo";
            this.lblWorkInfo.Size = new System.Drawing.Size(140, 15);
            this.lblWorkInfo.TabIndex = 15;
            this.lblWorkInfo.Text = "Información de Contacto";
            // 
            // txtContactPosition
            // 
            this.txtContactPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPosition.ForeColor = System.Drawing.Color.Gray;
            this.txtContactPosition.Location = new System.Drawing.Point(105, 244);
            this.txtContactPosition.Name = "txtContactPosition";
            this.txtContactPosition.Size = new System.Drawing.Size(293, 20);
            this.txtContactPosition.TabIndex = 14;
            this.txtContactPosition.Text = "Puesto en la Empresa";
            this.txtContactPosition.Enter += new System.EventHandler(this.txtContactPosition_Enter);
            this.txtContactPosition.Leave += new System.EventHandler(this.txtContactPosition_Leave);
            // 
            // txtContactName
            // 
            this.txtContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactName.ForeColor = System.Drawing.Color.Gray;
            this.txtContactName.Location = new System.Drawing.Point(105, 218);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(293, 20);
            this.txtContactName.TabIndex = 13;
            this.txtContactName.Text = "Nombre Completo";
            this.txtContactName.Enter += new System.EventHandler(this.txtContactName_Enter);
            this.txtContactName.Leave += new System.EventHandler(this.txtContactName_Leave);
            // 
            // txtClientWebSite
            // 
            this.txtClientWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientWebSite.ForeColor = System.Drawing.Color.Gray;
            this.txtClientWebSite.Location = new System.Drawing.Point(105, 162);
            this.txtClientWebSite.Name = "txtClientWebSite";
            this.txtClientWebSite.Size = new System.Drawing.Size(293, 20);
            this.txtClientWebSite.TabIndex = 12;
            this.txtClientWebSite.Text = "Sitio Web";
            this.txtClientWebSite.Enter += new System.EventHandler(this.txtClientWebSite_Enter);
            this.txtClientWebSite.Leave += new System.EventHandler(this.txtClientWebSite_Leave);
            // 
            // txtClientOcupation
            // 
            this.txtClientOcupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientOcupation.ForeColor = System.Drawing.Color.Gray;
            this.txtClientOcupation.Location = new System.Drawing.Point(105, 134);
            this.txtClientOcupation.Name = "txtClientOcupation";
            this.txtClientOcupation.Size = new System.Drawing.Size(293, 20);
            this.txtClientOcupation.TabIndex = 11;
            this.txtClientOcupation.Text = "Ocupación";
            this.txtClientOcupation.Enter += new System.EventHandler(this.txtClientOcupation_Enter);
            this.txtClientOcupation.Leave += new System.EventHandler(this.txtClientOcupation_Leave);
            // 
            // txtClientCountry
            // 
            this.txtClientCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCountry.ForeColor = System.Drawing.Color.Gray;
            this.txtClientCountry.Location = new System.Drawing.Point(105, 106);
            this.txtClientCountry.Name = "txtClientCountry";
            this.txtClientCountry.Size = new System.Drawing.Size(293, 20);
            this.txtClientCountry.TabIndex = 10;
            this.txtClientCountry.Text = "País";
            this.txtClientCountry.Enter += new System.EventHandler(this.txtClientCountry_Enter);
            this.txtClientCountry.Leave += new System.EventHandler(this.txtClientCountry_Leave);
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.ForeColor = System.Drawing.Color.Gray;
            this.txtClientName.Location = new System.Drawing.Point(105, 78);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(293, 20);
            this.txtClientName.TabIndex = 9;
            this.txtClientName.Text = "Nombre";
            this.txtClientName.Enter += new System.EventHandler(this.txtClientName_Enter);
            this.txtClientName.Leave += new System.EventHandler(this.txtClientName_Leave);
            // 
            // txtClientID
            // 
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.ForeColor = System.Drawing.Color.Gray;
            this.txtClientID.Location = new System.Drawing.Point(105, 52);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(293, 20);
            this.txtClientID.TabIndex = 8;
            this.txtClientID.Text = "Número de Identificación";
            this.txtClientID.Enter += new System.EventHandler(this.txtClientID_Enter);
            this.txtClientID.Leave += new System.EventHandler(this.txtClientID_Leave);
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.Location = new System.Drawing.Point(60, 29);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(155, 15);
            this.lblPersonalInfo.TabIndex = 0;
            this.lblPersonalInfo.Text = "Información de la Empresa";
            // 
            // CostumersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 642);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgClientsInfo);
            this.Controls.Add(this.gbContributors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CostumersForm";
            this.Text = "CostumersForm";
            this.Load += new System.EventHandler(this.CostumersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientsInfo)).EndInit();
            this.gbContributors.ResumeLayout(false);
            this.gbContributors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuickSearch;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.ComboBox cmbClientNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgClientsInfo;
        private System.Windows.Forms.GroupBox gbContributors;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnModifyClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label lblWorkInfo;
        private System.Windows.Forms.TextBox txtContactPosition;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtClientWebSite;
        private System.Windows.Forms.TextBox txtClientOcupation;
        private System.Windows.Forms.TextBox txtClientCountry;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientOcupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientWebSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactEmail;
    }
}