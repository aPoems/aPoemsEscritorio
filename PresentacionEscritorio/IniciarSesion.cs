using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosAPI;

namespace PresentacionEscritorio
{
    public partial class IniciarSesion : Form
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string respuesta = accesoDatos.IniciarSesion(txtCorreo.Text, txtContraseña.Text);
            MessageBox.Show(respuesta);

            if(respuesta == "Inicio correcto")
            {
                Principal principal = new Principal();
                this.Close();
                principal.Show();
            }
            else
            {
                this.Close();
                Program.bienvenida.Show();
            }
        }
    }
}
