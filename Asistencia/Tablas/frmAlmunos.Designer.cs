namespace Asistencia.Tablas
{
    partial class frmAlmunos
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApmat = new TextBox();
            txtAppat = new TextBox();
            txtNoControl = new TextBox();
            btnAgregar = new Button();
            dgvBusquedaAl = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusquedaAl).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtNombre);
            splitContainer1.Panel1.Controls.Add(txtApmat);
            splitContainer1.Panel1.Controls.Add(txtAppat);
            splitContainer1.Panel1.Controls.Add(txtNoControl);
            splitContainer1.Panel1.Controls.Add(btnAgregar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvBusquedaAl);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 335;
            splitContainer1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 41);
            label5.Name = "label5";
            label5.Size = new Size(142, 37);
            label5.TabIndex = 9;
            label5.Text = "Busqueda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 256);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 8;
            label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 198);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 143);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 93);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 5;
            label1.Text = "Numero de Control";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 161);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApmat
            // 
            txtApmat.Location = new Point(33, 274);
            txtApmat.Name = "txtApmat";
            txtApmat.Size = new Size(267, 23);
            txtApmat.TabIndex = 3;
            // 
            // txtAppat
            // 
            txtAppat.Location = new Point(33, 216);
            txtAppat.Name = "txtAppat";
            txtAppat.Size = new Size(267, 23);
            txtAppat.TabIndex = 2;
            // 
            // txtNoControl
            // 
            txtNoControl.Location = new Point(33, 111);
            txtNoControl.Name = "txtNoControl";
            txtNoControl.Size = new Size(267, 23);
            txtNoControl.TabIndex = 1;
            txtNoControl.TextChanged += txtNoControl_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(114, 348);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 33);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvBusquedaAl
            // 
            dgvBusquedaAl.AllowUserToAddRows = false;
            dgvBusquedaAl.AllowUserToDeleteRows = false;
            dgvBusquedaAl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBusquedaAl.Dock = DockStyle.Fill;
            dgvBusquedaAl.Location = new Point(0, 0);
            dgvBusquedaAl.Name = "dgvBusquedaAl";
            dgvBusquedaAl.ReadOnly = true;
            dgvBusquedaAl.Size = new Size(461, 450);
            dgvBusquedaAl.TabIndex = 0;
            // 
            // frmAlmunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmAlmunos";
            Text = "Lista de Alumnos";
            Activated += frmAlmunos_Activated;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBusquedaAl).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private Button btnAgregar;
        private DataGridView dgvBusquedaAl;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApmat;
        private TextBox txtAppat;
        private TextBox txtNoControl;
    }
}