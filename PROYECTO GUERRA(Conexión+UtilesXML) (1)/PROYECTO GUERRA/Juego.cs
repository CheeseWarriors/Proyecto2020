using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_GUERRA
{
    public class Juego
    {
        
        
       

        public Juego()
        {
            

        }


        public void RepartirCartas(List<Usuario> jugadores, Baraja baraja)
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


        public void CompararCartas(Partida partida)
        {
            
            foreach (var carta in partida.Cartasjugadas)
            {
                int indice = partida.Cartasjugadas.IndexOf(carta);
                int numerocarta = carta.Numero;
                int numerocartasiguiente = partida.Cartasjugadas[indice + 1].Numero;
                if (numerocarta>numerocartasiguiente)
                {
                    partida.Cartasperdidas.Add(partida.Cartasjugadas[indice + 1]);
                    partida.Cartasjugadas.Remove(partida.Cartasjugadas[indice + 1]);
                    Console.WriteLine("Gano " + carta.Palo + carta.Numero);
                }
                else
                {
                    if (numerocarta==numerocartasiguiente)
                    {
                        //GUERRA
                    }
                    else
                    {
                        partida.Cartasperdidas.Add(carta);
                        partida.Cartasjugadas.Remove(carta);
                        Console.WriteLine("Gano " + partida.Cartasjugadas[indice + 1].Palo + partida.Cartasjugadas[indice + 1].Numero);
                    }
                }
            }
            
        }


        


    }

}
