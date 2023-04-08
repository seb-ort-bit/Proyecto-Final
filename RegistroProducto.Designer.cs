namespace Tarea_4
{
    partial class formRegistroProducto
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
            lblMarca = new Label();
            lblUsuario = new Label();
            linkRegistrate = new LinkLabel();
            btnRegistrar = new Button();
            lblLogin = new Label();
            txtMarca = new TextBox();
            txtNombre = new TextBox();
            lblCategoria = new Label();
            txtCategoria = new TextBox();
            lblWarningRegistro = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(44, 122);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(47, 19);
            lblMarca.TabIndex = 15;
            lblMarca.Text = "Marca";
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
            linkRegistrate.Location = new Point(110, 454);
            linkRegistrate.Name = "linkRegistrate";
            linkRegistrate.Size = new Size(72, 21);
            linkRegistrate.TabIndex = 8;
            linkRegistrate.TabStop = true;
            linkRegistrate.Text = "Regresar";
            linkRegistrate.LinkClicked += linkRegistrate_LinkClicked;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(41, 416);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(210, 34);
            btnRegistrar.TabIndex = 7;
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
            // txtMarca
            // 
            txtMarca.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(40, 144);
            txtMarca.MaxLength = 20;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(210, 26);
            txtMarca.TabIndex = 1;
            txtMarca.TextChanged += txtRegistroApellido_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(40, 85);
            txtNombre.MaxLength = 15;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 26);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtRegistroNombre_TextChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.Location = new Point(44, 178);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(68, 19);
            lblCategoria.TabIndex = 18;
            lblCategoria.Text = "Categoría";
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoria.Location = new Point(40, 203);
            txtCategoria.MaxLength = 15;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(210, 26);
            txtCategoria.TabIndex = 2;
            // 
            // lblWarningRegistro
            // 
            lblWarningRegistro.AutoSize = true;
            lblWarningRegistro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblWarningRegistro.ForeColor = Color.Crimson;
            lblWarningRegistro.Location = new Point(36, 364);
            lblWarningRegistro.Name = "lblWarningRegistro";
            lblWarningRegistro.Size = new Size(221, 40);
            lblWarningRegistro.TabIndex = 20;
            lblWarningRegistro.Text = "Hay campos obligatorios vacíos\r\no contienen espacios";
            lblWarningRegistro.TextAlign = ContentAlignment.TopCenter;
            lblWarningRegistro.Visible = false;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(37, 239);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(228, 19);
            lblCantidad.TabIndex = 22;
            lblCantidad.Text = "Cantidad Disponible (Solo números)";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(40, 261);
            txtCantidad.MaxLength = 9;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(210, 26);
            txtCantidad.TabIndex = 3;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(44, 299);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(205, 19);
            lblPrecio.TabIndex = 24;
            lblPrecio.Text = "Precio (Solo números decimales)";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(40, 321);
            txtPrecio.MaxLength = 9;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(210, 26);
            txtPrecio.TabIndex = 4;
            // 
            // formRegistroProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 484);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblWarningRegistro);
            Controls.Add(lblCategoria);
            Controls.Add(txtCategoria);
            Controls.Add(lblMarca);
            Controls.Add(lblUsuario);
            Controls.Add(linkRegistrate);
            Controls.Add(btnRegistrar);
            Controls.Add(lblLogin);
            Controls.Add(txtMarca);
            Controls.Add(txtNombre);
            Name = "formRegistroProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Producto";
            FormClosing += formRegister_Closing;
            Load += formRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private Label lblUsuario;
        private LinkLabel linkRegistrate;
        private Button btnRegistrar;
        private Label lblLogin;
        private TextBox txtMarca;
        private TextBox txtNombre;
        private Label lblCategoria;
        private TextBox txtCategoria;
        private Label lblWarningRegistro;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblPrecio;
        private TextBox txtPrecio;
    }
}