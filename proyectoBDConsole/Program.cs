using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace ConsultaBD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cadena de conexión a la base de datos
            string connectionString = "Data Source=tu_servidor;Initial Catalog=nombre_base_datos;User ID=usuario;Password=contraseña";

            // Query SQL que deseas ejecutar
            string query = "SELECT * FROM NombreTabla";

            // Establecer la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear el comando SQL
                SqlCommand command = new SqlCommand(query, connection);

                // Abrir la conexión
                connection.Open();

                // Ejecutar la consulta y obtener un lector de datos
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Iterar sobre los resultados y mostrarlos
                    while (reader.Read())
                    {
                        // Aquí puedes acceder a los valores de las columnas por nombre o índice
                        int id = reader.GetInt32(0); // Suponiendo que la primera columna es un entero
                        string nombre = reader.GetString(1); // Suponiendo que la segunda columna es una cadena
                        // Puedes seguir obteniendo los valores de las columnas según su tipo
                        Console.WriteLine($"ID: {id}, Nombre: {nombre}");
                    }
                }
            }
        }
    }
}