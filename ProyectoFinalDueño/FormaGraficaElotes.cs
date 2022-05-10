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
    public partial class FormaGraficaElotes : Form
    {
        SqlConnection conexion = new SqlConnection("Server=localhost;DataBase=VendedorAmbulante; Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        public FormaGraficaElotes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaGraficaElotes_Load(object sender, EventArgs e)
        {
            TMActualizar.Start();
            GraficaElotesMasVendidos();
            MostrarVentasElotes();
        }

        ArrayList TipoElote = new ArrayList();
        ArrayList Cantidad = new ArrayList();
        private void GraficaElotesMasVendidos()
        {
            cmd = new SqlCommand("EloteMasVendido", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                TipoElote.Add(dr.GetString(0));
                Cantidad.Add(dr.GetInt32(1));
            }
            charGraficaElotes.Series[0].Points.DataBindXY(TipoElote, Cantidad);
            dr.Close();
            conexion.Close();
        }

        private void MostrarVentasElotes()
        {
            cmd = new SqlCommand("TotalVentasElotes", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter total = new SqlParameter("@TotalVentaElotes", 0);
            total.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(total);
            conexion.Open();
            cmd.ExecuteNonQuery();
            lblCantidadVentasElotes.Text = "$" + cmd.Parameters["@TotalVentaElotes"].Value.ToString();
            conexion.Close();
        }

        private void TMActualizar_Tick(object sender, EventArgs e)
        {
            TipoElote.Clear();
            Cantidad.Clear();
            lblCantidadVentasElotes.Text = "";
            GraficaElotesMasVendidos();
            MostrarVentasElotes();
        }
    }
}
