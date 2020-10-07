using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_GUERRA
{
    class Baraja
    {
        Herramientas herramientas = new Herramientas();

        //public Carta[] baraja = new Carta[50];
        public List<Carta> baraja = new List<Carta>();


        private string[] palos = { "oro", "espada", "copa", "basto" };

        /// <summary>
        /// Método constructor de la baraja.
        /// Crea una nueva instancia de la baraja
        /// </summary>
        public Baraja()
        {
            int posicion = 0;

            while (posicion < 48)
            {
                Carta nuevaCarta = null;

   
                    foreach (var palo in palos)
                    {
                        for (int num = 1; num < 13; num++)
                        {
                            nuevaCarta = new Carta(num, palo);
                            baraja.Add(nuevaCarta);
                            posicion++;
                        }
                    }
                }

            }


        /// <summary>
        /// Muestra en la consola cada carta de la baraja
        /// </summary>
        public void MostrarBaraja()
        {
           
            foreach (var carta in baraja)
            {
                string dato = carta.Numero.ToString() + " - " + carta.Palo;
                

            }
        }

        /// <summary>
        /// Método para barajar la baraja
        /// </summary>
        public void Barajar_nuevo()
        {
            for (int c = 0; c < baraja.Count; c++)
            {
                Carta barajada = null;

                int numCarta2 = herramientas.AlAzarEntre(0, baraja.Count);

                barajada = baraja[c];
                baraja[c] = baraja[numCarta2];
                baraja[numCarta2] = barajada;
            }

        }


        public string BarajaATexto()
        {
            string resultado="";


            foreach (var carta in this.baraja)
            {
                string letra = carta.Palo[0]+"";
                int numero = carta.Numero;
                resultado = resultado + "-" + letra + "_" + numero;

            }
            resultado = resultado.Substring(1);

            return resultado;
        }


    }
}
