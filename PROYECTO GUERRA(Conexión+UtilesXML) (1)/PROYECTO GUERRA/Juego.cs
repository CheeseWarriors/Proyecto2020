using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_GUERRA
{
    public class Juego
    {
        List<Jugador> jugadores = new List<Jugador>();

        Baraja baraja = new Baraja();

        public Juego(List<Jugador> jugadores)
        {
            this.jugadores = jugadores;
            baraja.Barajar_nuevo();
            RepartirCartas();

        }


        public void RepartirCartas()
        {
            int cant_jugadores = jugadores.Count();
            int numero_jugador = 0;


            foreach (var carta in baraja.baraja)
            {
                jugadores[numero_jugador].RecibirCarta(carta);

                numero_jugador++;
                if (numero_jugador == cant_jugadores)
                {
                    numero_jugador = 0;
                }
            }
        }
    }

}
