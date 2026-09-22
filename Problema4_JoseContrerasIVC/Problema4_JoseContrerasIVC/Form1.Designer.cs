namespace Problema4_JoseContrerasIVC
{
    partial class Form1
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
            lblNombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtNombreCompleto = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            btnConcatenar = new Button();
            btnNuevosDatos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(205, 125);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 156);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 190);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido Materno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 226);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(265, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(205, 244);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(342, 23);
            txtNombreCompleto.TabIndex = 5;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(309, 190);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(238, 23);
            txtApellidoMaterno.TabIndex = 7;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(309, 153);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(238, 23);
            txtApellidoPaterno.TabIndex = 8;
            // 
            // btnConcatenar
            // 
            btnConcatenar.Location = new Point(205, 306);
            btnConcatenar.Name = "btnConcatenar";
            btnConcatenar.Size = new Size(78, 42);
            btnConcatenar.TabIndex = 9;
            btnConcatenar.Text = "Concatenar Datos";
            btnConcatenar.UseVisualStyleBackColor = true;
            btnConcatenar.Click += btnConcatenar_Click;
            // 
            // btnNuevosDatos
            // 
            btnNuevosDatos.Location = new Point(334, 306);
            btnNuevosDatos.Name = "btnNuevosDatos";
            btnNuevosDatos.Size = new Size(85, 40);
            btnNuevosDatos.TabIndex = 10;
            btnNuevosDatos.Text = "Nuevos Datos";
            btnNuevosDatos.UseVisualStyleBackColor = true;
            btnNuevosDatos.Click += btnNuevosDatos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(472, 304);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 44);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir del Programa";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevosDatos);
            Controls.Add(btnConcatenar);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtNombreCompleto;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private Button btnConcatenar;
        private Button btnNuevosDatos;
        private Button btnSalir;
    }
}
