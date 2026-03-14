using Asistencia.Tablas;

namespace Asistencia
{
    public partial class frmMenu : Form
    {
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

            frmAlmunos Alumnos = new frmAlmunos();
            Alumnos.ShowDialog();
        }

        private void importarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
