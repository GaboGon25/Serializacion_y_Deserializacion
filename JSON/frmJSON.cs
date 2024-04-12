using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializacion_y_Deserializacion
{
    public partial class frmJSON : Form
    {
        List<Persona> personas = new List<Persona>();
        public frmJSON()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        private void btnInsertarJSON_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Cuenta = Convert.ToInt32(txtCuenta.Text);
            persona.PrimerNombre = txtPrimerNombre.Text;
            persona.PrimerApellido = txtPrimerApellido.Text;
            persona.Saldo = Convert.ToDecimal(txtSaldo.Text);

            personas.Add(persona);

            dgvJSON.DataSource = null;
            dgvJSON.DataSource = personas;

            btnSerializarJSON.Enabled = true;
            // Metodo para limpiar
            foreach (Control guiControl in Controls)
            {
                (guiControl as TextBox)?.Clear();
            }
            txtCuenta.Focus();
        }

        private void btnSerializarJSON_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;

            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Nombre de archivo inválido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var personaRepositoryJSON = new PersonaRepositoryJSON();
                        personaRepositoryJSON.SerializarLista(personas, fileName);

                        btnSerializarJSON.Enabled = false;
                        btnInsertarJSON.Enabled = true;

                        MessageBox.Show("Archivo serializado correctamente", string.Empty,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeserializarJSON_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                foreach (Control guiControl in Controls)
                {
                    (guiControl as TextBox)?.Clear();
                }

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Nombre de archivo inválido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var personaRepositoryJSON = new PersonaRepositoryJSON();
                        personas = personaRepositoryJSON.DeserializarLista(fileName);

                        dgvJSON.DataSource = personas;

                        btnDeserializarJSON.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error de archivo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            MessageBox.Show("Archivo deserializado correctamente", string.Empty,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

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

