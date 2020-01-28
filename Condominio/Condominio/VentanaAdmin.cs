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

        private void btnDatosUsuario_Click(object sender, EventArgs e)
        {
            DatosUsuario datoUsuario = new DatosUsuario();
            datoUsuario.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM usuario WHERE idUsuario=" + Login.codigo; //hace una consulta para devolver datos de la persona que inicio sesión

            DataSet DS = Utilidades.Ejecutar(cmd);


        }
    }
}
