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
    public partial class DatosUsuario : Form
    {
        public DatosUsuario()
        {
            InitializeComponent();
        }

        private void DatosUsuario_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM usuario WHERE idUsuario=" + Login.codigo; //hace una consulta para devolver datos de la persona que inicio sesión

            DataSet DS = Utilidades.Ejecutar(cmd);

            txtNombre.Text = DS.Tables[0].Rows[0]["nombreUsuario"].ToString();
            txtApellido.Text = DS.Tables[0].Rows[0]["apellidoUsuario"].ToString();
            txtCedula.Text = DS.Tables[0].Rows[0]["ciUsuario"].ToString();
            txtMail.Text = DS.Tables[0].Rows[0]["mailUusuario"].ToString();
            txtCodigo.Text = DS.Tables[0].Rows[0]["idUsuario"].ToString();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
