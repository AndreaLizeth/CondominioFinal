using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-MUS3J725;Initial Catalog=Condominio;User ID=Tecnicas;Password=123456");
            conexion.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, conexion);

            DP.Fill(DS);

            conexion.Close();

            return DS;

        }
    }
}
