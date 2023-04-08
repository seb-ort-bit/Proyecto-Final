﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4
{
    public partial class formRegistroUsuario : Form
    {

        public formRegistroUsuario()
        {
            InitializeComponent();

        }

        private void writeSQL(string cmdText)
        {
            string connectionString = "Data Source=localhost;Integrated Security=SSPI;Initial Catalog=;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {

                sqlConnection.Open();
                sqlConnection.ChangeDatabase("Almacen");
                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        private List<object> readSQL(string cmdText)
        {
            List<object> query = new List<object>();
            string connectionString = "Data Source=localhost;Integrated Security=SSPI;Initial Catalog=;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
                sqlConnection.ChangeDatabase("Almacen");
                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        query.Add(reader.GetValue(0));
                    }
                }
                reader.Close();
            }
            return query;
        }

        private void newPerson()
        {
            string cmd = $@"
             INSERT into Personas VALUES
             ('{txtRegistroUsuario.Text}', '{txtRegistroNombre.Text}', '{txtRegistroApellido.Text}', '{txtTelefono.Text}', '{txtCorreo.Text}', '{txtContraseña.Text}');
            ";
            writeSQL(cmd);
        }


        private bool validarRegistro()
        {
            string camposFaltantes = "";
            //Revisar todos los textbox en el Form actual y verificar si estan vacios o solo tienen espacios.
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {

                if (string.IsNullOrWhiteSpace(txtBox.Text) || txtBox.Text.Contains(" "))
                {

                    camposFaltantes = camposFaltantes + "\n" + (txtBox.Name.Substring(3)).Replace("Registro", "");

                }
                if (txtConfirmar.Text != txtContraseña.Text)
                {
                    lblWarningRegistro.Text = "Las contraseñas son diferentes";
                    lblWarningRegistro.Visible = true;
                    return false;
                }
            }

            if (!(camposFaltantes == ""))
            {
                MessageBox.Show(camposFaltantes, "Los siguientes campos están vacíos o contienen espacios:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private string obtenerUsuario()
        {
            string usuario = txtRegistroNombre.Text + " " + txtRegistroApellido.Text + " " + txtRegistroUsuario.Text + " " + txtCorreo.Text + " " + txtTelefono.Text + " " + txtConfirmar.Text;
            return usuario;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarRegistro() == true)
            {
                //Comprobar si el usuario existe y guardar los datos en la dba y mostrar la pagina principal si no existe

                string usuarioNuevo = obtenerUsuario();
                bool userExists = false;

                string cmd = $@"
                SELECT Nombre
                FROM Personas
                WHERE Nombre = '{txtRegistroNombre}' AND Contraseña = '{txtContraseña.Text}'
                ";
                var query = readSQL(cmd);
                if (query.Count != 0 && query != null) { userExists = true; }

                if (userExists == false) { newPerson(); (new MenuPrincipal()).Show(); this.Hide(); }
                else if (userExists == true) { lblWarningRegistro.Text = "Este usuario ya existe"; lblWarningRegistro.Visible = true; }
            }

        }

        private void linkRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new formLogin()).Show(); this.Hide();
        }

        private void formRegister_Load(object sender, EventArgs e)
        {


        }

        private void formRegister_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtRegistroNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}