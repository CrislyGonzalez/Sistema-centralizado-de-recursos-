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
    public partial class CostumersForm : Form
    {

        Methods connMethods = new Methods();

        public CostumersForm()
        {
            InitializeComponent();
        }

        private void resetTextFields()
        {
            try
            {
                this.txtClientID.Text = "Número de Identificación";
                this.txtClientName.Text = "Nombre";
                this.txtClientCountry.Text = "País";
                this.txtClientOcupation.Text = "Ocupación";
                this.txtClientWebSite.Text = "Sitio Web";
                this.txtContactName.Text = "Nombre Completo";
                this.txtContactPosition.Text = "Puesto en la Empresa";
                this.txtContactEmail.Text = "Correo Electrónico";
                this.txtClientID.ForeColor = this.txtClientName.ForeColor = this.txtClientCountry.ForeColor = this.txtClientOcupation.ForeColor = this.txtClientWebSite.ForeColor = this.txtContactName.ForeColor = this.txtContactPosition.ForeColor = this.txtContactEmail.ForeColor = Color.Gray;
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se ha producido un error en la aplicación. Por favor presione Aceptar y reinicie la aplicación", "Error - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchClientByID()
        {
            try
            {
                if (this.txtSearchID.Text.Trim() == "Número de Identificación")
                    MessageBox.Show("Por favor ingrese el número de identificación del cliente que desea buscar.", "Buscar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool found = true;
                    for (int i = 0; i < (this.dgClientsInfo.Rows.Count) - 1; i++)
                    {
                        if (this.txtSearchID.Text.Trim() == (String)this.dgClientsInfo[0, i].Value.ToString().Trim())
                        {
                            found = false;
                            int x = this.dgClientsInfo.SelectedCells[0].RowIndex;
                            this.dgClientsInfo.Rows[x].Selected = false;
                            this.dgClientsInfo.Rows[i].Selected = true;
                            this.txtSearchID.Text = "Número de Identificación";
                            this.txtSearchID.ForeColor = Color.Gray;
                            this.txtSearchID.Enabled = false;
                            this.txtSearchID.Enabled = true;
                            this.fillInputFields();
                            break;
                        }
                    }

                    if (found)
                    {
                        MessageBox.Show("No se ha encontrado ningún cliente que coincida con el número de identificación proporcionado.", "Buscar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al buscar el cliente por su número de indentificación. Por favor revise que el dato proporcionado sea correcto e inténtelo nuevamente.", "Buscar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillInputFields()
        {
            try
            {
                int selectedRow = this.dgClientsInfo.SelectedCells[0].RowIndex;

                if (this.dgClientsInfo[0, selectedRow].Value == null)
                {
                    this.resetTextFields();
                }
                else
                {
                    this.txtClientID.Text = (String)this.dgClientsInfo[0, selectedRow].Value.ToString().Trim();
                    this.txtClientName.Text = (String)this.dgClientsInfo[1, selectedRow].Value.ToString().Trim();
                    this.txtClientCountry.Text = (String)this.dgClientsInfo[2, selectedRow].Value.ToString().Trim();
                    this.txtClientOcupation.Text = (String)this.dgClientsInfo[3, selectedRow].Value.ToString().Trim();
                    this.txtClientWebSite.Text = (String)this.dgClientsInfo[4, selectedRow].Value.ToString().Trim();
                    this.txtContactName.Text = (String)this.dgClientsInfo[5, selectedRow].Value.ToString().Trim();
                    this.txtContactPosition.Text = (String)this.dgClientsInfo[6, selectedRow].Value.ToString().Trim();
                    this.txtContactEmail.Text = (String)this.dgClientsInfo[7, selectedRow].Value.ToString().Trim();
                    this.txtClientID.ForeColor = this.txtClientName.ForeColor = this.txtClientCountry.ForeColor = this.txtClientOcupation.ForeColor = this.txtClientWebSite.ForeColor = this.txtContactName.ForeColor = this.txtContactPosition.ForeColor = this.txtContactEmail.ForeColor = Color.Black;
                }
            }
            catch (Exception) { }
        }

        private void txtClientID_Enter(object sender, EventArgs e)
        {
            if (this.txtClientID.Text.Trim().Equals("Número de Identificación"))
            {
                this.txtClientID.Text = "";
                this.txtClientID.ForeColor = Color.Black;
            }
        }

        private void txtClientID_Leave(object sender, EventArgs e)
        {
            if (this.txtClientID.Text.Trim() == "")
            {
                this.txtClientID.Text = "Número de Identificación";
                this.txtClientID.ForeColor = Color.Gray;
            }
        }

        private void txtClientName_Enter(object sender, EventArgs e)
        {
            if (this.txtClientName.Text.Trim().Equals("Nombre"))
            {
                this.txtClientName.Text = "";
                this.txtClientName.ForeColor = Color.Black;
            }
        }

        private void txtClientName_Leave(object sender, EventArgs e)
        {
            if (this.txtClientName.Text.Trim() == "")
            {
                this.txtClientName.Text = "Nombre";
                this.txtClientName.ForeColor = Color.Gray;
            }
        }

        private void txtClientCountry_Enter(object sender, EventArgs e)
        {
            if (this.txtClientCountry.Text.Trim().Equals("País"))
            {
                this.txtClientCountry.Text = "";
                this.txtClientCountry.ForeColor = Color.Black;
            }
        }

        private void txtClientCountry_Leave(object sender, EventArgs e)
        {
            if (this.txtClientCountry.Text.Trim() == "")
            {
                this.txtClientCountry.Text = "País";
                this.txtClientCountry.ForeColor = Color.Gray;
            }
        }

        private void txtClientOcupation_Enter(object sender, EventArgs e)
        {
            if (this.txtClientOcupation.Text.Trim().Equals("Ocupación"))
            {
                this.txtClientOcupation.Text = "";
                this.txtClientOcupation.ForeColor = Color.Black;
            }
        }

        private void txtClientOcupation_Leave(object sender, EventArgs e)
        {
            if (this.txtClientOcupation.Text.Trim() == "")
            {
                this.txtClientOcupation.Text = "Ocupación";
                this.txtClientOcupation.ForeColor = Color.Gray;
            }
        }

        private void txtClientWebSite_Enter(object sender, EventArgs e)
        {
            if (this.txtClientWebSite.Text.Trim().Equals("Sitio Web"))
            {
                this.txtClientWebSite.Text = "";
                this.txtClientWebSite.ForeColor = Color.Black;
            }
        }

        private void txtClientWebSite_Leave(object sender, EventArgs e)
        {
            if (this.txtClientWebSite.Text.Trim() == "")
            {
                this.txtClientWebSite.Text = "Sitio Web";
                this.txtClientWebSite.ForeColor = Color.Gray;
            }
        }

        private void txtContactName_Enter(object sender, EventArgs e)
        {
            if (this.txtContactName.Text.Trim().Equals("Nombre Completo"))
            {
                this.txtContactName.Text = "";
                this.txtContactName.ForeColor = Color.Black;
            }
        }

        private void txtContactName_Leave(object sender, EventArgs e)
        {
            if (this.txtContactName.Text.Trim() == "")
            {
                this.txtContactName.Text = "Nombre Completo";
                this.txtContactName.ForeColor = Color.Gray;
            }
        }

        private void txtContactPosition_Enter(object sender, EventArgs e)
        {
            if (this.txtContactPosition.Text.Trim().Equals("Puesto en la Empresa"))
            {
                this.txtContactPosition.Text = "";
                this.txtContactPosition.ForeColor = Color.Black;
            }
        }

        private void txtContactPosition_Leave(object sender, EventArgs e)
        {
            if (this.txtContactPosition.Text.Trim() == "")
            {
                this.txtContactPosition.Text = "Puesto en la Empresa";
                this.txtContactPosition.ForeColor = Color.Gray;
            }
        }

        private void txtContactEmail_Enter(object sender, EventArgs e)
        {
            if (this.txtContactEmail.Text.Trim().Equals("Correo Electrónico"))
            {
                this.txtContactEmail.Text = "";
                this.txtContactEmail.ForeColor = Color.Black;
            }
        }

        private void txtContactEmail_Leave(object sender, EventArgs e)
        {
            if (this.txtContactEmail.Text.Trim() == "")
            {
                this.txtContactEmail.Text = "Correo Electrónico";
                this.txtContactEmail.ForeColor = Color.Gray;
            }
        }

        private void txtSearchID_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchID.Text.Trim().Equals("Número de Identificación"))
            {
                this.txtSearchID.Text = "";
                this.txtSearchID.ForeColor = Color.Black;
            }
        }

        private void txtSearchID_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchID.Text.Trim() == "")
            {
                this.txtSearchID.Text = "Número de Identificación";
                this.txtSearchID.ForeColor = Color.Gray;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtClientID.Text.Trim().Equals("Número de Identificación") || this.txtClientName.Text.Trim().Equals("Nombre") || this.txtClientCountry.Text.Trim().Equals("País") || this.txtClientOcupation.Text.Trim().Equals("Ocupación") || this.txtClientWebSite.Text.Trim().Equals("Sitio Web") || this.txtContactName.Text.Trim().Equals("Nombre Completo") || this.txtContactPosition.Text.Trim().Equals("Posición en la Empresa") || this.txtContactEmail.Text.Trim().Equals("Correo Electrónico"))
                    MessageBox.Show("Por favor complete todos los espacios para continuar.", "Agregar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (this.connMethods.setClientInfo(Convert.ToInt32(this.txtClientID.Text.Trim()), this.txtClientName.Text.Trim(), this.txtClientCountry.Text.Trim(), this.txtClientOcupation.Text.Trim(), this.txtClientWebSite.Text.Trim()))
                    {
                        if (this.connMethods.setContactInfo(this.txtContactName.Text.Trim(), Convert.ToInt32(this.txtClientID.Text.Trim()), this.txtContactPosition.Text.Trim(), this.txtContactEmail.Text.Trim()))
                        {
                            MessageBox.Show("El nuevo cliente y su contacto se agregaron exitosamente.", "Agregar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.resetTextFields();
                            this.connMethods.chargeClientsInfo(this.dgClientsInfo, this.cmbClientNames);
                            this.dgClientsInfo.Rows[0].Selected = true;
                            this.fillInputFields();
                        }
                    }
                    else
                        MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar el cliente y su contacto. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Agregar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar el cliente y su contacto. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Agregar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CostumersForm_Load(object sender, EventArgs e)
        {
            this.connMethods.chargeClientsInfo(this.dgClientsInfo, this.cmbClientNames);
            this.fillInputFields();
            if (this.dgClientsInfo[0, 0].Value != null)
            {
                this.dgClientsInfo.Rows[0].Selected = true;
                this.cmbClientNames.SelectedIndex = 0;
            }
            this.ActiveControl = this.lblPersonalInfo;
        }

        private void btnModifyClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtClientID.Text.Trim().Equals("Número de Identificación") || this.txtClientName.Text.Trim().Equals("Nombre") || this.txtClientCountry.Text.Trim().Equals("País") || this.txtClientOcupation.Text.Trim().Equals("Ocupación") || this.txtClientWebSite.Text.Trim().Equals("Sitio Web") || this.txtContactName.Text.Trim().Equals("Nombre Completo") || this.txtContactPosition.Text.Trim().Equals("Posición en la Empresa") || this.txtContactEmail.Text.Trim().Equals("Correo Electrónico"))
                {
                    MessageBox.Show("Por favor seleccione el cliente que desea modificar.", "Modificar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.fillInputFields();
                }
                else
                {
                    DialogResult modifyQuestion = MessageBox.Show("¿Seguro que desea modificar los datos del cliente seleccionado?\nPresione Si para guardar los cambios realizados o presione No para descartar los cambios.", "Modificar - Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modifyQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.modifyClientInfo(Convert.ToInt32(this.txtClientID.Text.Trim()), this.txtClientName.Text.Trim(), this.txtClientCountry.Text.Trim(), this.txtClientOcupation.Text.Trim(), this.txtClientWebSite.Text.Trim()))
                        {
                            if (this.connMethods.modifyContactInfo(this.txtContactName.Text.Trim(), Convert.ToInt32(this.txtClientID.Text.Trim()), this.txtContactPosition.Text.Trim(), this.txtContactEmail.Text.Trim()))
                            {
                                MessageBox.Show("El cliente ha sido modificado exitosamente.", "Modificar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.connMethods.chargeClientsInfo(this.dgClientsInfo, this.cmbClientNames);
                                this.fillInputFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar el cliente seleccionado. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.fillInputFields();
                        }
                    }
                    else
                        this.fillInputFields();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar el cliente seleccionado. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.fillInputFields();
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtClientID.Text.Trim().Equals("Número de Identificación"))
                    MessageBox.Show("Por favor seleccione el cliente que desea elmininar.", "Eliminar - Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DialogResult removeQuestion = MessageBox.Show("¿Seguro que desea eliminar el cliente seleccionado?\nPresione Si para remover toda la información vinculada con este cliente.\nPresione No para mantener la información.", "Eliminar - Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (removeQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.deleteClient(Convert.ToInt32(this.txtClientID.Text.Trim())))
                        {
                            MessageBox.Show("El cliente y su contacto han sido eliminados exitosamente.", "Eliminar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgClientsInfo.Rows.RemoveAt(this.dgClientsInfo.SelectedCells[0].RowIndex);
                            this.connMethods.chargeContributorsInfo(this.dgClientsInfo, this.cmbClientNames);
                            this.dgClientsInfo.Rows[this.dgClientsInfo.SelectedCells[0].RowIndex].Selected = false;
                            this.dgClientsInfo.Rows[0].Selected = true;
                            this.fillInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar el cliente. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.connMethods.chargeContributorsInfo(this.dgClientsInfo, this.cmbClientNames);
                            this.fillInputFields();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar el colaborador. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgClientsInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int totalRows = this.dgClientsInfo.Rows.Count;
                if (this.dgClientsInfo.Rows[0].Selected)
                {
                    this.btnFirst.Enabled = false;
                    this.btnLast.Enabled = true;
                }
                if (this.dgClientsInfo.Rows[totalRows - 2].Selected)
                {
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
                else if (this.dgClientsInfo.Rows[0].Selected == false && this.dgClientsInfo.Rows[totalRows - 2].Selected == false)
                {
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = true;
                }
                this.fillInputFields();
            }
            catch (Exception)
            {

            }
        }

        private void cmbClientNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.dgClientsInfo.Rows.Count.Equals(1))
            {
                this.dgClientsInfo.Rows[this.dgClientsInfo.SelectedCells[0].RowIndex].Selected = false;
                this.dgClientsInfo.Rows[this.cmbClientNames.SelectedIndex].Selected = true;
            }
        }

        private void btnQuickSearch_Click(object sender, EventArgs e)
        {
            this.searchClientByID();
        }

        private void txtSearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.searchClientByID();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = this.dgClientsInfo.SelectedCells[0].RowIndex;
                this.dgClientsInfo.Rows[selectedRow].Selected = false;
                this.dgClientsInfo.Rows[0].Selected = true;
                this.btnFirst.Enabled = false;
                this.btnLast.Enabled = true;

            }
            catch (Exception) { }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnLast.Enabled = true;
                int selectedRow = this.dgClientsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgClientsInfo.Rows.Count;

                if (this.dgClientsInfo.Rows[1].Selected)
                {
                    this.dgClientsInfo.Rows[1].Selected = false;
                    this.dgClientsInfo.Rows[0].Selected = true;
                    this.btnFirst.Enabled = false;
                }
                else if (this.dgClientsInfo.Rows[0].Selected)
                {
                    this.dgClientsInfo.Rows[0].Selected = false;
                    this.dgClientsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
                else
                {
                    this.dgClientsInfo.Rows[selectedRow].Selected = false;
                    this.dgClientsInfo.Rows[selectedRow - 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnFirst.Enabled = true;
                int selectedRow = this.dgClientsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgClientsInfo.Rows.Count;

                if (this.dgClientsInfo.Rows[totalRows - 3].Selected)
                {
                    this.dgClientsInfo.Rows[totalRows - 3].Selected = false;
                    this.dgClientsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnLast.Enabled = false;
                }
                else if (this.dgClientsInfo.Rows[totalRows - 2].Selected)
                {
                    this.dgClientsInfo.Rows[totalRows - 2].Selected = false;
                    this.dgClientsInfo.Rows[0].Selected = true;
                    this.btnFirst.Enabled = false;
                    this.btnLast.Enabled = true;
                }
                else
                {
                    this.dgClientsInfo.Rows[selectedRow].Selected = false;
                    this.dgClientsInfo.Rows[selectedRow + 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = this.dgClientsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgClientsInfo.Rows.Count;

                if (this.dgClientsInfo[0, selectedRow].Value != null)
                {
                    this.dgClientsInfo.Rows[selectedRow].Selected = false;
                    this.dgClientsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
            }
            catch (Exception) { }
        }
    }
}
