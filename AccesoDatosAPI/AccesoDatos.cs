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
        public Usuario usuarioActual = new Usuario();
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

                usuarioActual.IdUsuario = resp.IdUsuarioInicioSesion;
                return resp.Resultado == true ? "Inicio correcto" : "Correo o contraseña incorrecta";
            }
            catch(Exception e)
            {
                return "Error"+e.ToString();
            }
        }
        public List<Post> ConsultarPosts()
        {
            SolicitudVerPost req = new SolicitudVerPost();

            string url = $"http://localhost:65004/api/VerPost";

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
                RespuestaVerPost resp = JsonConvert.DeserializeObject<RespuestaVerPost>(respuesta);

                return resp.Resultado;
            }
            catch
            {
                List<Post> PostsVacios = new List<Post>();
                PostsVacios.Add(new Post());
                return PostsVacios;
            }
        }

        public string PublicarPost(string contenido)
        {
            SolicitudPublicarPost req = new SolicitudPublicarPost();
            req.Contenido = contenido;
            req.IdUsuario = usuarioActual.IdUsuario;

            string url = $"http://localhost:65004/api/PublicarPost";

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

                return resp.Resultado == true ? "Post publicado" : "Error en la publicacion";
            }
            catch(Exception e)
            {
                return "Error" + e.ToString();
            }
        }
        public string LikePost(int idPost)
        {
            SolicitudLikePost req = new SolicitudLikePost();
            req.IdPost = idPost;

            string url = $"http://localhost:65004/api/LikePost";

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
                RespuestaLikePost resp = JsonConvert.DeserializeObject<RespuestaLikePost>(respuesta);

                return resp.Respuesta;
            }
            catch (Exception e)
            {
                return "Error" + e.ToString();
            }
        }
        public string ComentarPost(int idPost, string contenido)
        {
            SolicitudComentarPost req = new SolicitudComentarPost();
            req.IdPost = idPost;
            req.IdUsuarioComentario = usuarioActual.IdUsuario;
            req.Contenido = contenido;

            string url = $"http://localhost:65004/api/ComentarPost";

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

                return resp.Resultado == true ? "Comentario publicado" : "Error en la publicacion";
            }
            catch (Exception e)
            {
                return "Error" + e.ToString();
            }
        }

        public List<Comentario> VerComentarios(int idPost)
        {
            SolicitudVerComentarios req = new SolicitudVerComentarios();
            req.IdPost = idPost;

            string url = $"http://localhost:65004/api/VerComentarios";

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
                RespuestaVerComentarios resp = JsonConvert.DeserializeObject<RespuestaVerComentarios>(respuesta);

                return resp.Resultado;
            }
            catch (Exception e)
            {
                return new List<Comentario>();
            }
        }
    }
}
