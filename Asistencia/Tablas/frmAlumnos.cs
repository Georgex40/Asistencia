
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Asistencia.Tablas;
using OfficeOpenXml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Asistencia.Tablas
{
    public partial class frmAlumnos : Form
    {
        Datos ct = new Datos();
        DataSet ds = new DataSet();
        public frmAlumnos()
        {
            InitializeComponent();
        }
        private void nulo()
        {
            if (txtNoControl.Text == "" && txtNombre.Text == "" && txtAppat.Text == "" && txtApmat.Text == "")
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

        private void txtNoControl_TextChanged(object sender, EventArgs e)
        {
            if (txtNoControl.Text != "")
            {
                try
                {

                    ds = ct.ejecutar($"SELECT * from Alumnos " +
                        $"where NoControl like '{txtNoControl.Text}%'");
                    if (ds != null)
                    {
                        dgvBusquedaAl.DataSource = ds.Tables[0];
                    }
                    txtNombre.Enabled = false;
                    txtAppat.Enabled = false;
                    txtApmat.Enabled = false;
                    txtSemestre.Enabled = false;
                }
                catch (Exception ex)
                { }
            }
            else
            {
                txtNombre.Enabled = true;
                txtAppat.Enabled = true;
                txtApmat.Enabled = true;
                txtSemestre.Enabled = true;
                nulo();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlumno Alumno = new frmAlumno();
            Alumno.ShowDialog();
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                try
                {
                    ds = ct.ejecutar($"SELECT * from Alumnos " +
                        $"where Nombre like '{txtNombre.Text}%'");
                    if (ds != null)
                    {
                        dgvBusquedaAl.DataSource = ds.Tables[0];
                    }
                    txtNoControl.Enabled = false;
                    txtAppat.Enabled = false;
                    txtApmat.Enabled = false;
                    txtSemestre.Enabled = false;
                }
                catch (Exception ex)
                { }
            }
            else
            {
                txtNoControl.Enabled = true;
                txtAppat.Enabled = true;
                txtApmat.Enabled = true;
                txtSemestre.Enabled = true;
                nulo();

            }
        }

        private void txtAppat_TextChanged(object sender, EventArgs e)
        {
            if (txtAppat.Text != "")
            {


                try
                {
                    ds = ct.ejecutar($"SELECT * from Alumnos " +
                        $"where Appat like '{txtAppat.Text}%'");
                    if (ds != null)
                    {
                        dgvBusquedaAl.DataSource = ds.Tables[0];
                    }
                    txtNoControl.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApmat.Enabled = false;
                    txtSemestre.Enabled = false;
                }
                catch (Exception ex)
                { }
            }
            else
            {
                txtNoControl.Enabled = true;
                txtNombre.Enabled = true;
                txtApmat.Enabled = true;
                txtSemestre.Enabled = true;
                nulo();

            }
        }

        private void txtApmat_TextChanged(object sender, EventArgs e)
        {
            if (txtApmat.Text != "")
            {


                try
                {
                    ds = ct.ejecutar($"SELECT * from Alumnos " +
                        $"where Apmat like '{txtApmat.Text}%'");
                    if (ds != null)
                    {
                        dgvBusquedaAl.DataSource = ds.Tables[0];
                    }
                    txtNoControl.Enabled = false;
                    txtNombre.Enabled = false;
                    txtAppat.Enabled = false;
                    txtSemestre.Enabled = false;
                }
                catch (Exception ex)
                { }
            }
            else
            {
                txtNoControl.Enabled = true;
                txtNombre.Enabled = true;
                txtAppat.Enabled = true;
                txtSemestre.Enabled = true;
                nulo();

            }

        }


        private void dgvBusquedaAl_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAlumno Alumnos = new frmAlumno(dgvBusquedaAl.CurrentRow.Cells[0].Value.ToString(),
                dgvBusquedaAl.CurrentRow.Cells[1].Value.ToString(),
                dgvBusquedaAl.CurrentRow.Cells[2].Value.ToString(),
                dgvBusquedaAl.CurrentRow.Cells[3].Value.ToString(),
                dgvBusquedaAl.CurrentRow.Cells[4].Value.ToString());
            Alumnos.ShowDialog();
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.String path;
            DialogResult dr = ofdImportar.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdImportar.FileName;
                ExcelPackage.License.SetNonCommercialPersonal("<Jorge>");
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int colcount = worksheet.Dimension.Columns;
                    int rowCount = worksheet.Dimension.Rows;
                    DataTable ds = new DataTable();
                    for (int col = 1; col <= colcount; col++)
                    {
                        ds.Columns.Add(worksheet.Cells[1, col].Value.ToString());
                    }
                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow dsNew = ds.NewRow();
                        for (int col = 1; col <= colcount; col++)
                        {
                            dsNew[col - 1] = worksheet.Cells[row, col].Value.ToString();
                        }
                        ds.Rows.Add(dsNew);
                        System.String comand = $"insert into Alumnos(Nocontrol,Nombre,Appat,Apmat,Semestre)" +
                            $"values ('{dsNew.ItemArray[0]}','{dsNew.ItemArray[1]}','{dsNew.ItemArray[2]}','{dsNew.ItemArray[3]}',{dsNew.ItemArray[4]})";
                        ct.ejecutarComando(comand);

                    }
                }

            }


        }
        private int NumeroRandom()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10);
        }

        private void txtSemestre_TextChanged(object sender, EventArgs e)
        {
            if (txtSemestre.Text != "")
            {


                try
                {
                    ds = ct.ejecutar($"SELECT * from Alumnos " +
                        $"where Apmat like '{txtApmat.Text}%'");
                    if (ds != null)
                    {
                        dgvBusquedaAl.DataSource = ds.Tables[0];
                    }
                    txtNoControl.Enabled = false;
                    txtNombre.Enabled = false;
                    txtAppat.Enabled = false;
                    txtApmat.Enabled = false;
                }
                catch (Exception ex)
                { }
            }
            else
            {
                txtNoControl.Enabled = true;
                txtNombre.Enabled = true;
                txtAppat.Enabled = true;
                txtApmat.Enabled = true;
                nulo();

            }

        }
    }

}

