using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ProyectoFinalDueño
{
    public partial class FormaMenu : Form
    {
        public FormaMenu()
        {
            InitializeComponent();
        }
        //codigo de libreria  Runtime para mover el diseño del programa
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //funcion para abrir formas en panel
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 70)
            {
                MenuVertical.Width = 250;
            }
            else
            {
                MenuVertical.Width = 70;
            }
        }

        private void IconoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IconoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconoRestaurar.Visible = false;
            IconoMaximizar.Visible = true;
        }

        private void IconoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoRestaurar.Visible = true;
            IconoMaximizar.Visible = false;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGraficaFrutas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormaGraficaFrutas());
        }

        private void btnGraficaElotes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormaGraficaElotes());
        }

        private void btnGraficaAguas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormaGraficaAguas());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
