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
            Partida NuevaVentana = new Partida();
            NuevaVentana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Jugar Partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                JugandoPartidade4 NuevaVentana = new JugandoPartidade4();
                NuevaVentana.Show();

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
