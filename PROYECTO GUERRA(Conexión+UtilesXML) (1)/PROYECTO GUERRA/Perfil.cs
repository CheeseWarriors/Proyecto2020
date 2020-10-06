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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal NuevaVentana = new MenuPrincipal();
            NuevaVentana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregaramigos NuevaVentana = new Agregaramigos();
            NuevaVentana.Show();
        }
    }
}
