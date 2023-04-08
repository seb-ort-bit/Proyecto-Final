using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4
{
    public partial class EditarEliminarProducto : Form
    {
        public static EditarEliminarProducto instance;
        public TextBox txtNombrePublic;
        public TextBox txtMarcaPublic;
        public TextBox txtCategoriaPublic;
        public TextBox txtCantidadPublic;
        public TextBox txtPrecioPublic;

        public string ogNombre;
        public string ogMarca;
        public string ogCategoria;
        public string ogCantidad;
        public string ogPrecio;

        public string deleteCmd = "";
        public string updateCmd = "";

        public EditarEliminarProducto()
        {
            InitializeComponent();
            instance = this;
            txtNombrePublic = txtNombre;
            txtMarcaPublic = txtMarca;
            txtCategoriaPublic = txtCategoria;
            txtCantidadPublic = txtCantidad;
            txtPrecioPublic = txtPrecio;

            ogNombre = txtNombre.Text;
            ogMarca = txtMarca.Text;
            ogCategoria = txtCategoria.Text;
            ogCantidad = txtCantidad.Text;
            ogPrecio = txtPrecio.Text;

        }

        private bool validarProducto()
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

            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            return true;
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

        private void EditarEliminarProducto_Load(object sender, EventArgs e)
        {

        }

        private void EditarEliminarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            (new GestionProductos()).Show(); this.Hide();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarProducto();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            validarProducto();
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            validarProducto();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            validarProducto();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            validarProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarProducto())
            {
                deleteCmd = $@"
             DELETE FROM Productos
             WHERE Nombre = '{ogNombre}' AND Marca = '{ogMarca}';
            ";

                writeSQL(deleteCmd);
                (new GestionProductos()).Show(); this.Hide();
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarProducto())
            {
                updateCmd = $@"
             UPDATE Productos
             SET Nombre = '{txtNombre.Text}', Marca = '{txtMarca.Text}', Categoria = '{txtCategoria.Text}', Precio = {txtPrecio.Text}, Cantidad_Disponible = {txtCantidad.Text}
             WHERE Nombre = '{ogNombre}' AND Marca = '{ogMarca}';
            ";

                writeSQL(updateCmd);
                (new GestionProductos()).Show(); this.Hide();
            }

        }
    }
}
