namespace Go_Labs_Project
{
    partial class MembersForm
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
            this.cmbMemberNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMembersInfo = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbContributors = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberPercentage = new System.Windows.Forms.TextBox();
            this.txtMemberInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.txtMemberAddress = new System.Windows.Forms.TextBox();
            this.txtMemberTel = new System.Windows.Forms.TextBox();
            this.txtMemberSecondLastName = new System.Windows.Forms.TextBox();
            this.txtMemberFirstLastName = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnModifyMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembersInfo)).BeginInit();
            this.gbContributors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(1059, 354);
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
            this.btnNext.Location = new System.Drawing.Point(993, 354);
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
            this.btnPrevious.Location = new System.Drawing.Point(927, 354);
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
            this.btnFirst.Location = new System.Drawing.Point(861, 354);
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
            this.groupBox1.Controls.Add(this.cmbMemberNames);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(616, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 142);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda Rápida";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // cmbMemberNames
            // 
            this.cmbMemberNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemberNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMemberNames.FormattingEnabled = true;
            this.cmbMemberNames.Location = new System.Drawing.Point(174, 29);
            this.cmbMemberNames.Name = "cmbMemberNames";
            this.cmbMemberNames.Size = new System.Drawing.Size(293, 21);
            this.cmbMemberNames.TabIndex = 2;
            this.cmbMemberNames.SelectedIndexChanged += new System.EventHandler(this.cmbMemberNames_SelectedIndexChanged);
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
            // dgMembersInfo
            // 
            this.dgMembersInfo.AllowUserToDeleteRows = false;
            this.dgMembersInfo.AllowUserToResizeColumns = false;
            this.dgMembersInfo.AllowUserToResizeRows = false;
            this.dgMembersInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgMembersInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembersInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.MemberName,
            this.MemberTel,
            this.MemberAddress,
            this.MemberEmail,
            this.MemberInput,
            this.MemberPercentage});
            this.dgMembersInfo.Location = new System.Drawing.Point(12, 406);
            this.dgMembersInfo.MultiSelect = false;
            this.dgMembersInfo.Name = "dgMembersInfo";
            this.dgMembersInfo.ReadOnly = true;
            this.dgMembersInfo.RowHeadersVisible = false;
            this.dgMembersInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMembersInfo.Size = new System.Drawing.Size(1126, 224);
            this.dgMembersInfo.TabIndex = 8;
            this.dgMembersInfo.SelectionChanged += new System.EventHandler(this.dgMembersInfo_SelectionChanged);
            // 
            // MemberID
            // 
            this.MemberID.HeaderText = "Cédula";
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.Width = 80;
            // 
            // MemberName
            // 
            this.MemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemberName.HeaderText = "Nombre Completo";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // MemberTel
            // 
            this.MemberTel.HeaderText = "Teléfono";
            this.MemberTel.Name = "MemberTel";
            this.MemberTel.ReadOnly = true;
            this.MemberTel.Width = 90;
            // 
            // MemberAddress
            // 
            this.MemberAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemberAddress.HeaderText = "Dirección";
            this.MemberAddress.Name = "MemberAddress";
            this.MemberAddress.ReadOnly = true;
            // 
            // MemberEmail
            // 
            this.MemberEmail.HeaderText = "Correo Electrónico";
            this.MemberEmail.Name = "MemberEmail";
            this.MemberEmail.ReadOnly = true;
            this.MemberEmail.Width = 180;
            // 
            // MemberInput
            // 
            this.MemberInput.HeaderText = "Aportación";
            this.MemberInput.Name = "MemberInput";
            this.MemberInput.ReadOnly = true;
            // 
            // MemberPercentage
            // 
            this.MemberPercentage.HeaderText = "Porcentaje";
            this.MemberPercentage.Name = "MemberPercentage";
            this.MemberPercentage.ReadOnly = true;
            // 
            // gbContributors
            // 
            this.gbContributors.Controls.Add(this.label4);
            this.gbContributors.Controls.Add(this.txtMemberPercentage);
            this.gbContributors.Controls.Add(this.txtMemberInput);
            this.gbContributors.Controls.Add(this.label3);
            this.gbContributors.Controls.Add(this.txtMemberEmail);
            this.gbContributors.Controls.Add(this.txtMemberAddress);
            this.gbContributors.Controls.Add(this.txtMemberTel);
            this.gbContributors.Controls.Add(this.txtMemberSecondLastName);
            this.gbContributors.Controls.Add(this.txtMemberFirstLastName);
            this.gbContributors.Controls.Add(this.txtMemberName);
            this.gbContributors.Controls.Add(this.txtMemberID);
            this.gbContributors.Controls.Add(this.btnDeleteMember);
            this.gbContributors.Controls.Add(this.btnModifyMember);
            this.gbContributors.Controls.Add(this.btnAddMember);
            this.gbContributors.Controls.Add(this.lblPersonalInfo);
            this.gbContributors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContributors.Location = new System.Drawing.Point(12, 12);
            this.gbContributors.Name = "gbContributors";
            this.gbContributors.Size = new System.Drawing.Size(499, 388);
            this.gbContributors.TabIndex = 7;
            this.gbContributors.TabStop = false;
            this.gbContributors.Text = "Información Personal - Socio";
            this.gbContributors.Enter += new System.EventHandler(this.gbContributors_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "%";
            // 
            // txtMemberPercentage
            // 
            this.txtMemberPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberPercentage.ForeColor = System.Drawing.Color.Gray;
            this.txtMemberPercentage.Location = new System.Drawing.Point(105, 287);
            this.txtMemberPercentage.Name = "txtMemberPercentage";
            this.txtMemberPercentage.Size = new System.Drawing.Size(293, 20);
            this.txtMemberPercentage.TabIndex = 32;
            this.txtMemberPercentage.Text = "Porcentaje Accionario";
            this.txtMemberPercentage.Enter += new System.EventHandler(this.txtMemberPercentage_Enter);
            this.txtMemberPercentage.Leave += new System.EventHandler(this.txtMemberPercentage_Leave);
            // 
            // txtMemberInput
            // 
            this.txtMemberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberInput.ForeColor = System.Drawing.Color.Gray;
            this.txtMemberInput.Location = new System.Drawing.Point(105, 261);
            this.txtMemberInput.Name = "txtMemberInput";
            this.txtMemberInput.Size = new System.Drawing.Size(293, 20);
            this.txtMemberInput.TabIndex = 31;
            this.txtMemberInput.Text = "Aportación";
            this.txtMemberInput.Enter += new System.EventHandler(this.txtMemberInput_Enter);
            this.txtMemberInput.Leave += new System.EventHandler(this.txtMemberInput_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Información de Socio";
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtMemberEmail.Location = new System.Drawing.Point(105, 208);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.Size = new System.Drawing.Size(293, 20);
            this.txtMemberEmail.TabIndex = 29;
            this.txtMemberEmail.Text = "Correo Electrónico";
            this.txtMemberEmail.Enter += new System.EventHandler(this.txtMemberEmail_Enter);
            this.txtMemberEmail.Leave += new System.EventHandler(this.txtMemberEmail_Leave);
            // 
            // txtMemberAddress
            // 
            this.txtMemberAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtMemberAddress.Location = new System.Drawing.Point(105, 182);
            this.txtMemberAddress.Name = "txtMemberAddress";
            this.txtMemberAddress.Size = new System.Drawing.Size(293, 20);
            this.txtMemberAddress.TabIndex = 28;
            this.txtMemberAddress.Text = "Dirección";
            this.txtMemberAddress.Enter += new System.EventHandler(this.txtMemberAddress_Enter);
            this.txtMemberAddress.Leave += new System.EventHandler(this.txtMemberAddress_Leave);
            // 
            // txtMemberTel
            // 
            this.txtMemberTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberTel.ForeColor = System.Drawing.Color.Gray;
            this.txtMemberTel.Location = new System.Drawing.Point(105, 156);
            this.txtMemberTel.Name = "txtMemberTel";
            this.txtMemberTel.Size = new System.Drawing.Size(293, 20);
            this.txtMemberTel.TabIndex = 27;
            this.txtMemberTel.Text = "Teléfono";
            this.txtMemberTel.Enter += new System.EventHandler(this.txtMemberTel_Enter);
            this.txtMemberTel.Leave += new System.EventHandler(this.txtMemberTel_Leave);
            // 
            // txtMemberSecondLastName
            // 
            this.txtMemberSecondLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberSecondLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtMemberSecondLastName.Location = new System.Drawing.Point(105, 130);
            this.txtMemberSecondLastName.Name = "txtMemberSecondLastName";
            this.txtMemberSecondLastName.Size = new System.Drawing.Size(293, 20);
            this.txtMemberSecondLastName.TabIndex = 26;
            this.txtMemberSecondLastName.Text = "Segundo Apellido";
            this.txtMemberSecondLastName.Enter += new System.EventHandler(this.txtMemberSecondLastName_Enter);
            this.txtMemberSecondLastName.Leave += new System.EventHandler(this.txtMemberSecondLastName_Leave);
            // 
            // txtMemberFirstLastName
            // 
            this.txtMemberFirstLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberFirstLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtMemberFirstLastName.Location = new System.Drawing.Point(105, 104);
            this.txtMemberFirstLastName.Name = "txtMemberFirstLastName";
            this.txtMemberFirstLastName.Size = new System.Drawing.Size(293, 20);
            this.txtMemberFirstLastName.TabIndex = 25;
            this.txtMemberFirstLastName.Text = "Primer Apellido";
            this.txtMemberFirstLastName.Enter += new System.EventHandler(this.txtMemberFirstLastName_Enter);
            this.txtMemberFirstLastName.Leave += new System.EventHandler(this.txtMemberFirstLastName_Leave);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.ForeColor = System.Drawing.Color.Gray;
            this.txtMemberName.Location = new System.Drawing.Point(105, 78);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(293, 20);
            this.txtMemberName.TabIndex = 24;
            this.txtMemberName.Text = "Nombre";
            this.txtMemberName.Enter += new System.EventHandler(this.txtMemberName_Enter);
            this.txtMemberName.Leave += new System.EventHandler(this.txtMemberName_Leave);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.ForeColor = System.Drawing.Color.Gray;
            this.txtMemberID.Location = new System.Drawing.Point(105, 52);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(293, 20);
            this.txtMemberID.TabIndex = 23;
            this.txtMemberID.Text = "Cédula";
            this.txtMemberID.Enter += new System.EventHandler(this.txtMemberID_Enter);
            this.txtMemberID.Leave += new System.EventHandler(this.txtMemberID_Leave);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Image = global::Go_Labs_Project.Properties.Resources.DeleteIcon;
            this.btnDeleteMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMember.Location = new System.Drawing.Point(328, 335);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(152, 41);
            this.btnDeleteMember.TabIndex = 22;
            this.btnDeleteMember.Text = "Eliminar";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnModifyMember
            // 
            this.btnModifyMember.Image = global::Go_Labs_Project.Properties.Resources.ModifyIcon;
            this.btnModifyMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyMember.Location = new System.Drawing.Point(170, 335);
            this.btnModifyMember.Name = "btnModifyMember";
            this.btnModifyMember.Size = new System.Drawing.Size(152, 41);
            this.btnModifyMember.TabIndex = 21;
            this.btnModifyMember.Text = "Modificar";
            this.btnModifyMember.UseVisualStyleBackColor = true;
            this.btnModifyMember.Click += new System.EventHandler(this.btnModifyMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Image = global::Go_Labs_Project.Properties.Resources.AddIcon;
            this.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.Location = new System.Drawing.Point(13, 335);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(152, 41);
            this.btnAddMember.TabIndex = 20;
            this.btnAddMember.Text = "Agregar";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
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
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 642);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgMembersInfo);
            this.Controls.Add(this.gbContributors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            this.Load += new System.EventHandler(this.MembersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembersInfo)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbMemberNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMembersInfo;
        private System.Windows.Forms.GroupBox gbContributors;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnModifyMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberPercentage;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemberPercentage;
        private System.Windows.Forms.TextBox txtMemberInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.TextBox txtMemberAddress;
        private System.Windows.Forms.TextBox txtMemberTel;
        private System.Windows.Forms.TextBox txtMemberSecondLastName;
        private System.Windows.Forms.TextBox txtMemberFirstLastName;
        private System.Windows.Forms.TextBox txtMemberName;
    }
}