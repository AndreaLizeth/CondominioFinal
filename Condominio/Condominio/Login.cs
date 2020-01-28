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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string codigo = "";



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string cmd = string.Format("Select * from usuario where nombreUsuario='{0}' AND claveUsuario='{1}'", txtUsuario.Text.Trim(), txtContrasena.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(cmd);

                codigo = ds.Tables[0].Rows[0]["idUsuario"].ToString().Trim();

                string user = ds.Tables[0].Rows[0]["nombreUsuario"].ToString();
                Console.WriteLine(user);
                string clave = ds.Tables[0].Rows[0]["claveUsuario"].ToString();
                Console.WriteLine(clave);
                Console.WriteLine(txtUsuario.Text.Trim());



                if (user == txtUsuario.Text.Trim() && clave == txtContrasena.Text.Trim())
                {
                    
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["tipoUsuario"]) == true)
                    {
                        this.Hide();
                        VentanaAdmin AdminVentana = new VentanaAdmin();
                        AdminVentana.Show();
                        

                    }
                    else
                    {
                        VentanaUser UserVentana = new VentanaUser();
                        this.Hide();
                        UserVentana.Show();


                    }


                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
           
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
