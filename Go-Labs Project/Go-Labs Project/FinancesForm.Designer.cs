namespace Go_Labs_Project
{
    partial class FinancesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgInputsInfo = new System.Windows.Forms.DataGridView();
            this.gbContributors = new System.Windows.Forms.GroupBox();
            this.lblInputTypes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputObservations = new System.Windows.Forms.TextBox();
            this.dtpInputDate = new System.Windows.Forms.DateTimePicker();
            this.txtInputAmount = new System.Windows.Forms.TextBox();
            this.cmbBillNumber = new System.Windows.Forms.ComboBox();
            this.cmbInputTypes = new System.Windows.Forms.ComboBox();
            this.txtInputID = new System.Windows.Forms.TextBox();
            this.btnDeleteInput = new System.Windows.Forms.Button();
            this.btnModifyInput = new System.Windows.Forms.Button();
            this.btnAddInput = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.InputID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInputsInfo)).BeginInit();
            this.gbContributors.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.tabPage1.Controls.Add(this.dgInputsInfo);
            this.tabPage1.Controls.Add(this.gbContributors);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(1034, 335);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(60, 46);
            this.btnLast.TabIndex = 13;
            this.btnLast.Text = ">>|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(968, 335);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 46);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(902, 335);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 46);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(836, 335);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(60, 46);
            this.btnFirst.TabIndex = 10;
            this.btnFirst.Text = "|<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuickSearch);
            this.groupBox1.Controls.Add(this.txtSearchID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(610, 7);
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
            this.btnQuickSearch.Location = new System.Drawing.Point(292, 64);
            this.btnQuickSearch.Name = "btnQuickSearch";
            this.btnQuickSearch.Size = new System.Drawing.Size(152, 41);
            this.btnQuickSearch.TabIndex = 4;
            this.btnQuickSearch.Text = "Buscar";
            this.btnQuickSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchID.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchID.Location = new System.Drawing.Point(151, 35);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(293, 20);
            this.txtSearchID.TabIndex = 3;
            this.txtSearchID.Text = "ID de Ingreso";
            this.txtSearchID.Enter += new System.EventHandler(this.txtSearchID_Enter);
            this.txtSearchID.Leave += new System.EventHandler(this.txtSearchID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por Cédula";
            // 
            // dgInputsInfo
            // 
            this.dgInputsInfo.AllowUserToDeleteRows = false;
            this.dgInputsInfo.AllowUserToResizeColumns = false;
            this.dgInputsInfo.AllowUserToResizeRows = false;
            this.dgInputsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgInputsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInputsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InputID,
            this.InputType,
            this.BillNumber,
            this.InputAmount,
            this.InputDate});
            this.dgInputsInfo.Location = new System.Drawing.Point(6, 387);
            this.dgInputsInfo.MultiSelect = false;
            this.dgInputsInfo.Name = "dgInputsInfo";
            this.dgInputsInfo.ReadOnly = true;
            this.dgInputsInfo.RowHeadersVisible = false;
            this.dgInputsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInputsInfo.Size = new System.Drawing.Size(1106, 199);
            this.dgInputsInfo.TabIndex = 8;
            // 
            // gbContributors
            // 
            this.gbContributors.Controls.Add(this.lblInputTypes);
            this.gbContributors.Controls.Add(this.label4);
            this.gbContributors.Controls.Add(this.label3);
            this.gbContributors.Controls.Add(this.txtInputObservations);
            this.gbContributors.Controls.Add(this.dtpInputDate);
            this.gbContributors.Controls.Add(this.txtInputAmount);
            this.gbContributors.Controls.Add(this.cmbBillNumber);
            this.gbContributors.Controls.Add(this.cmbInputTypes);
            this.gbContributors.Controls.Add(this.txtInputID);
            this.gbContributors.Controls.Add(this.btnDeleteInput);
            this.gbContributors.Controls.Add(this.btnModifyInput);
            this.gbContributors.Controls.Add(this.btnAddInput);
            this.gbContributors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContributors.Location = new System.Drawing.Point(6, 7);
            this.gbContributors.Name = "gbContributors";
            this.gbContributors.Size = new System.Drawing.Size(538, 374);
            this.gbContributors.TabIndex = 7;
            this.gbContributors.TabStop = false;
            this.gbContributors.Text = "Información de Ingreso";
            // 
            // lblInputTypes
            // 
            this.lblInputTypes.AutoSize = true;
            this.lblInputTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputTypes.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInputTypes.Location = new System.Drawing.Point(315, 78);
            this.lblInputTypes.Name = "lblInputTypes";
            this.lblInputTypes.Size = new System.Drawing.Size(145, 13);
            this.lblInputTypes.TabIndex = 30;
            this.lblInputTypes.Text = "Administrar Tipos de Ingresos";
            this.lblInputTypes.Click += new System.EventHandler(this.lblInputTypes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Número de Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo de Ingreso";
            // 
            // txtInputObservations
            // 
            this.txtInputObservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputObservations.ForeColor = System.Drawing.Color.Gray;
            this.txtInputObservations.Location = new System.Drawing.Point(31, 181);
            this.txtInputObservations.Multiline = true;
            this.txtInputObservations.Name = "txtInputObservations";
            this.txtInputObservations.Size = new System.Drawing.Size(429, 120);
            this.txtInputObservations.TabIndex = 28;
            this.txtInputObservations.Text = "Observaciones";
            this.txtInputObservations.Enter += new System.EventHandler(this.txtInputObservations_Enter);
            this.txtInputObservations.Leave += new System.EventHandler(this.txtInputObservations_Leave);
            // 
            // dtpInputDate
            // 
            this.dtpInputDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInputDate.Location = new System.Drawing.Point(167, 155);
            this.dtpInputDate.Name = "dtpInputDate";
            this.dtpInputDate.Size = new System.Drawing.Size(293, 20);
            this.dtpInputDate.TabIndex = 27;
            // 
            // txtInputAmount
            // 
            this.txtInputAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputAmount.ForeColor = System.Drawing.Color.Gray;
            this.txtInputAmount.Location = new System.Drawing.Point(167, 129);
            this.txtInputAmount.Name = "txtInputAmount";
            this.txtInputAmount.Size = new System.Drawing.Size(293, 20);
            this.txtInputAmount.TabIndex = 26;
            this.txtInputAmount.Text = "Monto";
            this.txtInputAmount.Enter += new System.EventHandler(this.txtInputAmount_Enter);
            this.txtInputAmount.Leave += new System.EventHandler(this.txtInputAmount_Leave);
            // 
            // cmbBillNumber
            // 
            this.cmbBillNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillNumber.FormattingEnabled = true;
            this.cmbBillNumber.Location = new System.Drawing.Point(167, 102);
            this.cmbBillNumber.Name = "cmbBillNumber";
            this.cmbBillNumber.Size = new System.Drawing.Size(293, 21);
            this.cmbBillNumber.TabIndex = 25;
            // 
            // cmbInputTypes
            // 
            this.cmbInputTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInputTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInputTypes.FormattingEnabled = true;
            this.cmbInputTypes.Location = new System.Drawing.Point(167, 54);
            this.cmbInputTypes.Name = "cmbInputTypes";
            this.cmbInputTypes.Size = new System.Drawing.Size(293, 21);
            this.cmbInputTypes.TabIndex = 24;
            // 
            // txtInputID
            // 
            this.txtInputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputID.ForeColor = System.Drawing.Color.Gray;
            this.txtInputID.Location = new System.Drawing.Point(167, 28);
            this.txtInputID.Name = "txtInputID";
            this.txtInputID.Size = new System.Drawing.Size(293, 20);
            this.txtInputID.TabIndex = 23;
            this.txtInputID.Text = "ID de Ingreso";
            this.txtInputID.Enter += new System.EventHandler(this.txtInputID_Enter);
            this.txtInputID.Leave += new System.EventHandler(this.txtInputID_Leave);
            // 
            // btnDeleteInput
            // 
            this.btnDeleteInput.Image = global::Go_Labs_Project.Properties.Resources.DeleteIcon;
            this.btnDeleteInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteInput.Location = new System.Drawing.Point(325, 316);
            this.btnDeleteInput.Name = "btnDeleteInput";
            this.btnDeleteInput.Size = new System.Drawing.Size(152, 41);
            this.btnDeleteInput.TabIndex = 22;
            this.btnDeleteInput.Text = "Eliminar";
            this.btnDeleteInput.UseVisualStyleBackColor = true;
            // 
            // btnModifyInput
            // 
            this.btnModifyInput.Image = global::Go_Labs_Project.Properties.Resources.ModifyIcon;
            this.btnModifyInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyInput.Location = new System.Drawing.Point(167, 316);
            this.btnModifyInput.Name = "btnModifyInput";
            this.btnModifyInput.Size = new System.Drawing.Size(152, 41);
            this.btnModifyInput.TabIndex = 21;
            this.btnModifyInput.Text = "Modificar";
            this.btnModifyInput.UseVisualStyleBackColor = true;
            // 
            // btnAddInput
            // 
            this.btnAddInput.Image = global::Go_Labs_Project.Properties.Resources.AddIcon;
            this.btnAddInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddInput.Location = new System.Drawing.Point(10, 316);
            this.btnAddInput.Name = "btnAddInput";
            this.btnAddInput.Size = new System.Drawing.Size(152, 41);
            this.btnAddInput.TabIndex = 20;
            this.btnAddInput.Text = "Agregar";
            this.btnAddInput.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gastos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1118, 592);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Facturas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // InputID
            // 
            this.InputID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InputID.HeaderText = "Identificación";
            this.InputID.Name = "InputID";
            this.InputID.ReadOnly = true;
            // 
            // InputType
            // 
            this.InputType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InputType.HeaderText = "Tipo de Ingreso";
            this.InputType.Name = "InputType";
            this.InputType.ReadOnly = true;
            // 
            // BillNumber
            // 
            this.BillNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillNumber.HeaderText = "Factura";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.ReadOnly = true;
            // 
            // InputAmount
            // 
            this.InputAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InputAmount.HeaderText = "Monto";
            this.InputAmount.Name = "InputAmount";
            this.InputAmount.ReadOnly = true;
            // 
            // InputDate
            // 
            this.InputDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InputDate.HeaderText = "Fecha";
            this.InputDate.Name = "InputDate";
            this.InputDate.ReadOnly = true;
            // 
            // FinancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 642);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinancesForm";
            this.Text = "FinancesForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInputsInfo)).EndInit();
            this.gbContributors.ResumeLayout(false);
            this.gbContributors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuickSearch;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgInputsInfo;
        private System.Windows.Forms.GroupBox gbContributors;
        private System.Windows.Forms.Button btnDeleteInput;
        private System.Windows.Forms.Button btnModifyInput;
        private System.Windows.Forms.Button btnAddInput;
        private System.Windows.Forms.TextBox txtInputObservations;
        private System.Windows.Forms.DateTimePicker dtpInputDate;
        private System.Windows.Forms.TextBox txtInputAmount;
        private System.Windows.Forms.ComboBox cmbBillNumber;
        private System.Windows.Forms.ComboBox cmbInputTypes;
        private System.Windows.Forms.TextBox txtInputID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInputTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputDate;
    }
}