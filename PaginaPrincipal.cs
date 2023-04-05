using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
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
            //Cargar los usuarios en la pagina principal usando listarUsuario()


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

            //editar usuario


            toggleCampos();

            (new PaginaPrincipal()).Show(); this.Hide(); //recargar paginas
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminar Usuario
            (new PaginaPrincipal()).Show(); this.Hide();

        }

        
    }
}
