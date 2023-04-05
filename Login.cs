using System.Data.SqlClient;

namespace Tarea_4
{
    public partial class formLogin : Form
    {
        public formLogin()
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
                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        query.Add(reader.GetValue(0));
                        Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                            reader.GetString(1));
                    }
                }
                reader.Close();
            }
            return query;
        }

        private bool validarLogin()
        {
            var path = Path.Combine(Application.StartupPath, "datos.txt");

            foreach (var txtBox in this.Controls.OfType<TextBox>())
            {

                if (string.IsNullOrWhiteSpace(txtBox.Text))
                {

                    lblWarningLogin.Visible = true;
                    return false;

                }
            }
            if (File.Exists(path))
            {
                return true;
            }
            else 
            {
                lblWarningLogin.Visible = true;
                return false;

            }

        }

        private string[] obtenerUsuario()
        {
            string usuario = txtLoginUsuario.Text + " " + txtLoginContraseña.Text;
            string[] usuarioSplit = usuario.Split(" ");
            return usuarioSplit;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new formRegister()).Show(); this.Hide();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string[] usuarioNuevo = obtenerUsuario();
            bool userExists = false;

            if (validarLogin())
            {
                //Comparar datos introducidos con los disponibles en la base de datos, modificando userExists de acorde al resultado
                string cmd = $@"
                SELECT Nombre 
                FROM Personas
                WHERE Nombre = \'{txtLoginUsuario.Text}\' AND Contraseña = \'{txtLoginContraseña.Text}\'
                ";

                var query = readSQL(cmd);

                if (query.Count != 0) { userExists = true; }

                if (userExists) 
                {
                    (new PaginaPrincipal()).Show(); this.Hide();
                }
                else
                {
                    lblWarningLogin.Visible = true;

                }
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            try
            {
                writeSQL("create database Almacen");
                string initTablas = @"
                create table Personas
                (
                Usuario varchar(30),
                Nombre varchar(20),
                Apellido varchar(29),
                Telefono varchar(10),
                Correo varchar(254),
                Contraseña varchar(20)
                );

                Create Table Productos
                (
                Nombre varchar(50),
                Marca varchar(20),
                Categoria varchar(20),
                Precio int,
                Cantidad_Disponible int
                )";
               writeSQL(initTablas);
            }
            catch { writeSQL("using Almacen"); }
        }

        private void formLogin_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}