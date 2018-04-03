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
    public partial class MembersForm : Form
    {
        Methods connMethods = new Methods();

        public MembersForm()
        {
            InitializeComponent();
        }

        private void resetTextFields()
        {
            try
            {
                this.txtMemberID.Text = "Cédula";
                this.txtMemberName.Text = "Nombre";
                this.txtMemberFirstLastName.Text = "Primer Apellido";
                this.txtMemberSecondLastName.Text = "Segundo Apellido";
                this.txtMemberTel.Text = "Teléfono";
                this.txtMemberAddress.Text = "Dirección";
                this.txtMemberEmail.Text = "Correo Electrónico";
                this.txtMemberInput.Text = "Aportación";
                this.txtMemberPercentage.Text = "Porcentaje Accionario";
                this.txtMemberID.ForeColor = this.txtMemberName.ForeColor = this.txtMemberFirstLastName.ForeColor = this.txtMemberSecondLastName.ForeColor = this.txtMemberTel.ForeColor = this.txtMemberAddress.ForeColor = this.txtMemberEmail.ForeColor = this.txtMemberInput.ForeColor = this.txtMemberPercentage.ForeColor = Color.Gray;
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se ha producido un error en la aplicación. Por favor presione Aceptar y reinicie la aplicación", "Error - Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillInputFields()
        {
            try
            {
                int selectedRow = this.dgMembersInfo.SelectedCells[0].RowIndex;

                if (this.dgMembersInfo[0, selectedRow].Value == null)
                {
                    this.resetTextFields();
                }
                else
                {
                    string fullName = (String)this.dgMembersInfo[1, selectedRow].Value.ToString().Trim();
                    string[] nameByParts = fullName.Split(' ');
                    if (nameByParts.Length == 3)
                    {
                        this.txtMemberName.Text = nameByParts[0];
                        this.txtMemberFirstLastName.Text = nameByParts[1];
                        this.txtMemberSecondLastName.Text = nameByParts[2];
                    }
                    else
                    {
                        this.txtMemberName.Text = nameByParts[0] + " " + nameByParts[1];
                        this.txtMemberFirstLastName.Text = nameByParts[2];
                        this.txtMemberSecondLastName.Text = nameByParts[3];
                    }
                    this.txtMemberID.Text = (String)this.dgMembersInfo[0, selectedRow].Value.ToString().Trim();
                    this.txtMemberTel.Text = (String)this.dgMembersInfo[2, selectedRow].Value.ToString().Trim();
                    this.txtMemberAddress.Text = (String)this.dgMembersInfo[3, selectedRow].Value.ToString().Trim();
                    this.txtMemberEmail.Text = (String)this.dgMembersInfo[4, selectedRow].Value.ToString().Trim();
                    this.txtMemberInput.Text = (String)this.dgMembersInfo[5, selectedRow].Value.ToString().Trim();
                    this.txtMemberPercentage.Text = (String)this.dgMembersInfo[6, selectedRow].Value.ToString().Trim();
                    this.txtMemberID.ForeColor = this.txtMemberName.ForeColor = this.txtMemberFirstLastName.ForeColor = this.txtMemberSecondLastName.ForeColor = this.txtMemberTel.ForeColor = this.txtMemberAddress.ForeColor = this.txtMemberEmail.ForeColor = this.txtMemberInput.ForeColor = this.txtMemberPercentage.ForeColor = Color.Black;
                }
            }
            catch (Exception) { }
        }

        private void searchMemberByID()
        {
            try
            {
                if (this.txtSearchID.Text.Trim() == "Cédula")
                    MessageBox.Show("Por favor ingrese el número de identificación del socio que desea buscar.", "Buscar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool found = true;
                    for (int i = 0; i < (this.dgMembersInfo.Rows.Count) - 1; i++)
                    {
                        if (this.txtSearchID.Text.Trim() == (String)this.dgMembersInfo[0, i].Value.ToString().Trim())
                        {
                            found = false;
                            int x = this.dgMembersInfo.SelectedCells[0].RowIndex;
                            this.dgMembersInfo.Rows[x].Selected = false;
                            this.dgMembersInfo.Rows[i].Selected = true;
                            this.txtSearchID.Text = "Cédula";
                            this.txtSearchID.ForeColor = Color.Gray;
                            this.txtSearchID.Enabled = false;
                            this.txtSearchID.Enabled = true;
                            this.fillInputFields();
                            break;
                        }
                    }

                    if (found)
                    {
                        MessageBox.Show("No se ha encontrado ningún socio que coincida con el número de identificación proporcionado.", "Buscar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al buscar el socio por su número de indentificación. Por favor revise que el dato proporcionado sea correcto e inténtelo nuevamente.", "Buscar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMemberID_Enter(object sender, EventArgs e)
        {
            if (this.txtMemberID.Text.Trim().Equals("Cédula"))
            {
                this.txtMemberID.Text = "";
                this.txtMemberID.ForeColor = Color.Black;
            }
        }

        private void txtMemberID_Leave(object sender, EventArgs e)
        {
            if (this.txtMemberID.Text.Trim() == "")
            {
                this.txtMemberID.Text = "Cédula";
                this.txtMemberID.ForeColor = Color.Gray;
            }
        }

        private void txtMemberName_Enter(object sender, EventArgs e)
        {
            if (this.txtMemberName.Text.Trim().Equals("Nombre"))
            {
                this.txtMemberName.Text = "";
                this.txtMemberName.ForeColor = Color.Black;
            }
        }

        private void txtMemberName_Leave(object sender, EventArgs e)
        {
            if (this.txtMemberName.Text.Trim() == "")
            {
                this.txtMemberName.Text = "Nombre";
                this.txtMemberName.ForeColor = Color.Gray;
            }
        }

        private void txtMemberFirstLastName_Enter(object sender, EventArgs e)
        {
            if (this.txtMemberFirstLastName.Text.Trim().Equals("Primer Apellido"))
            {
                this.txtMemberFirstLastName.Text = "";
                this.txtMemberFirstLastName.ForeColor = Color.Black;
            }
        }

        private void txtMemberFirstLastName_Leave(object sender, EventArgs e)
        {
            if (this.txtMemberFirstLastName.Text.Trim() == "")
            {
                this.txtMemberFirstLastName.Text = "Primer Apellido";
                this.txtMemberFirstLastName.ForeColor = Color.Gray;
            }
        }

        private void txtMemberSecondLastName_Enter(object sender, EventArgs e)
        {
            if (this.txtMemberSecondLastName.Text.Trim().Equals("Segundo Apellido"))
            {
                this.txtMemberSecondLastName.Text = "";
                this.txtMemberSecondLastName.ForeColor = Color.Black;
            }
        }

        private void txtMemberSecondLastName_Leave(object sender, EventArgs e)
        {
            if (this.txtMemberSecondLastName.Text.Trim() == "")
            {
                this.txtMemberSecondLastName.Text = "Segundo Apellido";
                this.txtMemberSecondLastName.ForeColor = Color.Gray;
            }
        }

        private void txtMemberTel_Enter(object sender, EventArgs e)
        {
            if (this.txtMemberTel.Text.Trim().Equals("Teléfono"))
            {
                this.txtMemberTel.Text = "";
                this.txtMemberTel.ForeColor = Color.Black;
            }
        }

        private void txtMemberTel_Leave(object sender, EventArgs e)
        {
            if (this.txtMemberTel.Text.Trim() == "")
            {
                this.txtMemberTel.Text = "Teléfono";
                this.txtMemberTel.ForeColor = Color.Gray;
            }
        }

        private void txtMemberAddress_Enter(object sender, EventArgs e)
        {
            if (this.txtMemberAddress.Text.Trim().Equals("Dirección"))
            {
                this.txtMemberAddress.Text = "";
                this.txtMemberAddress.ForeColor = Color.Black;
            }
        }

        private void txtMemberAddress_Leave(object sender, EventArgs e)
        {
            if (this.txtMemberAddress.Text.Trim() == "")
            {
                this.txtMemberAddress.Text = "Dirección";
                this.txtMemberAddress.ForeColor = Color.Gray;
            }
        }

        private void txtMemberEmail_Enter(object sender, EventArgs e)
        {
            if (this.txtMemberEmail.Text.Trim().Equals("Correo Electrónico"))
            {
                this.txtMemberEmail.Text = "";
                this.txtMemberEmail.ForeColor = Color.Black;
            }
        }

        private void txtMemberEmail_Leave(object sender, EventArgs e)
        {
            if (this.txtMemberEmail.Text.Trim() == "")
            {
                this.txtMemberEmail.Text = "Correo Electrónico";
                this.txtMemberEmail.ForeColor = Color.Gray;
            }
        }

        private void txtMemberInput_Enter(object sender, EventArgs e)
        {
            if (this.txtMemberInput.Text.Trim().Equals("Aportación"))
            {
                this.txtMemberInput.Text = "";
                this.txtMemberInput.ForeColor = Color.Black;
            }
        }

        private void txtMemberInput_Leave(object sender, EventArgs e)
        {
            if (this.txtMemberInput.Text.Trim() == "")
            {
                this.txtMemberInput.Text = "Aportación";
                this.txtMemberInput.ForeColor = Color.Gray;
            }
        }

        private void txtMemberPercentage_Enter(object sender, EventArgs e)
        {
            if (this.txtMemberPercentage.Text.Trim().Equals("Porcentaje Accionario"))
            {
                this.txtMemberPercentage.Text = "";
                this.txtMemberPercentage.ForeColor = Color.Black;
            }
        }

        private void txtMemberPercentage_Leave(object sender, EventArgs e)
        {
            if (this.txtMemberPercentage.Text.Trim() == "")
            {
                this.txtMemberPercentage.Text = "Porcentaje Accionario";
                this.txtMemberPercentage.ForeColor = Color.Gray;
            }
        }

        private void txtSearchID_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchID.Text.Trim().Equals("Cédula"))
            {
                this.txtSearchID.Text = "";
                this.txtSearchID.ForeColor = Color.Black;
            }
        }

        private void txtSearchID_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchID.Text.Trim() == "")
            {
                this.txtSearchID.Text = "Cédula";
                this.txtSearchID.ForeColor = Color.Gray;
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMemberID.Text.Trim().Equals("Cédula") || this.txtMemberName.Text.Trim().Equals("Nombre") || this.txtMemberFirstLastName.Text.Trim().Equals("Primer Apellido") || this.txtMemberSecondLastName.Text.Trim().Equals("Segundo Apellido") || this.txtMemberTel.Text.Trim().Equals("Teléfono") || this.txtMemberAddress.Text.Trim().Equals("Dirección") || this.txtMemberEmail.Text.Trim().Equals("Correo Electrónico") || this.txtMemberInput.Text.Trim().Equals("Aportación") || this.txtMemberPercentage.Text.Trim().Equals("Porcentaje Accionario"))
                    MessageBox.Show("Por favor complete todos los espacios para continuar.", "Agregar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (this.connMethods.setPersonalInfo(this.txtMemberID.Text.Trim(), this.txtMemberName.Text.Trim(), this.txtMemberFirstLastName.Text.Trim(), this.txtMemberSecondLastName.Text.Trim(), this.txtMemberTel.Text.Trim(), this.txtMemberAddress.Text.Trim(), this.txtMemberEmail.Text.Trim()))
                    {
                        if (this.connMethods.setMembersInfo(this.txtMemberID.Text.Trim(), Convert.ToInt32(this.txtMemberInput.Text.Trim()), Convert.ToDecimal(this.txtMemberPercentage.Text.Trim())))
                        {
                            MessageBox.Show("El nuevo socio se agregó exitosamente.", "Agregar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.resetTextFields();
                            this.connMethods.chargeMembersInfo(this.dgMembersInfo, this.cmbMemberNames);
                            this.dgMembersInfo.Rows[0].Selected = true;
                            this.fillInputFields();
                        }
                    }
                    else
                    {
                        DialogResult existQuestion = MessageBox.Show("Se encontró una persona ingresada con los mismos datos personales.\n¿Desea agregar los datos de socio a la persona?\nPresione Si para agregar los datos y continuar o presione No para descartar los datos ingresados.", "Agregar - Socios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (existQuestion == DialogResult.Yes)
                        {
                            if (this.connMethods.setMembersInfo(this.txtMemberID.Text.Trim(), Convert.ToInt32(this.txtMemberInput.Text.Trim()), Convert.ToDecimal(this.txtMemberPercentage.Text.Trim())))
                            {
                                MessageBox.Show("Los datos han sido vinculados a la persona exitosamente.", "Agregar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.resetTextFields();
                                this.connMethods.chargeMembersInfo(this.dgMembersInfo, this.cmbMemberNames);
                                this.dgMembersInfo.Rows[0].Selected = true;
                                this.fillInputFields();
                            }
                            else
                                MessageBox.Show("Lo sentimos. Se produjo un error al intentar agregar los datos de socio. Por favor revise que la información sea correcta o no exista otro socio con el mismo número de identificacón.", "Agregar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar el nuevo socio. Por favor revise que la información sea correcta o no exista otro socio con el mismo número de identificacón.", "Agregar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            this.connMethods.chargeMembersInfo(this.dgMembersInfo, this.cmbMemberNames);
            this.fillInputFields();
            if (this.dgMembersInfo[0, 0].Value != null)
            {
                this.dgMembersInfo.Rows[0].Selected = true;
                this.cmbMemberNames.SelectedIndex = 0;
            }
            this.ActiveControl = this.lblPersonalInfo;
        }

        private void dgMembersInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int totalRows = this.dgMembersInfo.Rows.Count;
                if (this.dgMembersInfo.Rows[0].Selected)
                {
                    this.btnFirst.Enabled = false;
                    this.btnLast.Enabled = true;
                }
                if (this.dgMembersInfo.Rows[totalRows - 2].Selected)
                {
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
                else if (this.dgMembersInfo.Rows[0].Selected == false && this.dgMembersInfo.Rows[totalRows - 2].Selected == false)
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

        private void btnModifyMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMemberID.Text.Trim().Equals("Cédula") || this.txtMemberName.Text.Trim().Equals("Nombre") || this.txtMemberFirstLastName.Text.Trim().Equals("Primer Apellido") || this.txtMemberSecondLastName.Text.Trim().Equals("Segundo Apellido") || this.txtMemberTel.Text.Trim().Equals("Teléfono") || this.txtMemberAddress.Text.Trim().Equals("Dirección") || this.txtMemberEmail.Text.Trim().Equals("Correo Electrónico") || this.txtMemberInput.Text.Trim().Equals("Aportación") || this.txtMemberPercentage.Text.Trim().Equals("Porcentaje Accionario"))
                {
                    MessageBox.Show("Por favor seleccione el socio que desea modificar.", "Modificar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.fillInputFields();
                }
                else
                {
                    DialogResult modifyQuestion = MessageBox.Show("¿Seguro que desea modificar los datos del socio seleccionado?\nPresione Si para guardar los cambios realizados o presione No para descartar los cambios.", "Modificar - Socios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modifyQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.modifyPersonalInfo(this.txtMemberID.Text.Trim(), this.txtMemberName.Text.Trim(), this.txtMemberFirstLastName.Text.Trim(), this.txtMemberSecondLastName.Text.Trim(), this.txtMemberTel.Text.Trim(), this.txtMemberAddress.Text.Trim(), this.txtMemberEmail.Text.Trim()))
                        {
                            if (this.connMethods.modifyMembersInfo(this.txtMemberID.Text.Trim(), Convert.ToInt32(this.txtMemberInput.Text.Trim()), Convert.ToDecimal(this.txtMemberPercentage.Text.Trim())))
                            {
                                MessageBox.Show("El socio ha sido modificado exitosamente.", "Modificar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.connMethods.chargeMembersInfo(this.dgMembersInfo, this.cmbMemberNames);
                                this.fillInputFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar el socio seleccionado. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.fillInputFields();
                        }
                    }
                    else
                        this.fillInputFields();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar el socio seleccionado. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.fillInputFields();
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMemberID.Text.Trim().Equals("Cédula"))
                    MessageBox.Show("Por favor seleccione el socio que desea eliminar.", "Eliminar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DialogResult removeQuestion = MessageBox.Show("¿Desea eliminar toda la información sobre el socio?\nPresione Si para remover toda la información vinculada con este socio.\nPresione No para eliminar solo la información de socio y no la personal.", "Eliminar - Socios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (removeQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.deletePersonalInfo(this.txtMemberID.Text.Trim()))
                        {
                            MessageBox.Show("Toda la información vinculada con este socio ha sido eliminada exitosamente.", "Eliminar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgMembersInfo.Rows.RemoveAt(this.dgMembersInfo.SelectedCells[0].RowIndex);
                            this.connMethods.chargeContributorsInfo(this.dgMembersInfo, this.cmbMemberNames);
                            this.dgMembersInfo.Rows[this.dgMembersInfo.SelectedCells[0].RowIndex].Selected = false;
                            this.dgMembersInfo.Rows[0].Selected = true;
                            this.fillInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar toda la información del socio. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.connMethods.chargeContributorsInfo(this.dgMembersInfo, this.cmbMemberNames);
                            this.fillInputFields();
                        }
                    }
                    else if (removeQuestion == DialogResult.No)
                    {
                        if (this.connMethods.deleteMember(this.txtMemberID.Text.Trim()))
                        {
                            MessageBox.Show("La información de socio vinculada con esta persona ha sido eliminada exitosamente.", "Eliminar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgMembersInfo.Rows.RemoveAt(this.dgMembersInfo.SelectedCells[0].RowIndex);
                            this.connMethods.chargeMembersInfo(this.dgMembersInfo, this.cmbMemberNames);
                            this.dgMembersInfo.Rows[this.dgMembersInfo.SelectedCells[0].RowIndex].Selected = false;
                            this.dgMembersInfo.Rows[0].Selected = true;
                            this.fillInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar la información de socio vinculada a esta persona. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.connMethods.chargeMembersInfo(this.dgMembersInfo, this.cmbMemberNames);
                            this.fillInputFields();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar el socio. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMemberNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.dgMembersInfo.Rows.Count.Equals(1))
            {
                this.dgMembersInfo.Rows[this.dgMembersInfo.SelectedCells[0].RowIndex].Selected = false;
                this.dgMembersInfo.Rows[this.cmbMemberNames.SelectedIndex].Selected = true;
            }
        }

        private void btnQuickSearch_Click(object sender, EventArgs e)
        {
            this.searchMemberByID();
        }

        private void txtSearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.searchMemberByID();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = this.dgMembersInfo.SelectedCells[0].RowIndex;
                this.dgMembersInfo.Rows[selectedRow].Selected = false;
                this.dgMembersInfo.Rows[0].Selected = true;
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
                int selectedRow = this.dgMembersInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgMembersInfo.Rows.Count;

                if (this.dgMembersInfo.Rows[1].Selected)
                {
                    this.dgMembersInfo.Rows[1].Selected = false;
                    this.dgMembersInfo.Rows[0].Selected = true;
                    this.btnFirst.Enabled = false;
                }
                else if (this.dgMembersInfo.Rows[0].Selected)
                {
                    this.dgMembersInfo.Rows[0].Selected = false;
                    this.dgMembersInfo.Rows[totalRows - 2].Selected = true;
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
                else
                {
                    this.dgMembersInfo.Rows[selectedRow].Selected = false;
                    this.dgMembersInfo.Rows[selectedRow - 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnFirst.Enabled = true;
                int selectedRow = this.dgMembersInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgMembersInfo.Rows.Count;

                if (this.dgMembersInfo.Rows[totalRows - 3].Selected)
                {
                    this.dgMembersInfo.Rows[totalRows - 3].Selected = false;
                    this.dgMembersInfo.Rows[totalRows - 2].Selected = true;
                    this.btnLast.Enabled = false;
                }
                else if (this.dgMembersInfo.Rows[totalRows - 2].Selected)
                {
                    this.dgMembersInfo.Rows[totalRows - 2].Selected = false;
                    this.dgMembersInfo.Rows[0].Selected = true;
                    this.btnFirst.Enabled = false;
                    this.btnLast.Enabled = true;
                }
                else
                {
                    this.dgMembersInfo.Rows[selectedRow].Selected = false;
                    this.dgMembersInfo.Rows[selectedRow + 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = this.dgMembersInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgMembersInfo.Rows.Count;

                if (this.dgMembersInfo[0, selectedRow].Value != null)
                {
                    this.dgMembersInfo.Rows[selectedRow].Selected = false;
                    this.dgMembersInfo.Rows[totalRows - 2].Selected = true;
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
            }
            catch (Exception) { }
        }

        private void gbContributors_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
