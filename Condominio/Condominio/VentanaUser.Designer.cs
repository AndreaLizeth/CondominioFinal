namespace Condominio
{
    partial class VentanaUser
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCuotas = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnQuejas = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMenu.Controls.Add(this.btnCuotas);
            this.panelMenu.Controls.Add(this.btnPagos);
            this.panelMenu.Controls.Add(this.btnQuejas);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(234, 450);
            this.panelMenu.TabIndex = 1;
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
            // VentanaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Name = "VentanaUser";
            this.Text = "VentanaUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaUser_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCuotas;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnQuejas;
    }
}