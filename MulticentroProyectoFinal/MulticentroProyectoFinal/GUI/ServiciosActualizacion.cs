﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticentroProyectoFinal
{
    public partial class ServiciosActualizacion : Form
    {
        public ServiciosActualizacion()
        {
            InitializeComponent();
        }
        public string getNombre()
        {
            return txtNombreServiciosActualizacion.Text;
        }

        public string getCantidad()
        {
            return txtCantidadServiciosActualizacion.Text;

        }

        public string getPrecio()
        {
            return txtPrecioServiciosActualizacion.Text;
        }
        public string getCodigoParaActualizar()
        {
            return TxtCodAActualizarActualizacionServicios.Text;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ServiciosActualizacionBD servicioActualizacion = new ServiciosActualizacionBD();
            servicioActualizacion.Actualizar();           

        }


        private void BtnSalirServiciosActualizacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuPrincipalEnServiciosActualizacion_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipalPrograma = new MenuPrincipal();
            menuPrincipalPrograma.Show();
            this.Dispose();
        }

        private void ServiciosActualizacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
