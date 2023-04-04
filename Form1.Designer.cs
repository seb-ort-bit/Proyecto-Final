namespace Tarea_4
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLoginUsuario = new TextBox();
            txtLoginContraseña = new TextBox();
            lblLogin = new Label();
            btnEntrar = new Button();
            lblCuenta = new Label();
            linkRegistrate = new LinkLabel();
            lblUsuario = new Label();
            lblConstraseña = new Label();
            lblWarningLogin = new Label();
            SuspendLayout();
            // 
            // txtLoginUsuario
            // 
            txtLoginUsuario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginUsuario.Location = new Point(38, 89);
            txtLoginUsuario.Name = "txtLoginUsuario";
            txtLoginUsuario.Size = new Size(210, 26);
            txtLoginUsuario.TabIndex = 0;
            // 
            // txtLoginContraseña
            // 
            txtLoginContraseña.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginContraseña.Location = new Point(38, 148);
            txtLoginContraseña.Name = "txtLoginContraseña";
            txtLoginContraseña.PasswordChar = '*';
            txtLoginContraseña.Size = new Size(210, 26);
            txtLoginContraseña.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(81, 15);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(116, 47);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Log in";
            lblLogin.Click += label1_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.Location = new Point(38, 193);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(210, 34);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuenta.Location = new Point(27, 274);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(170, 21);
            lblCuenta.TabIndex = 4;
            lblCuenta.Text = "¿No tienes una cuenta?";
            // 
            // linkRegistrate
            // 
            linkRegistrate.AutoSize = true;
            linkRegistrate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkRegistrate.Location = new Point(190, 274);
            linkRegistrate.Name = "linkRegistrate";
            linkRegistrate.Size = new Size(80, 21);
            linkRegistrate.TabIndex = 5;
            linkRegistrate.TabStop = true;
            linkRegistrate.Text = "Regístrate";
            linkRegistrate.LinkClicked += linkRegistrate_LinkClicked;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(40, 64);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 19);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // lblConstraseña
            // 
            lblConstraseña.AutoSize = true;
            lblConstraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblConstraseña.Location = new Point(40, 126);
            lblConstraseña.Name = "lblConstraseña";
            lblConstraseña.Size = new Size(79, 19);
            lblConstraseña.TabIndex = 7;
            lblConstraseña.Text = "Contraseña";
            // 
            // lblWarningLogin
            // 
            lblWarningLogin.AutoSize = true;
            lblWarningLogin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblWarningLogin.ForeColor = Color.Crimson;
            lblWarningLogin.Location = new Point(23, 230);
            lblWarningLogin.Name = "lblWarningLogin";
            lblWarningLogin.Size = new Size(259, 40);
            lblWarningLogin.TabIndex = 21;
            lblWarningLogin.Text = "Debe ingresar su usuario y contraseña\r\ny registrarse si no lo ha hecho\r\n";
            lblWarningLogin.TextAlign = ContentAlignment.TopCenter;
            lblWarningLogin.Visible = false;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 302);
            Controls.Add(lblWarningLogin);
            Controls.Add(lblConstraseña);
            Controls.Add(lblUsuario);
            Controls.Add(linkRegistrate);
            Controls.Add(lblCuenta);
            Controls.Add(btnEntrar);
            Controls.Add(lblLogin);
            Controls.Add(txtLoginContraseña);
            Controls.Add(txtLoginUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            FormClosing += formLogin_Closing;
            Load += formLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoginUsuario;
        private TextBox txtLoginContraseña;
        private Label lblLogin;
        private Button btnEntrar;
        private Label lblCuenta;
        private LinkLabel linkRegistrate;
        private Label lblUsuario;
        private Label lblConstraseña;
        private Label lblWarningLogin;
    }
}