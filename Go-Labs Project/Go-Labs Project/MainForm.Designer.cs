namespace Go_Labs_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnVacations = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnFinances = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnContributors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(192, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1150, 642);
            this.panelContainer.TabIndex = 6;
            // 
            // btnVacations
            // 
            this.btnVacations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacations.Image = global::Go_Labs_Project.Properties.Resources.VacationsIco;
            this.btnVacations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVacations.Location = new System.Drawing.Point(12, 314);
            this.btnVacations.Name = "btnVacations";
            this.btnVacations.Size = new System.Drawing.Size(174, 56);
            this.btnVacations.TabIndex = 5;
            this.btnVacations.Text = "Vacaciones";
            this.btnVacations.UseVisualStyleBackColor = true;
            this.btnVacations.Click += new System.EventHandler(this.btnVacations_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.Image = global::Go_Labs_Project.Properties.Resources.ProjectIco;
            this.btnProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.Location = new System.Drawing.Point(12, 252);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(174, 56);
            this.btnProjects.TabIndex = 4;
            this.btnProjects.Text = "Proyectos";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Image = global::Go_Labs_Project.Properties.Resources.CustomerIco;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(12, 190);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(174, 56);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Clientes";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnFinances
            // 
            this.btnFinances.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinances.Image = global::Go_Labs_Project.Properties.Resources.FinancesIco;
            this.btnFinances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinances.Location = new System.Drawing.Point(12, 128);
            this.btnFinances.Name = "btnFinances";
            this.btnFinances.Size = new System.Drawing.Size(174, 56);
            this.btnFinances.TabIndex = 2;
            this.btnFinances.Text = "Finanzas";
            this.btnFinances.UseVisualStyleBackColor = true;
            this.btnFinances.Click += new System.EventHandler(this.btnFinances_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.Image = global::Go_Labs_Project.Properties.Resources.MembersIco;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.Location = new System.Drawing.Point(12, 66);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(174, 56);
            this.btnMembers.TabIndex = 1;
            this.btnMembers.Text = "Socios";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnContributors
            // 
            this.btnContributors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContributors.Image = global::Go_Labs_Project.Properties.Resources.ContributorsIco;
            this.btnContributors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContributors.Location = new System.Drawing.Point(12, 4);
            this.btnContributors.Name = "btnContributors";
            this.btnContributors.Size = new System.Drawing.Size(174, 56);
            this.btnContributors.TabIndex = 0;
            this.btnContributors.Text = "Colaboradores";
            this.btnContributors.UseVisualStyleBackColor = true;
            this.btnContributors.Click += new System.EventHandler(this.btnContributors_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 656);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnVacations);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnFinances);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnContributors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go-Labs Data Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContributors;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnFinances;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnVacations;
        private System.Windows.Forms.Panel panelContainer;
    }
}

