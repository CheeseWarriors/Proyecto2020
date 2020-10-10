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
    public partial class Jugar : Form
    {
        public Jugar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reglas NuevaVentana = new Reglas();
            NuevaVentana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal NuevaVentana = new MenuPrincipal();
            NuevaVentana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPartida NuevaVentana = new VentanaPartida();
            NuevaVentana.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal NuevaVentana = new MenuPrincipal();
            NuevaVentana.Show();
        }
    }
}
