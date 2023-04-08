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
    public partial class GestionProductos : Form
    {
        public GestionProductos()
        {
            InitializeComponent();
        }

        class Producto
        {
            public string Nombre = "";
            public string Marca = "";
            public string Categoria = "";
            public int Cantidad = 0;
            public double Precio = 0;
        }


        private List<Producto> readProductoSQL(string cmdText)
        {
            List<Producto> query = new List<Producto>();
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
                        var entry = new Producto();
                        entry.Nombre = reader.GetValue(0).ToString();
                        entry.Marca = reader.GetValue(1).ToString();
                        entry.Categoria = reader.GetValue(2).ToString();
                        entry.Precio = Convert.ToDouble(reader.GetValue(3));
                        entry.Cantidad = Convert.ToInt32(reader.GetValue(4));
                        

                        query.Add(entry);
                    }
                }
                reader.Close();
            }
            return query;
        }



        private void comEditarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            var query = readProductoSQL("SELECT * FROM Productos;");
            //Cargar los usuarios en la pagina principal usando listarUsuario()
            for (int i = 0; i < query.Count;)
            {
                Producto current = query[i];

                listarProducto(i, current.Nombre, current.Marca, current.Categoria, current.Cantidad.ToString(), current.Precio.ToString());

                i++;
            }
        }

        private void GestionProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            (new MenuPrincipal()).Show(); this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new formRegistroProducto()).Show(); this.Hide();
        }
    }
}
