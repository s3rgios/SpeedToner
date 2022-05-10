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

namespace ProyectoFinalDueño
{
    public partial class FormaGraficaAguas : Form
    {
        SqlConnection conexion = new SqlConnection("Server=localhost;DataBase=VendedorAmbulante; Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        public FormaGraficaAguas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaGraficaAguas_Load(object sender, EventArgs e)
        {
            TMActualizar.Start();
            GraficaAguaMasVendida();
            MostrarTotalVentas();
        }
        ArrayList Sabor = new ArrayList();
        ArrayList Cantidad = new ArrayList();

        public void GraficaAguaMasVendida()
        {
            cmd = new SqlCommand("AguasMasVendidas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Sabor.Add(dr.GetString(0));
                Cantidad.Add(dr.GetInt32(1));
            }
            chartGraficaAguas.Series[0].Points.DataBindXY(Sabor, Cantidad);
            dr.Close();
            conexion.Close();
        }

        private void MostrarTotalVentas()
        {
            cmd = new SqlCommand("TotalVentas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter total = new SqlParameter("@TotalVenta", 0);
            total.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(total);
            conexion.Open();
            cmd.ExecuteNonQuery();
            lblCantidadVentasElotes.Text = "$"+ cmd.Parameters["@TotalVenta"].Value.ToString();
            conexion.Close();
        }

        private void chartGraficaAguas_Click(object sender, EventArgs e)
        {

        }

        private void TMActualizar_Tick(object sender, EventArgs e)
        {
            Sabor.Clear();
            Cantidad.Clear();
            lblCantidadVentasElotes.Text = "";
            GraficaAguaMasVendida();
            MostrarTotalVentas();
        }
    }
}
