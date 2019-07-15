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
    public partial class ServiciosIngreso : Form
    {
        public ServiciosIngreso()
        {
            InitializeComponent();
            //conexion = new ConexionesBasicasAbrirCerrarBD();
        }

        // private IConexionesBasicasAbrirCerrarBD conexion;

        public string getNombre()
        {
            return txtNombreServicioIngreso.Text;
        }

        public string getCodigo()
        {
            return txtCodigoServicioIngreso.Text;

        }

        public string getPrecio()
        {
            return txtPrecioServicioIngreso.Text;
        }

        private void ServiciosIngreso_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalirServicioIngreso_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalEnServicioIngreso_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();

        }

        private void ServiciosIngreso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAceptarServicioIngreso_Click(object sender, EventArgs e)
        {

            //conexion.AbrirConexion();
            //SqlCommand cmd = new SqlCommand("insert into Multicentro.dbo.servicio (codigoservicio,nombre,precio)" +
            //        " values('" + Int32.Parse(txtCodigoServicioIngreso.Text) + "', '" + txtNombreServicioIngreso.Text + "', '" + Int32.Parse(txtPrecioServicioIngreso.Text) + "')", conexion.GetSqlConnection());
            //cmd.ExecuteNonQuery();

            //MessageBox.Show("Información agregada");
            //conexion.CerrarConexion();
            
            ServiciosIngresoBD servicioIngreso = new ServiciosIngresoBD();
            servicioIngreso.Agregar();

            txtNombreServicioIngreso.Clear();
            txtCodigoServicioIngreso.Clear();
            txtPrecioServicioIngreso.Clear();

        }
    }
}
