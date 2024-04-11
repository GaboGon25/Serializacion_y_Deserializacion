using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion_y_Deserializacion
{
    public class Persona
    {
        public int Cuenta { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public decimal Saldo { get; set; }

        public Persona() : this(0, string.Empty, string.Empty, 0M) { }


        public Persona(int cuenta, string primerNombre, string primerApellido, decimal saldo)
        {
            Cuenta = cuenta;
            PrimerNombre = primerNombre;
            PrimerApellido = primerApellido;
            Saldo = saldo;
        }

    }
}
