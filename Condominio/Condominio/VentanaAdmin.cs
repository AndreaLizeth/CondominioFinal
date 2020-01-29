using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;

namespace Condominio
{
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
             
        }

        private void btnDatosUsuario_Click(object sender, EventArgs e)
        {
            /*  DatosUsuario datosUsuario = new DatosUsuario();
              this.Hide();
              datosUsuario.Show();*/
            AbrirFormulario<DatosUsuario>();
            pictureBox1.Hide();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = panelContenedor.Controls.OfType<T>().FirstOrDefault();
            if (formulario != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = new T();
            formulario.TopLevel = false;
            panelContenedor.Controls.Add(formulario);
            panelContenedor.Tag = formulario;
            formulario.Show();
        }

    }
}
