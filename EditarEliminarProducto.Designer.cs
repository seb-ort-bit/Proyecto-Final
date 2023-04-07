namespace Tarea_4
{
    partial class EditarEliminarProducto
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
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblCategoria = new Label();
            txtCategoria = new TextBox();
            lblMarca = new Label();
            lblUsuario = new Label();
            txtMarca = new TextBox();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(141, 153);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(205, 19);
            lblPrecio.TabIndex = 34;
            lblPrecio.Text = "Precio (Solo números decimales)";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(137, 175);
            txtPrecio.MaxLength = 5;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(210, 26);
            txtPrecio.TabIndex = 29;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(248, 91);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(228, 19);
            lblCantidad.TabIndex = 33;
            lblCantidad.Text = "Cantidad Disponible (Solo números)";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(251, 113);
            txtCantidad.MaxLength = 12;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(210, 26);
            txtCantidad.TabIndex = 28;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.Location = new Point(25, 88);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(68, 19);
            lblCategoria.TabIndex = 32;
            lblCategoria.Text = "Categoría";
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoria.Location = new Point(21, 113);
            txtCategoria.MaxLength = 15;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(210, 26);
            txtCategoria.TabIndex = 27;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.Location = new Point(255, 29);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(47, 19);
            lblMarca.TabIndex = 31;
            lblMarca.Text = "Marca";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(25, 26);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 19);
            lblUsuario.TabIndex = 30;
            lblUsuario.Text = "Nombre";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(251, 51);
            txtMarca.MaxLength = 20;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(210, 26);
            txtMarca.TabIndex = 26;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(21, 51);
            txtNombre.MaxLength = 15;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 26);
            txtNombre.TabIndex = 25;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(59, 219);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 71);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Azure;
            btnEliminar.Location = new Point(278, 219);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 71);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // EditarEliminarProducto
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(486, 319);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblCategoria);
            Controls.Add(txtCategoria);
            Controls.Add(lblMarca);
            Controls.Add(lblUsuario);
            Controls.Add(txtMarca);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditarEliminarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nombre del producto";
            Load += EditarEliminarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblCategoria;
        private TextBox txtCategoria;
        private Label lblMarca;
        private Label lblUsuario;
        private TextBox txtMarca;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}