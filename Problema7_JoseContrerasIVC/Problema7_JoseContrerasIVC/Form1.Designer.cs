namespace Problema7_JoseContrerasIVC
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
            lblFecha = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtFecha = new TextBox();
            chkJava = new CheckBox();
            chkSQLServer = new CheckBox();
            chkOracle = new CheckBox();
            chkCSharp = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTotal = new TextBox();
            txtAPagar = new TextBox();
            txtResta = new TextBox();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(204, 86);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(111, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del cliente:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(204, 139);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(118, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha de inscripción:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(204, 188);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(110, 15);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Numero telefonico:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(321, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(320, 180);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(237, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(321, 139);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(237, 23);
            txtFecha.TabIndex = 6;
            // 
            // chkJava
            // 
            chkJava.AutoSize = true;
            chkJava.Location = new Point(204, 252);
            chkJava.Name = "chkJava";
            chkJava.Size = new Size(51, 19);
            chkJava.TabIndex = 7;
            chkJava.Text = "JAVA";
            chkJava.UseVisualStyleBackColor = true;
            // 
            // chkSQLServer
            // 
            chkSQLServer.AutoSize = true;
            chkSQLServer.Location = new Point(204, 327);
            chkSQLServer.Name = "chkSQLServer";
            chkSQLServer.Size = new Size(79, 19);
            chkSQLServer.TabIndex = 8;
            chkSQLServer.Text = "SQLServer";
            chkSQLServer.UseVisualStyleBackColor = true;
            // 
            // chkOracle
            // 
            chkOracle.AutoSize = true;
            chkOracle.Location = new Point(204, 302);
            chkOracle.Name = "chkOracle";
            chkOracle.Size = new Size(60, 19);
            chkOracle.TabIndex = 9;
            chkOracle.Text = "Oracle";
            chkOracle.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Location = new Point(204, 277);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(64, 19);
            chkCSharp.TabIndex = 10;
            chkCSharp.Text = "CSharp";
            chkCSharp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(421, 260);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 11;
            label1.Text = "Total a pagar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 342);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 12;
            label2.Text = "Resta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 302);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 13;
            label3.Text = "A pagar:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(504, 260);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(126, 23);
            txtTotal.TabIndex = 14;
            // 
            // txtAPagar
            // 
            txtAPagar.Location = new Point(475, 299);
            txtAPagar.Name = "txtAPagar";
            txtAPagar.Size = new Size(126, 23);
            txtAPagar.TabIndex = 15;
            // 
            // txtResta
            // 
            txtResta.Location = new Point(465, 342);
            txtResta.Name = "txtResta";
            txtResta.Size = new Size(126, 23);
            txtResta.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(259, 381);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(397, 381);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtResta);
            Controls.Add(txtAPagar);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkCSharp);
            Controls.Add(chkOracle);
            Controls.Add(chkSQLServer);
            Controls.Add(chkJava);
            Controls.Add(txtFecha);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblFecha;
        private Label lblTelefono;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtFecha;
        private CheckBox chkJava;
        private CheckBox chkSQLServer;
        private CheckBox chkOracle;
        private CheckBox chkCSharp;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTotal;
        private TextBox txtAPagar;
        private TextBox txtResta;
        private Button btnLimpiar;
        private Button btnRegistrar;
    }
}
