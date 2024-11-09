using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ADMINISTRADOR2 : Form
    {
        public ADMINISTRADOR2()
        {
            InitializeComponent();
        }
        #region FuncionesBarra
        private void ptnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ptnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptnMax.Visible = false;
            ptnMin.Visible = true;
        }

        private void ptnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptnMin.Visible = false;
            ptnMax.Visible = true;
        }
        private void ptnBack_Click(object sender, EventArgs e)
        {
            InicioSesion form = new InicioSesion();
            Hide();
            form.ShowDialog();
            Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion


        private void AbrirForm<Formulario>() where Formulario : Form, new()
        {
            Form formulario;
            formulario = panelEscritorio.Controls.OfType<Formulario>().FirstOrDefault();//Busca el fomulario
            //Busca un formulario inexistente
            if (formulario == null)
            {
                formulario = new Formulario();
                formulario.TopLevel = false;
                //formulario.AutoSize = true; // Permite que el formulario se ajuste a su tamaño preferido
                //formulario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.AutoScroll = true;
                panelEscritorio.Controls.Add(formulario);
                formulario.Dock = DockStyle.None; // Evita que se extienda en el panel
                formulario.Location = new Point(
                    (panelEscritorio.Width - formulario.Width) / 2,
                    (panelEscritorio.Height - formulario.Height) / 2
                );
                //formulario.Dock = DockStyle.Fill;
                panelEscritorio.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CerrarForm);
                
            }
            //En caso exista lo traemos al frente
            else
            {
                formulario.BringToFront();
            }
        }
        //metodo para cuando se cierren los formulario
        private void CerrarForm(object sender, FormClosedEventArgs e)//250; 163; 7
        {
            if (Application.OpenForms["FormRegistroUsuario"] == null)
                btnRegistrarUsuario.BackColor = Color.FromArgb(255, 205, 92, 92);
            if (Application.OpenForms["NotaIngreso"] == null && Application.OpenForms["NotaSalida"] == null && Application.OpenForms["Provedor"] == null && Application.OpenForms["Insumo"] == null && Application.OpenForms["TipoInsumo"] == null)
            {
                btnAlmacen.BackColor = Color.FromArgb(255, 205, 92, 92);
            }
            if (Application.OpenForms["NotaIngreso"] == null && Application.OpenForms["NotaSalida"] == null && Application.OpenForms["NotaSalida"] == null
                && Application.OpenForms["Provedor"] == null)
            {
                btnProduccion.BackColor = Color.FromArgb(255, 205, 92, 92);
            }
            if (Application.OpenForms["NotaVenta"] == null && Application.OpenForms["Cliente"] == null && Application.OpenForms["Pago"] == null
                && Application.OpenForms["MetodoPago"] == null)
            {
                btnVentas1.BackColor = Color.FromArgb(255, 205, 92, 92);
            }

        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            subAlmacen.Visible = true;
            btnAlmacen.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            subProduccion.Visible = true;
            btnProduccion.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void panelBARRA_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            subAlmacen.Visible = false;
            AbrirForm<NotaIngreso>();
        }

        private void btnNotaSalida_Click(object sender, EventArgs e)
        {
            subAlmacen.Visible = false;
            AbrirForm<NotaSalida>();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            subAlmacen.Visible = false;
            AbrirForm<Provedor>();
        }

        private void btnInsumo_Click(object sender, EventArgs e)
        {
            subAlmacen.Visible = false;
            AbrirForm<Insumo>();
        }

        private void btnTipoInsumo_Click(object sender, EventArgs e)
        {
            subAlmacen.Visible = false;
            AbrirForm<TipoInsumo>();
        }

        
        private void btnNotaVenta_Click(object sender, EventArgs e)
        {
            SubVentas.Visible = false;
            AbrirForm<NotaVenta>();
        }

        private void btnVentas1_Click(object sender, EventArgs e)
        {
            SubVentas.Visible = true;
            btnVentas1.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnPlato_Click(object sender, EventArgs e)
        {
            subProduccion.Visible = false;
            AbrirForm<Plato>();
        }

        private void btnTipoPlato_Click(object sender, EventArgs e)
        {
            subProduccion.Visible = false;
            AbrirForm<TipoPlato>();
        }

        private void btnCategoriaMetodoPago_Click(object sender, EventArgs e)
        {
            SubVentas.Visible = false;
            AbrirForm<CategoriaMetodoPago>();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            SubVentas.Visible = false;
            AbrirForm<Pago>();
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            SubVentas.Visible = false;
            AbrirForm<MetodoPago>();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            SubVentas.Visible = false;
            AbrirForm<Cliente>();
        }
    }
}
