using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asistencia.Tablas
{
    public partial class frmAlumno : Form
    {
        bool updating = false;
        Datos dt = new Datos();
        public frmAlumno()
        {
            InitializeComponent();
        }
        public frmAlumno(string noCtrl, string nombre, string apPaterno, string apMaterno, string semestre)
        {
            InitializeComponent();
            txtNoControl.Text = noCtrl;
            txtNombre.Text = nombre;
            txtAppat.Text = apPaterno;
            txtApmat.Text = apMaterno;
            txtSemestre.Text= semestre;
            updating = true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Alumnos (No_Control,Nombre,ApPat,ApMat,Semestre)" +
                    $"values ('{txtNoControl.Text}','{txtNombre.Text}','{txtAppat.Text}','{txtApmat.Text}','{txtSemestre.Text})");
                if (resultado)
                {
                    MessageBox.Show("Alumno Registrado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al Registrar Alumno");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"Update Alumnos set Nombre='{txtNombre.Text}',ApPat='{txtAppat.Text}',ApMat='{txtApmat.Text},Semestre='{txtSemestre}''" +
                    $"where No_Control={txtNoControl.Text}");
                if (resultado)
                {
                    MessageBox.Show("Informacion del alumno Actualizada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar al Alumno");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
