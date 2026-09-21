namespace Problema6_JoseContrerasIVC
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
            LblPantalla = new Label();
            btnEncenderApagar = new Button();
            btnSubirVolumen = new Button();
            btnBajarVolumen = new Button();
            btnSubirCanal = new Button();
            btnBajarCanal = new Button();
            SuspendLayout();
            // 
            // LblPantalla
            // 
            LblPantalla.AutoSize = true;
            LblPantalla.Location = new Point(331, 67);
            LblPantalla.Name = "LblPantalla";
            LblPantalla.Size = new Size(77, 15);
            LblPantalla.TabIndex = 0;
            LblPantalla.Text = "TV APAGADA";
            // 
            // btnEncenderApagar
            // 
            btnEncenderApagar.Location = new Point(300, 122);
            btnEncenderApagar.Name = "btnEncenderApagar";
            btnEncenderApagar.Size = new Size(152, 23);
            btnEncenderApagar.TabIndex = 1;
            btnEncenderApagar.Text = "ENCENDER / APAGAR";
            btnEncenderApagar.UseVisualStyleBackColor = true;
            btnEncenderApagar.Click += btnEncenderApagar_Click;
            // 
            // btnSubirVolumen
            // 
            btnSubirVolumen.Location = new Point(250, 176);
            btnSubirVolumen.Name = "btnSubirVolumen";
            btnSubirVolumen.Size = new Size(75, 23);
            btnSubirVolumen.TabIndex = 2;
            btnSubirVolumen.Text = "+ Volumen";
            btnSubirVolumen.UseVisualStyleBackColor = true;
            btnSubirVolumen.Click += btnSubirVolumen_Click;
            // 
            // btnBajarVolumen
            // 
            btnBajarVolumen.Location = new Point(250, 225);
            btnBajarVolumen.Name = "btnBajarVolumen";
            btnBajarVolumen.Size = new Size(75, 23);
            btnBajarVolumen.TabIndex = 3;
            btnBajarVolumen.Text = "- Volumen";
            btnBajarVolumen.UseVisualStyleBackColor = true;
            btnBajarVolumen.Click += btnBajarVolumen_Click;
            // 
            // btnSubirCanal
            // 
            btnSubirCanal.Location = new Point(430, 176);
            btnSubirCanal.Name = "btnSubirCanal";
            btnSubirCanal.Size = new Size(75, 23);
            btnSubirCanal.TabIndex = 4;
            btnSubirCanal.Text = "+ Canal";
            btnSubirCanal.UseVisualStyleBackColor = true;
            btnSubirCanal.Click += btnSubirCanal_Click;
            // 
            // btnBajarCanal
            // 
            btnBajarCanal.Location = new Point(430, 225);
            btnBajarCanal.Name = "btnBajarCanal";
            btnBajarCanal.Size = new Size(75, 23);
            btnBajarCanal.TabIndex = 5;
            btnBajarCanal.Text = "- Canal";
            btnBajarCanal.UseVisualStyleBackColor = true;
            btnBajarCanal.Click += btnBajarCanal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBajarCanal);
            Controls.Add(btnSubirCanal);
            Controls.Add(btnBajarVolumen);
            Controls.Add(btnSubirVolumen);
            Controls.Add(btnEncenderApagar);
            Controls.Add(LblPantalla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPantalla;
        private Button btnEncenderApagar;
        private Button btnSubirVolumen;
        private Button btnBajarVolumen;
        private Button btnSubirCanal;
        private Button btnBajarCanal;
    }
}
