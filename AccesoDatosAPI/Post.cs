using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosAPI
{
    public class Post
    {
        public int Idpost { get; set; }
        public int IdUsuarioPost { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Contenido { get; set; }
        public int CantidadComentarios { get; set; }
        public int CantidadLikes { get; set; }
        // public List<Comentario> Comentarios { get; set; }
        public string Nickname { get; set; }
    }
}
