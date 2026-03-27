namespace Asistencia.Tablas
{
    partial class frmAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            dgvAsistencia = new DataGridView();
            splitContainer2 = new SplitContainer();
            label1 = new Label();
            txtAlumno = new TextBox();
            btnGuardarTodo = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvAsistencia);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(693, 421);
            splitContainer1.SplitterDistance = 542;
            splitContainer1.TabIndex = 0;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.AllowUserToAddRows = false;
            dgvAsistencia.AllowUserToDeleteRows = false;
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Dock = DockStyle.Fill;
            dgvAsistencia.Location = new Point(0, 0);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.ReadOnly = true;
            dgvAsistencia.Size = new Size(542, 421);
            dgvAsistencia.TabIndex = 0;
            dgvAsistencia.CellEnter += dgvAsistencia_CellEnter;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(txtAlumno);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnGuardarTodo);
            splitContainer2.Size = new Size(147, 421);
            splitContainer2.SplitterDistance = 107;
            splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Alumno";
            // 
            // txtAlumno
            // 
            txtAlumno.Font = new Font("Segoe UI", 14.25F);
            txtAlumno.Location = new Point(3, 47);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new Size(118, 33);
            txtAlumno.TabIndex = 0;
            txtAlumno.KeyUp += txtAlumno_KeyUp;
            // 
            // btnGuardarTodo
            // 
            btnGuardarTodo.Location = new Point(14, 58);
            btnGuardarTodo.Name = "btnGuardarTodo";
            btnGuardarTodo.Size = new Size(121, 53);
            btnGuardarTodo.TabIndex = 0;
            btnGuardarTodo.Text = "Guardar todo el Registro";
            btnGuardarTodo.UseVisualStyleBackColor = true;
            btnGuardarTodo.Click += btnGuardarTodo_Click;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 421);
            Controls.Add(splitContainer1);
            Name = "frmAsistencia";
            Text = "Registro de Asistencia";
            Activated += frmAsistencia_Activated;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private DataGridView dgvAsistencia;
        private TextBox txtAlumno;
        private Label label1;
        private Button btnGuardarTodo;
    }
}