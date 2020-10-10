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
    public partial class VentanaPartida : Form
    {
        public VentanaPartida()
        {
            InitializeComponent();
        }

        private void Partida_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crearpartida NuevaVentana = new Crearpartida ();
            NuevaVentana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jugar NuevaVentana = new Jugar();
            NuevaVentana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresarPartida NuevaVentana = new IngresarPartida();
            NuevaVentana.Show();
        }
    }
}
