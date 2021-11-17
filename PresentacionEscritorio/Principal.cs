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
    public partial class Principal : Form
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public Usuario UsuarioActual = new Usuario();
        List<Post> Posts;
        int postSeleccionadoComentar;
        public Principal()
        {
            InitializeComponent();
        }

        private void ActualizarPost()
        {
            Posts = accesoDatos.ConsultarPosts();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Nickname", typeof(string));
            dataTable.Columns.Add("FechaPublicacion", typeof(DateTime));
            dataTable.Columns.Add("Contenido", typeof(string));
            dataTable.Columns.Add("CantidadLikes", typeof(int));
            dataTable.Columns.Add("CantidadComentarios", typeof(int));

            foreach (Post p in Posts)
            {
                DataRow row = dataTable.NewRow();

                row[0] = p.Nickname;
                row[1] = p.FechaPublicacion;
                row[2] = p.Contenido;
                row[3] = p.CantidadLikes;
                row[4] = p.CantidadComentarios;

                dataTable.Rows.Add(row);
            }
            dgvPosts.DataSource = dataTable;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            ActualizarPost();
        }

        private void btnPublicarPost_Click(object sender, EventArgs e)
        {
            PublicarPost publicarPost = new PublicarPost();
            publicarPost.IdUsuario = UsuarioActual.IdUsuario;
            publicarPost.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarPost();
        }

        private void btnDarLike_Click(object sender, EventArgs e)
        {
            int postSeleccionado;
            if (dgvPosts.SelectedRows.Count > 0)
            {
                postSeleccionado = dgvPosts.CurrentRow.Index;
                string repuesta = accesoDatos.LikePost(Posts[postSeleccionado].Idpost);
                ActualizarPost();
            }
            else
            {
                MessageBox.Show("Seleccione un Post");
            }
        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            
            if (dgvPosts.SelectedRows.Count > 0)
            {
                postSeleccionadoComentar = dgvPosts.CurrentRow.Index;
                txtComentario.Visible = true;
                btnPublicarComentario.Visible = true;                
            }
            else
            {
                MessageBox.Show("Seleccione un Post");
            }
        }

        private void btnPublicarComentario_Click(object sender, EventArgs e)
        {
            accesoDatos.usuarioActual.IdUsuario = UsuarioActual.IdUsuario;
            string repuesta = accesoDatos.ComentarPost(Posts[postSeleccionadoComentar].Idpost, txtComentario.Text);
            MessageBox.Show(repuesta);
            txtComentario.Visible = false;
            btnPublicarComentario.Visible = false;
            ActualizarPost();
        }

        private void ActualizarComentarios(int idPost)
        {
            List<Comentario> comentarios = accesoDatos.VerComentarios(idPost);
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Nickname", typeof(string));
            dataTable.Columns.Add("FechaPublicacion", typeof(DateTime));
            dataTable.Columns.Add("Contenido", typeof(string));

            foreach (Comentario c in comentarios)
            {
                DataRow row = dataTable.NewRow();

                row[0] = c.Nickname;
                row[1] = c.Publicacion;
                row[2] = c.Contenido;

                dataTable.Rows.Add(row);
            }
            dgvComentarios.DataSource = dataTable;
        }

        private void btnVerComentarios_Click(object sender, EventArgs e)
        {
            if (dgvPosts.SelectedRows.Count > 0)
            {
                int postSeleccionadoComentarios = dgvPosts.CurrentRow.Index;
                ActualizarComentarios(Posts[postSeleccionadoComentarios].Idpost);
            }
            else
            {
                MessageBox.Show("Seleccione un Post");
            }
        }
    }
}
