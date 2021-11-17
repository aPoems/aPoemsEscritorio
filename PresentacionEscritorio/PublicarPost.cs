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
    public partial class PublicarPost : Form
    {
        public int IdUsuario;
        public PublicarPost()
        {
            InitializeComponent();
        }

        private void btnPublicarPost_Click(object sender, EventArgs e)
        {
            AccesoDatos accesoDatosAPI = new AccesoDatos();
            accesoDatosAPI.usuarioActual.IdUsuario = IdUsuario;
            string mensaje = accesoDatosAPI.PublicarPost(txtContenido.Text);
            MessageBox.Show(mensaje);            
            this.Close();
        }
    }
}
