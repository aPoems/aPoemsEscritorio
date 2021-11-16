using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosAPI
{
    class SolicitudRegistroUsuario
    {
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Nickname { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
