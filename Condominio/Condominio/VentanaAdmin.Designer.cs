namespace Condominio
{
    partial class VentanaAdmin
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
            this.btnDatosUsuario = new System.Windows.Forms.Button();
            this.btnQuejas = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnCuotas = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatosUsuario
            // 
            this.btnDatosUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnDatosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDatosUsuario.Location = new System.Drawing.Point(0, 80);
            this.btnDatosUsuario.Name = "btnDatosUsuario";
            this.btnDatosUsuario.Size = new System.Drawing.Size(234, 57);
            this.btnDatosUsuario.TabIndex = 0;
            this.btnDatosUsuario.Text = "DATOS DEL USUARIO";
            this.btnDatosUsuario.UseVisualStyleBackColor = false;
            this.btnDatosUsuario.Click += new System.EventHandler(this.btnDatosUsuario_Click);
            // 
            // btnQuejas
            // 
            this.btnQuejas.BackColor = System.Drawing.Color.Transparent;
            this.btnQuejas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuejas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuejas.Location = new System.Drawing.Point(0, 143);
            this.btnQuejas.Name = "btnQuejas";
            this.btnQuejas.Size = new System.Drawing.Size(234, 56);
            this.btnQuejas.TabIndex = 1;
            this.btnQuejas.Text = "QUEJAS";
            this.btnQuejas.UseVisualStyleBackColor = false;
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.Transparent;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPagos.Location = new System.Drawing.Point(0, 205);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(234, 48);
            this.btnPagos.TabIndex = 2;
            this.btnPagos.Text = "PAGOS";
            this.btnPagos.UseVisualStyleBackColor = false;
            // 
            // btnCuotas
            // 
            this.btnCuotas.BackColor = System.Drawing.Color.Transparent;
            this.btnCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuotas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCuotas.Location = new System.Drawing.Point(0, 259);
            this.btnCuotas.Name = "btnCuotas";
            this.btnCuotas.Size = new System.Drawing.Size(234, 48);
            this.btnCuotas.TabIndex = 3;
            this.btnCuotas.Text = "CUOTAS";
            this.btnCuotas.UseVisualStyleBackColor = false;
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartamento.Location = new System.Drawing.Point(0, 313);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(234, 48);
            this.btnDepartamento.TabIndex = 4;
            this.btnDepartamento.Text = "DEPARTAMENTOS";
            this.btnDepartamento.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMenu.Controls.Add(this.btnDepartamento);
            this.panelMenu.Controls.Add(this.btnCuotas);
            this.panelMenu.Controls.Add(this.btnPagos);
            this.panelMenu.Controls.Add(this.btnQuejas);
            this.panelMenu.Controls.Add(this.btnDatosUsuario);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(234, 450);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(234, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(566, 450);
            this.panelContenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Condominio.Properties.Resources.pngocean_com;
            this.pictureBox1.Location = new System.Drawing.Point(131, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Name = "VentanaAdmin";
            this.Text = "VentanaAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaAdmin_FormClosed);
            this.Load += new System.EventHandler(this.VentanaAdmin_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDatosUsuario;
        private System.Windows.Forms.Button btnQuejas;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnCuotas;
        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}