using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacion_y_Deserializacion
{
    public class XMLObjectS : IRepositoryXML
    {
        public List<Persona> Deserializar(string rutaArchivo)
        {
            List<Persona> listPersonas;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));

            using (var reader = new StreamReader(rutaArchivo))
            {
                listPersonas = (List<Persona>)serializer.Deserialize(reader);
            }
            return listPersonas;
        }

        public void Serializar(List<Persona> personas, string rutaArchivo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<>));
            using (var writer = new StreamWriter(rutaArchivo))
            {
                serializer.Serialize(writer, personas);
            }
        }
    }
}
