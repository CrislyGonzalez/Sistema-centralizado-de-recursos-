namespace Go_Labs_Project
{
    partial class InputTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputTypeForm));
            this.dgInputTypesInfo = new System.Windows.Forms.DataGridView();
            this.TechnologyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechnologyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInputTypeContainer = new System.Windows.Forms.GroupBox();
            this.txtInputTypeName = new System.Windows.Forms.TextBox();
            this.txtInputTypeID = new System.Windows.Forms.TextBox();
            this.btnDeleteInputType = new System.Windows.Forms.Button();
            this.btnModifyInputType = new System.Windows.Forms.Button();
            this.btnAddInputType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInputTypesInfo)).BeginInit();
            this.gbInputTypeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgInputTypesInfo
            // 
            this.dgInputTypesInfo.AllowUserToDeleteRows = false;
            this.dgInputTypesInfo.AllowUserToResizeColumns = false;
            this.dgInputTypesInfo.AllowUserToResizeRows = false;
            this.dgInputTypesInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgInputTypesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInputTypesInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TechnologyID,
            this.TechnologyName});
            this.dgInputTypesInfo.Location = new System.Drawing.Point(12, 160);
            this.dgInputTypesInfo.MultiSelect = false;
            this.dgInputTypesInfo.Name = "dgInputTypesInfo";
            this.dgInputTypesInfo.ReadOnly = true;
            this.dgInputTypesInfo.RowHeadersVisible = false;
            this.dgInputTypesInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInputTypesInfo.Size = new System.Drawing.Size(511, 150);
            this.dgInputTypesInfo.TabIndex = 5;
            this.dgInputTypesInfo.SelectionChanged += new System.EventHandler(this.dgInputTypesInfo_SelectionChanged);
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
            // gbInputTypeContainer
            // 
            this.gbInputTypeContainer.Controls.Add(this.btnDeleteInputType);
            this.gbInputTypeContainer.Controls.Add(this.btnModifyInputType);
            this.gbInputTypeContainer.Controls.Add(this.btnAddInputType);
            this.gbInputTypeContainer.Controls.Add(this.txtInputTypeName);
            this.gbInputTypeContainer.Controls.Add(this.txtInputTypeID);
            this.gbInputTypeContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInputTypeContainer.Location = new System.Drawing.Point(12, 12);
            this.gbInputTypeContainer.Name = "gbInputTypeContainer";
            this.gbInputTypeContainer.Size = new System.Drawing.Size(511, 132);
            this.gbInputTypeContainer.TabIndex = 4;
            this.gbInputTypeContainer.TabStop = false;
            this.gbInputTypeContainer.Text = "Tipos de Ingresos";
            // 
            // txtInputTypeName
            // 
            this.txtInputTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputTypeName.ForeColor = System.Drawing.Color.Gray;
            this.txtInputTypeName.Location = new System.Drawing.Point(92, 49);
            this.txtInputTypeName.Name = "txtInputTypeName";
            this.txtInputTypeName.Size = new System.Drawing.Size(293, 20);
            this.txtInputTypeName.TabIndex = 1;
            this.txtInputTypeName.Text = "Nombre";
            this.txtInputTypeName.Enter += new System.EventHandler(this.txtInputTypeName_Enter);
            this.txtInputTypeName.Leave += new System.EventHandler(this.txtInputTypeName_Leave);
            // 
            // txtInputTypeID
            // 
            this.txtInputTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputTypeID.ForeColor = System.Drawing.Color.Gray;
            this.txtInputTypeID.Location = new System.Drawing.Point(92, 23);
            this.txtInputTypeID.Name = "txtInputTypeID";
            this.txtInputTypeID.Size = new System.Drawing.Size(293, 20);
            this.txtInputTypeID.TabIndex = 0;
            this.txtInputTypeID.Text = "Número de Identificación";
            this.txtInputTypeID.Enter += new System.EventHandler(this.txtInputTypeID_Enter);
            this.txtInputTypeID.Leave += new System.EventHandler(this.txtInputTypeID_Leave);
            // 
            // btnDeleteInputType
            // 
            this.btnDeleteInputType.Image = global::Go_Labs_Project.Properties.Resources.DeleteIcon;
            this.btnDeleteInputType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteInputType.Location = new System.Drawing.Point(336, 78);
            this.btnDeleteInputType.Name = "btnDeleteInputType";
            this.btnDeleteInputType.Size = new System.Drawing.Size(152, 41);
            this.btnDeleteInputType.TabIndex = 24;
            this.btnDeleteInputType.Text = "Eliminar";
            this.btnDeleteInputType.UseVisualStyleBackColor = true;
            this.btnDeleteInputType.Click += new System.EventHandler(this.btnDeleteInputType_Click);
            // 
            // btnModifyInputType
            // 
            this.btnModifyInputType.Image = global::Go_Labs_Project.Properties.Resources.ModifyIcon;
            this.btnModifyInputType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyInputType.Location = new System.Drawing.Point(178, 78);
            this.btnModifyInputType.Name = "btnModifyInputType";
            this.btnModifyInputType.Size = new System.Drawing.Size(152, 41);
            this.btnModifyInputType.TabIndex = 23;
            this.btnModifyInputType.Text = "Modificar";
            this.btnModifyInputType.UseVisualStyleBackColor = true;
            this.btnModifyInputType.Click += new System.EventHandler(this.btnModifyInputType_Click);
            // 
            // btnAddInputType
            // 
            this.btnAddInputType.Image = global::Go_Labs_Project.Properties.Resources.AddIcon;
            this.btnAddInputType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddInputType.Location = new System.Drawing.Point(20, 78);
            this.btnAddInputType.Name = "btnAddInputType";
            this.btnAddInputType.Size = new System.Drawing.Size(152, 41);
            this.btnAddInputType.TabIndex = 21;
            this.btnAddInputType.Text = "Agregar";
            this.btnAddInputType.UseVisualStyleBackColor = true;
            this.btnAddInputType.Click += new System.EventHandler(this.btnAddInputType_Click);
            // 
            // InputTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 320);
            this.Controls.Add(this.dgInputTypesInfo);
            this.Controls.Add(this.gbInputTypeContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputTypeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Ingresos";
            this.Load += new System.EventHandler(this.InputTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInputTypesInfo)).EndInit();
            this.gbInputTypeContainer.ResumeLayout(false);
            this.gbInputTypeContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInputTypesInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnologyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnologyName;
        private System.Windows.Forms.GroupBox gbInputTypeContainer;
        private System.Windows.Forms.Button btnDeleteInputType;
        private System.Windows.Forms.Button btnModifyInputType;
        private System.Windows.Forms.Button btnAddInputType;
        private System.Windows.Forms.TextBox txtInputTypeName;
        private System.Windows.Forms.TextBox txtInputTypeID;
    }
}