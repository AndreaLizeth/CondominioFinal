namespace Condominio
{
    partial class DatosUsuario
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Numeric = new System.Windows.Forms.NumericUpDown();
            this.LblNumMiembros = new System.Windows.Forms.Label();
            this.LblApellidoArrendatario = new System.Windows.Forms.Label();
            this.LblNombreArrendatario = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(412, 324);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 49);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Numeric
            // 
            this.Numeric.Location = new System.Drawing.Point(499, 270);
            this.Numeric.Name = "Numeric";
            this.Numeric.Size = new System.Drawing.Size(120, 22);
            this.Numeric.TabIndex = 24;
            // 
            // LblNumMiembros
            // 
            this.LblNumMiembros.AutoSize = true;
            this.LblNumMiembros.Location = new System.Drawing.Point(312, 270);
            this.LblNumMiembros.Name = "LblNumMiembros";
            this.LblNumMiembros.Size = new System.Drawing.Size(168, 17);
            this.LblNumMiembros.TabIndex = 23;
            this.LblNumMiembros.Text = "N° Miembros de la familia";
            // 
            // LblApellidoArrendatario
            // 
            this.LblApellidoArrendatario.AutoSize = true;
            this.LblApellidoArrendatario.Location = new System.Drawing.Point(312, 137);
            this.LblApellidoArrendatario.Name = "LblApellidoArrendatario";
            this.LblApellidoArrendatario.Size = new System.Drawing.Size(62, 17);
            this.LblApellidoArrendatario.TabIndex = 22;
            this.LblApellidoArrendatario.Text = "Apellido:";
            // 
            // LblNombreArrendatario
            // 
            this.LblNombreArrendatario.AutoSize = true;
            this.LblNombreArrendatario.Location = new System.Drawing.Point(312, 94);
            this.LblNombreArrendatario.Name = "LblNombreArrendatario";
            this.LblNombreArrendatario.Size = new System.Drawing.Size(62, 17);
            this.LblNombreArrendatario.TabIndex = 21;
            this.LblNombreArrendatario.Text = "Nombre:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(412, 134);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(207, 22);
            this.TxtApellido.TabIndex = 20;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(412, 89);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(207, 22);
            this.TxtNombre.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "DATOS DEL NUEVO ARRENDATARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mail:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "cédula:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(412, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 22);
            this.textBox2.TabIndex = 28;
            // 
            // DatosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.Numeric);
            this.Controls.Add(this.LblNumMiembros);
            this.Controls.Add(this.LblApellidoArrendatario);
            this.Controls.Add(this.LblNombreArrendatario);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Name = "DatosUsuario";
            this.Text = "DatosUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown Numeric;
        private System.Windows.Forms.Label LblNumMiembros;
        private System.Windows.Forms.Label LblApellidoArrendatario;
        private System.Windows.Forms.Label LblNombreArrendatario;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}