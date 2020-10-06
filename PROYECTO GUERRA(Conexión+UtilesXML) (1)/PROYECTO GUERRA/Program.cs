using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_GUERRA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new iniciosesion());


            Jugador j1 = new Jugador();
            Jugador j2 = new Jugador();
            Jugador j3 = new Jugador();
            Jugador j4 = new Jugador();

            List<Jugador> jugadores = new List<Jugador>();

            jugadores.Add(j1);
            jugadores.Add(j2);
            jugadores.Add(j3);
            jugadores.Add(j4);

            Juego prueba = new Juego(jugadores);

            Console.WriteLine(j1.monton.Count());
        }
    }
}
