using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            (new formLogin()).Show(); this.Hide();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            (new GestionUsuarios()).Show(); this.Hide();
        }
    }
}