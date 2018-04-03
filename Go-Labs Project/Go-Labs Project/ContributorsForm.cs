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
    public partial class ContributorsForm : Form
    {
        private Methods connMethods = new Methods();

        public ContributorsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para volver todos los TextBoxes a su estado original
        /// </summary>
        private void resetTextFields()
        {
            try
            {
                this.txtContributorID.Text = "Cédula";
                this.txtContributorName.Text = "Nombre";
                this.txtContributorFirstLastName.Text = "Primer Apellido";
                this.txtContributorSecondLastName.Text = "Segundo Apellido";
                this.txtContributorTel.Text = "Teléfono";
                this.txtContributorAddress.Text = "Dirección";
                this.txtContributorEmail.Text = "Correo Electrónico";
                this.cmbContributorLevel.SelectedIndex = 0;
                this.txtContributorSalary.Text = "Salario";
                this.txtContributorVacations.Text = "Cantidad de Vacaciones";
                this.txtContributorServedYears.Text = "Años Laborados";
                this.txtContributorID.ForeColor = this.txtContributorName.ForeColor = this.txtContributorFirstLastName.ForeColor = this.txtContributorSecondLastName.ForeColor = this.txtContributorTel.ForeColor = this.txtContributorAddress.ForeColor = this.txtContributorEmail.ForeColor = this.txtContributorSalary.ForeColor = this.txtContributorVacations.ForeColor = this.txtContributorServedYears.ForeColor = Color.Gray;
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se ha producido un error en la aplicación. Por favor presione Aceptar y reinicie la aplicación", "Error - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para para llenar los TextBoxes con la información correspondiente del DataGrid
        /// </summary>
        private void fillInputFields()
        {
            try
            {
                int selectedRow = this.dgContributorsInfo.SelectedCells[0].RowIndex;

                if (this.dgContributorsInfo[0, selectedRow].Value == null)
                {
                    this.resetTextFields();
                }
                else
                {
                    string fullName = (String)this.dgContributorsInfo[1, selectedRow].Value.ToString().Trim();
                    string[] nameByParts = fullName.Split(' ');
                    if (nameByParts.Length == 3)
                    {
                        this.txtContributorName.Text = nameByParts[0];
                        this.txtContributorFirstLastName.Text = nameByParts[1];
                        this.txtContributorSecondLastName.Text = nameByParts[2];
                    }
                    else
                    {
                        this.txtContributorName.Text = nameByParts[0] + " " + nameByParts[1];
                        this.txtContributorFirstLastName.Text = nameByParts[2];
                        this.txtContributorSecondLastName.Text = nameByParts[3];
                    }
                    this.txtContributorID.Text = (String)this.dgContributorsInfo[0, selectedRow].Value.ToString().Trim();
                    this.txtContributorTel.Text = (String)this.dgContributorsInfo[2, selectedRow].Value.ToString().Trim();
                    this.txtContributorAddress.Text = (String)this.dgContributorsInfo[3, selectedRow].Value.ToString().Trim();
                    this.txtContributorEmail.Text = (String)this.dgContributorsInfo[4, selectedRow].Value.ToString().Trim();
                    this.txtContributorSalary.Text = (String)this.dgContributorsInfo[6, selectedRow].Value.ToString().Trim();
                    this.txtContributorVacations.Text = (String)this.dgContributorsInfo[7, selectedRow].Value.ToString().Trim();
                    this.txtContributorServedYears.Text = (String)this.dgContributorsInfo[8, selectedRow].Value.ToString().Trim();
                    this.txtContributorID.ForeColor = this.txtContributorName.ForeColor = this.txtContributorFirstLastName.ForeColor = this.txtContributorSecondLastName.ForeColor = this.txtContributorTel.ForeColor = this.txtContributorAddress.ForeColor = this.txtContributorEmail.ForeColor = this.txtContributorSalary.ForeColor = this.txtContributorVacations.ForeColor = this.txtContributorServedYears.ForeColor = Color.Black;

                    if ((String)this.dgContributorsInfo[5, selectedRow].Value.ToString().Trim() == "Junior")
                        this.cmbContributorLevel.SelectedIndex = 1;
                    else if ((String)this.dgContributorsInfo[5, selectedRow].Value.ToString().Trim() == "Senior")
                        this.cmbContributorLevel.SelectedIndex = 2;
                    else
                        this.cmbContributorLevel.SelectedIndex = 3;
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Método para buscar los colaboradores por número de identificación
        /// </summary>
        private void searchContributorByID()
        {
            try
            {
                if (this.txtSearchID.Text.Trim() == "Cédula")
                    MessageBox.Show("Por favor ingrese el número de identificación del colaborador que desea buscar.", "Buscar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool found = true;
                    for (int i = 0; i < (this.dgContributorsInfo.Rows.Count) - 1; i++)
                    {
                        if (this.txtSearchID.Text.Trim() == (String)this.dgContributorsInfo[0, i].Value.ToString().Trim())
                        {
                            found = false;
                            int x = this.dgContributorsInfo.SelectedCells[0].RowIndex;
                            this.dgContributorsInfo.Rows[x].Selected = false;
                            this.dgContributorsInfo.Rows[i].Selected = true;
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
                        MessageBox.Show("No se ha encontrado ningún colaborador que coincida con el número de identificación proporcionado.", "Buscar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al buscar el colaborador por su número de indentificación. Por favor revise que el dato proporcionado sea correcto e inténtelo nuevamente.", "Buscar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContributorID_Enter(object sender, EventArgs e)
        {
            if (this.txtContributorID.Text.Trim().Equals("Cédula"))
            {
                this.txtContributorID.Text = "";
                this.txtContributorID.ForeColor = Color.Black;
            }
        }

        private void txtContributorID_Leave(object sender, EventArgs e)
        {
            if (this.txtContributorID.Text.Trim() == "")
            {
                this.txtContributorID.Text = "Cédula";
                this.txtContributorID.ForeColor = Color.Gray;
            }
        }

        private void txtContributorName_Enter(object sender, EventArgs e)
        {
            if (this.txtContributorName.Text.Trim().Equals("Nombre"))
            {
                this.txtContributorName.Text = "";
                this.txtContributorName.ForeColor = Color.Black;
            }
        }

        private void txtContributorName_Leave(object sender, EventArgs e)
        {
            if (this.txtContributorName.Text.Trim() == "")
            {
                this.txtContributorName.Text = "Nombre";
                this.txtContributorName.ForeColor = Color.Gray;
            }
        }

        private void txtContributorFirstLastName_Enter(object sender, EventArgs e)
        {
            if (this.txtContributorFirstLastName.Text.Trim().Equals("Primer Apellido"))
            {
                this.txtContributorFirstLastName.Text = "";
                this.txtContributorFirstLastName.ForeColor = Color.Black;
            }
        }

        private void txtContributorFirstLastName_Leave(object sender, EventArgs e)
        {
            if (this.txtContributorFirstLastName.Text.Trim() == "")
            {
                this.txtContributorFirstLastName.Text = "Primer Apellido";
                this.txtContributorFirstLastName.ForeColor = Color.Gray;
            }
        }

        private void txtContributorSecondLastName_Enter(object sender, EventArgs e)
        {
            if (this.txtContributorSecondLastName.Text.Trim().Equals("Segundo Apellido"))
            {
                this.txtContributorSecondLastName.Text = "";
                this.txtContributorSecondLastName.ForeColor = Color.Black;
            }
        }

        private void txtContributorSecondLastName_Leave(object sender, EventArgs e)
        {
            if (this.txtContributorSecondLastName.Text.Trim() == "")
            {
                this.txtContributorSecondLastName.Text = "Segundo Apellido";
                this.txtContributorSecondLastName.ForeColor = Color.Gray;
            }
        }

        private void txtContributorTel_Enter(object sender, EventArgs e)
        {
            if (this.txtContributorTel.Text.Trim().Equals("Teléfono"))
            {
                this.txtContributorTel.Text = "";
                this.txtContributorTel.ForeColor = Color.Black;
            }
        }

        private void txtContributorTel_Leave(object sender, EventArgs e)
        {
            if (this.txtContributorTel.Text.Trim() == "")
            {
                this.txtContributorTel.Text = "Teléfono";
                this.txtContributorTel.ForeColor = Color.Gray;
            }
        }

        private void txtContributorAddress_Enter(object sender, EventArgs e)
        {
            if (this.txtContributorAddress.Text.Trim().Equals("Dirección"))
            {
                this.txtContributorAddress.Text = "";
                this.txtContributorAddress.ForeColor = Color.Black;
            }
        }

        private void txtContributorAddress_Leave(object sender, EventArgs e)
        {
            if (this.txtContributorAddress.Text.Trim() == "")
            {
                this.txtContributorAddress.Text = "Dirección";
                this.txtContributorAddress.ForeColor = Color.Gray;
            }
        }

        private void txtContributorEmail_Enter(object sender, EventArgs e)
        {
            if (this.txtContributorEmail.Text.Trim().Equals("Correo Electrónico"))
            {
                this.txtContributorEmail.Text = "";
                this.txtContributorEmail.ForeColor = Color.Black;
            }
        }

        private void txtContributorEmail_Leave(object sender, EventArgs e)
        {
            if (this.txtContributorEmail.Text.Trim() == "")
            {
                this.txtContributorEmail.Text = "Correo Electrónico";
                this.txtContributorEmail.ForeColor = Color.Gray;
            }
        }

        private void txtContributorSalary_Enter(object sender, EventArgs e)
        {
            if (this.txtContributorSalary.Text.Trim().Equals("Salario"))
            {
                this.txtContributorSalary.Text = "";
                this.txtContributorSalary.ForeColor = Color.Black;
            }
        }

        private void txtContributorSalary_Leave(object sender, EventArgs e)
        {
            if (this.txtContributorSalary.Text.Trim() == "")
            {
                this.txtContributorSalary.Text = "Salario";
                this.txtContributorSalary.ForeColor = Color.Gray;
            }
        }

        private void txtContributorVacations_Enter(object sender, EventArgs e)
        {
            if (this.txtContributorVacations.Text.Trim().Equals("Cantidad de Vacaciones"))
            {
                this.txtContributorVacations.Text = "";
                this.txtContributorVacations.ForeColor = Color.Black;
            }
        }

        private void txtContributorVacations_Leave(object sender, EventArgs e)
        {
            if (this.txtContributorVacations.Text.Trim() == "")
            {
                this.txtContributorVacations.Text = "Cantidad de Vacaciones";
                this.txtContributorVacations.ForeColor = Color.Gray;
            }
        }

        private void txtContributorServedYears_Enter(object sender, EventArgs e)
        {
            if (this.txtContributorServedYears.Text.Trim().Equals("Años Laborados"))
            {
                this.txtContributorServedYears.Text = "";
                this.txtContributorServedYears.ForeColor = Color.Black;
            }
        }

        private void txtContributorServedYears_Leave(object sender, EventArgs e)
        {
            if (this.txtContributorServedYears.Text.Trim() == "")
            {
                this.txtContributorServedYears.Text = "Años Laborados";
                this.txtContributorServedYears.ForeColor = Color.Gray;
            }
        }

        private void ContributorsForm_Load(object sender, EventArgs e)
        {
            this.connMethods.chargeContributorsInfo(this.dgContributorsInfo, this.cmbContributorNames);
            this.fillInputFields();
            if (this.dgContributorsInfo[0, 0].Value != null)
            {
                this.dgContributorsInfo.Rows[0].Selected = true;
                this.cmbContributorNames.SelectedIndex = 0;
            }
            this.ActiveControl = this.lblPersonalInfo;
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

        private void btnAddContributor_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtContributorID.Text.Trim().Equals("Cédula") || this.txtContributorName.Text.Trim().Equals("Nombre") || this.txtContributorFirstLastName.Text.Trim().Equals("Primer Apellido") || this.txtContributorSecondLastName.Text.Trim().Equals("Segundo Apellido") || this.txtContributorTel.Text.Trim().Equals("Teléfono") || this.txtContributorAddress.Text.Trim().Equals("Dirección") || this.txtContributorEmail.Text.Trim().Equals("Correo Electrónico") || this.cmbContributorLevel.Text.Trim().Equals("Seleccione un nivel") || this.txtContributorSalary.Text.Trim().Equals("Salario") || this.txtContributorVacations.Text.Trim().Equals("Cantidad de Vacaciones") || this.txtContributorServedYears.Text.Trim().Equals("Años Laborados"))
                    MessageBox.Show("Por favor complete todos los espacios para continuar.", "Agregar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (this.connMethods.setPersonalInfo(this.txtContributorID.Text.Trim(), this.txtContributorName.Text.Trim(), this.txtContributorFirstLastName.Text.Trim(), this.txtContributorSecondLastName.Text.Trim(), this.txtContributorTel.Text.Trim(), this.txtContributorAddress.Text.Trim(), this.txtContributorEmail.Text.Trim()))
                    {
                        if (this.connMethods.setContributorsInfo(this.txtContributorID.Text.Trim(), this.cmbContributorLevel.SelectedItem.ToString().Trim(), Convert.ToInt32(this.txtContributorSalary.Text.Trim()), Convert.ToInt32(this.txtContributorVacations.Text.Trim()), Convert.ToInt32(this.txtContributorServedYears.Text.Trim())))
                        {
                            MessageBox.Show("El nuevo colaborador se agregó exitosamente.", "Agregar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.resetTextFields();
                            this.connMethods.chargeContributorsInfo(this.dgContributorsInfo, this.cmbContributorNames);
                            this.dgContributorsInfo.Rows[0].Selected = true;
                            this.fillInputFields();
                        }
                    }
                    else
                    {
                        DialogResult existQuestion = MessageBox.Show("Se encontró una persona ingresada con los mismos datos personales.\n¿Desea agregar los datos de colaborador a la persona?\nPresione Si para agregar los datos y continuar o presione No para descartar los datos ingresados.", "Agregar - Colaborador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (existQuestion == DialogResult.Yes)
                        {
                            if (this.connMethods.setContributorsInfo(this.txtContributorID.Text.Trim(), this.cmbContributorLevel.SelectedItem.ToString().Trim(), Convert.ToInt32(this.txtContributorSalary.Text.Trim()), Convert.ToInt32(this.txtContributorVacations.Text.Trim()), Convert.ToInt32(this.txtContributorServedYears.Text.Trim())))
                            {
                                MessageBox.Show("Los datos han sido vinculados a la persona exitosamente.", "Agregar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.resetTextFields();
                                this.connMethods.chargeContributorsInfo(this.dgContributorsInfo, this.cmbContributorNames);
                                this.dgContributorsInfo.Rows[0].Selected = true;
                                this.fillInputFields();
                            }
                            else
                                MessageBox.Show("Lo sentimos. Se produjo un error al intentar agregar los datos de colaborador. Por favor revise que la información sea correcta o no exista otro colaborador con el mismo número de identificacón.", "Agregar - Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar el nuevo colaborador. Por favor revise que la información sea correcta o no exista otro colaborador con el mismo número de identificacón.", "Agregar - Colaborador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgContributorsInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int totalRows = this.dgContributorsInfo.Rows.Count;
                if (this.dgContributorsInfo.Rows[0].Selected)
                {
                    this.btnFirst.Enabled = false;
                    this.btnLast.Enabled = true;
                }
                if (this.dgContributorsInfo.Rows[totalRows - 2].Selected)
                {
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
                else if (this.dgContributorsInfo.Rows[0].Selected == false && this.dgContributorsInfo.Rows[totalRows - 2].Selected == false)
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

        private void btnModifyContributor_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtContributorID.Text.Trim().Equals("Cédula") || this.txtContributorName.Text.Trim().Equals("Nombre") || this.txtContributorFirstLastName.Text.Trim().Equals("Primer Apellido") || this.txtContributorSecondLastName.Text.Trim().Equals("Segundo Apellido") || this.txtContributorTel.Text.Trim().Equals("Teléfono") || this.txtContributorAddress.Text.Trim().Equals("Dirección") || this.txtContributorEmail.Text.Trim().Equals("Correo Electrónico") || this.cmbContributorLevel.Text.Trim().Equals("Seleccione un nivel") || this.txtContributorSalary.Text.Trim().Equals("Salario") || this.txtContributorVacations.Text.Trim().Equals("Cantidad de Vacaciones") || this.txtContributorServedYears.Text.Trim().Equals("Años Laborados"))
                {
                    MessageBox.Show("Por favor seleccione el colaborador que desea modificar.", "Modificar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.fillInputFields();
                }
                else
                {
                    DialogResult modifyQuestion = MessageBox.Show("¿Seguro que desea modificar los datos del colaborador seleccionado?\nPresione Si para guardar los cambios realizados o presione No para descartar los cambios.", "Modificar - Colaboradores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modifyQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.modifyPersonalInfo(this.txtContributorID.Text.Trim(), this.txtContributorName.Text.Trim(), this.txtContributorFirstLastName.Text.Trim(), this.txtContributorSecondLastName.Text.Trim(), this.txtContributorTel.Text.Trim(), this.txtContributorAddress.Text.Trim(), this.txtContributorEmail.Text.Trim()))
                        {
                            if (this.connMethods.modifyContributorsInfo(this.txtContributorID.Text.Trim(), this.cmbContributorLevel.SelectedItem.ToString().Trim(), Convert.ToInt32(this.txtContributorSalary.Text.Trim()), Convert.ToInt32(this.txtContributorVacations.Text.Trim()), Convert.ToInt32(this.txtContributorServedYears.Text.Trim())))
                            {
                                MessageBox.Show("El colaborador ha sido modificado exitosamente.", "Modificar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.connMethods.chargeContributorsInfo(this.dgContributorsInfo, this.cmbContributorNames);
                                this.fillInputFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar el colaborador seleccionado. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.fillInputFields();
                        }
                    }
                    else
                        this.fillInputFields();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar el colaborador seleccionado. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.fillInputFields();
            }
        }

        private void btnDeleteContributor_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtContributorID.Text.Trim().Equals("Cédula"))
                    MessageBox.Show("Por favor seleccione el colaborador que desea elmininar.", "Eliminar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DialogResult removeQuestion = MessageBox.Show("¿Desea eliminar toda la información sobre el colaborador?\nPresione Si para remover toda la información vinculada con este colaborador.\nPresione No para eliminar solo la información de colaborador y no la personal.", "Eliminar - Colaboradores", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (removeQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.deletePersonalInfo(this.txtContributorID.Text.Trim()))
                        {
                            MessageBox.Show("Toda la información vinculada con este colaborador ha sido eliminada exitosamente.", "Eliminar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgContributorsInfo.Rows.RemoveAt(this.dgContributorsInfo.SelectedCells[0].RowIndex);
                            this.connMethods.chargeContributorsInfo(this.dgContributorsInfo, this.cmbContributorNames);
                            this.dgContributorsInfo.Rows[this.dgContributorsInfo.SelectedCells[0].RowIndex].Selected = false;
                            this.dgContributorsInfo.Rows[0].Selected = true;
                            this.fillInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar toda la información del colaborador. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.connMethods.chargeContributorsInfo(this.dgContributorsInfo, this.cmbContributorNames);
                            this.fillInputFields();
                        }
                    }
                    else if (removeQuestion == DialogResult.No)
                    {
                        if (this.connMethods.deleteContributorInfo(this.txtContributorID.Text.Trim()))
                        {
                            MessageBox.Show("La información de colaborador vinculada con esta persona ha sido eliminada exitosamente.", "Eliminar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgContributorsInfo.Rows.RemoveAt(this.dgContributorsInfo.SelectedCells[0].RowIndex);
                            this.connMethods.chargeContributorsInfo(this.dgContributorsInfo, this.cmbContributorNames);
                            this.dgContributorsInfo.Rows[this.dgContributorsInfo.SelectedCells[0].RowIndex].Selected = false;
                            this.dgContributorsInfo.Rows[0].Selected = true;
                            this.fillInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar la información de colaborador vinculada a esta persona. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.connMethods.chargeContributorsInfo(this.dgContributorsInfo, this.cmbContributorNames);
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

        private void cmbContributorNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.dgContributorsInfo.Rows.Count.Equals(1))
            {
                this.dgContributorsInfo.Rows[this.dgContributorsInfo.SelectedCells[0].RowIndex].Selected = false;
                this.dgContributorsInfo.Rows[this.cmbContributorNames.SelectedIndex].Selected = true;
            }
        }

        private void btnQuickSearch_Click(object sender, EventArgs e)
        {
            this.searchContributorByID();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = this.dgContributorsInfo.SelectedCells[0].RowIndex;
                this.dgContributorsInfo.Rows[selectedRow].Selected = false;
                this.dgContributorsInfo.Rows[0].Selected = true;
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
                int selectedRow = this.dgContributorsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgContributorsInfo.Rows.Count;

                if (this.dgContributorsInfo.Rows[1].Selected)
                {
                    this.dgContributorsInfo.Rows[1].Selected = false;
                    this.dgContributorsInfo.Rows[0].Selected = true;
                    this.btnFirst.Enabled = false;
                }
                else if (this.dgContributorsInfo.Rows[0].Selected)
                {
                    this.dgContributorsInfo.Rows[0].Selected = false;
                    this.dgContributorsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
                else
                {
                    this.dgContributorsInfo.Rows[selectedRow].Selected = false;
                    this.dgContributorsInfo.Rows[selectedRow - 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnFirst.Enabled = true;
                int selectedRow = this.dgContributorsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgContributorsInfo.Rows.Count;

                if (this.dgContributorsInfo.Rows[totalRows - 3].Selected)
                {
                    this.dgContributorsInfo.Rows[totalRows - 3].Selected = false;
                    this.dgContributorsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnLast.Enabled = false;
                }
                else if (this.dgContributorsInfo.Rows[totalRows - 2].Selected)
                {
                    this.dgContributorsInfo.Rows[totalRows - 2].Selected = false;
                    this.dgContributorsInfo.Rows[0].Selected = true;
                    this.btnFirst.Enabled = false;
                    this.btnLast.Enabled = true;
                }
                else
                {
                    this.dgContributorsInfo.Rows[selectedRow].Selected = false;
                    this.dgContributorsInfo.Rows[selectedRow + 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = this.dgContributorsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgContributorsInfo.Rows.Count;

                if (this.dgContributorsInfo[0, selectedRow].Value != null)
                {
                    this.dgContributorsInfo.Rows[selectedRow].Selected = false;
                    this.dgContributorsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
            }
            catch (Exception) { }
        }

        private void txtSearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.searchContributorByID();
        }
    }
}
