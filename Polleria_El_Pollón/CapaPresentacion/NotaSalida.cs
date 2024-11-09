using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class NotaSalida : System.Windows.Forms.Form
    {
        public NotaSalida()
        {
            InitializeComponent();
        }

        private void btnAnularNotaSalida_Click(object sender, EventArgs e)
        {
            Form formulario = new AnularNotaSalida();
            formulario.Show();
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
