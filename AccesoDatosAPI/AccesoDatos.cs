using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace AccesoDatosAPI
{
    public class AccesoDatos
    {
        public string RegistrarUsuario(string correo, string contraseña, string nickname, DateTime fechaNacimiento)
        {
            SolicitudRegistroUsuario req = new SolicitudRegistroUsuario();
            req.Correo = correo;
            req.Contraseña = contraseña;
            req.Nickname = nickname;
            req.FechaNacimiento = fechaNacimiento;

            string url = $"http://localhost:65004/api/RegistrarUsuario";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            string jsonAEnviar = JsonConvert.SerializeObject(req);

            var streamWriter = new StreamWriter(request.GetRequestStream());
            streamWriter.Write(jsonAEnviar);
            streamWriter.Flush();
            streamWriter.Close();

            try
            {
                WebResponse response = request.GetResponse();
                Stream streamReader = response.GetResponseStream();
                StreamReader objReader = new StreamReader(streamReader);

                string respuesta = objReader.ReadToEnd();
                RespuestaBool resp = JsonConvert.DeserializeObject<RespuestaBool>(respuesta);

                return resp.Resultado == true ? "Registro exitoso" : "No se realizo el registro";
            }
            catch
            {
                return "Error";
            }

        }

        public string IniciarSesion(string correo, string contraseña)
        {
            SolicitudIniciarSesion req = new SolicitudIniciarSesion();
            req.Correo = correo;
            req.Contraseña = contraseña;

            string url = $"http://localhost:65004/api/IniciarSesion";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            string jsonAEnviar = JsonConvert.SerializeObject(req);

            var streamWriter = new StreamWriter(request.GetRequestStream());
            streamWriter.Write(jsonAEnviar);
            streamWriter.Flush();
            streamWriter.Close();

            try
            {
                WebResponse response = request.GetResponse();
                Stream streamReader = response.GetResponseStream();
                StreamReader objReader = new StreamReader(streamReader);

                string respuesta = objReader.ReadToEnd();
                RespuestaBool resp = JsonConvert.DeserializeObject<RespuestaBool>(respuesta);

                return resp.Resultado == true ? "Inicio correcto" : "Correo o contraseña incorrecta";
            }
            catch(Exception e)
            {
                return "Error"+e.ToString();
            }

        }
    }
}
