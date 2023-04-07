namespace Tarea_4
{
    partial class GestionProductos
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

        public void listarProducto(int position, string nombre, string marca, string categoria, string cantidad, string precio)
        {
            int Ypos = 41 + (106 * position);

            GroupBox groupBox = new GroupBox();
            Label lblCantidad = new Label();
            Label lblPrecio = new Label();
            Label lblCategoria = new Label();
            Label lblMarca = new Label();
            Label lblProducto = new Label();

            groupBox.SuspendLayout();
            SuspendLayout();

            groupBox.Location = new Point(12, Ypos);
            groupBox.Name = "boxProducto" + Convert.ToString(position);
            groupBox.Size = new Size(543, 100);
            groupBox.AutoSize = true;
            groupBox.Padding = new Padding(0);
            groupBox.Controls.Add(lblCantidad);
            groupBox.Controls.Add(lblPrecio);
            groupBox.Controls.Add(lblCategoria);
            groupBox.Controls.Add(lblMarca);
            groupBox.Controls.Add(lblProducto);

            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblProducto.TextAlign = ContentAlignment.MiddleCenter;
            lblProducto.Location = new Point(11, 22);
            lblProducto.Name = "lblProducto" + Convert.ToString(position);
            lblProducto.Size = new Size(98, 28);
            lblProducto.Text = nombre;

            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMarca.TextAlign = ContentAlignment.MiddleCenter;
            lblMarca.Location = new Point(11, 62);
            lblMarca.Name = "lblMarca" + Convert.ToString(position);
            lblMarca.Size = new Size(53, 21);
            lblMarca.Text = marca;

            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.TextAlign = ContentAlignment.MiddleCenter;
            lblCategoria.Location = new Point(172, 41);
            lblCategoria.Name = "lblCategoria" + Convert.ToString(position);
            lblCategoria.Size = new Size(88, 25);
            lblCategoria.Text = categoria;

            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.TextAlign = ContentAlignment.MiddleLeft;
            lblCantidad.Location = new Point(323, 41);
            lblCantidad.Name = "lblCantidad" + Convert.ToString(position);
            lblCantidad.Size = new Size(42, 25);
            lblCantidad.Text = cantidad;

            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.TextAlign = ContentAlignment.MiddleLeft;
            lblPrecio.Location = new Point(428, 41);
            lblPrecio.Name = "lblPrecio" + Convert.ToString(position);
            lblPrecio.Size = new Size(66, 25);
            lblPrecio.Text = precio;

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
            btnRegresar = new Button();
            btnGuardarCambios = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.IndianRed;
            btnRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(586, 249);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(138, 35);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Enabled = false;
            btnGuardarCambios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarCambios.Location = new Point(586, 127);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(138, 55);
            btnGuardarCambios.TabIndex = 13;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(586, 199);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 33);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(586, 46);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(138, 29);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // GestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(751, 469);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnRegresar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GestionProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Productos";
            FormClosing += GestionProductos_FormClosing;
            Load += GestionProductos_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegresar;
        private Button btnGuardarCambios;
        private Button btnEliminar;
        private Button btnNuevo;
    }
}