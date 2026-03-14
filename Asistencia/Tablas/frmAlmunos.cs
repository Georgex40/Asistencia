using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Asistencia.Tablas
{
    public partial class frmAlmunos : Form
    {
        Datos ct = new Datos();
        DataSet ds = new DataSet();
        public frmAlmunos()
        {
            InitializeComponent();
        }

        private void txtNoControl_TextChanged(object sender, EventArgs e)
        {
            ds=ct.ejecutar($"SELECT * from Alumnos where NoControl like '{txtNoControl.Text}'");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void frmAlmunos_Activated(object sender, EventArgs e)
        {
            try
            {

                ds = ct.ejecutar("SELECT * from Alumnos");
                if (ds != null)
                {
                    dgvBusquedaAl.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            { }
        }
    }
}
