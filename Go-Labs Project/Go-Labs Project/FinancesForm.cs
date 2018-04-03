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
    public partial class FinancesForm : Form
    {
        public FinancesForm()
        {
            InitializeComponent();
        }

        private void lblInputTypes_Click(object sender, EventArgs e)
        {
            InputTypeForm inputTypes = new InputTypeForm();
            this.Enabled = false;
            inputTypes.ShowDialog();
            this.Enabled = true;
        }

        private void txtInputID_Enter(object sender, EventArgs e)
        {
            if (this.txtInputID.Text.Trim().Equals("ID de Ingreso"))
            {
                this.txtInputID.Text = "";
                this.txtInputID.ForeColor = Color.Black;
            }
        }

        private void txtInputID_Leave(object sender, EventArgs e)
        {
            if (this.txtInputID.Text.Trim() == "")
            {
                this.txtInputID.Text = "ID de Ingreso";
                this.txtInputID.ForeColor = Color.Gray;
            }
        }

        private void txtInputAmount_Enter(object sender, EventArgs e)
        {
            if (this.txtInputAmount.Text.Trim().Equals("Monto"))
            {
                this.txtInputAmount.Text = "";
                this.txtInputAmount.ForeColor = Color.Black;
            }
        }

        private void txtInputAmount_Leave(object sender, EventArgs e)
        {
            if (this.txtInputAmount.Text.Trim() == "")
            {
                this.txtInputAmount.Text = "Monto";
                this.txtInputAmount.ForeColor = Color.Gray;
            }
        }

        private void txtInputObservations_Enter(object sender, EventArgs e)
        {
            if (this.txtInputObservations.Text.Trim().Equals("Observaciones"))
            {
                this.txtInputObservations.Text = "";
                this.txtInputObservations.ForeColor = Color.Black;
            }
        }

        private void txtInputObservations_Leave(object sender, EventArgs e)
        {
            if (this.txtInputObservations.Text.Trim() == "")
            {
                this.txtInputObservations.Text = "Observaciones";
                this.txtInputObservations.ForeColor = Color.Gray;
            }
        }

        private void txtSearchID_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchID.Text.Trim().Equals("ID de Ingreso"))
            {
                this.txtSearchID.Text = "";
                this.txtSearchID.ForeColor = Color.Black;
            }
        }

        private void txtSearchID_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchID.Text.Trim() == "")
            {
                this.txtSearchID.Text = "ID de Ingreso";
                this.txtSearchID.ForeColor = Color.Gray;
            }
        }
    }
}
