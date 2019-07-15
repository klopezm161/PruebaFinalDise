using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace MulticentroProyectoFinal
{
    public partial class ServiciosBusqueda : Form
    {
        public ServiciosBusqueda()
        {
            InitializeComponent();
            conexion = new ConexionesBasicasAbrirCerrarBD();
        }
        private IConexionesBasicasAbrirCerrarBD conexion;
        //DataSet dbdataset;
        public string getNombre()
        {
            return txtNombreBusquedaServicio.Text;
        }

        public string getCodigo()
        {
            return txtCodigoBusquedaServicio.Text;
        }
        private void BtnSalirEnBusquedaServicio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalEnBusquedaServicio_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void ServiciosBusqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtNombreBusquedaServicio_TextChanged(object sender, EventArgs e)
        {
            //ServiciosBusquedaBD busqueda = new ServiciosBusquedaBD();
            //busqueda.Buscar();
            //DataTable dt = new DataTable();
            //busqueda.getSqlAdaptador().Fill(dt);
            //dGVBusquedaServicio.DataSource = dt;

            //conexion.AbrirConexion();
            //string query = @"SELECT * FROM dbo.servicio where nombre like'" + txtNombreBusquedaServicio.Text + "%'";
            //SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.GetSqlConnection());
            //DataTable dt = new DataTable();
            //adaptador.Fill(dt);
            //dGVBusquedaServicio.DataSource = dt;
            //conexion.CerrarConexion();
        }

        private void TxtCodigoBusquedaServicio_TextChanged(object sender, EventArgs e)
        {
          

            //conexion.AbrirConexion();
            //string query = @"SELECT * FROM dbo.servicio where codigoservicio like'" + int.Parse(txtCodigoBusquedaServicio.Text) + "%'";
            //SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion.GetSqlConnection());
            //DataTable dt = new DataTable();
            //adaptador.Fill(dt);
            //dGVBusquedaServicio.DataSource = dt;

            //conexion.CerrarConexion();
            // txtCodigoBusquedaServicio.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiciosBusquedaBD busqueda = new ServiciosBusquedaBD();
                busqueda.Buscar();
                DataTable dt = new DataTable();
                busqueda.getSqlAdaptador().Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dGVBusquedaServicio.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontró el servicio. Inténtelo de nuevo");
                }
            }
            catch(System.NullReferenceException ex)
            {
               // MessageBox.Show("No se seleccionó un dato correcto, no hay nada que mostrar.");
            }
            txtCodigoBusquedaServicio.Clear();
            txtNombreBusquedaServicio.Clear();
        }
    }
}
