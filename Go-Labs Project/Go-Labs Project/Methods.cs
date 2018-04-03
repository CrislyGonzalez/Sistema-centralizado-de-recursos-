using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Go_Labs_Project
{
    class Methods
    {
        /// <summary>
        /// Variables Globales para el uso de la base de datos
        /// </summary>
        DBConnection DBconn = new DBConnection();
        private string query;

        /// <summary>
        /// Método para ingresar la información de persona en la base de datos.
        /// </summary>
        /// <param name="Cédula"></param>
        /// <param name="Nombre"></param>
        /// <param name="Primer Apellido"></param>
        /// <param name="Segundo Apellido"></param>
        /// <param name="Teléfono"></param>
        /// <param name="Dirección"></param>
        /// <param name="Correo Electrónico"></param>
        /// <returns>True si lo ingresó bien, false en caso de que no.</returns>
        public Boolean setPersonalInfo(string conID, string conName, string conFirstLastName, string conSecondLastName, string conTel, string conAddress, string conEmail)
        {
            try
            {
                this.query = "exec insertarPersonas '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'";
                this.query = String.Format(query, conID, conAddress, conEmail, conTel, conName, conFirstLastName, conSecondLastName);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método para ingresar la información laboral del colaborador.
        /// </summary>
        /// <param name="Cédula"></param>
        /// <param name="Nivel"></param>
        /// <param name="Salario"></param>
        /// <param name="Cantidad de Vacaciones"></param>
        /// <param name="Años Laborados"></param>
        /// <returns>true si lo ingresó bien, false en caso de que no.</returns>
        public Boolean setContributorsInfo(string conID, string conLevel, int conSalary, int conVacations, int conServedYears)
        {
            try
            {
                this.query = "exec insertarColaborador '{0}', '{1}', '{2}', '{3}', '{4}'";
                this.query = String.Format(query, conID, conLevel, conSalary, conVacations, conServedYears);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método para modificar la información de persona en la base de datos.
        /// </summary>
        /// <param name="Cédula"></param>
        /// <param name="Nombre"></param>
        /// <param name="Primer Apellido"></param>
        /// <param name="Segundo Apellido"></param>
        /// <param name="Teléfono"></param>
        /// <param name="Dirección"></param>
        /// <param name="Correo Electrónico"></param>
        /// <returns>True si lo modificó bien, false en caso de que no.</returns>
        public Boolean modifyPersonalInfo(string conID, string conName, string conFirstLastName, string conSecondLastName, string conTel, string conAddress, string conEmail)
        {
            try
            {
                this.query = "exec modificarPersona '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'";
                this.query = String.Format(query, conID, conAddress, conEmail, conTel, conName, conFirstLastName, conSecondLastName);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método para modificar la información laboral del colaborador.
        /// </summary>
        /// <param name="Cédula"></param>
        /// <param name="Nivel"></param>
        /// <param name="Salario"></param>
        /// <param name="Cantidad de Vacaciones"></param>
        /// <param name="Años Laborados"></param>
        /// <returns>true si lo modificó bien, false en caso de que no.</returns>
        public Boolean modifyContributorsInfo(string conID, string conLevel, int conSalary, int conVacations, int conServedYears)
        {
            try
            {
                this.query = "exec modificarColaborador '{0}', '{1}', '{2}', '{3}', '{4}'";
                this.query = String.Format(query, conID, conLevel, conSalary, conVacations, conServedYears);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método para eliminar la información personal.
        /// </summary>
        /// <param name="Cédula"></param>
        /// <returns>true si lo eliminó bien, false en caso de que no.</returns>
        public Boolean deletePersonalInfo(string conID)
        {
            try
            {
                this.query = "exec eliminarPersona '{0}'";
                this.query = String.Format(query, conID);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método para eliminar la información laboral de un colaborador.
        /// </summary>
        /// <param name="Cédula"></param>
        /// <returns>true si lo eliminó bien, false en caso de que no.</returns>
        public Boolean deleteContributorInfo(string conID)
        {
            try
            {
                this.query = "exec eliminarColaborador '{0}'";
                this.query = String.Format(query, conID);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Cargar en el DataGridView y en el ComboBox los datos de los colaboradores.
        /// </summary>
        /// <param name="DataGridView"></param>
        /// <param name="ComboBox de Nombres"></param>
        public void chargeContributorsInfo(DataGridView dgClients, ComboBox cmbBSearchByName)
        {
            try
            {
                this.DBconn.extractContributors(dgClients, cmbBSearchByName);
                if (cmbBSearchByName.Items.Count >= 1)
                {
                    cmbBSearchByName.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Método para insertar los socios en la base de datos
        /// </summary>
        /// <param name="Cédula"></param>
        /// <param name="Aportación"></param>
        /// <param name="Porcentaje Accionario"></param>
        /// <returns>true si lo ingresa, false si no</returns>
        public Boolean setMembersInfo(string memberID, int input, decimal percentage) 
        {
            try
            {
                this.query = "exec insertarSocio '{0}', '{1}', '{2}'";
                this.query = String.Format(query, memberID, input, percentage);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método para modificar la información de un socio
        /// </summary>
        /// <param name="Cédula"></param>
        /// <param name="Aportación"></param>
        /// <param name="Porcentaje Accionario"></param>
        /// <returns>true si lo modifica, false si no</returns>
        public Boolean modifyMembersInfo(string memberID, int input, decimal percentage)
        {
            try
            {
                this.query = "exec modificarSocio '{0}', '{1}', '{2}'";
                this.query = String.Format(query, memberID, input, percentage);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método para eliminar un socio
        /// </summary>
        /// <param name="Cédula"></param>
        /// <returns>true si lo elimina, false si no</returns>
        public Boolean deleteMember(string memberID)
        {
            try
            {
                this.query = "exec eliminarSocio '{0}'";
                this.query = String.Format(query, memberID);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método para obtener toda la información de los Socios
        /// </summary>
        /// <param name="DataGridView"></param>
        /// <param name="ComboBox"></param>
        public void chargeMembersInfo(DataGridView dgClients, ComboBox cmbBSearchByName)
        {
            try
            {
                this.DBconn.extractMembers(dgClients, cmbBSearchByName);
                if (cmbBSearchByName.Items.Count >= 1)
                {
                    cmbBSearchByName.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {

            }
        }

        public Boolean setClientInfo(int clientID, string clientName, string clientCountry, string clientOcupation, string clientWebSite)
        {
            try
            {
                this.query = "exec insertarCliente '{0}', '{1}', '{2}', '{3}', '{4}'";
                this.query = String.Format(query, clientID, clientName, clientCountry, clientOcupation, clientWebSite);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean setContactInfo(string fullName, int clientID, string contactPosition, string contactEmail)
        {
            try
            {
                this.query = "exec insertarContacto '{0}', '{1}', '{2}', '{3}'";
                this.query = String.Format(query, fullName, clientID, contactPosition, contactEmail);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean modifyClientInfo(int clientID, string clientName, string clientCountry, string clientOcupation, string clientWebSite)
        {
            try
            {
                this.query = "exec modificarCliente '{0}', '{1}', '{2}', '{3}', '{4}'";
                this.query = String.Format(query, clientID, clientName, clientCountry, clientOcupation, clientWebSite);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean modifyContactInfo(string fullName, int clientID, string contactPosition, string contactEmail)
        {
            try
            {
                this.query = "exec modificarContacto '{0}', '{1}', '{2}', '{3}'";
                this.query = String.Format(query, fullName, clientID, contactPosition, contactEmail);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean deleteClient(int clientID)
        {
            try
            {
                this.query = "exec eliminarCliente '{0}'";
                this.query = String.Format(query, clientID);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void chargeClientsInfo(DataGridView dgClients, ComboBox cmbBSearchByName)
        {
            try
            {
                this.DBconn.extractClients(dgClients, cmbBSearchByName);
                if (cmbBSearchByName.Items.Count >= 1)
                {
                    cmbBSearchByName.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {

            }
        }

        public Boolean setTechnologyInfo(int techID, string techName)
        {
            try
            {
                this.query = "exec insertarTecnologia '{0}', '{1}'";
                this.query = String.Format(query, techID, techName);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean modifyTechnologyInfo(int techID, string techName)
        {
            try
            {
                this.query = "exec modificarTecnologia '{0}', '{1}'";
                this.query = String.Format(query, techID, techName);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean deleteTechnologyInfo(int techID)
        {
            try
            {
                this.query = "exec eliminarTecnologia '{0}'";
                this.query = String.Format(query, techID);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void chargeTechnologiesInfo(DataGridView dgTecnologies)
        {
            try
            {
                this.DBconn.extractTechnologies(dgTecnologies);
            }
            catch (Exception)
            {

            }
        }

        public Boolean setProjects(int projectID, string client, string projectName, string projectObservations, string dateBegin, string dateExpected, string dateFinish)
        {
            try
            {
                this.query = "exec insertarProyecto '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'";
                this.query = String.Format(query, projectID, client, projectName, projectObservations, dateBegin, dateExpected, dateFinish);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean modifyProjects(int projectID, string client, string projectName, string projectObservations, string dateBegin, string dateExpected, string dateFinish)
        {
            try
            {
                this.query = "exec modificarProyecto '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'";
                this.query = String.Format(query, projectID, client, projectName, projectObservations, dateBegin, dateExpected, dateFinish);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean deleteProjects(int projectID)
        {
            try
            {
                this.query = "exec eliminarProyecto '{0}'";
                this.query = String.Format(query, projectID);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void chargeClientNames(ComboBox cmbClients)
        {
            try
            {
                this.DBconn.extractClientNames(cmbClients);
            }
            catch (Exception) { }
        }

        public void chargeProjectsInfo(DataGridView dgProjectsInfo, ComboBox cmbClientsNames)
        {
            try
            {
                this.DBconn.extractProjects(dgProjectsInfo, cmbClientsNames);
            }
            catch (Exception)
            {

            }
        }

        public void chargeProjectObservations(TextBox txtObservations, int projectID)
        {
            try
            {
                this.DBconn.extractProjectObservation(txtObservations, projectID);
            }
            catch (Exception)
            {

            }
        }

        public Boolean setVacationsInfo(string conName, int vacID, int timeOut, string date)
        {
            try
            {
                this.query = "exec insertarVacaciones '{0}', '{1}', '{2}', '{3}'";
                this.query = String.Format(query, conName, vacID, timeOut, date);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean modifyVacationsInfo(string conName, int vacID, int timeOut, string date)
        {
            try
            {
                this.query = "exec modificarVacaciones '{0}', '{1}', '{2}', '{3}'";
                this.query = String.Format(query, conName, vacID, timeOut, date);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean deleteVacationsInfo(int vacID)
        {
            try
            {
                this.query = "exec eliminarVacaciones '{0}'";
                this.query = String.Format(query, vacID);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void chargeVacationsInfo(DataGridView dgVacationsInfo)
        {
            try
            {
                this.DBconn.extractVacationsInfo(dgVacationsInfo);
            }
            catch (Exception) { }
        }

        public void chargeContributorNames(ComboBox cmbContributors)
        {
            try
            {
                this.DBconn.extractContributorNames(cmbContributors);
            }
            catch (Exception) { }
        }

        public Boolean setInputTypes(int ID, string name)
        {
            try
            {
                this.query = "exec insertarTipoIngreso '{0}', '{1}'";
                this.query = String.Format(query, ID, name);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean modifyInputTypes(int ID, string name)
        {
            try
            {
                this.query = "exec modificarTipoIngreso '{0}', '{1}'";
                this.query = String.Format(query, ID, name);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean deleteInputTypes(int ID)
        {
            try
            {
                this.query = "exec eliminarTipoIngreso '{0}'";
                this.query = String.Format(query, ID);
                if (DBconn.functions(query))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void chargeInputTypes(DataGridView dgInputTypes)
        {
            try
            {
                this.DBconn.extractInputTypes(dgInputTypes);
            }
            catch (Exception) { }
        }
    }
}
