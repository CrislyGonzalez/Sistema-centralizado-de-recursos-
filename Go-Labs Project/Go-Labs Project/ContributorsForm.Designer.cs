namespace Go_Labs_Project
{
    partial class ContributorsForm
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
            this.gbContributors = new System.Windows.Forms.GroupBox();
            this.btnDeleteContributor = new System.Windows.Forms.Button();
            this.btnModifyContributor = new System.Windows.Forms.Button();
            this.btnAddContributor = new System.Windows.Forms.Button();
            this.txtContributorServedYears = new System.Windows.Forms.TextBox();
            this.txtContributorSalary = new System.Windows.Forms.TextBox();
            this.txtContributorVacations = new System.Windows.Forms.TextBox();
            this.cmbContributorLevel = new System.Windows.Forms.ComboBox();
            this.lblWorkInfo = new System.Windows.Forms.Label();
            this.txtContributorEmail = new System.Windows.Forms.TextBox();
            this.txtContributorAddress = new System.Windows.Forms.TextBox();
            this.txtContributorTel = new System.Windows.Forms.TextBox();
            this.txtContributorSecondLastName = new System.Windows.Forms.TextBox();
            this.txtContributorFirstLastName = new System.Windows.Forms.TextBox();
            this.txtContributorName = new System.Windows.Forms.TextBox();
            this.txtContributorID = new System.Windows.Forms.TextBox();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.dgContributorsInfo = new System.Windows.Forms.DataGridView();
            this.ContributorsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContributorsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContributorsTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContributorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContributorsEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContributorLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContributorsSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContributorsVacations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContributorsServedYears = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuickSearch = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.cmbContributorNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.gbContributors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContributorsInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContributors
            // 
            this.gbContributors.Controls.Add(this.btnDeleteContributor);
            this.gbContributors.Controls.Add(this.btnModifyContributor);
            this.gbContributors.Controls.Add(this.btnAddContributor);
            this.gbContributors.Controls.Add(this.txtContributorServedYears);
            this.gbContributors.Controls.Add(this.txtContributorSalary);
            this.gbContributors.Controls.Add(this.txtContributorVacations);
            this.gbContributors.Controls.Add(this.cmbContributorLevel);
            this.gbContributors.Controls.Add(this.lblWorkInfo);
            this.gbContributors.Controls.Add(this.txtContributorEmail);
            this.gbContributors.Controls.Add(this.txtContributorAddress);
            this.gbContributors.Controls.Add(this.txtContributorTel);
            this.gbContributors.Controls.Add(this.txtContributorSecondLastName);
            this.gbContributors.Controls.Add(this.txtContributorFirstLastName);
            this.gbContributors.Controls.Add(this.txtContributorName);
            this.gbContributors.Controls.Add(this.txtContributorID);
            this.gbContributors.Controls.Add(this.lblPersonalInfo);
            this.gbContributors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContributors.Location = new System.Drawing.Point(12, 12);
            this.gbContributors.Name = "gbContributors";
            this.gbContributors.Size = new System.Drawing.Size(499, 450);
            this.gbContributors.TabIndex = 0;
            this.gbContributors.TabStop = false;
            this.gbContributors.Text = "Información Personal - Laboral";
            // 
            // btnDeleteContributor
            // 
            this.btnDeleteContributor.Image = global::Go_Labs_Project.Properties.Resources.DeleteIcon;
            this.btnDeleteContributor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteContributor.Location = new System.Drawing.Point(328, 394);
            this.btnDeleteContributor.Name = "btnDeleteContributor";
            this.btnDeleteContributor.Size = new System.Drawing.Size(152, 41);
            this.btnDeleteContributor.TabIndex = 22;
            this.btnDeleteContributor.Text = "Eliminar";
            this.btnDeleteContributor.UseVisualStyleBackColor = true;
            this.btnDeleteContributor.Click += new System.EventHandler(this.btnDeleteContributor_Click);
            // 
            // btnModifyContributor
            // 
            this.btnModifyContributor.Image = global::Go_Labs_Project.Properties.Resources.ModifyIcon;
            this.btnModifyContributor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyContributor.Location = new System.Drawing.Point(170, 394);
            this.btnModifyContributor.Name = "btnModifyContributor";
            this.btnModifyContributor.Size = new System.Drawing.Size(152, 41);
            this.btnModifyContributor.TabIndex = 21;
            this.btnModifyContributor.Text = "Modificar";
            this.btnModifyContributor.UseVisualStyleBackColor = true;
            this.btnModifyContributor.Click += new System.EventHandler(this.btnModifyContributor_Click);
            // 
            // btnAddContributor
            // 
            this.btnAddContributor.Image = global::Go_Labs_Project.Properties.Resources.AddIcon;
            this.btnAddContributor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContributor.Location = new System.Drawing.Point(13, 394);
            this.btnAddContributor.Name = "btnAddContributor";
            this.btnAddContributor.Size = new System.Drawing.Size(152, 41);
            this.btnAddContributor.TabIndex = 20;
            this.btnAddContributor.Text = "Agregar";
            this.btnAddContributor.UseVisualStyleBackColor = true;
            this.btnAddContributor.Click += new System.EventHandler(this.btnAddContributor_Click);
            // 
            // txtContributorServedYears
            // 
            this.txtContributorServedYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributorServedYears.ForeColor = System.Drawing.Color.Gray;
            this.txtContributorServedYears.Location = new System.Drawing.Point(105, 350);
            this.txtContributorServedYears.Name = "txtContributorServedYears";
            this.txtContributorServedYears.Size = new System.Drawing.Size(293, 20);
            this.txtContributorServedYears.TabIndex = 19;
            this.txtContributorServedYears.Text = "Años Laborados";
            this.txtContributorServedYears.Enter += new System.EventHandler(this.txtContributorServedYears_Enter);
            this.txtContributorServedYears.Leave += new System.EventHandler(this.txtContributorServedYears_Leave);
            // 
            // txtContributorSalary
            // 
            this.txtContributorSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributorSalary.ForeColor = System.Drawing.Color.Gray;
            this.txtContributorSalary.Location = new System.Drawing.Point(105, 298);
            this.txtContributorSalary.Name = "txtContributorSalary";
            this.txtContributorSalary.Size = new System.Drawing.Size(293, 20);
            this.txtContributorSalary.TabIndex = 17;
            this.txtContributorSalary.Text = "Salario";
            this.txtContributorSalary.Enter += new System.EventHandler(this.txtContributorSalary_Enter);
            this.txtContributorSalary.Leave += new System.EventHandler(this.txtContributorSalary_Leave);
            // 
            // txtContributorVacations
            // 
            this.txtContributorVacations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributorVacations.ForeColor = System.Drawing.Color.Gray;
            this.txtContributorVacations.Location = new System.Drawing.Point(105, 324);
            this.txtContributorVacations.Name = "txtContributorVacations";
            this.txtContributorVacations.Size = new System.Drawing.Size(293, 20);
            this.txtContributorVacations.TabIndex = 18;
            this.txtContributorVacations.Text = "Cantidad de Vacaciones";
            this.txtContributorVacations.Enter += new System.EventHandler(this.txtContributorVacations_Enter);
            this.txtContributorVacations.Leave += new System.EventHandler(this.txtContributorVacations_Leave);
            // 
            // cmbContributorLevel
            // 
            this.cmbContributorLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContributorLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContributorLevel.FormattingEnabled = true;
            this.cmbContributorLevel.Items.AddRange(new object[] {
            "Seleccione un nivel",
            "Junior",
            "Senior",
            "Arquitecto"});
            this.cmbContributorLevel.Location = new System.Drawing.Point(105, 271);
            this.cmbContributorLevel.Name = "cmbContributorLevel";
            this.cmbContributorLevel.Size = new System.Drawing.Size(293, 21);
            this.cmbContributorLevel.TabIndex = 16;
            // 
            // lblWorkInfo
            // 
            this.lblWorkInfo.AutoSize = true;
            this.lblWorkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkInfo.Location = new System.Drawing.Point(60, 248);
            this.lblWorkInfo.Name = "lblWorkInfo";
            this.lblWorkInfo.Size = new System.Drawing.Size(117, 15);
            this.lblWorkInfo.TabIndex = 15;
            this.lblWorkInfo.Text = "Información Laboral";
            // 
            // txtContributorEmail
            // 
            this.txtContributorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributorEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtContributorEmail.Location = new System.Drawing.Point(105, 218);
            this.txtContributorEmail.Name = "txtContributorEmail";
            this.txtContributorEmail.Size = new System.Drawing.Size(293, 20);
            this.txtContributorEmail.TabIndex = 14;
            this.txtContributorEmail.Text = "Correo Electrónico";
            this.txtContributorEmail.Enter += new System.EventHandler(this.txtContributorEmail_Enter);
            this.txtContributorEmail.Leave += new System.EventHandler(this.txtContributorEmail_Leave);
            // 
            // txtContributorAddress
            // 
            this.txtContributorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributorAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtContributorAddress.Location = new System.Drawing.Point(105, 190);
            this.txtContributorAddress.Name = "txtContributorAddress";
            this.txtContributorAddress.Size = new System.Drawing.Size(293, 20);
            this.txtContributorAddress.TabIndex = 13;
            this.txtContributorAddress.Text = "Dirección";
            this.txtContributorAddress.Enter += new System.EventHandler(this.txtContributorAddress_Enter);
            this.txtContributorAddress.Leave += new System.EventHandler(this.txtContributorAddress_Leave);
            // 
            // txtContributorTel
            // 
            this.txtContributorTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributorTel.ForeColor = System.Drawing.Color.Gray;
            this.txtContributorTel.Location = new System.Drawing.Point(105, 162);
            this.txtContributorTel.Name = "txtContributorTel";
            this.txtContributorTel.Size = new System.Drawing.Size(293, 20);
            this.txtContributorTel.TabIndex = 12;
            this.txtContributorTel.Text = "Teléfono";
            this.txtContributorTel.Enter += new System.EventHandler(this.txtContributorTel_Enter);
            this.txtContributorTel.Leave += new System.EventHandler(this.txtContributorTel_Leave);
            // 
            // txtContributorSecondLastName
            // 
            this.txtContributorSecondLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributorSecondLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtContributorSecondLastName.Location = new System.Drawing.Point(105, 134);
            this.txtContributorSecondLastName.Name = "txtContributorSecondLastName";
            this.txtContributorSecondLastName.Size = new System.Drawing.Size(293, 20);
            this.txtContributorSecondLastName.TabIndex = 11;
            this.txtContributorSecondLastName.Text = "Segundo Apellido";
            this.txtContributorSecondLastName.Enter += new System.EventHandler(this.txtContributorSecondLastName_Enter);
            this.txtContributorSecondLastName.Leave += new System.EventHandler(this.txtContributorSecondLastName_Leave);
            // 
            // txtContributorFirstLastName
            // 
            this.txtContributorFirstLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributorFirstLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtContributorFirstLastName.Location = new System.Drawing.Point(105, 106);
            this.txtContributorFirstLastName.Name = "txtContributorFirstLastName";
            this.txtContributorFirstLastName.Size = new System.Drawing.Size(293, 20);
            this.txtContributorFirstLastName.TabIndex = 10;
            this.txtContributorFirstLastName.Text = "Primer Apellido";
            this.txtContributorFirstLastName.Enter += new System.EventHandler(this.txtContributorFirstLastName_Enter);
            this.txtContributorFirstLastName.Leave += new System.EventHandler(this.txtContributorFirstLastName_Leave);
            // 
            // txtContributorName
            // 
            this.txtContributorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributorName.ForeColor = System.Drawing.Color.Gray;
            this.txtContributorName.Location = new System.Drawing.Point(105, 78);
            this.txtContributorName.Name = "txtContributorName";
            this.txtContributorName.Size = new System.Drawing.Size(293, 20);
            this.txtContributorName.TabIndex = 9;
            this.txtContributorName.Text = "Nombre";
            this.txtContributorName.Enter += new System.EventHandler(this.txtContributorName_Enter);
            this.txtContributorName.Leave += new System.EventHandler(this.txtContributorName_Leave);
            // 
            // txtContributorID
            // 
            this.txtContributorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContributorID.ForeColor = System.Drawing.Color.Gray;
            this.txtContributorID.Location = new System.Drawing.Point(105, 52);
            this.txtContributorID.Name = "txtContributorID";
            this.txtContributorID.Size = new System.Drawing.Size(293, 20);
            this.txtContributorID.TabIndex = 8;
            this.txtContributorID.Text = "Cédula";
            this.txtContributorID.Enter += new System.EventHandler(this.txtContributorID_Enter);
            this.txtContributorID.Leave += new System.EventHandler(this.txtContributorID_Leave);
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.Location = new System.Drawing.Point(60, 29);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(124, 15);
            this.lblPersonalInfo.TabIndex = 0;
            this.lblPersonalInfo.Text = "Información Personal";
            // 
            // dgContributorsInfo
            // 
            this.dgContributorsInfo.AllowUserToDeleteRows = false;
            this.dgContributorsInfo.AllowUserToResizeColumns = false;
            this.dgContributorsInfo.AllowUserToResizeRows = false;
            this.dgContributorsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgContributorsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContributorsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContributorsID,
            this.ContributorsName,
            this.ContributorsTel,
            this.ContributorAddress,
            this.ContributorsEmail,
            this.ContributorLevel,
            this.ContributorsSalary,
            this.ContributorsVacations,
            this.ContributorsServedYears});
            this.dgContributorsInfo.Location = new System.Drawing.Point(12, 468);
            this.dgContributorsInfo.MultiSelect = false;
            this.dgContributorsInfo.Name = "dgContributorsInfo";
            this.dgContributorsInfo.ReadOnly = true;
            this.dgContributorsInfo.RowHeadersVisible = false;
            this.dgContributorsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContributorsInfo.Size = new System.Drawing.Size(1126, 162);
            this.dgContributorsInfo.TabIndex = 1;
            this.dgContributorsInfo.SelectionChanged += new System.EventHandler(this.dgContributorsInfo_SelectionChanged);
            // 
            // ContributorsID
            // 
            this.ContributorsID.HeaderText = "Cédula";
            this.ContributorsID.Name = "ContributorsID";
            this.ContributorsID.ReadOnly = true;
            this.ContributorsID.Width = 80;
            // 
            // ContributorsName
            // 
            this.ContributorsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContributorsName.HeaderText = "Nombre Completo";
            this.ContributorsName.Name = "ContributorsName";
            this.ContributorsName.ReadOnly = true;
            // 
            // ContributorsTel
            // 
            this.ContributorsTel.HeaderText = "Teléfono";
            this.ContributorsTel.Name = "ContributorsTel";
            this.ContributorsTel.ReadOnly = true;
            this.ContributorsTel.Width = 90;
            // 
            // ContributorAddress
            // 
            this.ContributorAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContributorAddress.HeaderText = "Dirección";
            this.ContributorAddress.Name = "ContributorAddress";
            this.ContributorAddress.ReadOnly = true;
            // 
            // ContributorsEmail
            // 
            this.ContributorsEmail.HeaderText = "Correo Electrónico";
            this.ContributorsEmail.Name = "ContributorsEmail";
            this.ContributorsEmail.ReadOnly = true;
            this.ContributorsEmail.Width = 180;
            // 
            // ContributorLevel
            // 
            this.ContributorLevel.HeaderText = "Nivel";
            this.ContributorLevel.Name = "ContributorLevel";
            this.ContributorLevel.ReadOnly = true;
            this.ContributorLevel.Width = 90;
            // 
            // ContributorsSalary
            // 
            this.ContributorsSalary.HeaderText = "Salario";
            this.ContributorsSalary.Name = "ContributorsSalary";
            this.ContributorsSalary.ReadOnly = true;
            this.ContributorsSalary.Width = 75;
            // 
            // ContributorsVacations
            // 
            this.ContributorsVacations.HeaderText = "Vacaciones";
            this.ContributorsVacations.Name = "ContributorsVacations";
            this.ContributorsVacations.ReadOnly = true;
            this.ContributorsVacations.Width = 75;
            // 
            // ContributorsServedYears
            // 
            this.ContributorsServedYears.HeaderText = "Laborados";
            this.ContributorsServedYears.Name = "ContributorsServedYears";
            this.ContributorsServedYears.ReadOnly = true;
            this.ContributorsServedYears.Width = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuickSearch);
            this.groupBox1.Controls.Add(this.txtSearchID);
            this.groupBox1.Controls.Add(this.cmbContributorNames);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(616, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 142);
            this.groupBox1.TabIndex = 2;
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
            this.txtSearchID.Text = "Cédula";
            this.txtSearchID.Enter += new System.EventHandler(this.txtSearchID_Enter);
            this.txtSearchID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchID_KeyPress);
            this.txtSearchID.Leave += new System.EventHandler(this.txtSearchID_Leave);
            // 
            // cmbContributorNames
            // 
            this.cmbContributorNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContributorNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContributorNames.FormattingEnabled = true;
            this.cmbContributorNames.Location = new System.Drawing.Point(174, 29);
            this.cmbContributorNames.Name = "cmbContributorNames";
            this.cmbContributorNames.Size = new System.Drawing.Size(293, 21);
            this.cmbContributorNames.TabIndex = 2;
            this.cmbContributorNames.SelectedIndexChanged += new System.EventHandler(this.cmbContributorNames_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por Cédula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por Nombre y Apellidos";
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(860, 416);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(60, 46);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "|<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(926, 416);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 46);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(992, 416);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 46);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(1058, 416);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(60, 46);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">>|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // ContributorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 642);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgContributorsInfo);
            this.Controls.Add(this.gbContributors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContributorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContributorsForm";
            this.Load += new System.EventHandler(this.ContributorsForm_Load);
            this.gbContributors.ResumeLayout(false);
            this.gbContributors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContributorsInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContributors;
        private System.Windows.Forms.TextBox txtContributorEmail;
        private System.Windows.Forms.TextBox txtContributorAddress;
        private System.Windows.Forms.TextBox txtContributorTel;
        private System.Windows.Forms.TextBox txtContributorSecondLastName;
        private System.Windows.Forms.TextBox txtContributorFirstLastName;
        private System.Windows.Forms.TextBox txtContributorName;
        private System.Windows.Forms.TextBox txtContributorID;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.TextBox txtContributorServedYears;
        private System.Windows.Forms.TextBox txtContributorSalary;
        private System.Windows.Forms.TextBox txtContributorVacations;
        private System.Windows.Forms.ComboBox cmbContributorLevel;
        private System.Windows.Forms.Label lblWorkInfo;
        private System.Windows.Forms.Button btnDeleteContributor;
        private System.Windows.Forms.Button btnModifyContributor;
        private System.Windows.Forms.Button btnAddContributor;
        private System.Windows.Forms.DataGridView dgContributorsInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuickSearch;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.ComboBox cmbContributorNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContributorsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContributorsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContributorsTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContributorAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContributorsEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContributorLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContributorsSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContributorsVacations;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContributorsServedYears;
    }
}