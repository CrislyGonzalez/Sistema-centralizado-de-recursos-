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
    public partial class ProjectsForm : Form
    {

        Methods connMethods = new Methods();

        public ProjectsForm()
        {
            InitializeComponent();
        }

        private void searchClientByID()
        {
            try
            {
                if (this.txtSearchID.Text.Trim() == "ID de Proyecto")
                    MessageBox.Show("Por favor ingrese el número de identificación del proyecto que desea buscar.", "Buscar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool found = true;
                    for (int i = 0; i < (this.dgProjectsInfo.Rows.Count) - 1; i++)
                    {
                        if (this.txtSearchID.Text.Trim() == (String)this.dgProjectsInfo[0, i].Value.ToString().Trim())
                        {
                            found = false;
                            int x = this.dgProjectsInfo.SelectedCells[0].RowIndex;
                            this.dgProjectsInfo.Rows[x].Selected = false;
                            this.dgProjectsInfo.Rows[i].Selected = true;
                            this.txtSearchID.Text = "ID de Proyecto";
                            this.txtSearchID.ForeColor = Color.Gray;
                            this.txtSearchID.Enabled = false;
                            this.txtSearchID.Enabled = true;
                            this.fillInputFieldsProject();
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

        private void resetTextFieldsTech()
        {
            try
            {
                this.txtTechnologyID.Text = "Número de Identificación";
                this.txtTechnologyName.Text = "Nombre";
                this.txtTechnologyID.ForeColor = this.txtTechnologyName.ForeColor = Color.Gray;
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se ha producido un error en la aplicación. Por favor presione Aceptar y reinicie la aplicación", "Error - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillInputFieldsTech()
        {
            try
            {
                int selectedRow = this.dgTechnologiesInfo.SelectedCells[0].RowIndex;

                if (this.dgTechnologiesInfo[0, selectedRow].Value == null)
                {
                    this.resetTextFieldsTech();
                }
                else
                {
                    this.txtTechnologyID.Text = (String)this.dgTechnologiesInfo[0, selectedRow].Value.ToString().Trim();
                    this.txtTechnologyName.Text = (String)this.dgTechnologiesInfo[1, selectedRow].Value.ToString().Trim();
                    this.txtTechnologyID.ForeColor = this.txtTechnologyName.ForeColor = Color.Black;
                }
            }
            catch (Exception) { }
        }

        private void txtTechnologyID_Enter(object sender, EventArgs e)
        {
            if (this.txtTechnologyID.Text.Trim().Equals("Número de Identificación"))
            {
                this.txtTechnologyID.Text = "";
                this.txtTechnologyID.ForeColor = Color.Black;
            }
        }

        private void txtTechnologyID_Leave(object sender, EventArgs e)
        {
            if (this.txtTechnologyID.Text.Trim() == "")
            {
                this.txtTechnologyID.Text = "Número de Identificación";
                this.txtTechnologyID.ForeColor = Color.Gray;
            }
        }

        private void txtTechnologyName_Enter(object sender, EventArgs e)
        {
            if (this.txtTechnologyName.Text.Trim().Equals("Nombre"))
            {
                this.txtTechnologyName.Text = "";
                this.txtTechnologyName.ForeColor = Color.Black;
            }
        }

        private void txtTechnologyName_Leave(object sender, EventArgs e)
        {
            if (this.txtTechnologyName.Text.Trim() == "")
            {
                this.txtTechnologyName.Text = "Nombre";
                this.txtTechnologyName.ForeColor = Color.Gray;
            }
        }

        private void resetTextFieldsProject()
        {
            try
            {
                this.txtProjectID.Text = "ID de Proyecto";
                this.txtProjectName.Text = "Nombre";
                this.cmbClients.SelectedIndex = 0;
                this.txtProjectObservations.Text = "Observaciones";
                this.dtpBegin.Value = DateTime.Today;
                this.dtpFinish.Value = DateTime.Today;
                this.dtpExpected.Value = DateTime.Today;
                this.txtProjectID.ForeColor = this.txtProjectName.ForeColor = this.txtProjectObservations.ForeColor = Color.Gray;
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se ha producido un error en la aplicación. Por favor presione Aceptar y reinicie la aplicación", "Error - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillInputFieldsProject()
        {
            try
            {
                int selectedRow = this.dgProjectsInfo.SelectedCells[0].RowIndex;

                if (this.dgProjectsInfo[0, selectedRow].Value == null)
                {
                    this.resetTextFieldsProject();
                }
                else
                {
                    this.txtProjectID.Text = (String)this.dgProjectsInfo[0, selectedRow].Value.ToString().Trim();
                    this.txtProjectName.Text = (String)this.dgProjectsInfo[1, selectedRow].Value.ToString().Trim();
                    this.connMethods.chargeProjectObservations(this.txtProjectObservations, Convert.ToInt32(this.txtProjectID.Text.Trim()));
                    this.cmbClients.Text = (String)this.dgProjectsInfo[2, selectedRow].Value.ToString().Trim();
                    this.dtpBegin.Text = (String)this.dgProjectsInfo[3, selectedRow].Value.ToString().Trim();
                    this.dtpExpected.Text = (String)this.dgProjectsInfo[4, selectedRow].Value.ToString().Trim();
                    this.dtpFinish.Text = (String)this.dgProjectsInfo[5, selectedRow].Value.ToString().Trim();
                    this.txtProjectID.ForeColor = this.txtProjectName.ForeColor = this.txtProjectObservations.ForeColor = Color.Black;
                }
            }
            catch (Exception) { }
        }

        private void txtProjectID_Enter(object sender, EventArgs e)
        {
            if (this.txtProjectID.Text.Trim().Equals("ID de Proyecto"))
            {
                this.txtProjectID.Text = "";
                this.txtProjectID.ForeColor = Color.Black;
            }
        }

        private void txtProjectID_Leave(object sender, EventArgs e)
        {
            if (this.txtProjectID.Text.Trim() == "")
            {
                this.txtProjectID.Text = "ID de Proyecto";
                this.txtProjectID.ForeColor = Color.Gray;
            }
        }

        private void txtProjectName_Enter(object sender, EventArgs e)
        {
            if (this.txtProjectName.Text.Trim().Equals("Nombre"))
            {
                this.txtProjectName.Text = "";
                this.txtProjectName.ForeColor = Color.Black;
            }
        }

        private void txtProjectName_Leave(object sender, EventArgs e)
        {
            if (this.txtProjectName.Text.Trim() == "")
            {
                this.txtProjectName.Text = "Nombre";
                this.txtProjectName.ForeColor = Color.Gray;
            }
        }

        private void txtProjectObservations_Enter(object sender, EventArgs e)
        {
            if (this.txtProjectObservations.Text.Trim().Equals("Observaciones"))
            {
                this.txtProjectObservations.Text = "";
                this.txtProjectObservations.ForeColor = Color.Black;
            }
        }

        private void txtProjectObservations_Leave(object sender, EventArgs e)
        {
            if (this.txtProjectObservations.Text.Trim() == "")
            {
                this.txtProjectObservations.Text = "Observaciones";
                this.txtProjectObservations.ForeColor = Color.Gray;
            }
        }

        private void txtSearchID_Enter(object sender, EventArgs e)
        {
            if (this.txtSearchID.Text.Trim().Equals("ID de Proyecto"))
            {
                this.txtSearchID.Text = "";
                this.txtSearchID.ForeColor = Color.Black;
            }
        }

        private void txtSearchID_Leave(object sender, EventArgs e)
        {
            if (this.txtSearchID.Text.Trim() == "")
            {
                this.txtSearchID.Text = "ID de Proyecto";
                this.txtSearchID.ForeColor = Color.Gray;
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtProjectID.Text.Trim().Equals("ID de Proyecto") || this.txtProjectName.Text.Trim().Equals("Nombre") || this.cmbClients.SelectedItem.ToString().Trim().Equals("Seleccione un cliente") || this.txtProjectObservations.Text.Trim().Equals("Observaciones"))
                    MessageBox.Show("Por favor complete todos los espacios para continuar.", "Agregar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (this.connMethods.setProjects(Convert.ToInt32(this.txtProjectID.Text.Trim()), this.cmbClients.SelectedItem.ToString().Trim(), this.txtProjectName.Text.Trim(), this.txtProjectObservations.Text.Trim(), this.dtpBegin.Value.ToString("D"), this.dtpFinish.Value.ToString("D"), this.dtpExpected.Value.ToString("D")))
                    {
                        MessageBox.Show("El nuevo proyecto se agregó exitosamente.", "Agregar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.resetTextFieldsProject();
                        this.connMethods.chargeProjectsInfo(this.dgProjectsInfo, this.cmbClientNames);
                        this.dgProjectsInfo.Rows[0].Selected = true;
                        this.fillInputFieldsProject();
                    }
                    else
                        MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar el proyecto. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Agregar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar el proyecto. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Agregar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            this.connMethods.chargeClientNames(this.cmbClients);
            this.cmbClients.SelectedIndex = 0;
            this.connMethods.chargeProjectsInfo(this.dgProjectsInfo, this.cmbClientNames);
            this.fillInputFieldsProject();
            this.connMethods.chargeTechnologiesInfo(this.dgTechnologiesInfo);
            this.fillInputFieldsTech();
            if (this.dgProjectsInfo[0, 0].Value != null)
            {
                this.dgProjectsInfo.Rows[0].Selected = true;
                this.cmbClientNames.SelectedIndex = 0;
            }
        }

        private void btnAddTechnolgy_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTechnologyID.Text.Trim().Equals("Número de Identificación") || this.txtTechnologyName.Text.Trim().Equals("Nombre"))
                    MessageBox.Show("Por favor complete todos los espacios para continuar.", "Agregar - Tecnologías", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (this.connMethods.setTechnologyInfo(Convert.ToInt32(this.txtTechnologyID.Text.Trim()), this.txtTechnologyName.Text.Trim()))
                    {
                        MessageBox.Show("La nueva tecnología se agregó exitosamente.", "Agregar - Tecnologías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.resetTextFieldsTech();
                        this.connMethods.chargeTechnologiesInfo(this.dgTechnologiesInfo);
                        this.dgTechnologiesInfo.Rows[0].Selected = true;
                        this.fillInputFieldsTech();
                    }
                    else
                        MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar la tecnología. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Agregar - Tecnologías", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar la tecnología. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Agregar - Tecnologías", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifyTechnology_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTechnologyID.Text.Trim().Equals("Número de Identificación") || this.txtTechnologyName.Text.Trim().Equals("Nombre"))
                {
                    MessageBox.Show("Por favor seleccione la tecnología que desea modificar.", "Modificar - Technologías", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.fillInputFieldsTech();
                }
                else
                {
                    DialogResult modifyQuestion = MessageBox.Show("¿Seguro que desea modificar los datos de la tecnología seleccionada?\nPresione Si para guardar los cambios realizados o presione No para descartar los cambios.", "Modificar - Tecnologías", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modifyQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.modifyTechnologyInfo(Convert.ToInt32(this.txtTechnologyID.Text.Trim()), this.txtTechnologyName.Text.Trim()))
                        {
                            MessageBox.Show("La tecnología ha sido modificada exitosamente.", "Modificar - Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.connMethods.chargeTechnologiesInfo(this.dgTechnologiesInfo);
                            this.fillInputFieldsTech();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar la tecnología seleccionada. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Tecnologías", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.fillInputFieldsTech();
                        }
                    }
                    else
                        this.fillInputFieldsTech();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar la tecnología seleccionada. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Tecnologías", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.fillInputFieldsTech();
            }
        }

        private void btnDeleteTechnology_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTechnologyID.Text.Trim().Equals("Número de Identificación"))
                    MessageBox.Show("Por favor seleccione la tecnología que desea elmininar.", "Eliminar - Tecnologías", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DialogResult removeQuestion = MessageBox.Show("¿Seguro que desea eliminar la tecnología seleccionada?\nPresione Si para eliminar la tecnología.\nPresione No para mantener la información.", "Eliminar - Tecnologías", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (removeQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.deleteTechnologyInfo(Convert.ToInt32(this.txtTechnologyID.Text.Trim())))
                        {
                            MessageBox.Show("La tecnología se ha eliminado exitosamente..", "Eliminar - Tecnologías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgTechnologiesInfo.Rows.RemoveAt(this.dgTechnologiesInfo.SelectedCells[0].RowIndex);
                            this.connMethods.chargeTechnologiesInfo(this.dgTechnologiesInfo);
                            this.dgTechnologiesInfo.Rows[this.dgTechnologiesInfo.SelectedCells[0].RowIndex].Selected = false;
                            this.dgTechnologiesInfo.Rows[0].Selected = true;
                            this.fillInputFieldsTech();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar la tecnología. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Tecnologías", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.connMethods.chargeTechnologiesInfo(this.dgTechnologiesInfo);
                            this.fillInputFieldsTech();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar la tecnología. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Tecnologías", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgTechnologiesInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.fillInputFieldsTech();
            }
            catch (Exception) { }
        }

        private void dgProjectsInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int totalRows = this.dgProjectsInfo.Rows.Count;
                if (this.dgProjectsInfo.Rows[0].Selected)
                {
                    this.btnFirst.Enabled = false;
                    this.btnLast.Enabled = true;
                }
                if (this.dgProjectsInfo.Rows[totalRows - 2].Selected)
                {
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
                else if (this.dgProjectsInfo.Rows[0].Selected == false && this.dgProjectsInfo.Rows[totalRows - 2].Selected == false)
                {
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = true;
                }
                this.fillInputFieldsProject();
            }
            catch (Exception)
            {

            }
        }

        private void btnModifyProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtProjectID.Text.Trim().Equals("ID de Proyecto") || this.txtProjectName.Text.Trim().Equals("Nombre") || this.cmbClients.SelectedItem.ToString().Trim().Equals("Seleccione un cliente") || this.txtProjectObservations.Text.Trim().Equals("Observaciones"))
                {
                    MessageBox.Show("Por favor seleccione el proyecto que desea modificar.", "Modificar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.fillInputFieldsProject();
                }
                else
                {
                    DialogResult modifyQuestion = MessageBox.Show("¿Seguro que desea modificar los datos del proyecto seleccionado?\nPresione Si para guardar los cambios realizados o presione No para descartar los cambios.", "Modificar - Proyectos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modifyQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.modifyProjects(Convert.ToInt32(this.txtProjectID.Text.Trim()), this.cmbClients.SelectedItem.ToString().Trim(), this.txtProjectName.Text.Trim(), this.txtProjectObservations.Text.Trim(), this.dtpBegin.Value.ToString("D"), this.dtpFinish.Value.ToString("D"), this.dtpExpected.Value.ToString("D")))
                        {
                            MessageBox.Show("El proyecto ha sido modificado exitosamente.", "Modificar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.connMethods.chargeProjectsInfo(this.dgProjectsInfo, this.cmbClientNames);
                            this.fillInputFieldsProject();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar el proyecto seleccionado. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.fillInputFieldsProject();
                        }
                    }
                    else
                        this.fillInputFieldsProject();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar el proyecto seleccionado. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.fillInputFieldsProject();
            }
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtProjectID.Text.Trim().Equals("ID de Proyecto"))
                    MessageBox.Show("Por favor seleccione el proyecto que desea elmininar.", "Eliminar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DialogResult removeQuestion = MessageBox.Show("¿Seguro que desea eliminar el proyecto seleccionado?\nPresione Si para remover toda la información del proyecto.\nPresione No para mantener la información.", "Eliminar - Proyectos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (removeQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.deleteProjects(Convert.ToInt32(this.txtProjectID.Text.Trim())))
                        {
                            MessageBox.Show("El proyecto ha sido eliminado exitosamente.", "Eliminar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgProjectsInfo.Rows.RemoveAt(this.dgProjectsInfo.SelectedCells[0].RowIndex);
                            this.connMethods.chargeProjectsInfo(this.dgProjectsInfo, this.cmbClientNames);
                            this.dgProjectsInfo.Rows[this.dgProjectsInfo.SelectedCells[0].RowIndex].Selected = false;
                            this.dgProjectsInfo.Rows[0].Selected = true;
                            this.fillInputFieldsProject();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar el proyecto. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.connMethods.chargeContributorsInfo(this.dgProjectsInfo, this.cmbClientNames);
                            this.fillInputFieldsProject();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar el proyecto. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Proyectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbClientNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.dgProjectsInfo.Rows.Count.Equals(1))
            {
                this.dgProjectsInfo.Rows[this.dgProjectsInfo.SelectedCells[0].RowIndex].Selected = false;
                this.dgProjectsInfo.Rows[this.cmbClientNames.SelectedIndex].Selected = true;
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
                int selectedRow = this.dgProjectsInfo.SelectedCells[0].RowIndex;
                this.dgProjectsInfo.Rows[selectedRow].Selected = false;
                this.dgProjectsInfo.Rows[0].Selected = true;
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
                int selectedRow = this.dgProjectsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgProjectsInfo.Rows.Count;

                if (this.dgProjectsInfo.Rows[1].Selected)
                {
                    this.dgProjectsInfo.Rows[1].Selected = false;
                    this.dgProjectsInfo.Rows[0].Selected = true;
                    this.btnFirst.Enabled = false;
                }
                else if (this.dgProjectsInfo.Rows[0].Selected)
                {
                    this.dgProjectsInfo.Rows[0].Selected = false;
                    this.dgProjectsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
                else
                {
                    this.dgProjectsInfo.Rows[selectedRow].Selected = false;
                    this.dgProjectsInfo.Rows[selectedRow - 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnFirst.Enabled = true;
                int selectedRow = this.dgProjectsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgProjectsInfo.Rows.Count;

                if (this.dgProjectsInfo.Rows[totalRows - 3].Selected)
                {
                    this.dgProjectsInfo.Rows[totalRows - 3].Selected = false;
                    this.dgProjectsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnLast.Enabled = false;
                }
                else if (this.dgProjectsInfo.Rows[totalRows - 2].Selected)
                {
                    this.dgProjectsInfo.Rows[totalRows - 2].Selected = false;
                    this.dgProjectsInfo.Rows[0].Selected = true;
                    this.btnFirst.Enabled = false;
                    this.btnLast.Enabled = true;
                }
                else
                {
                    this.dgProjectsInfo.Rows[selectedRow].Selected = false;
                    this.dgProjectsInfo.Rows[selectedRow + 1].Selected = true;
                }
            }
            catch (Exception) { }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = this.dgProjectsInfo.SelectedCells[0].RowIndex;
                int totalRows = this.dgProjectsInfo.Rows.Count;

                if (this.dgProjectsInfo[0, selectedRow].Value != null)
                {
                    this.dgProjectsInfo.Rows[selectedRow].Selected = false;
                    this.dgProjectsInfo.Rows[totalRows - 2].Selected = true;
                    this.btnFirst.Enabled = true;
                    this.btnLast.Enabled = false;
                }
            }
            catch (Exception) { }
        }
    }
}
