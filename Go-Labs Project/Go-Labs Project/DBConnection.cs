using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Go_Labs_Project
{
    class DBConnection
    {
        /// <summary>
        /// Variables de conexión a la base de datos.
        /// </summary>
        private SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder();
        private SqlConnection DBconn;
        public List<String> list;
        private SqlCommand command;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public DBConnection()
        {
            this.connStringBuilder.InitialCatalog = "GoLabs";
            this.connStringBuilder.IntegratedSecurity = true;
        }

        /// <summary>
        /// Método para llevar a cabo la ejecución de los querys.
        /// </summary>
        public Boolean functions(string query)
        {
            try
            {
                using (this.DBconn = new SqlConnection(connStringBuilder.ConnectionString))
                {
                    command = new SqlCommand(query, DBconn);
                    this.DBconn.Open();
                    command.ExecuteNonQuery();
                    this.DBconn.Close();
                    this.DBconn.Dispose();
                    return true;
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
                return false;
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }

        /// <summary>
        /// Método para extraer la información de los colaboradores.
        /// </summary>
        /// <param name="DataGridView a llenar"></param>
        /// <param name="ComboBox a llenar"></param>
        public void extractContributors(DataGridView dgContributors, ComboBox cmbNames)
        {
            try
            {
                using (this.DBconn = new SqlConnection(this.connStringBuilder.ConnectionString))
                using (this.command = new SqlCommand("Select p.*, c.* from Persona as p join Colaborador as c on p.cedula = c.cedula", this.DBconn))
                {
                    this.list = new List<string>();
                    this.DBconn.Open();
                    this.command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            this.list.Add(String.Format("{0}", reader[i]).Trim());
                        }
                    }
                    reader.Close();
                    this.DBconn.Close();
                    this.DBconn.Dispose();

                    int x = 0;
                    cmbNames.Items.Clear();
                    for (int i = 0; i < this.list.Count; i = i + 12)
                    {
                        if (dgContributors[0, x].Value == null)
                            dgContributors.Rows.Add(1);
                        dgContributors[0, x].Value = this.list[i];
                        dgContributors[1, x].Value = this.list[i + 4] + " " + this.list[i + 5] + " " + this.list[i + 6];
                        dgContributors[2, x].Value = this.list[i + 3];
                        dgContributors[3, x].Value = this.list[i + 1];
                        dgContributors[4, x].Value = this.list[i + 2];
                        dgContributors[5, x].Value = this.list[i + 8];
                        dgContributors[6, x].Value = Math.Truncate(Convert.ToSingle(this.list[i + 9]));
                        dgContributors[7, x].Value = this.list[i + 10];
                        dgContributors[8, x].Value = this.list[i + 11];
                        cmbNames.Items.Add(dgContributors[1, x].Value);
                        x++;
                    }
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }

        /// <summary>
        /// Método para extraer toda la información de los socios
        /// </summary>
        /// <param name="DataGridView"></param>
        /// <param name="ComboBox"></param>
        public void extractMembers(DataGridView dgMembers, ComboBox cmbNames)
        {
            try
            {
                using (this.DBconn = new SqlConnection(this.connStringBuilder.ConnectionString))
                using (this.command = new SqlCommand("Select p.*, s.* from Persona as p join Socio as s on p.cedula = s.cedula", this.DBconn))
                {
                    this.list = new List<string>();
                    this.DBconn.Open();
                    this.command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            this.list.Add(String.Format("{0}", reader[i]).Trim());
                        }
                    }
                    reader.Close();
                    this.DBconn.Close();
                    this.DBconn.Dispose();

                    int x = 0;
                    cmbNames.Items.Clear();
                    for (int i = 0; i < this.list.Count; i = i + 10)
                    {
                        if (dgMembers[0, x].Value == null)
                            dgMembers.Rows.Add(1);
                        dgMembers[0, x].Value = this.list[i];
                        dgMembers[1, x].Value = this.list[i + 4] + " " + this.list[i + 5] + " " + this.list[i + 6];
                        dgMembers[2, x].Value = this.list[i + 3];
                        dgMembers[3, x].Value = this.list[i + 1];
                        dgMembers[4, x].Value = this.list[i + 2];
                        dgMembers[5, x].Value = Math.Truncate(Convert.ToSingle(this.list[i + 8]));
                        dgMembers[6, x].Value = Convert.ToDecimal(this.list[i + 9]);
                        cmbNames.Items.Add(dgMembers[1, x].Value);
                        x++;
                    }
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }

        public void extractClients(DataGridView dgClients, ComboBox cmbNames)
        {
            try
            {
                using (this.DBconn = new SqlConnection(this.connStringBuilder.ConnectionString))
                using (this.command = new SqlCommand("Select cl.*, c.* from Cliente as cl join Contacto as c on cl.IDcliente = c.IDcliente", this.DBconn))
                {
                    this.list = new List<string>();
                    this.DBconn.Open();
                    this.command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            this.list.Add(String.Format("{0}", reader[i]).Trim());
                        }
                    }
                    reader.Close();
                    this.DBconn.Close();
                    this.DBconn.Dispose();

                    int x = 0;
                    cmbNames.Items.Clear();
                    for (int i = 0; i < this.list.Count; i = i + 9)
                    {
                        if (dgClients[0, x].Value == null)
                            dgClients.Rows.Add(1);
                        dgClients[0, x].Value = this.list[i];
                        dgClients[1, x].Value = this.list[i + 1];   
                        dgClients[2, x].Value = this.list[i + 2];
                        dgClients[3, x].Value = this.list[i + 3];
                        dgClients[4, x].Value = this.list[i + 4];
                        dgClients[5, x].Value = this.list[i + 5];
                        dgClients[6, x].Value = this.list[i + 7];
                        dgClients[7, x].Value = this.list[i + 8];
                        cmbNames.Items.Add(dgClients[1, x].Value);
                        x++;
                    }
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }

        public void extractTechnologies(DataGridView dgTechnologies)
        {
            try
            {
                using (this.DBconn = new SqlConnection(this.connStringBuilder.ConnectionString))
                using (this.command = new SqlCommand("Select * from Tecnologia", this.DBconn))
                {
                    this.list = new List<string>();
                    this.DBconn.Open();
                    this.command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            this.list.Add(String.Format("{0}", reader[i]).Trim());
                        }
                    }
                    reader.Close();
                    this.DBconn.Close();
                    this.DBconn.Dispose();

                    int x = 0;
                    for (int i = 0; i < this.list.Count; i = i + 2)
                    {
                        if (dgTechnologies[0, x].Value == null)
                            dgTechnologies.Rows.Add(1);
                        dgTechnologies[0, x].Value = this.list[i];
                        dgTechnologies[1, x].Value = this.list[i + 1];
                        x++;
                    }
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }

        public void extractProjects(DataGridView dgProjects, ComboBox cmbProjectNames)
        {
            try
            {
                using (this.DBconn = new SqlConnection(this.connStringBuilder.ConnectionString))
                using (this.command = new SqlCommand("Select * from Proyecto", this.DBconn))
                {
                    this.list = new List<string>();
                    this.DBconn.Open();
                    this.command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            this.list.Add(String.Format("{0}", reader[i]).Trim());
                        }
                    }
                    reader.Close();
                    this.DBconn.Close();
                    this.DBconn.Dispose();

                    int x = 0;
                    cmbProjectNames.Items.Clear();
                    for (int i = 0; i < this.list.Count; i = i + 7)
                    {
                        if (dgProjects[0, x].Value == null)
                            dgProjects.Rows.Add(1);
                        dgProjects[0, x].Value = this.list[i];
                        dgProjects[1, x].Value = this.list[i + 2];
                        dgProjects[2, x].Value = this.list[i + 1];
                        dgProjects[3, x].Value = this.list[i + 4];
                        dgProjects[4, x].Value = this.list[i + 6];
                        dgProjects[5, x].Value = this.list[i + 5];
                        cmbProjectNames.Items.Add(dgProjects[1, x].Value);
                        x++;
                    }
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }

        public void extractClientNames(ComboBox cmbClientsNames)
        {
            try
            {
                using (this.DBconn = new SqlConnection(this.connStringBuilder.ConnectionString))
                using (this.command = new SqlCommand("Select nombre from Cliente", this.DBconn))
                {
                    this.list = new List<string>();
                    this.DBconn.Open();
                    this.command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            this.list.Add(String.Format("{0}", reader[i]).Trim());
                        }
                    }
                    reader.Close();
                    this.DBconn.Close();
                    this.DBconn.Dispose();

                    cmbClientsNames.Items.Clear();
                    cmbClientsNames.Items.Add("Seleccione un cliente");
                    for (int i = 0; i < this.list.Count; i++)
                    {
                        cmbClientsNames.Items.Add(this.list[i]);
                    }
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }

        public void extractContributorNames(ComboBox cmbContributorsNames)
        {
            try
            {
                using (this.DBconn = new SqlConnection(this.connStringBuilder.ConnectionString))
                using (this.command = new SqlCommand("Select p.nombre, p.apellido1, p.apellido2 from Persona as p join Colaborador as c on p.cedula = c.cedula", this.DBconn))
                {
                    this.list = new List<string>();
                    this.DBconn.Open();
                    this.command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            this.list.Add(String.Format("{0}", reader[i]).Trim());
                        }
                    }
                    reader.Close();
                    this.DBconn.Close();
                    this.DBconn.Dispose();

                    cmbContributorsNames.Items.Clear();
                    cmbContributorsNames.Items.Add("Seleccione un colaborador");
                    for (int i = 0; i < this.list.Count; i += 3)
                    {
                        cmbContributorsNames.Items.Add(this.list[i] + " " + this.list[1] + " " + this.list[2]);
                    }
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }

        public void extractProjectObservation(TextBox txtObservation, int projectID)
        {
            try
            {
                using (this.DBconn = new SqlConnection(this.connStringBuilder.ConnectionString))
                using (this.command = new SqlCommand("Select observaciones from Proyecto where IDproyecto = '" + projectID + "'", this.DBconn))
                {
                    this.list = new List<string>();
                    this.DBconn.Open();
                    this.command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            this.list.Add(String.Format("{0}", reader[i]).Trim());
                        }
                    }
                    reader.Close();
                    this.DBconn.Close();
                    this.DBconn.Dispose();

                    txtObservation.Text = this.list[0];
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }

        public void extractVacationsInfo(DataGridView dgVacations)
        {
            try
            {
                using (this.DBconn = new SqlConnection(this.connStringBuilder.ConnectionString))
                using (this.command = new SqlCommand("Select * from Vacaciones", this.DBconn))
                {
                    this.list = new List<string>();
                    this.DBconn.Open();
                    this.command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            this.list.Add(String.Format("{0}", reader[i]).Trim());
                        }
                    }
                    reader.Close();
                    this.DBconn.Close();
                    this.DBconn.Dispose();

                    int x = 0;
                    for (int i = 0; i < this.list.Count; i = i + 4)
                    {
                        if (dgVacations[0, x].Value == null)
                            dgVacations.Rows.Add(1);
                        dgVacations[0, x].Value = this.list[i + 1];
                        dgVacations[1, x].Value = this.list[i];
                        dgVacations[2, x].Value = this.list[i + 2];
                        dgVacations[3, x].Value = this.list[i + 3];
                        x++;
                    }
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }

        public void extractInputTypes(DataGridView dgInputTypes)
        {
            try
            {
                using (this.DBconn = new SqlConnection(this.connStringBuilder.ConnectionString))
                using (this.command = new SqlCommand("Select * from tipoIngreso", this.DBconn))
                {
                    this.list = new List<string>();
                    this.DBconn.Open();
                    this.command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            this.list.Add(String.Format("{0}", reader[i]).Trim());
                        }
                    }
                    reader.Close();
                    this.DBconn.Close();
                    this.DBconn.Dispose();

                    int x = 0;
                    for (int i = 0; i < this.list.Count; i = i + 2)
                    {
                        if (dgInputTypes[0, x].Value == null)
                            dgInputTypes.Rows.Add(1);
                        dgInputTypes[0, x].Value = this.list[i];
                        dgInputTypes[1, x].Value = this.list[i + 1];
                        x++;
                    }
                }
            }
            catch (Exception)
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
            finally
            {
                this.DBconn.Close();
                this.DBconn.Dispose();
            }
        }
    }
}
