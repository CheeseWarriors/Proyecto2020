using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_GUERRA
{
    public class Partida
    {
        private List<Usuario> jugadores = new List<Usuario>();
        private Baraja baraja = new Baraja();
        private Juego juego = new Juego();

        private List<Carta> cartasjugadas = new List<Carta>();
        private List<Carta> cartasperdidas = new List<Carta>();

        public Partida(List<Usuario> jugadores) {

            this.Jugadores = jugadores;
            this.Baraja.Barajar_nuevo();
            this.Juego.RepartirCartas(this.Jugadores, this.Baraja);

        }

        public List<Usuario> Jugadores { get => jugadores; set => jugadores = value; }
        public Baraja Baraja { get => baraja; set => baraja = value; }
        public Juego Juego { get => juego; set => juego = value; }
        public List<Carta> Cartasjugadas { get => cartasjugadas; set => cartasjugadas = value; }
        public List<Carta> Cartasperdidas { get => cartasperdidas; set => cartasperdidas = value; }
    }
}
