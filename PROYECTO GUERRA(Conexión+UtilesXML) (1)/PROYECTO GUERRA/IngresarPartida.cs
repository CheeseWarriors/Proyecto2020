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
    public partial class IngresarPartida : Form
    {
        public IngresarPartida()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPartida NuevaVentana = new VentanaPartida();
            NuevaVentana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Jugar Partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Usuario J1 = new Usuario("1");
                Usuario J2 = new Usuario("1");
                Usuario J3 = new Usuario("1");
                Usuario J4 = new Usuario("1");

                List<Usuario> jugadores = new List<Usuario>();
                jugadores.Add(J1);
                jugadores.Add(J2);
                jugadores.Add(J3);
                jugadores.Add(J4);

                JugandoPartidade4 NuevaVentana = new JugandoPartidade4(jugadores);
                NuevaVentana.Show();
                this.Close();

            }

            else if (DialogResult == DialogResult.No)
            {
                // Nothing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Jugar Partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Jugandopartidade3 NuevaVentana = new Jugandopartidade3();
                NuevaVentana.Show();

            }

            else if (DialogResult == DialogResult.No)
            {
                // Nothing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Jugar Partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                JuegoPartidade2 NuevaVentana = new JuegoPartidade2();
                NuevaVentana.Show();

            }

            else if (DialogResult == DialogResult.No)
            {
                // Nothing
            }
        }
    }
}
