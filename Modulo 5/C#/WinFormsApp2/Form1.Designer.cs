namespace WinFormsApp2
{
    partial class lblNombre
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
            lblTitulo = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            btnMostar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Fuchsia;
            lblTitulo.Location = new Point(157, 74);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONTROLES WINDOWS FORM";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 158);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(188, 158);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 39);
            txtNombre.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(188, 274);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(200, 39);
            txtEdad.TabIndex = 4;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(75, 274);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(71, 32);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(188, 219);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 39);
            txtApellido.TabIndex = 6;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(75, 219);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(107, 32);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido:";
            // 
            // btnMostar
            // 
            btnMostar.Location = new Point(65, 384);
            btnMostar.Name = "btnMostar";
            btnMostar.Size = new Size(162, 49);
            btnMostar.TabIndex = 7;
            btnMostar.Text = "Mostrar";
            btnMostar.UseVisualStyleBackColor = true;
            btnMostar.Click += btnMostar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(233, 384);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(162, 49);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(401, 384);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(162, 49);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(43, 514);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 32);
            lblResultado.TabIndex = 10;
            // 
            // lblNombre
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(649, 809);
            Controls.Add(lblResultado);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostar);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Name = "lblNombre";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblEdad;
        private TextBox txtApellido;
        private Label lblApellido;
        private Button btnMostar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblResultado;
    }
}
