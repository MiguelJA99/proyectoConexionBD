using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyectoConexionBD.BibliotecaClases
{

    public class BaseDeDatos
    {

        public static SqlConnection ObtenerConexion()
        {
            string servidor1 = "JAMX-LP-055";
            string baseDatos1 = "NorthWind_Mart";
            string usuario1 = "sa";
            string contraseña1 = "12345678";

            string servidor2 = "JAMX-LP-055";
            string baseDatos2 = "NucorProductionTracking";
            string usuario2 = "sa";
            string contraseña2 = "12345678";

            // Crear la cadena de conexión para el primer servidor
            string cadenaConexion1 = $"Data Source={servidor1};Initial Catalog={baseDatos1};User ID={usuario1};Password={contraseña1}";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión válida");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            // Crear la cadena de conexión para el segundo servidor
            string cadenaConexion2 = $"Data Source={servidor2};Initial Catalog={baseDatos2};User ID={usuario2};Password={contraseña2}";

            // Establecer la conexión
            SqlConnection conexion = new SqlConnection(cadenaConexion1);

            // Devolver la conexión
            return conexion;
        }

    }

}

