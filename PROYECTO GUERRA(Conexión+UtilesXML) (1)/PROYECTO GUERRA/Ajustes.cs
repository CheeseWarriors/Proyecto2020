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
    public partial class Ajustes : Form
    {
        private UtilesXML utilesXML = new UtilesXML();
        //Objeto para leer los datos de configuración

        private readonly string archivoConfig = "configuracion.xml";
        //Archivo con los datos de configuración

        public Ajustes()
        {
            InitializeComponent();

            utilesXML.CrearXML(archivoConfig);

            textBox_IP.Text = LeerConfiguracion("IP");
            textBox_usuMySQL.Text = LeerConfiguracion("UsuarioMySQL");
            textBox_contraseña.Text = LeerConfiguracion("Contraseña");
            textBox_BdD.Text = LeerConfiguracion("BasedeDatos");

        }

        private string LeerConfiguracion(string configuracion)
        {
            string dato = utilesXML.LeerConfig(archivoConfig, configuracion);
            if (dato.StartsWith("Error:"))
            {
                MessageBox.Show(dato);
                dato = "";
            }
            return dato;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string[] datos = {
                "IP:" + textBox_IP.Text,
                "UsuarioMySQL:" + textBox_usuMySQL.Text,
                "BasedeDatos:" + textBox_BdD.Text,
                "Contraseña:" + textBox_contraseña.Text
            };

            string resultado = utilesXML.AgregarConfig(archivoConfig, datos);
            //Escribimos los datos en el archivo de configuración

            MessageBox.Show(resultado);
            //Mostramos en pantalla el resultado de la operación

            this.Close();
            this.Dispose();

        }
    }
}
