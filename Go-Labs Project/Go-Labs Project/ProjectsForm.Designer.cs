namespace Go_Labs_Project
{
    partial class ProjectsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.dgProjectsInfo = new System.Windows.Forms.DataGridView();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectExpected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbContributors = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectObservations = new System.Windows.Forms.TextBox();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpExpected = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnModifyProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgTechnologiesInfo = new System.Windows.Forms.DataGridView();
            this.TechnologyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechnologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTechContainer = new System.Windows.Forms.GroupBox();
            this.btnDeleteTechnology = new System.Windows.Forms.Button();
            this.btnModifyTechnology = new System.Windows.Forms.Button();
            this.btnAddTechnolgy = new System.Windows.Forms.Button();
            this.txtTechnologyName = new System.Windows.Forms.TextBox();
            this.txtTechnologyID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProjectsInfo)).BeginInit();
            this.gbContributors.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTechnologiesInfo)).BeginInit();
            this.gbTechContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 618);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLast);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.btnPrevious);
            this.tabPage1.Controls.Add(this.btnFirst);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgProjectsInfo);
            this.tabPage1.Controls.Add(this.gbContributors);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proyectos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(1042, 288);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(60, 46);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = ">>|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(976, 288);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 46);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(910, 288);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 46);
            this.btnPrevious.TabIndex = 18;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(844, 288);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(60, 46);
            this.btnFirst.TabIndex = 17;
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
            this.groupBox1.Location = new System.Drawing.Point(610, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 142);
            this.groupBox1.TabIndex = 16;
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
            this.txtSearchID.Text = "ID de Proyecto";
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
            // dgProjectsInfo
            // 
            this.dgProjectsInfo.AllowUserToDeleteRows = false;
            this.dgProjectsInfo.AllowUserToResizeColumns = false;
            this.dgProjectsInfo.AllowUserToResizeRows = false;
            this.dgProjectsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgProjectsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProjectsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectID,
            this.ProjectName,
            this.ProjectClient,
            this.ProjectBegin,
            this.ProjectExpected,
            this.ProjectFinish});
            this.dgProjectsInfo.Location = new System.Drawing.Point(6, 351);
            this.dgProjectsInfo.MultiSelect = false;
            this.dgProjectsInfo.Name = "dgProjectsInfo";
            this.dgProjectsInfo.ReadOnly = true;
            this.dgProjectsInfo.RowHeadersVisible = false;
            this.dgProjectsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProjectsInfo.Size = new System.Drawing.Size(1106, 235);
            this.dgProjectsInfo.TabIndex = 15;
            this.dgProjectsInfo.SelectionChanged += new System.EventHandler(this.dgProjectsInfo_SelectionChanged);
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "Identificación";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.ReadOnly = true;
            this.ProjectID.Width = 90;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectName.HeaderText = "Nombre";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // ProjectClient
            // 
            this.ProjectClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectClient.HeaderText = "Cliente";
            this.ProjectClient.Name = "ProjectClient";
            this.ProjectClient.ReadOnly = true;
            // 
            // ProjectBegin
            // 
            this.ProjectBegin.HeaderText = "Inicio";
            this.ProjectBegin.Name = "ProjectBegin";
            this.ProjectBegin.ReadOnly = true;
            this.ProjectBegin.Width = 180;
            // 
            // ProjectExpected
            // 
            this.ProjectExpected.HeaderText = "Prevista";
            this.ProjectExpected.Name = "ProjectExpected";
            this.ProjectExpected.ReadOnly = true;
            this.ProjectExpected.Width = 180;
            // 
            // ProjectFinish
            // 
            this.ProjectFinish.HeaderText = "Finalización";
            this.ProjectFinish.Name = "ProjectFinish";
            this.ProjectFinish.ReadOnly = true;
            this.ProjectFinish.Width = 180;
            // 
            // gbContributors
            // 
            this.gbContributors.Controls.Add(this.label5);
            this.gbContributors.Controls.Add(this.label4);
            this.gbContributors.Controls.Add(this.label3);
            this.gbContributors.Controls.Add(this.txtProjectObservations);
            this.gbContributors.Controls.Add(this.dtpFinish);
            this.gbContributors.Controls.Add(this.dtpExpected);
            this.gbContributors.Controls.Add(this.dtpBegin);
            this.gbContributors.Controls.Add(this.cmbClients);
            this.gbContributors.Controls.Add(this.txtProjectName);
            this.gbContributors.Controls.Add(this.txtProjectID);
            this.gbContributors.Controls.Add(this.btnDeleteProject);
            this.gbContributors.Controls.Add(this.btnModifyProject);
            this.gbContributors.Controls.Add(this.btnAddProject);
            this.gbContributors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContributors.Location = new System.Drawing.Point(6, 6);
            this.gbContributors.Name = "gbContributors";
            this.gbContributors.Size = new System.Drawing.Size(499, 339);
            this.gbContributors.TabIndex = 14;
            this.gbContributors.TabStop = false;
            this.gbContributors.Text = "Información de Proyecto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de Finalización";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha prevista de Finalización";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha de Inicio";
            // 
            // txtProjectObservations
            // 
            this.txtProjectObservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectObservations.ForeColor = System.Drawing.Color.Gray;
            this.txtProjectObservations.Location = new System.Drawing.Point(25, 182);
            this.txtProjectObservations.Multiline = true;
            this.txtProjectObservations.Name = "txtProjectObservations";
            this.txtProjectObservations.Size = new System.Drawing.Size(436, 81);
            this.txtProjectObservations.TabIndex = 29;
            this.txtProjectObservations.Text = "Observaciones";
            this.txtProjectObservations.Enter += new System.EventHandler(this.txtProjectObservations_Enter);
            this.txtProjectObservations.Leave += new System.EventHandler(this.txtProjectObservations_Leave);
            // 
            // dtpFinish
            // 
            this.dtpFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinish.Location = new System.Drawing.Point(178, 156);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(283, 20);
            this.dtpFinish.TabIndex = 28;
            // 
            // dtpExpected
            // 
            this.dtpExpected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpected.Location = new System.Drawing.Point(178, 130);
            this.dtpExpected.Name = "dtpExpected";
            this.dtpExpected.Size = new System.Drawing.Size(283, 20);
            this.dtpExpected.TabIndex = 27;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBegin.Location = new System.Drawing.Point(178, 104);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(283, 20);
            this.dtpBegin.TabIndex = 26;
            // 
            // cmbClients
            // 
            this.cmbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(178, 77);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(283, 21);
            this.cmbClients.TabIndex = 25;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.ForeColor = System.Drawing.Color.Gray;
            this.txtProjectName.Location = new System.Drawing.Point(178, 51);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(283, 20);
            this.txtProjectName.TabIndex = 24;
            this.txtProjectName.Text = "Nombre";
            this.txtProjectName.Enter += new System.EventHandler(this.txtProjectName_Enter);
            this.txtProjectName.Leave += new System.EventHandler(this.txtProjectName_Leave);
            // 
            // txtProjectID
            // 
            this.txtProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectID.ForeColor = System.Drawing.Color.Gray;
            this.txtProjectID.Location = new System.Drawing.Point(178, 25);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(283, 20);
            this.txtProjectID.TabIndex = 23;
            this.txtProjectID.Text = "ID de Proyecto";
            this.txtProjectID.Enter += new System.EventHandler(this.txtProjectID_Enter);
            this.txtProjectID.Leave += new System.EventHandler(this.txtProjectID_Leave);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Image = global::Go_Labs_Project.Properties.Resources.DeleteIcon;
            this.btnDeleteProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProject.Location = new System.Drawing.Point(328, 282);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(152, 41);
            this.btnDeleteProject.TabIndex = 22;
            this.btnDeleteProject.Text = "Eliminar";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnModifyProject
            // 
            this.btnModifyProject.Image = global::Go_Labs_Project.Properties.Resources.ModifyIcon;
            this.btnModifyProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyProject.Location = new System.Drawing.Point(170, 282);
            this.btnModifyProject.Name = "btnModifyProject";
            this.btnModifyProject.Size = new System.Drawing.Size(152, 41);
            this.btnModifyProject.TabIndex = 21;
            this.btnModifyProject.Text = "Modificar";
            this.btnModifyProject.UseVisualStyleBackColor = true;
            this.btnModifyProject.Click += new System.EventHandler(this.btnModifyProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Image = global::Go_Labs_Project.Properties.Resources.AddIcon;
            this.btnAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProject.Location = new System.Drawing.Point(13, 282);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(152, 41);
            this.btnAddProject.TabIndex = 20;
            this.btnAddProject.Text = "Agregar";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgTechnologiesInfo);
            this.tabPage2.Controls.Add(this.gbTechContainer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tecnologías";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgTechnologiesInfo
            // 
            this.dgTechnologiesInfo.AllowUserToDeleteRows = false;
            this.dgTechnologiesInfo.AllowUserToResizeColumns = false;
            this.dgTechnologiesInfo.AllowUserToResizeRows = false;
            this.dgTechnologiesInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgTechnologiesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTechnologiesInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TechnologyID,
            this.TechnologyName});
            this.dgTechnologiesInfo.Location = new System.Drawing.Point(304, 295);
            this.dgTechnologiesInfo.MultiSelect = false;
            this.dgTechnologiesInfo.Name = "dgTechnologiesInfo";
            this.dgTechnologiesInfo.ReadOnly = true;
            this.dgTechnologiesInfo.RowHeadersVisible = false;
            this.dgTechnologiesInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTechnologiesInfo.Size = new System.Drawing.Size(511, 150);
            this.dgTechnologiesInfo.TabIndex = 3;
            this.dgTechnologiesInfo.SelectionChanged += new System.EventHandler(this.dgTechnologiesInfo_SelectionChanged);
            // 
            // TechnologyID
            // 
            this.TechnologyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TechnologyID.HeaderText = "Número de Identificación";
            this.TechnologyID.Name = "TechnologyID";
            this.TechnologyID.ReadOnly = true;
            // 
            // TechnologyName
            // 
            this.TechnologyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TechnologyName.HeaderText = "Nombre";
            this.TechnologyName.Name = "TechnologyName";
            this.TechnologyName.ReadOnly = true;
            // 
            // gbTechContainer
            // 
            this.gbTechContainer.Controls.Add(this.btnDeleteTechnology);
            this.gbTechContainer.Controls.Add(this.btnModifyTechnology);
            this.gbTechContainer.Controls.Add(this.btnAddTechnolgy);
            this.gbTechContainer.Controls.Add(this.txtTechnologyName);
            this.gbTechContainer.Controls.Add(this.txtTechnologyID);
            this.gbTechContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTechContainer.Location = new System.Drawing.Point(304, 147);
            this.gbTechContainer.Name = "gbTechContainer";
            this.gbTechContainer.Size = new System.Drawing.Size(511, 132);
            this.gbTechContainer.TabIndex = 2;
            this.gbTechContainer.TabStop = false;
            this.gbTechContainer.Text = "Información de Tecnologías";
            // 
            // btnDeleteTechnology
            // 
            this.btnDeleteTechnology.Image = global::Go_Labs_Project.Properties.Resources.DeleteIcon;
            this.btnDeleteTechnology.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTechnology.Location = new System.Drawing.Point(336, 78);
            this.btnDeleteTechnology.Name = "btnDeleteTechnology";
            this.btnDeleteTechnology.Size = new System.Drawing.Size(152, 41);
            this.btnDeleteTechnology.TabIndex = 24;
            this.btnDeleteTechnology.Text = "Eliminar";
            this.btnDeleteTechnology.UseVisualStyleBackColor = true;
            this.btnDeleteTechnology.Click += new System.EventHandler(this.btnDeleteTechnology_Click);
            // 
            // btnModifyTechnology
            // 
            this.btnModifyTechnology.Image = global::Go_Labs_Project.Properties.Resources.ModifyIcon;
            this.btnModifyTechnology.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyTechnology.Location = new System.Drawing.Point(178, 78);
            this.btnModifyTechnology.Name = "btnModifyTechnology";
            this.btnModifyTechnology.Size = new System.Drawing.Size(152, 41);
            this.btnModifyTechnology.TabIndex = 23;
            this.btnModifyTechnology.Text = "Modificar";
            this.btnModifyTechnology.UseVisualStyleBackColor = true;
            this.btnModifyTechnology.Click += new System.EventHandler(this.btnModifyTechnology_Click);
            // 
            // btnAddTechnolgy
            // 
            this.btnAddTechnolgy.Image = global::Go_Labs_Project.Properties.Resources.AddIcon;
            this.btnAddTechnolgy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTechnolgy.Location = new System.Drawing.Point(20, 78);
            this.btnAddTechnolgy.Name = "btnAddTechnolgy";
            this.btnAddTechnolgy.Size = new System.Drawing.Size(152, 41);
            this.btnAddTechnolgy.TabIndex = 21;
            this.btnAddTechnolgy.Text = "Agregar";
            this.btnAddTechnolgy.UseVisualStyleBackColor = true;
            this.btnAddTechnolgy.Click += new System.EventHandler(this.btnAddTechnolgy_Click);
            // 
            // txtTechnologyName
            // 
            this.txtTechnologyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechnologyName.ForeColor = System.Drawing.Color.Gray;
            this.txtTechnologyName.Location = new System.Drawing.Point(92, 49);
            this.txtTechnologyName.Name = "txtTechnologyName";
            this.txtTechnologyName.Size = new System.Drawing.Size(293, 20);
            this.txtTechnologyName.TabIndex = 1;
            this.txtTechnologyName.Text = "Nombre";
            this.txtTechnologyName.Enter += new System.EventHandler(this.txtTechnologyName_Enter);
            this.txtTechnologyName.Leave += new System.EventHandler(this.txtTechnologyName_Leave);
            // 
            // txtTechnologyID
            // 
            this.txtTechnologyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechnologyID.ForeColor = System.Drawing.Color.Gray;
            this.txtTechnologyID.Location = new System.Drawing.Point(92, 23);
            this.txtTechnologyID.Name = "txtTechnologyID";
            this.txtTechnologyID.Size = new System.Drawing.Size(293, 20);
            this.txtTechnologyID.TabIndex = 0;
            this.txtTechnologyID.Text = "Número de Identificación";
            this.txtTechnologyID.Enter += new System.EventHandler(this.txtTechnologyID_Enter);
            this.txtTechnologyID.Leave += new System.EventHandler(this.txtTechnologyID_Leave);
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 642);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectsForm";
            this.Text = "ProjectsForm";
            this.Load += new System.EventHandler(this.ProjectsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProjectsInfo)).EndInit();
            this.gbContributors.ResumeLayout(false);
            this.gbContributors.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTechnologiesInfo)).EndInit();
            this.gbTechContainer.ResumeLayout(false);
            this.gbTechContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.DataGridView dgProjectsInfo;
        private System.Windows.Forms.GroupBox gbContributors;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnModifyProject;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjectObservations;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.DateTimePicker dtpExpected;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectExpected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectFinish;
        private System.Windows.Forms.DataGridView dgTechnologiesInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnologyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnologyName;
        private System.Windows.Forms.GroupBox gbTechContainer;
        private System.Windows.Forms.Button btnDeleteTechnology;
        private System.Windows.Forms.Button btnModifyTechnology;
        private System.Windows.Forms.Button btnAddTechnolgy;
        private System.Windows.Forms.TextBox txtTechnologyName;
        private System.Windows.Forms.TextBox txtTechnologyID;

    }
}