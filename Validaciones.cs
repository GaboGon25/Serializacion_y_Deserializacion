using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion_y_Deserializacion
{
    public class Validaciones
    {
        public void ValidarLetra(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Esto evita que se ingrese el dígito.
                MessageBox.Show("No se permiten números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Esto evita que se ingresen caracteres.
                MessageBox.Show("Solo se permiten letras en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
