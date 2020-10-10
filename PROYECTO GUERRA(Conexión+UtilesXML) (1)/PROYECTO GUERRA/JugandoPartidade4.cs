using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_GUERRA
{
    public partial class JugandoPartidade4 : Form


    {
        Partida partida = null;
        Carta cartaJugada = null;

        List<Label> etiquetascantcartas = new List<Label>();



        public JugandoPartidade4(List<Usuario> jugadores)
        {

            InitializeComponent();

            etiquetascantcartas.Add(etiq_cartajug1);
            etiquetascantcartas.Add(etiq_cartajug2);
            etiquetascantcartas.Add(etiq_cartajug3);
            etiquetascantcartas.Add(etiq_cartajug4);


            partida = new Partida(jugadores);
            ContadorCartasJugadores();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                MenuPrincipal NuevaVentana = new MenuPrincipal();
                NuevaVentana.Show();

            }

            else if (DialogResult == DialogResult.No)
            {
                // Nothing
            }
        }

        private void btnmazo_Click(object sender, EventArgs e)
        {
            Console.WriteLine(partida.Jugadores[0].monton.Count.ToString());
            if (partida.Jugadores[0].monton.Count > 0)
            {
                cartaJugada = partida.Jugadores[0].monton[0];//partida.Baraja.baraja[0];
                partida.Jugadores[0].monton.Remove(cartaJugada);

                String archivo = cartaJugada.InfoImagen();
                Console.WriteLine(archivo);
                Image im = Image.FromFile(archivo);
                img_cartajugada.Image = im;
                img_cartajugada.BackgroundImageLayout = ImageLayout.Stretch;

            }
            else
            {
                btnmazo.BackgroundImage = Image.FromFile("Baraja\\vacia.png");
            }
            ContadorCartasJugadores();

        }


        public void ContadorCartasJugadores()
        {
            foreach (var jugador in partida.Jugadores)
            {
                int cantcartas = jugador.monton.Count;
                int indice = partida.Jugadores.FindIndex(jug => jug == jugador);
                etiquetascantcartas[indice].Text = cantcartas.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            partida.Cartasjugadas.Add(partida.Jugadores[0].monton[0]);
            partida.Cartasjugadas.Add(partida.Jugadores[1].monton[0]);
            partida.Cartasjugadas.Add(partida.Jugadores[2].monton[0]);
            partida.Cartasjugadas.Add(partida.Jugadores[3].monton[0]);


            Console.WriteLine("Cartas Jugadas");
            foreach (var carta in partida.Cartasjugadas)
            {
                Console.WriteLine(carta.Palo + carta.Numero);
            }

            partida.Juego.CompararCartas(partida);

        }
    }
}
