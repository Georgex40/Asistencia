using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asistencia.Tablas
{
    public partial class frmAsistencia : Form
    {
        Datos ct = new Datos();
        DataSet ds = new DataSet(); 
        public frmAsistencia()
        {
            InitializeComponent();
        }
        public frmAsistencia(DataSet Numero)
        {
            InitializeComponent();
            try
            {

                ds = ct.ejecutar($"SELECT * from Asistencia" +
                    $"Where {Numero} like No_Registro");
                if (Numero != null)
                {
                    dgvAsistencia.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            { }
        }
        
    }
}
