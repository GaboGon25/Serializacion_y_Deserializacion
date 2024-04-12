using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion_y_Deserializacion
{
    public class PersonaRepositoryJSON : IRepositoryJSON
    {
        public List<Persona> DeserializarLista(string rutaArchivo)
        {
            var strJSON = OpenFilePersona(rutaArchivo);
            if (strJSON.Substring(0, 5) != "Falla ")
            {
                return JsonConvert.DeserializeObject<List<Persona>>(strJSON);
            }
            else
            {
                var lista = new List<Persona>();
                var persona = new Persona();
                persona.PrimerNombre = strJSON;
                lista.Add(persona);
                return lista;
            }
        }

        private string OpenFilePersona(string rutaArchivo)
        {
            try
            {
                var strJSON = "";
                using (var fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
                {
                    using (var sr = new StreamReader(fs))
                    {
                        strJSON = sr.ReadToEnd();
                    }
                }
                return strJSON;
            }
            catch (Exception ex)
            {

                return "Falla: " + ex.Message;
            }
        }

        public void SerializarLista(List<Persona> personas, string rutaArchivo)
        {
            var strJson = JsonConvert.SerializeObject(personas, Formatting.Indented);
            SaveFilePersona(strJson, rutaArchivo);
        }

        private void SaveFilePersona(string strJson, string rutaArchivo)
        {
            try
            {
                using (var fs = new FileStream(rutaArchivo, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(strJson);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Falla: " + ex.Message);
            }
        }
    }
}
