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
    public partial class Registrarme : Form
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public Registrarme()
        {
            InitializeComponent();
        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            string respuesta = accesoDatos.RegistrarUsuario(txtCorreo.Text, txtContraseña.Text, txtNickname.Text, dtFechaNacimiento.Value);
            MessageBox.Show(respuesta);
            this.Close();
            Program.bienvenida.Show();                      
        }

        private void Registrarme_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
