using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_GUERRA
{
    public class Carta
    {
        private int numero = 0;
        private string palo = "";

        public Carta(int numero, string palo)
        {
            this.Numero = numero;
            this.Palo = palo;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Palo { get => palo; set => palo = value; }

        public string InfoImagen()
        {
            return "Baraja\\" + palo + numero + ".png";
        }
    }
}
