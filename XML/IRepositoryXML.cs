using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion_y_Deserializacion
{
    public interface IRepositoryXML
    {
        void Serializar(List<Persona> personas, string rutaArchivo);
        List<Persona> Deserializar(string rutaArchivo);
    }
}
