using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionEscritorio
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Show();            
        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrarme registrarme = new Registrarme();
            registrarme.Show();            
        }

        private void Bienvenida_Activated(object sender, EventArgs e)
        {
            
        }

        private void Bienvenida_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
