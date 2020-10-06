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
    public partial class iniciosesion : Form
    {
        public iniciosesion()
        {
            InitializeComponent();
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();

            Registro registro = new Registro();
            registro.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioCi = textBox1.Text;
            string contrasenia = textBox2.Text;
            //Obtenemos los datos de los campos de texto

            textBox2.Text = "";

            Cursor.Current = Cursors.WaitCursor;
            this.Enabled = false;
            //Cambiamos el cursor al 'reloj de espera'
            // y deshabilitamos la ventana

            Usuario usuario = new Usuario(usuarioCi);
            Sesion nuevaSesion = usuario.IniciarSesion(contrasenia);
            //Creamos un objeto usuario para iniciar la sesión

            if (nuevaSesion.Estado.StartsWith("Error"))
            {
                MessageBox.Show(nuevaSesion.Estado);
            }
            else
            {
                MessageBox.Show("Hola, " + usuario.Nombre);
                MenuPrincipal NuevaVentana = new MenuPrincipal();
                NuevaVentana.Show();
                this.Enabled = true;
                this.Hide();
            }
        }


        private void btn_ajustes_Click(object sender, EventArgs e)
        {
            Ajustes ajustes = new Ajustes();
            ajustes.ShowDialog();
        }

        private void iniciosesion_Load(object sender, EventArgs e)
        {

        }
    }
}
    

