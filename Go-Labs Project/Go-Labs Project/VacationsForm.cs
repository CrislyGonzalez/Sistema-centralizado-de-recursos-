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
    public partial class VacationsForm : Form
    {

        Methods connMethods = new Methods();

        public VacationsForm()
        {
            InitializeComponent();
        }

        private void searchVacationsByID()
        {
            try
            {
                if (this.txtSearchID.Text.Trim() == "ID de Vacaciones")
                    MessageBox.Show("Por favor ingrese el número de identificación de las vacaciones que desea buscar.", "Buscar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool found = true;
                    for (int i = 0; i < (this.dgVacationsInfo.Rows.Count) - 1; i++)
                    {
                        if (this.txtSearchID.Text.Trim() == (String)this.dgVacationsInfo[0, i].Value.ToString().Trim())
                        {
                            found = false;
                            int x = this.dgVacationsInfo.SelectedCells[0].RowIndex;
                            this.dgVacationsInfo.Rows[x].Selected = false;
                            this.dgVacationsInfo.Rows[i].Selected = true;
                            this.txtSearchID.Text = "ID de Vacaciones";
                            this.txtSearchID.ForeColor = Color.Gray;
                            this.txtSearchID.Enabled = false;
                            this.txtSearchID.Enabled = true;
                            this.fillInputFields();
                            break;
                        }
                    }

                    if (found)
                    {
                        MessageBox.Show("No se ha encontrado ningún dato que coincida con el número de ID proporcionado.", "Buscar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al buscar las vacaciones por su ID. Por favor revise que el dato proporcionado sea correcto e inténtelo nuevamente.", "Buscar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetTextFields()
        {
            try
            {
                this.txtVacationID.Text = "ID de Vacaciones";
                this.cmbContributorsNames.SelectedIndex = 0;
                this.txtTimeOut.Text = "Cantidad de Tiempo Fuera";
                this.dtpVacationsDate.Value = DateTime.Today;
                this.txtVacationID.ForeColor = this.txtTimeOut.ForeColor = Color.Gray;
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se ha producido un error en la aplicación. Por favor presione Aceptar y reinicie la aplicación", "Error - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillInputFields()
        {
            try
            {
                int selectedRow = this.dgVacationsInfo.SelectedCells[0].RowIndex;

                if (this.dgVacationsInfo[0, selectedRow].Value == null)
                {
                    this.resetTextFields();
                }
                else
                {
                    this.txtVacationID.Text = (String)this.dgVacationsInfo[0, selectedRow].Value.ToString().Trim();
                    this.cmbContributorsNames.Text = (String)this.dgVacationsInfo[1, selectedRow].Value.ToString().Trim();
                    this.txtTimeOut.Text = (String)this.dgVacationsInfo[2, selectedRow].Value.ToString().Trim();
                    this.dtpVacationsDate.Text = (String)this.dgVacationsInfo[3, selectedRow].Value.ToString().Trim();
                    this.txtVacationID.ForeColor = this.txtTimeOut.ForeColor = Color.Black;
                }
            }
            catch (Exception) { }
        }

        private void txtVacationsID_Enter(object sender, EventArgs e)
        {
            if (this.txtVacationID.Text.Trim().Equals("ID de Vacaciones"))
            {
                this.txtVacationID.Text = "";
                this.txtVacationID.ForeColor = Color.Black;
            }
        }

        private void txtVacationsID_Leave(object sender, EventArgs e)
        {
            if (this.txtVacationID.Text.Trim() == "")
            {
                this.txtVacationID.Text = "ID de Vacaciones";
                this.txtVacationID.ForeColor = Color.Gray;
            }
        }

        private void txtTimeOut_Enter(object sender, EventArgs e)
        {
            if (this.txtTimeOut.Text.Trim().Equals("Cantidad de Tiempo Fuera"))
            {
                this.txtTimeOut.Text = "";
                this.txtTimeOut.ForeColor = Color.Black;
            }
        }

        private void txtTimeOut_Leave(object sender, EventArgs e)
        {
            if (this.txtTimeOut.Text.Trim() == "")
            {
                this.txtTimeOut.Text = "Cantidad de Tiempo Fuera";
                this.txtTimeOut.ForeColor = Color.Gray;
            }
        }

        private void txtSearchID_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchID.Text.Trim().Equals("ID de Vacaciones"))
            {
                this.txtSearchID.Text = "";
                this.txtSearchID.ForeColor = Color.Black;
            }
        }

        private void txtSearchID_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchID.Text.Trim() == "")
            {
                this.txtSearchID.Text = "ID de Vacaciones";
                this.txtSearchID.ForeColor = Color.Gray;
            }
        }

        private void VacationsForm_Load(object sender, EventArgs e)
        {
            this.connMethods.chargeContributorNames(this.cmbContributorsNames);
            this.cmbContributorsNames.SelectedIndex = 0;

            this.connMethods.chargeVacationsInfo(this.dgVacationsInfo);
            this.fillInputFields();
            if (this.dgVacationsInfo[0, 0].Value != null)
            {
                this.dgVacationsInfo.Rows[0].Selected = true;
                //this.cmbClientNames.SelectedIndex = 0;
            }
            this.ActiveControl = this.lblPersonalInfo;
        }

        private void btnAddVacation_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtVacationID.Text.Trim().Equals("ID de Vacaciones") || this.cmbContributorsNames.SelectedItem.ToString().Trim().Equals("Seleccione un colaborador") || this.txtTimeOut.Text.Trim().Equals("Cantidad de Tiempo Fuera"))
                    MessageBox.Show("Por favor complete todos los espacios para continuar.", "Agregar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (this.connMethods.setVacationsInfo(this.cmbContributorsNames.SelectedItem.ToString().Trim(), Convert.ToInt32(this.txtVacationID.Text.Trim()), Convert.ToInt32(this.txtTimeOut.Text.Trim()), this.dtpVacationsDate.Value.ToString("D")))
                    {
                        MessageBox.Show("Las nuevas vacaciones se han agregado exitosamente.", "Agregar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.resetTextFields();
                        this.connMethods.chargeVacationsInfo(this.dgVacationsInfo);
                        this.dgVacationsInfo.Rows[0].Selected = true;
                        this.fillInputFields();
                    }
                    else
                        MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar las vacaciones. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Agregar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar las vacaciones. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Agregar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgVacationsInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int totalRows = this.dgVacationsInfo.Rows.Count;
                if (this.dgVacationsInfo.Rows[0].Selected)
                {
                    this.btnFirst.Enabled = false;
                    this.btnLast.Enabled = true;
                }
                if (this.dgVacationsInfo.Rows[totalRows - 2].Selected)
                {
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
                else if (this.dgVacationsInfo.Rows[0].Selected == false && this.dgVacationsInfo.Rows[totalRows - 2].Selected == false)
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

        private void btnModifyVacation_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtVacationID.Text.Trim().Equals("ID de Vacaciones") || this.cmbContributorsNames.SelectedItem.ToString().Trim().Equals("Seleccione un colaborador") || this.txtTimeOut.Text.Trim().Equals("Cantidad de Tiempo Fuera"))
                {
                    MessageBox.Show("Por favor seleccione las vacaciones que desea modificar.", "Modificar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.fillInputFields();
                }
                else
                {
                    DialogResult modifyQuestion = MessageBox.Show("¿Seguro que desea modificar las vacaciones seleccionadas?\nPresione Si para guardar los cambios realizados o presione No para descartar los cambios.", "Modificar - Vacaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modifyQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.modifyVacationsInfo(this.cmbContributorsNames.SelectedItem.ToString().Trim(), Convert.ToInt32(this.txtVacationID.Text.Trim()), Convert.ToInt32(this.txtTimeOut.Text.Trim()), this.dtpVacationsDate.Value.ToString("D")))
                        {
                            MessageBox.Show("Las vacaciones ha sido modificadas exitosamente.", "Modificar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.connMethods.chargeVacationsInfo(this.dgVacationsInfo);
                            this.fillInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar las vacaciones seleccionadas. Por favor revise que la información sea correcta o que no esté intentando modificar el ID de las vacaciones.", "Modificar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.fillInputFields();
                        }
                    }
                    else
                        this.fillInputFields();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar las vacaciones seleccionadas. Por favor revise que la información sea correcta o que no esté intentando modificar el ID de las vacaciones.", "Modificar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.fillInputFields();
            }
        }

        private void btnDeleteVacation_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtVacationID.Text.Trim().Equals("ID de Vacaciones"))
                    MessageBox.Show("Por favor seleccione las vacaciones que desea elmininar.", "Eliminar - Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DialogResult removeQuestion = MessageBox.Show("¿Seguro que desea eliminar las vacaciones seleccionadas?\nPresione Si para remover toda la información.\nPresione No para mantener la información.", "Eliminar - Vacaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (removeQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.deleteVacationsInfo(Convert.ToInt32(this.txtVacationID.Text.Trim())))
                        {
                            MessageBox.Show("Las vacaciones seleccionadas han sido eliminadas exitosamente.", "Eliminar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgVacationsInfo.Rows.RemoveAt(this.dgVacationsInfo.SelectedCells[0].RowIndex);
                            this.connMethods.chargeVacationsInfo(this.dgVacationsInfo);
                            this.dgVacationsInfo.Rows[this.dgVacationsInfo.SelectedCells[0].RowIndex].Selected = false;
                            this.dgVacationsInfo.Rows[0].Selected = true;
                            this.fillInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar las vacaciones. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.connMethods.chargeVacationsInfo(this.dgVacationsInfo);
                            this.fillInputFields();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar las vacaciones. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuickSearch_Click(object sender, EventArgs e)
        {
            this.searchVacationsByID();
        }

        private void txtSearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.searchVacationsByID();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = this.dgVacationsInfo.SelectedCells[0].RowIndex;
                this.dgVacationsInfo.Rows[selectedRow].Selected = false;
                this.dgVacationsInfo.Rows[0].Selected = true;
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
                int selectedRow = this.dgVacationsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgVacationsInfo.Rows.Count;

                if (this.dgVacationsInfo.Rows[1].Selected)
                {
                    this.dgVacationsInfo.Rows[1].Selected = false;
                    this.dgVacationsInfo.Rows[0].Selected = true;
                    this.btnFirst.Enabled = false;
                }
                else if (this.dgVacationsInfo.Rows[0].Selected)
                {
                    this.dgVacationsInfo.Rows[0].Selected = false;
                    this.dgVacationsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
                else
                {
                    this.dgVacationsInfo.Rows[selectedRow].Selected = false;
                    this.dgVacationsInfo.Rows[selectedRow - 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnFirst.Enabled = true;
                int selectedRow = this.dgVacationsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgVacationsInfo.Rows.Count;

                if (this.dgVacationsInfo.Rows[totalRows - 3].Selected)
                {
                    this.dgVacationsInfo.Rows[totalRows - 3].Selected = false;
                    this.dgVacationsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnLast.Enabled = false;
                }
                else if (this.dgVacationsInfo.Rows[totalRows - 2].Selected)
                {
                    this.dgVacationsInfo.Rows[totalRows - 2].Selected = false;
                    this.dgVacationsInfo.Rows[0].Selected = true;
                    this.btnFirst.Enabled = false;
                    this.btnLast.Enabled = true;
                }
                else
                {
                    this.dgVacationsInfo.Rows[selectedRow].Selected = false;
                    this.dgVacationsInfo.Rows[selectedRow + 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = this.dgVacationsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgVacationsInfo.Rows.Count;

                if (this.dgVacationsInfo[0, selectedRow].Value != null)
                {
                    this.dgVacationsInfo.Rows[selectedRow].Selected = false;
                    this.dgVacationsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
            }
            catch (Exception) { }
        }
    }
}
