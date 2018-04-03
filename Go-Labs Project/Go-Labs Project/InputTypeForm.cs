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
    public partial class InputTypeForm : Form
    {

        Methods connMethods = new Methods();

        public InputTypeForm()
        {
            InitializeComponent();
        }

        private void resetTextFields()
        {
            try
            {
                this.txtInputTypeID.Text = "Número de Identificación";
                this.txtInputTypeName.Text = "Nombre";
                this.txtInputTypeID.ForeColor = this.txtInputTypeName.ForeColor = Color.Gray;
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se ha producido un error en la aplicación. Por favor presione Aceptar y reinicie la aplicación", "Error - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillInputFields()
        {
            try
            {
                int selectedRow = this.dgInputTypesInfo.SelectedCells[0].RowIndex;

                if (this.dgInputTypesInfo[0, selectedRow].Value == null)
                {
                    this.resetTextFields();
                }
                else
                {
                    this.txtInputTypeID.Text = (String)this.dgInputTypesInfo[0, selectedRow].Value.ToString().Trim();
                    this.txtInputTypeName.Text = (String)this.dgInputTypesInfo[1, selectedRow].Value.ToString().Trim();
                    this.txtInputTypeID.ForeColor = this.txtInputTypeName.ForeColor = Color.Black;
                }
            }
            catch (Exception) { }
        }

        private void txtInputTypeID_Enter(object sender, EventArgs e)
        {
            if (this.txtInputTypeID.Text.Trim().Equals("Número de Identificación"))
            {
                this.txtInputTypeID.Text = "";
                this.txtInputTypeID.ForeColor = Color.Black;
            }
        }

        private void txtInputTypeID_Leave(object sender, EventArgs e)
        {
            if (this.txtInputTypeID.Text.Trim() == "")
            {
                this.txtInputTypeID.Text = "Número de Identificación";
                this.txtInputTypeID.ForeColor = Color.Gray;
            }
        }

        private void txtInputTypeName_Enter(object sender, EventArgs e)
        {
            if (this.txtInputTypeName.Text.Trim().Equals("Nombre"))
            {
                this.txtInputTypeName.Text = "";
                this.txtInputTypeName.ForeColor = Color.Black;
            }
        }

        private void txtInputTypeName_Leave(object sender, EventArgs e)
        {
            if (this.txtInputTypeName.Text.Trim() == "")
            {
                this.txtInputTypeName.Text = "Nombre";
                this.txtInputTypeName.ForeColor = Color.Gray;
            }
        }

        private void btnAddInputType_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtInputTypeID.Text.Trim().Equals("Número de Identificación") || this.txtInputTypeName.Text.Trim().Equals("Nombre"))
                    MessageBox.Show("Por favor complete todos los espacios para continuar.", "Agregar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (this.connMethods.setInputTypes(Convert.ToInt32(this.txtInputTypeID.Text.Trim()), this.txtInputTypeName.Text.Trim()))
                    {
                        MessageBox.Show("El nuevo tipo de ingreso se agregó exitosamente.", "Agregar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.resetTextFields();
                        this.connMethods.chargeInputTypes(this.dgInputTypesInfo);
                        this.dgInputTypesInfo.Rows[0].Selected = true;
                        this.fillInputFields();
                    }
                    else
                        MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar el tipo de ingreso. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Agregar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar insertar el tipo de ingreso. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Agregar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifyInputType_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtInputTypeID.Text.Trim().Equals("Número de Identificación") || this.txtInputTypeName.Text.Trim().Equals("Nombre"))
                {
                    MessageBox.Show("Por favor seleccione el tipo de ingreso que desea modificar.", "Modificar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.fillInputFields();
                }
                else
                {
                    DialogResult modifyQuestion = MessageBox.Show("¿Seguro que desea modificar los datos del tipo de ingreso seleccionado?\nPresione Si para guardar los cambios realizados o presione No para descartar los cambios.", "Modificar - Tipos de Ingresos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (modifyQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.modifyInputTypes(Convert.ToInt32(this.txtInputTypeID.Text.Trim()), this.txtInputTypeName.Text.Trim()))
                        {
                            MessageBox.Show("El tipo de ingreso ha sido modificada exitosamente.", "Modificar - Tipo de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.connMethods.chargeInputTypes(this.dgInputTypesInfo);
                            this.fillInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar el tipo de ingreso seleccionado. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.fillInputFields();
                        }
                    }
                    else
                        this.fillInputFields();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Se produjo un error al intentar modificar el tipo de ingreso seleccionado. Por favor revise que la información sea correcta o que no esté intentando modificar el número de identificación.", "Modificar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.fillInputFields();
            }
        }

        private void btnDeleteInputType_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtInputTypeID.Text.Trim().Equals("Número de Identificación"))
                    MessageBox.Show("Por favor seleccione el tipo de ingreso que desea elmininar.", "Eliminar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    DialogResult removeQuestion = MessageBox.Show("¿Seguro que desea eliminar el tipo de ingreso seleccionado?\nPresione Si para eliminar el tipo de ingreso.\nPresione No para mantener la información.", "Eliminar - Tipos de Ingresos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (removeQuestion == DialogResult.Yes)
                    {
                        if (this.connMethods.deleteInputTypes(Convert.ToInt32(this.txtInputTypeID.Text.Trim())))
                        {
                            MessageBox.Show("El tipo de ingreso se eliminó exitosamente.", "Eliminar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.dgInputTypesInfo.Rows.RemoveAt(this.dgInputTypesInfo.SelectedCells[0].RowIndex);
                            this.connMethods.chargeInputTypes(this.dgInputTypesInfo);
                            this.dgInputTypesInfo.Rows[this.dgInputTypesInfo.SelectedCells[0].RowIndex].Selected = false;
                            this.dgInputTypesInfo.Rows[0].Selected = true;
                            this.fillInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar el tipo de ingreso seleccionado. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.connMethods.chargeInputTypes(this.dgInputTypesInfo);
                            this.fillInputFields();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos. Ha ocurrido un error al intentar eliminar el tipo de ingreso seleccionado. Por favor revise que la información sea correcta e inténtelo nuevamente.", "Eliminar - Tipos de Ingresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgInputTypesInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.fillInputFields();
            }
            catch (Exception) { }
        }

        private void InputTypeForm_Load(object sender, EventArgs e)
        {
            this.connMethods.chargeInputTypes(this.dgInputTypesInfo);
            this.fillInputFields();
            this.ActiveControl = this.gbInputTypeContainer;
        }
    }
}
