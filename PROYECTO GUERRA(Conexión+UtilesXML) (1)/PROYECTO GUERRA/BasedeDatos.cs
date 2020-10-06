using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROYECTO_GUERRA
{
    public class BasedeDatos
    {
        public MySqlConnection CrearConexion(string servidor,
                                            string bdd,
                                            string usuario,
                                            string passwd)
        {
            MySqlConnection conexion;
            string datosConexion = "server=" + servidor + ";" +
                                   "database=" + bdd + ";" +
                                   "uid=" + usuario + ";" +
                                   "pwd=" + passwd + ";";

            conexion = new MySqlConnection(datosConexion);
            return conexion;
        }


        /// <summary>
        /// Realiza una prueba sencilla de la conexión, mostrando el resultado en la consola,
        /// ya sea éxito o error.
        /// </summary>
        /// <param name="conexion">Un objeto MySqlConnection de conexión proporcionado por 
        /// el método CrearConexión</param>
        public void ProbarConexion(MySqlConnection conexion)
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            conexion.Close();
            //Cerramos la conexión

        }
    }
}
        
