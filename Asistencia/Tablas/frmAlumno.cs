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
                    $"Insert into Alumnos (NoControl,Nombre,Appat,Apmat,Semestre)" +
                    $"values ('{txtNoControl.Text}','{txtNombre.Text}','{txtAppat.Text}','{txtApmat.Text}','{txtSemestre.Text}')");
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
                    $"Update Alumnos set Nombre='{txtNombre.Text}',Appat='{txtAppat.Text}',Apmat='{txtApmat.Text}',Semestre='{txtSemestre.Text}'" +
                    $"where NoControl='{txtNoControl.Text}'");
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
    }
}
