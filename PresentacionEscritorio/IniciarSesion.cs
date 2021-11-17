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
        public Usuario usuarioActual = new Usuario();
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
                usuarioActual.IdUsuario = accesoDatos.usuarioActual.IdUsuario;
                Principal principal = new Principal();
                principal.UsuarioActual = usuarioActual;
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
