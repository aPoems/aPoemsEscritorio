using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosAPI
{
    public class Comentario
    {
        public int IdComentario { get; set; }
        public int IdPost { get; set; }
        public int IdUsuarioComentario { get; set; }
        public DateTime Publicacion { get; set; }
        public string Contenido { get; set; }
        public string Nickname { get; set; }
    }
}
