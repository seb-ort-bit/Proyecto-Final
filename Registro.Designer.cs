namespace Tarea_4
{
    partial class formRegister
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
            lblConstraseña = new Label();
            lblUsuario = new Label();
            linkRegistrate = new LinkLabel();
            lblCuenta = new Label();
            btnRegistrar = new Button();
            lblLogin = new Label();
            txtRegistroApellido = new TextBox();
            txtRegistroNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtContraseña = new TextBox();
            txtRegistroUsuario = new TextBox();
            lblWarningRegistro = new Label();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblConfirmar = new Label();
            txtConfirmar = new TextBox();
            SuspendLayout();
            // 
            // lblConstraseña
            // 
            lblConstraseña.AutoSize = true;
            lblConstraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblConstraseña.Location = new Point(44, 122);
            lblConstraseña.Name = "lblConstraseña";
            lblConstraseña.Size = new Size(58, 19);
            lblConstraseña.TabIndex = 15;
            lblConstraseña.Text = "Apellido";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(44, 60);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 19);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "Nombre";
            // 
            // linkRegistrate
            // 
            linkRegistrate.AutoSize = true;
            linkRegistrate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkRegistrate.Location = new Point(192, 553);
            linkRegistrate.Name = "linkRegistrate";
            linkRegistrate.Size = new Size(61, 21);
            linkRegistrate.TabIndex = 13;
            linkRegistrate.TabStop = true;
            linkRegistrate.Text = "Ingresa";
            linkRegistrate.LinkClicked += linkRegistrate_LinkClicked;
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuenta.Location = new Point(29, 553);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(165, 21);
            lblCuenta.TabIndex = 12;
            lblCuenta.Text = "¿Ya tienes una cuenta?";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(41, 516);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(210, 34);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(71, 9);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(147, 47);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "Registro";
            // 
            // txtRegistroApellido
            // 
            txtRegistroApellido.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegistroApellido.Location = new Point(40, 144);
            txtRegistroApellido.Name = "txtRegistroApellido";
            txtRegistroApellido.Size = new Size(210, 26);
            txtRegistroApellido.TabIndex = 9;
            // 
            // txtRegistroNombre
            // 
            txtRegistroNombre.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegistroNombre.Location = new Point(40, 85);
            txtRegistroNombre.Name = "txtRegistroNombre";
            txtRegistroNombre.Size = new Size(210, 26);
            txtRegistroNombre.TabIndex = 8;
            txtRegistroNombre.TextChanged += txtRegistroNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 362);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 19;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 178);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 18;
            label2.Text = "Nombre de Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(40, 384);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(210, 26);
            txtContraseña.TabIndex = 17;
            // 
            // txtRegistroUsuario
            // 
            txtRegistroUsuario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegistroUsuario.Location = new Point(40, 203);
            txtRegistroUsuario.Name = "txtRegistroUsuario";
            txtRegistroUsuario.Size = new Size(210, 26);
            txtRegistroUsuario.TabIndex = 16;
            // 
            // lblWarningRegistro
            // 
            lblWarningRegistro.AutoSize = true;
            lblWarningRegistro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblWarningRegistro.ForeColor = Color.Crimson;
            lblWarningRegistro.Location = new Point(36, 472);
            lblWarningRegistro.Name = "lblWarningRegistro";
            lblWarningRegistro.Size = new Size(221, 40);
            lblWarningRegistro.TabIndex = 20;
            lblWarningRegistro.Text = "Hay campos obligatorios vacíos\r\no contienen espacios";
            lblWarningRegistro.TextAlign = ContentAlignment.TopCenter;
            lblWarningRegistro.Visible = false;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.Location = new Point(44, 239);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(121, 19);
            lblCorreo.TabIndex = 22;
            lblCorreo.Text = "Correo Electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(40, 261);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(210, 26);
            txtCorreo.TabIndex = 21;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(44, 299);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(60, 19);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(40, 321);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(210, 26);
            txtTelefono.TabIndex = 23;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmar.Location = new Point(44, 425);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(144, 19);
            lblConfirmar.TabIndex = 26;
            lblConfirmar.Text = "Confirmar Contraseña";
            // 
            // txtConfirmar
            // 
            txtConfirmar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmar.Location = new Point(40, 447);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PasswordChar = '*';
            txtConfirmar.Size = new Size(210, 26);
            txtConfirmar.TabIndex = 25;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 584);
            Controls.Add(lblConfirmar);
            Controls.Add(txtConfirmar);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(lblWarningRegistro);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtContraseña);
            Controls.Add(txtRegistroUsuario);
            Controls.Add(lblConstraseña);
            Controls.Add(lblUsuario);
            Controls.Add(linkRegistrate);
            Controls.Add(lblCuenta);
            Controls.Add(btnRegistrar);
            Controls.Add(lblLogin);
            Controls.Add(txtRegistroApellido);
            Controls.Add(txtRegistroNombre);
            Name = "formRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            FormClosing += formRegister_Closing;
            Load += formRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConstraseña;
        private Label lblUsuario;
        private LinkLabel linkRegistrate;
        private Label lblCuenta;
        private Button btnRegistrar;
        private Label lblLogin;
        private TextBox txtRegistroApellido;
        private TextBox txtRegistroNombre;
        private Label label1;
        private Label label2;
        private TextBox txtContraseña;
        private TextBox txtRegistroUsuario;
        private Label lblWarningRegistro;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblConfirmar;
        private TextBox txtConfirmar;
    }
}