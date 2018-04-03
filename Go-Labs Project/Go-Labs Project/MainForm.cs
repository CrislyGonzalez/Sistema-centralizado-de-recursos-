using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Go_Labs_Project
{
    public partial class MainForm : Form
    {
        private string currentForm = "Contributors";

        public MainForm()
        {
            InitializeComponent();
        }

        private void addFormInPanel(object form)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(f);
            this.panelContainer.Tag = f;
            f.Show();
        }

        private void btnContributors_Click(object sender, EventArgs e)
        {
            if (this.currentForm != "Contributors")
                this.addFormInPanel(new ContributorsForm());
            this.currentForm = "Contributors";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.addFormInPanel(new ContributorsForm());
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (this.currentForm != "Members")
                this.addFormInPanel(new MembersForm());
            this.currentForm = "Members";
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (this.currentForm != "Costumers")
                this.addFormInPanel(new CostumersForm());
            this.currentForm = "Costumers";
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            if (this.currentForm != "Projects")
                this.addFormInPanel(new ProjectsForm());
            this.currentForm = "Projects";
        }

        private void btnVacations_Click(object sender, EventArgs e)
        {
            if (this.currentForm != "Vacations")
                this.addFormInPanel(new VacationsForm());
            this.currentForm = "Vacations";
        }

        private void btnFinances_Click(object sender, EventArgs e)
        {
            if (this.currentForm != "Finances")
                this.addFormInPanel(new FinancesForm());
            this.currentForm = "Finances";
        }
    }
}
