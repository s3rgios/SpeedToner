using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using static System.Windows.Forms.Timer;

namespace ProyectoFinalDueño
{
    public partial class FormaGraficaFrutas : Form
    {
        SqlConnection conexion = new SqlConnection("Server=localhost;DataBase=VendedorAmbulante; Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        public FormaGraficaFrutas()
        {
            InitializeComponent();
        }

            private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaGraficaFrutas_Load(object sender, EventArgs e)
        {
            TMActualizar.Start();
            MostrarGraficaFrutas();
            MostrarVentasTotalesFrutas();
        }

        ArrayList Nombre = new ArrayList();
        ArrayList Cantidad = new ArrayList();

        private void MostrarGraficaFrutas()
        {
            cmd = new SqlCommand("FrutaMasVendida", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Nombre.Add(dr.GetString(0));
                Cantidad.Add(dr.GetInt32(1));
            }
            chartGraficaFrutas.Series[0].Points.DataBindXY(Nombre, Cantidad);
            dr.Close();
            conexion.Close();
        }

        private void MostrarVentasTotalesFrutas()
        {
            cmd = new SqlCommand("TotalVentasFrutas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter total = new SqlParameter("@TotalVentasFrutas", 0);
            total.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(total);
            conexion.Open();
            cmd.ExecuteNonQuery();
            lblCantidadVentasFrutas.Text = "$"+ cmd.Parameters["@TotalVentasFrutas"].Value.ToString();
            conexion.Close();
        }

        private void TMActualizar_Tick(object sender, EventArgs e)
        {
            Nombre.Clear();
            Cantidad.Clear();
            lblCantidadVentasFrutas.Text = "";
            MostrarGraficaFrutas();
            MostrarVentasTotalesFrutas();
        }
    }
}
