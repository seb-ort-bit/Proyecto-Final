namespace Tarea_4
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGestionarUsuarios = new Button();
            btnGestionarProductos = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // btnGestionarUsuarios
            // 
            btnGestionarUsuarios.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionarUsuarios.Location = new Point(12, 12);
            btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            btnGestionarUsuarios.Size = new Size(227, 255);
            btnGestionarUsuarios.TabIndex = 0;
            btnGestionarUsuarios.Text = "Gestionar Usuarios";
            btnGestionarUsuarios.UseVisualStyleBackColor = true;
            btnGestionarUsuarios.Click += btnGestionarUsuarios_Click;
            // 
            // btnGestionarProductos
            // 
            btnGestionarProductos.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionarProductos.Location = new Point(262, 12);
            btnGestionarProductos.Name = "btnGestionarProductos";
            btnGestionarProductos.Size = new Size(227, 255);
            btnGestionarProductos.TabIndex = 1;
            btnGestionarProductos.Text = "Gestionar Productos";
            btnGestionarProductos.UseVisualStyleBackColor = true;
            btnGestionarProductos.Click += btnGestionarProductos_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.IndianRed;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(175, 292);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(138, 35);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 339);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnGestionarProductos);
            Controls.Add(btnGestionarUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionarUsuarios;
        private Button btnGestionarProductos;
        private Button btnCerrarSesion;
    }
}