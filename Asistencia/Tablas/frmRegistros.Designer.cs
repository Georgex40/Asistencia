namespace Asistencia.Tablas
{
    partial class frmRegistros
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
            components = new System.ComponentModel.Container();
            dgvRegistroAs = new DataGridView();
            splitContainer1 = new SplitContainer();
            menuStrip1 = new MenuStrip();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            volverAlMenuToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            abrirToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroAs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRegistroAs
            // 
            dgvRegistroAs.AllowUserToAddRows = false;
            dgvRegistroAs.AllowUserToDeleteRows = false;
            dgvRegistroAs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroAs.Dock = DockStyle.Fill;
            dgvRegistroAs.Location = new Point(0, 0);
            dgvRegistroAs.Name = "dgvRegistroAs";
            dgvRegistroAs.ReadOnly = true;
            dgvRegistroAs.Size = new Size(800, 421);
            dgvRegistroAs.TabIndex = 0;
            dgvRegistroAs.CellContentClick += dgvRegistros_CellContentClick;
            dgvRegistroAs.CellDoubleClick += dgvRegistroAs_CellDoubleClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvRegistroAs);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 25;
            splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, volverAlMenuToolStripMenuItem });
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(67, 20);
            registrosToolStripMenuItem.Text = "Registros";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(152, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // volverAlMenuToolStripMenuItem
            // 
            volverAlMenuToolStripMenuItem.Name = "volverAlMenuToolStripMenuItem";
            volverAlMenuToolStripMenuItem.Size = new Size(152, 22);
            volverAlMenuToolStripMenuItem.Text = "Volver al Menu";
            volverAlMenuToolStripMenuItem.Click += volverAlMenuToolStripMenuItem_Click_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(117, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // frmRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmRegistros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistros";
            Activated += frmRegistros_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvRegistroAs).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvRegistroAs;
        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrosToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem volverAlMenuToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}