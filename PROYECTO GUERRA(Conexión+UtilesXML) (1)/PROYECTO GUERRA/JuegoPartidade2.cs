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
    public partial class JuegoPartidade2 : Form
    {
        Baraja baraja = new Baraja();
        Carta cartaJugada = null;


        public JuegoPartidade2()
        {
            InitializeComponent();
            baraja.Barajar_nuevo();
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

        private void btnmazo2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(baraja.baraja.Count.ToString());
            if (baraja.baraja.Count > 0)
            {
                cartaJugada = baraja.baraja[0];
                baraja.baraja.Remove(cartaJugada);

                String archivo = cartaJugada.InfoImagen();
                Console.WriteLine(archivo);
                Image im = Image.FromFile(archivo);
                img_cartajugada2.Image = im;
                img_cartajugada2.BackgroundImageLayout = ImageLayout.Stretch;

            }
            else
            {
                btnmazo2.BackgroundImage = Image.FromFile("Baraja\\vacia.png");
            }
            lbl_cantcartas2.Text = baraja.baraja.Count.ToString();
        }
    }
}
