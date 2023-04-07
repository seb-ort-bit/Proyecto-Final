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
    public partial class formRegistroProducto : Form
    {

        public formRegistroProducto()
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

        private void newProduct()
        {
            string cmd = $@"
             INSERT into Productos VALUES
             ('{txtNombre.Text}', '{txtMarca.Text}', '{txtCategoria.Text}', {Convert.ToDouble(txtPrecio.Text)}, {Convert.ToInt32(txtCantidad.Text)});
            ";
            writeSQL(cmd);
        }


        private bool validarRegistro()
        {
            string camposFaltantes = "";
            //Revisar todos los textbox en el Form actual y verificar si estan vacios o solo tienen espacios.
            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {
                bool isValidNumber = double.TryParse(txtPrecio.Text, out _) && int.TryParse(txtCantidad.Text, out _);

                if (string.IsNullOrWhiteSpace(txtBox.Text))
                {

                    camposFaltantes = camposFaltantes + "\n" + txtBox.Name.Substring(3);

                }
                else if ((txtBox.Name == "txtCantidad" || txtBox.Name == "txtPrecio") && !isValidNumber)
                { camposFaltantes = camposFaltantes + "\n" + txtBox.Name.Substring(3); }

            }

            if (!(camposFaltantes == ""))
            {
                MessageBox.Show(camposFaltantes, "Los siguientes campos están vacíos o contienen datos inválidos:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarRegistro() == true)
            {
                //Comprobar si el producto existe y guardar los datos en la dba y mostrar el menu principal si no existe

                bool productExists = false;

                string cmd = $@"
                SELECT Nombre
                FROM Productos
                WHERE Nombre = '{txtNombre.Text}' AND Marca = '{txtMarca.Text}'
                ";
                var query = readSQL(cmd);
                if (query.Count != 0 && query != null) { productExists = true; }

                if (productExists == false) { newProduct(); (new MenuPrincipal()).Show(); this.Hide(); }
                else if (productExists == true) { lblWarningRegistro.Text = "Este producto ya existe"; lblWarningRegistro.Visible = true; }
            }

        }

        private void linkRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new MenuPrincipal()).Show(); this.Hide();
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

        private void txtRegistroApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
