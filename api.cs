using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace practica_crud
{
    class api
    {
        public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create("https://www.ensenanzaweb.com/test/get.php");
            WebResponse rResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(rResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }



        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result;

            try
            {
                //string oReply;

                JavaScriptSerializer js = new JavaScriptSerializer();


                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                //request.Timeout = 10000; //esto es opcional

                //se escribre el json en estructura para el body
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                //SearchOption realiza el envio y se recibe una respuesta de  el servicio
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;

        }
        public string postMetodo(string url, string _nombre, string _apellido, string _correo, string _contrasena, string method = "POST")
        {
            string result = null;


            var request = WebRequest.Create(url);
            request.Method = method;
            request.ContentType = "application/json; charset=utf-8";
            using (var writer = new StreamWriter(request.GetRequestStream()))
            {
                var serializer = new JavaScriptSerializer();
                var payload = serializer.Serialize(new
                {
                    nombre = _nombre,
                    apellido = _apellido,
                    correo = _correo,
                    contrasena = _contrasena
                });
                writer.Write(payload);
                writer.Flush();
                writer.Close();
            }
            //using (var response = (HttpWebResponse)request.GetResponse())

            using (var response = request.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
                // do something with the results
            }


            return result;
        }
        public string PostMetodo(string url, string _nombre, string _apellido, string _correo, string _contrasena, string method = "POST")
        {
            string result = null;

            try
            {



            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        public async void POSTreq(string url, string _nombre, string _apellido, string _correo, string _contrasena)
        {
            Uri requestUri = new Uri(url); //replace your Url  
            dynamic dynamicJson = new ExpandoObject();
            dynamicJson.nombre = _nombre.ToString();
            dynamicJson.apellido = _apellido.ToString();
            dynamicJson.correo = _correo.ToString();
            dynamicJson.contrasena = _contrasena.ToString();
            //dynamicJson.password = "9442921025";
            string json = "";
            json = Newtonsoft.Json.JsonConvert.SerializeObject(dynamicJson);
            var objClint = new System.Net.Http.HttpClient();
            System.Net.Http.HttpResponseMessage respon = await objClint.PostAsync(requestUri, new StringContent(json, System.Text.Encoding.UTF8, "application/json"));
            string responJsonText = await respon.Content.ReadAsStringAsync();
            MessageBox.Show(responJsonText);
        }
        public string potCon<T>(string url, T objeto)
        {
            string result;

            JsonSerializerSettings configJson = new JsonSerializerSettings();//evitar que se serializen los nodos cuyo valor sea null
            configJson.NullValueHandling = NullValueHandling.Ignore;
            byte[] datoss = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(objeto, Formatting.None, configJson));

            HttpWebRequest Wreq = (HttpWebRequest)HttpWebRequest.Create(url);
            Wreq.ContentType = "application/json; charset=UTF-8";
            Wreq.ContentLength = datoss.Length;
            Wreq.Method = "POST";
            Wreq.GetRequestStream().Write(datoss, 0, datoss.Length);

            HttpWebResponse res = (HttpWebResponse)Wreq.GetResponse();
            Encoding codificacion = ASCIIEncoding.UTF8;

            StreamReader sreader = new StreamReader(res.GetResponseStream(), codificacion);

            return result = sreader.ReadToEnd();

        }
        public string Main<T>(string url, T objeto)
        {
            string resul;
            using (var client = new HttpClient())
            {
                //person p = new person { name = "Sourav", surname = "Kayal" };
                client.BaseAddress = new Uri(url);
                var response = client.PostAsJsonAsync("api/person", objeto).Result;
                if (response.IsSuccessStatusCode)
                {
                    resul = ("Success");
                    //Console.Write("Success");
                }
                else
                    //Console.Write("Error");
                    resul = ("Error");

            }
            return resul;
        }
    }
}
