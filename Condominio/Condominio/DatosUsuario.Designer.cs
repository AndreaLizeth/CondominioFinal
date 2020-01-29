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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(221, 434);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 49);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Numeric
            // 
            this.Numeric.Location = new System.Drawing.Point(248, 325);
            this.Numeric.Name = "Numeric";
            this.Numeric.Size = new System.Drawing.Size(120, 22);
            this.Numeric.TabIndex = 24;
            // 
            // LblNumMiembros
            // 
            this.LblNumMiembros.AutoSize = true;
            this.LblNumMiembros.Location = new System.Drawing.Point(61, 325);
            this.LblNumMiembros.Name = "LblNumMiembros";
            this.LblNumMiembros.Size = new System.Drawing.Size(168, 17);
            this.LblNumMiembros.TabIndex = 23;
            this.LblNumMiembros.Text = "N° Miembros de la familia";
            // 
            // LblApellidoArrendatario
            // 
            this.LblApellidoArrendatario.AutoSize = true;
            this.LblApellidoArrendatario.Location = new System.Drawing.Point(61, 192);
            this.LblApellidoArrendatario.Name = "LblApellidoArrendatario";
            this.LblApellidoArrendatario.Size = new System.Drawing.Size(62, 17);
            this.LblApellidoArrendatario.TabIndex = 22;
            this.LblApellidoArrendatario.Text = "Apellido:";
            // 
            // LblNombreArrendatario
            // 
            this.LblNombreArrendatario.AutoSize = true;
            this.LblNombreArrendatario.Location = new System.Drawing.Point(61, 149);
            this.LblNombreArrendatario.Name = "LblNombreArrendatario";
            this.LblNombreArrendatario.Size = new System.Drawing.Size(62, 17);
            this.LblNombreArrendatario.TabIndex = 21;
            this.LblNombreArrendatario.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(161, 189);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(207, 22);
            this.txtApellido.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 144);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 22);
            this.txtNombre.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "DATOS DEL NUEVO ARRENDATARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(161, 281);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(207, 22);
            this.txtMail.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(161, 237);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(207, 22);
            this.txtCedula.TabIndex = 28;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(161, 103);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(207, 22);
            this.txtCodigo.TabIndex = 30;
            // 
            // DatosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 542);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.Numeric);
            this.Controls.Add(this.LblNumMiembros);
            this.Controls.Add(this.LblApellidoArrendatario);
            this.Controls.Add(this.LblNombreArrendatario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosUsuario";
            this.Text = "DatosUsuario";
            this.Load += new System.EventHandler(this.DatosUsuario_Load);
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
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}