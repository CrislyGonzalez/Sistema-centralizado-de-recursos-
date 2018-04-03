namespace Go_Labs_Project
{
    partial class VacationsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgVacationsInfo = new System.Windows.Forms.DataGridView();
            this.VacationsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacationsContributor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacationsTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacationsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbContributors = new System.Windows.Forms.GroupBox();
            this.dtpVacationsDate = new System.Windows.Forms.DateTimePicker();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.cmbContributorsNames = new System.Windows.Forms.ComboBox();
            this.txtVacationID = new System.Windows.Forms.TextBox();
            this.btnDeleteVacation = new System.Windows.Forms.Button();
            this.btnModifyVacation = new System.Windows.Forms.Button();
            this.btnAddVacation = new System.Windows.Forms.Button();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacationsInfo)).BeginInit();
            this.gbContributors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(1061, 332);
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
            this.btnNext.Location = new System.Drawing.Point(995, 332);
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
            this.btnPrevious.Location = new System.Drawing.Point(929, 332);
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
            this.btnFirst.Location = new System.Drawing.Point(863, 332);
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(616, 12);
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
            this.btnQuickSearch.Location = new System.Drawing.Point(287, 67);
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
            this.txtSearchID.Location = new System.Drawing.Point(146, 38);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(293, 20);
            this.txtSearchID.TabIndex = 3;
            this.txtSearchID.Text = "ID de Vacaciones";
            this.txtSearchID.Enter += new System.EventHandler(this.txtSearchID_Enter);
            this.txtSearchID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchID_KeyPress);
            this.txtSearchID.Leave += new System.EventHandler(this.txtSearchID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por ID";
            // 
            // dgVacationsInfo
            // 
            this.dgVacationsInfo.AllowUserToDeleteRows = false;
            this.dgVacationsInfo.AllowUserToResizeColumns = false;
            this.dgVacationsInfo.AllowUserToResizeRows = false;
            this.dgVacationsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgVacationsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVacationsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VacationsID,
            this.VacationsContributor,
            this.VacationsTimeOut,
            this.VacationsDate});
            this.dgVacationsInfo.Location = new System.Drawing.Point(12, 384);
            this.dgVacationsInfo.MultiSelect = false;
            this.dgVacationsInfo.Name = "dgVacationsInfo";
            this.dgVacationsInfo.ReadOnly = true;
            this.dgVacationsInfo.RowHeadersVisible = false;
            this.dgVacationsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVacationsInfo.Size = new System.Drawing.Size(1126, 246);
            this.dgVacationsInfo.TabIndex = 15;
            this.dgVacationsInfo.SelectionChanged += new System.EventHandler(this.dgVacationsInfo_SelectionChanged);
            // 
            // VacationsID
            // 
            this.VacationsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VacationsID.HeaderText = "Identificación";
            this.VacationsID.Name = "VacationsID";
            this.VacationsID.ReadOnly = true;
            // 
            // VacationsContributor
            // 
            this.VacationsContributor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VacationsContributor.HeaderText = "Nombre del Colaborador";
            this.VacationsContributor.Name = "VacationsContributor";
            this.VacationsContributor.ReadOnly = true;
            // 
            // VacationsTimeOut
            // 
            this.VacationsTimeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VacationsTimeOut.HeaderText = "Cantidad de Tiempo Fuera";
            this.VacationsTimeOut.Name = "VacationsTimeOut";
            this.VacationsTimeOut.ReadOnly = true;
            // 
            // VacationsDate
            // 
            this.VacationsDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VacationsDate.HeaderText = "Fecha";
            this.VacationsDate.Name = "VacationsDate";
            this.VacationsDate.ReadOnly = true;
            // 
            // gbContributors
            // 
            this.gbContributors.Controls.Add(this.dtpVacationsDate);
            this.gbContributors.Controls.Add(this.txtTimeOut);
            this.gbContributors.Controls.Add(this.cmbContributorsNames);
            this.gbContributors.Controls.Add(this.txtVacationID);
            this.gbContributors.Controls.Add(this.btnDeleteVacation);
            this.gbContributors.Controls.Add(this.btnModifyVacation);
            this.gbContributors.Controls.Add(this.btnAddVacation);
            this.gbContributors.Controls.Add(this.lblPersonalInfo);
            this.gbContributors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContributors.Location = new System.Drawing.Point(12, 12);
            this.gbContributors.Name = "gbContributors";
            this.gbContributors.Size = new System.Drawing.Size(499, 249);
            this.gbContributors.TabIndex = 14;
            this.gbContributors.TabStop = false;
            this.gbContributors.Text = "Información de Vacaciones";
            // 
            // dtpVacationsDate
            // 
            this.dtpVacationsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVacationsDate.Location = new System.Drawing.Point(141, 127);
            this.dtpVacationsDate.Name = "dtpVacationsDate";
            this.dtpVacationsDate.Size = new System.Drawing.Size(293, 20);
            this.dtpVacationsDate.TabIndex = 26;
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeOut.ForeColor = System.Drawing.Color.Gray;
            this.txtTimeOut.Location = new System.Drawing.Point(141, 101);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(293, 20);
            this.txtTimeOut.TabIndex = 25;
            this.txtTimeOut.Text = "Cantidad de Tiempo Fuera";
            this.txtTimeOut.Enter += new System.EventHandler(this.txtTimeOut_Enter);
            this.txtTimeOut.Leave += new System.EventHandler(this.txtTimeOut_Leave);
            // 
            // cmbContributorsNames
            // 
            this.cmbContributorsNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContributorsNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContributorsNames.FormattingEnabled = true;
            this.cmbContributorsNames.Location = new System.Drawing.Point(141, 74);
            this.cmbContributorsNames.Name = "cmbContributorsNames";
            this.cmbContributorsNames.Size = new System.Drawing.Size(293, 21);
            this.cmbContributorsNames.TabIndex = 24;
            // 
            // txtVacationID
            // 
            this.txtVacationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacationID.ForeColor = System.Drawing.Color.Gray;
            this.txtVacationID.Location = new System.Drawing.Point(141, 48);
            this.txtVacationID.Name = "txtVacationID";
            this.txtVacationID.Size = new System.Drawing.Size(293, 20);
            this.txtVacationID.TabIndex = 23;
            this.txtVacationID.Text = "ID de Vacaciones";
            this.txtVacationID.Enter += new System.EventHandler(this.txtVacationsID_Enter);
            this.txtVacationID.Leave += new System.EventHandler(this.txtVacationsID_Leave);
            // 
            // btnDeleteVacation
            // 
            this.btnDeleteVacation.Image = global::Go_Labs_Project.Properties.Resources.DeleteIcon;
            this.btnDeleteVacation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteVacation.Location = new System.Drawing.Point(328, 163);
            this.btnDeleteVacation.Name = "btnDeleteVacation";
            this.btnDeleteVacation.Size = new System.Drawing.Size(152, 41);
            this.btnDeleteVacation.TabIndex = 22;
            this.btnDeleteVacation.Text = "Eliminar";
            this.btnDeleteVacation.UseVisualStyleBackColor = true;
            this.btnDeleteVacation.Click += new System.EventHandler(this.btnDeleteVacation_Click);
            // 
            // btnModifyVacation
            // 
            this.btnModifyVacation.Image = global::Go_Labs_Project.Properties.Resources.ModifyIcon;
            this.btnModifyVacation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyVacation.Location = new System.Drawing.Point(170, 163);
            this.btnModifyVacation.Name = "btnModifyVacation";
            this.btnModifyVacation.Size = new System.Drawing.Size(152, 41);
            this.btnModifyVacation.TabIndex = 21;
            this.btnModifyVacation.Text = "Modificar";
            this.btnModifyVacation.UseVisualStyleBackColor = true;
            this.btnModifyVacation.Click += new System.EventHandler(this.btnModifyVacation_Click);
            // 
            // btnAddVacation
            // 
            this.btnAddVacation.Image = global::Go_Labs_Project.Properties.Resources.AddIcon;
            this.btnAddVacation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVacation.Location = new System.Drawing.Point(13, 163);
            this.btnAddVacation.Name = "btnAddVacation";
            this.btnAddVacation.Size = new System.Drawing.Size(152, 41);
            this.btnAddVacation.TabIndex = 20;
            this.btnAddVacation.Text = "Agregar";
            this.btnAddVacation.UseVisualStyleBackColor = true;
            this.btnAddVacation.Click += new System.EventHandler(this.btnAddVacation_Click);
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.Location = new System.Drawing.Point(60, 75);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(75, 15);
            this.lblPersonalInfo.TabIndex = 0;
            this.lblPersonalInfo.Text = "Colaborador";
            // 
            // VacationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 642);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgVacationsInfo);
            this.Controls.Add(this.gbContributors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VacationsForm";
            this.Text = "VacationsForm";
            this.Load += new System.EventHandler(this.VacationsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacationsInfo)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgVacationsInfo;
        private System.Windows.Forms.GroupBox gbContributors;
        private System.Windows.Forms.Button btnDeleteVacation;
        private System.Windows.Forms.Button btnModifyVacation;
        private System.Windows.Forms.Button btnAddVacation;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacationsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacationsContributor;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacationsTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacationsDate;
        private System.Windows.Forms.DateTimePicker dtpVacationsDate;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.ComboBox cmbContributorsNames;
        private System.Windows.Forms.TextBox txtVacationID;
    }
}