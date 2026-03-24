using Asistencia.Tablas;
using System.Data;

namespace Asistencia
{
    public partial class frmMenu : Form
    {
        bool updating = false;
        Datos dt = new Datos();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistros Registros = new frmRegistros();
            Registros.ShowDialog();

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAlumnos Alumnos = new frmAlumnos();
            Alumnos.ShowDialog();
        }

        private void importarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

    }
}
