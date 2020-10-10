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
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jugar NuevaVentana = new Jugar();
            NuevaVentana.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil NuevaVentana = new Perfil();
            NuevaVentana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chat NuevaVentana = new Chat();
            NuevaVentana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Soporte NuevaVentana = new Soporte();
            NuevaVentana.Show();
        }

        private void button5_Click(object sender, EventArgs e)

        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Iniciosesion NuevaVentana = new Iniciosesion();
                NuevaVentana.Show();

            }

            else if (DialogResult == DialogResult.No)
            {
                // Nothing
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Créditos NuevaVentana = new Créditos();
            NuevaVentana.Show();
        }
    }
    }
