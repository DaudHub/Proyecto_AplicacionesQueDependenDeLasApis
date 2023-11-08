﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cargar : UserControl
    {
        public Cargar()
        {
            InitializeComponent();
            UpdateTable();
        }

        Dictionary<string, string> atributosCamion = new Dictionary<string, string>()
        {
            {"matrícula", "matricula"},
            {"modelo", "modelo"},
            {"capacidad(Kg)", "capacidadkg"},
            {"capacidad(m3)", "capacidadm3"}
        };

        private async void pnlCrearCamion_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $@"insert into proyecto.camion
                                            values ('{txtMatricula.Text}',
                                                (select idmodelo from proyecto.modelo where nombre='{cbxModelo.SelectedItem.ToString()}'),
                                                {txtCapacidadCamion.Text},
                                                {txtVolumenCamion.Text})";
                    await command.ExecuteNonQueryAsync();
                    UpdateTable();
                    MessageBox.Show("Camión creado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar crear el camión" + ex.ToString());
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblCrearCamion_Click(object sender, EventArgs e)
        {
            pnlCrearCamion_Click(sender, e);
        }

        private async void pnlAplicarCamion_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    string format;
                    if (new string[] {"capacidad(Kg)", "capacidad(m3)"}.Contains<string>(cbxAtributoCamion.SelectedItem.ToString()))
                        format = $"{txtActualizacionCamion.Text}";
                    else
                        format = $"'{txtActualizacionCamion.Text}'";
                    command.CommandText = $@"update proyecto.camion set {atributosCamion[cbxAtributoCamion.SelectedItem.ToString()]}={format} where matricula='{cbxModificarCamion.SelectedItem.ToString()}'";
                    await command.ExecuteNonQueryAsync();
                    UpdateTable();
                    MessageBox.Show("Camión modificado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar modificar el camión");
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblAplicarCamion_Click(object sender, EventArgs e)
        {
            pnlAplicarCamion_Click(sender, e);
        }

        private async void cbxModificarCamion_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $"select matricula from proyecto.camion";
                    var reader = await command.ExecuteReaderAsync();
                    cbxModificarCamion.Items.Clear();
                    while (reader.Read())
                    {
                        cbxModificarCamion.Items.Add(reader.GetString(0));
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private async void pnlEliminarCamion_Click(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    if (cbxEliminarCamion.SelectedItem.ToString() != txtConfirmarCamion.Text)
                    {
                        MessageBox.Show("Error de confirmación");
                        return;
                    }
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $"delete from proyecto.camion where matricula='{cbxEliminarCamion.SelectedItem.ToString()}'";
                    await command.ExecuteNonQueryAsync();
                    UpdateTable();
                    MessageBox.Show("Camion eliminado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar el camión" + ex.ToString());
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private void lblEliminarCamion_Click(object sender, EventArgs e)
        {
            pnlEliminarCamion_Click(sender, e);
        }

        private async void cbxEliminarCamion_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $"select matricula from proyecto.camion";
                    var reader = await command.ExecuteReaderAsync();
                    cbxEliminarCamion.Items.Clear();
                    while (reader.Read())
                        cbxEliminarCamion.Items.Add(reader.GetString(0));
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private async void UpdateTable()
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $"select matricula, nombre, capacidadkg, capacidadm3 from proyecto.camion inner join proyecto.modelo on camion.modelo=modelo.idmodelo";
                    var reader = await command.ExecuteReaderAsync();
                    tblCamiones.Rows.Clear();
                    while (reader.Read())
                    {
                        tblCamiones.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetInt32(3).ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }

        private async void cbxModelo_DropDown(object sender, EventArgs e)
        {
            using (var db_conn = new MySqlConnection("Host=127.0.0.1;User=root;Password=porfavorentrar"))
            {
                try
                {
                    await db_conn.OpenAsync();
                    var command = new MySqlCommand(null, db_conn);
                    command.CommandText = $"select nombre from proyecto.modelo";
                    var reader = await command.ExecuteReaderAsync();
                    cbxModelo.Items.Clear();
                    while (reader.Read())
                    {
                        cbxModelo.Items.Add(reader.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    await db_conn.CloseAsync();
                }
            }
        }
    }
}
