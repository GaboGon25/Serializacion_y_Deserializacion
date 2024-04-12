using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serializacion_y_Deserializacion
{
    public partial class frmXML : Form
    {
        List<Persona> personas = new List<Persona>();
        public frmXML()
        {
            InitializeComponent();
        }

        Validaciones validar = new Validaciones();
        private void btnInsertarXML_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Cuenta = Convert.ToInt32(txtCuenta.Text);
            persona.PrimerNombre = txtPrimerNombre.Text;
            persona.PrimerApellido = txtPrimerApellido.Text;
            persona.Saldo = Convert.ToDecimal(txtSaldo.Text);

            personas.Add(persona);

            dgvXML.DataSource = null;
            dgvXML.DataSource = personas;
            btnSerializarXML.Enabled = true;

            // Metodo para limpiar
            foreach (Control guiControl in Controls)
            {
                (guiControl as TextBox)?.Clear();
            }
            txtCuenta.Focus();


        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvXML.Rows)
            {
                personas.Add(new Persona
                {
                    Cuenta = Convert.ToInt32(row.Cells["Cuenta"].Value),
                    PrimerNombre = row.Cells["PrimerNombre"].Value.ToString(),
                    PrimerApellido = row.Cells["PrimerApellido"].Value.ToString(),
                    Saldo = Convert.ToDecimal(row.Cells["Saldo"].Value)

                });
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
            using (var writer = new StreamWriter("Personas.xml"))
            {
                serializer.Serialize(writer, personas);
            }
            MessageBox.Show("Datos serializados correctamente", string.Empty,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDeserializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                XMLObjectS serializer = new XMLObjectS();
                personas = serializer.Deserializar("Personas.xml");
                dgvXML.DataSource = personas;
                MessageBox.Show("Datos deserializados correctamente", string.Empty,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"ERROR AL DESERIALIZAR: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumero(sender, e);
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarLetra(sender, e);
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarLetra(sender, e);
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumero(sender, e);
        }
    }
}
