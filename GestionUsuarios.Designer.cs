namespace Tarea_4
{
    partial class GestionUsuarios
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

        public void listarUsuario(int position, string nombre, string telefono, string correo)
        {
            int Ypos = 33 + (64 * position);

            GroupBox groupBox = new GroupBox();
            Label lblNombre = new Label();
            Label lblNumber = new Label();
            Label lblMail = new Label();

            groupBox.SuspendLayout();
            SuspendLayout();

            groupBox.Location = new Point(12, Ypos);
            groupBox.Name = "groupBox" + Convert.ToString(position);
            groupBox.Size = new Size(524, 58);
            groupBox.AutoSize = true;
            groupBox.Padding = new Padding(0);
            groupBox.Controls.Add(lblNombre);
            groupBox.Controls.Add(lblNumber);
            groupBox.Controls.Add(lblMail);

            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Location = new Point(17, 19);
            lblNombre.Name = "lblNombre" + Convert.ToString(position);
            lblNombre.Size = new Size(66, 21);
            lblNombre.Text = nombre;

            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            lblNumber.Location = new Point(178, 19);
            lblNumber.Name = "lblNumero" + Convert.ToString(position);
            lblNumber.Size = new Size(100, 21);
            lblNumber.Text = telefono;

            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.TextAlign = ContentAlignment.MiddleCenter;
            lblMail.Location = new Point(390, 19);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(168, 21);
            lblMail.Text = correo;

            Controls.Add(groupBox);

            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            btnCerrarSesion = new Button();
            comEditarUsuario = new ComboBox();
            lblEditarUsuario = new Label();
            txtNombre = new TextBox();
            lblNuevoNombre = new Label();
            label1 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtCorreo = new TextBox();
            btnGuardarCambios = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(29, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.Location = new Point(189, 9);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(77, 21);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Teléfono";
            lblTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.Location = new Point(402, 9);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(61, 21);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo";
            lblCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.IndianRed;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(586, 416);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(138, 35);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Regresar";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // comEditarUsuario
            // 
            comEditarUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            comEditarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comEditarUsuario.FormattingEnabled = true;
            comEditarUsuario.Location = new Point(586, 81);
            comEditarUsuario.Name = "comEditarUsuario";
            comEditarUsuario.Size = new Size(138, 29);
            comEditarUsuario.TabIndex = 5;
            comEditarUsuario.SelectedIndexChanged += comEditarUsuario_SelectedIndexChange;
            // 
            // lblEditarUsuario
            // 
            lblEditarUsuario.AutoSize = true;
            lblEditarUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEditarUsuario.Location = new Point(597, 58);
            lblEditarUsuario.Name = "lblEditarUsuario";
            lblEditarUsuario.Size = new Size(117, 20);
            lblEditarUsuario.TabIndex = 6;
            lblEditarUsuario.Text = "Usuario a Editar:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(586, 144);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 29);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblNuevoNombre
            // 
            lblNuevoNombre.AutoSize = true;
            lblNuevoNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNuevoNombre.Location = new Point(598, 121);
            lblNuevoNombre.Name = "lblNuevoNombre";
            lblNuevoNombre.Size = new Size(114, 20);
            lblNuevoNombre.TabIndex = 8;
            lblNuevoNombre.Text = "Nuevo Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(597, 180);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 10;
            label1.Text = "Nuevo Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(586, 203);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(138, 29);
            txtTelefono.TabIndex = 9;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(603, 240);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 12;
            label2.Text = "Nuevo Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(586, 263);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(138, 29);
            txtCorreo.TabIndex = 11;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Enabled = false;
            btnGuardarCambios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarCambios.Location = new Point(586, 309);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(138, 55);
            btnGuardarCambios.TabIndex = 13;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(586, 377);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 33);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(751, 469);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(lblNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblEditarUsuario);
            Controls.Add(comEditarUsuario);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblCorreo);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GestionUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formGestionUsuarios";
            FormClosing += formPaginaPrincipalClosing;
            Load += formPaginaPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblTelefono;
        private Label lblCorreo;
        private Button btnCerrarSesion;
        private ComboBox comEditarUsuario;
        private Label lblEditarUsuario;
        private TextBox txtNombre;
        private Label lblNuevoNombre;
        private Label label1;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtCorreo;
        private Button btnGuardarCambios;
        private Button btnEliminar;
    }
}