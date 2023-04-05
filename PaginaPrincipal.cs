using System;
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
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        class Persona
        {
            public string Usuario = "";
            public string Nombre = "";
            public string Apellido = "";
            public string Telefono = "";
            public string Correo = "";
            public string Contraseña = "";

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

        private List<Persona> readPersonaSQL(string cmdText)
        {
            List<Persona> query = new List<Persona>();
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
                        var entry = new Persona();
                        entry.Usuario = reader.GetValue(0).ToString();
                        entry.Nombre = reader.GetValue(1).ToString();
                        entry.Apellido = reader.GetValue(2).ToString();
                        entry.Telefono = reader.GetValue(3).ToString();
                        entry.Correo = reader.GetValue(4).ToString();
                        entry.Contraseña = reader.GetValue(5).ToString();
                        query.Add(entry);
                    }
                }
                reader.Close();
            }
            return query;
        }

        private bool validarEdicion()
        {
            //Revisar todos los textbox en el Form actual y verificar si estan vacios o solo tienen espacios.
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {

                if (string.IsNullOrWhiteSpace(txtBox.Text) || txtBox.Text.Contains(" ") || comEditarUsuario.SelectedIndex == -1)
                {

                    return false;

                }
            }

            btnGuardarCambios.Enabled = true;
            return true;
        }

        public void toggleCampos()
        {
            txtCorreo.Enabled = !txtCorreo.Enabled;
            txtNombre.Enabled = !txtNombre.Enabled;
            txtTelefono.Enabled = !txtTelefono.Enabled;
            comEditarUsuario.Enabled = !comEditarUsuario.Enabled;

        }

        private void formPaginaPrincipalClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            (new formLogin()).Show(); this.Hide();
        }

        private void formPaginaPrincipal_Load(object sender, EventArgs e)
        {
            var query = readPersonaSQL("SELECT * FROM Personas;");
            //Cargar los usuarios en la pagina principal usando listarUsuario()
            for (int i = 0; i < query.Count;)
            {
                Persona current = query[i];

                listarUsuario(i, current.Nombre, current.Telefono, current.Correo);
                comEditarUsuario.Items.Add(current.Nombre + " | " + current.Correo);

                i++;
            }

        }

        private void comEditarUsuario_SelectedIndexChange(object sender, EventArgs e)
        {
            validarEdicion();
            btnEliminar.Enabled = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarEdicion();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            validarEdicion();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            validarEdicion();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            toggleCampos();

            var query = readPersonaSQL("SELECT * FROM Personas");

            string cmd = $@"
             UPDATE Personas
             SET Nombre = '{txtNombre.Text}', Telefono = '{txtTelefono.Text}', Correo = '{txtCorreo.Text}'
             WHERE Nombre = '{query[comEditarUsuario.SelectedIndex].Nombre}' AND Telefono = '{query[comEditarUsuario.SelectedIndex].Telefono}' AND Correo = '{query[comEditarUsuario.SelectedIndex].Correo}';
            ";

            writeSQL(cmd);
            toggleCampos();

            (new GestionUsuarios()).Show(); this.Hide(); //recargar paginas
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var query = readPersonaSQL("SELECT * FROM Personas");

            string cmd = $@"
             DELETE FROM Personas
             WHERE Nombre = '{query[comEditarUsuario.SelectedIndex].Nombre}' AND Telefono = '{query[comEditarUsuario.SelectedIndex].Telefono}' AND Correo = '{query[comEditarUsuario.SelectedIndex].Correo}';
            ";

            writeSQL(cmd);
            (new GestionUsuarios()).Show(); this.Hide();

        }


    }
}
