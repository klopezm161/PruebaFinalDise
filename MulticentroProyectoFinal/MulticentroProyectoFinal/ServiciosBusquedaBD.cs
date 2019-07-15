using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MulticentroProyectoFinal
{
    class ServiciosBusquedaBD
    {

        //referencia a clase para abrir conexion
        private IConexionesBasicasAbrirCerrarBD conexion;
        //referencia a clase de Windows Form para poder capturar los valores ingresados por el cliente
        private ServiciosBusqueda guiServiciosIBusqueda = (ServiciosBusqueda)Application.OpenForms["ServiciosBusqueda"];
        private string nombre;
        private string codigo;
        
        private SqlCommand cmd;
        private SqlDataAdapter adaptador;
        private SqlDataReader lector;
        public ServiciosBusquedaBD()
        {
            conexion = new ConexionesBasicasAbrirCerrarBD();
            nombre = guiServiciosIBusqueda.getNombre();
            codigo = guiServiciosIBusqueda.getCodigo();
            //codigo = int.Parse(guiServiciosIBusqueda.getCodigo());
        }

        public void Buscar()
        {           
            try
            {
                conexion.AbrirConexion();

                if (codigo.Length==0&&nombre.Length==0)
                {
                    MessageBox.Show("No ingresó ningún valor. Indique el código o nombre que desea buscar.");
                    
                }
                else if (codigo.Length==0)
                {
                    BuscarPorNombre();
                }
                else 
                    BuscarPorCodigo();

                conexion.CerrarConexion();
            }
            
            catch (NullReferenceException ex2)
            {
                MessageBox.Show("No se seleccionó un dato correcto, no hay nada que mostrar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje de error  " + ex);
            }
        }

        public void BuscarPorNombre()
        {

            string query = @"SELECT * FROM dbo.servicio where nombre like'" + nombre + "%'";
            adaptador = new SqlDataAdapter(query, conexion.GetSqlConnection());
            
        }

        public void BuscarPorCodigo()
        {            
            try
            {               
                string query = @"SELECT * FROM dbo.servicio where codigoservicio like'" + Int32.Parse(codigo) + "%'";
                adaptador = new SqlDataAdapter(query, conexion.GetSqlConnection());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Código ingresado incorrecto, ingrese un código numérico.");
            }
        }

        public SqlDataAdapter getSqlAdaptador()
        {
            return adaptador;
        }
    }
}
