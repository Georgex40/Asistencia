using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asistencia.Tablas
{

    public partial class frmRegistros : Form
    {
        Datos ct = new Datos();
        DataSet ds = new DataSet();
        public frmRegistros()
        {
            InitializeComponent();
        }

        private void volverAlMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRegistros_Activated(object sender, EventArgs e)
        {
            try
            {

                ds = ct.ejecutar("SELECT * from Registros");
                if (ds != null)
                {
                    dgvRegistroAs.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            { }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void volverAlMenuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsistencia Asistencia = new frmAsistencia();
            Asistencia.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                bool NV = ct.ejecutarComando($"Insert into Registros(Fecha_Hora)" +
                     $"Values (CurDate())");
                DataSet id = ct.ejecutar($"Select max(No_Registro) from Registros");

                int registroId = Convert.ToInt32(id.Tables[0].Rows[0][0]);
                if (registroId == 0) { MessageBox.Show("Error al obtener el ID del nuevo registro"); return; }

                if (NV)
                {
                    bool ins = ct.ejecutarComando($"INSERT INTO Asistencia (No_Registro, No_Control, Nombre, Asistio)" +
                        $"SELECT '{registroId}', NoControl, Nombre, 0 FROM Alumnos;");
                    if (ins)
                    {
                        frmAsistencia Asistencia = new frmAsistencia(registroId);
                        Asistencia.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error en la asistencia");
                    }
                }
                else
                {
                    MessageBox.Show("Error al crear nuevo registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear nuevo registro: " + ex.Message);
            }
        }

        private void dgvRegistroAs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int registroId = Convert.ToInt32(dgvRegistroAs.Rows[e.RowIndex].Cells[0].Value);
             


                frmAsistencia Asistencia = new frmAsistencia(registroId);
                Asistencia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el registro: " + ex.Message);
            }
        }
    }
}
