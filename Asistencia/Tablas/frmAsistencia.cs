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
    public partial class frmAsistencia : Form
    {
        int nRegistro;
        Datos ct = new Datos();
        DataSet ds = new DataSet();
        public frmAsistencia()
        {
            InitializeComponent();
        }
        public frmAsistencia(int Numero)
        {
            InitializeComponent();
            nRegistro = Numero;

        }

        private void frmAsistencia_Activated(object sender, EventArgs e)
        {
            try
            {

                ds = ct.ejecutar($"SELECT * FROM Asistencia WHERE No_Registro = {nRegistro}");

                if (ds != null)
                {
                    dgvAsistencia.DataSource = ds.Tables[0];
                    if (!dgvAsistencia.Columns.Contains("EstadoTexto"))
                    {
                        dgvAsistencia.Columns.Add("EstadoTexto", "Estado");
                    }

                    ActualizarEstadoVisual();

                    DataGridViewCheckBoxColumn chk = dgvAsistencia.Columns["Asistio"] as DataGridViewCheckBoxColumn;

                    if (chk != null)
                    {
                        chk.TrueValue = 1;
                        chk.FalseValue = 0;
                        chk.ValueType = typeof(bool);
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }


        private void txtAlumno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int filaIndex = dgvAsistencia.CurrentCell.RowIndex;
                int colIndex = dgvAsistencia.Columns["Asistio"].Index;

                var celda = dgvAsistencia.Rows[filaIndex].Cells[colIndex];

                // Toggle checkbox
                bool valor = Convert.ToBoolean(celda.Value);
                celda.Value = !valor;

                ActualizarEstadoVisual();
                if (filaIndex < dgvAsistencia.Rows.Count - 1)
                {
                    dgvAsistencia.CurrentCell = dgvAsistencia.Rows[filaIndex + 1].Cells[colIndex];
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                int filaIndex = dgvAsistencia.CurrentCell.RowIndex;
                int colIndex = dgvAsistencia.CurrentCell.ColumnIndex;

                if (filaIndex < dgvAsistencia.Rows.Count - 1)
                {
                    dgvAsistencia.CurrentCell = dgvAsistencia.Rows[filaIndex + 1].Cells[colIndex];
                }
            }
        }

        private void ActualizarEstadoVisual()
        {
            foreach (DataGridViewRow fila in dgvAsistencia.Rows)
            {
                if (fila.IsNewRow) continue;

                bool asistio = false;

                if (fila.Cells["Asistio"].Value != DBNull.Value && fila.Cells["Asistio"].Value != null)
                {
                    asistio = Convert.ToBoolean(fila.Cells["Asistio"].Value);
                }

                fila.Cells["EstadoTexto"].Value = asistio ? "Asistió" : "Falta";

                fila.DefaultCellStyle.BackColor = asistio ? Color.LightGreen : Color.LightCoral;
            }
        }
        private void dgvAsistencia_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAlumno.Text = dgvAsistencia.CurrentRow.Cells["No_Control"].Value.ToString();
        }

        private async void btnGuardarTodo_Click(object sender, EventArgs e)
        {
            
            var datos = new List<(string noControl, int noRegistro, int asistio)>();

            foreach (DataGridViewRow fila in dgvAsistencia.Rows)
            {
                if (fila.IsNewRow) continue;

                string noControl = fila.Cells["No_Control"].Value.ToString();
                int noRegistro = Convert.ToInt32(fila.Cells["No_Registro"].Value);

                bool asistio = false;

                if (fila.Cells["Asistio"].Value != DBNull.Value && fila.Cells["Asistio"].Value != null)
                {
                    asistio = Convert.ToBoolean(fila.Cells["Asistio"].Value);
                }

                datos.Add((noControl, noRegistro, asistio ? 1 : 0));
            }

           // await Task.Run(() =>
            //{
                GuardarAsistencia(datos);
            //});

            MessageBox.Show("Guardado");
        }
        
        private void GuardarAsistencia(List<(string noControl, int noRegistro, int asistio)> datos)
        {
            foreach (var d in datos)
            {
                string comando = $"UPDATE Asistencia SET Asistio = {d.asistio} " +
                                 $"WHERE No_Registro = {d.noRegistro} AND No_Control = '{d.noControl}'";

                ct.ejecutarComando(comando);
            }
        }


    }
    
}
