using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_GUERRA
{
    public class Jugador
    {
        public List<Carta> monton = new List<Carta>();

        public void RecibirCarta(Carta carta)
        {
            monton.Add(carta);
        }
    }
}
