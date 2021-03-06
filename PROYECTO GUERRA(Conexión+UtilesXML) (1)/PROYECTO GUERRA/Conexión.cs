﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PROYECTO_GUERRA
{
    public class Conexión
    {
        public MySqlConnection CrearConexion(string servidor,
                                     string bdd,
                                     string usuario,
                                     string passwd)
        {
            MySqlConnection conexion;
            //Creamos el objeto de conexión

            string datosConexion = "server=" + servidor + ";" +
                                   "database=" + bdd + ";" +
                                   "uid=" + usuario + ";" +
                                   "pwd=" + passwd + ";";
            //Declaro un string con los datos de conexión, agregando los parámetros

            conexion = new MySqlConnection(datosConexion);
            //Inicializo el objeto de conexión con los datos de conexión

            return conexion;
            //Devolvemos el objeto de conexión pronto
        }

        public void ProbarConexion()
        {
            MySqlConnection conexion = CrearConexion("localhost", "loginbasico", "root", "");
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

        /// <summary>
        /// Realiza una consulta SELECT o SHOW y devuelve su resultado, o un error, en
        /// un string
        /// </summary>
        /// <param name="consulta">La consulta SELECT o SHOW que se quiere realizar</param>
        /// <param name="conexion">Un objeto MySqlConnection de conexión proporcionado por 
        /// el método CrearConexión</param>
        /// <returns>El resultado de la consulta o un error</returns>
        public string ConsultaGenerica1Columna(string consulta, MySqlConnection conexion)
        {
            string resultado = "";
            // Inicializamos el string resultado

            try
            {
                conexion.Open();
                //1 - Se abre la conexión

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                //2 - Se genera un objeto comando, que contendrá nuestra consulta a la BdD
                //  este objeto requiere la consulta y la conexión abierta.

                MySqlDataReader lectorResultado = comando.ExecuteReader();
                //3 - Se crea un objeto lector mediante el método ExecuteReader del comando
                //  este lector solo es necesario para consultas que devuelven información
                //  como ser SELECT o SHOW. Para otras consultas como INSERT, DELETE o UPDATE
                //  usaremos el método ExecuteNonQuery

                if (lectorResultado.HasRows) //4 - Chequeamos si el lector tiene algún registro
                {
                    while (lectorResultado.Read()) //5 - Avanzamos por los registros del lector de a uno con un bucle WHILE
                    {
                        resultado = resultado + lectorResultado.GetString(0);
                        //6 - Agregamos la primera columna de cada registro al resultado con el método GetString
                        //  el número 0 indica que queremos la primera columna, si fuera 1 sería la segunda, y así sucesivamente.

                        resultado = resultado + "\n";
                        //7 - Agregamos un '\n', un salto de línea, para que los registros se muestren
                        // cada uno en una línea diferente
                    }
                }
                else //8 - Si no hay ningún registro en el lector, agregamos un mensaje de error al resultado
                {
                    resultado = "No hay resultados para mostrar";
                }

            }
            catch (Exception ex) //9 - Si hay un error en la conexión, lo recuperamos y lo mostramos
            {
                resultado = "ERROR: " + ex.Message;
            }

            conexion.Close();
            //10 - Cerramos la conexión

            return resultado;
            //11 - Entregamos la variable resultado
        }



    }
}
    

