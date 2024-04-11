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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            frmXML frmXML = new frmXML();
            frmXML.ShowDialog();
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            frmJSON frmJSON = new frmJSON();
            frmJSON.ShowDialog();
        }
    }
}
