namespace Asistencia.Tablas
{
    partial class frmAlumno
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
            btnAceptar = new Button();
            txtNoControl = new TextBox();
            txtAppat = new TextBox();
            txtNombre = new TextBox();
            txtApmat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSemestre = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(119, 261);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 46);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNoControl
            // 
            txtNoControl.Location = new Point(28, 52);
            txtNoControl.Name = "txtNoControl";
            txtNoControl.Size = new Size(287, 23);
            txtNoControl.TabIndex = 1;
            // 
            // txtAppat
            // 
            txtAppat.Location = new Point(28, 140);
            txtAppat.Name = "txtAppat";
            txtAppat.Size = new Size(287, 23);
            txtAppat.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(287, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApmat
            // 
            txtApmat.Location = new Point(28, 184);
            txtApmat.Name = "txtApmat";
            txtApmat.Size = new Size(287, 23);
            txtApmat.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 5;
            label1.Text = "NoControl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 78);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 122);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 7;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 166);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 8;
            label4.Text = "Apellido Materno";
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(28, 228);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(99, 23);
            txtSemestre.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 210);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 10;
            label5.Text = "Semestre";
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(386, 343);
            Controls.Add(label5);
            Controls.Add(txtSemestre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApmat);
            Controls.Add(txtNombre);
            Controls.Add(txtAppat);
            Controls.Add(txtNoControl);
            Controls.Add(btnAceptar);
            Name = "frmAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtNoControl;
        private TextBox txtAppat;
        private TextBox txtNombre;
        private TextBox txtApmat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSemestre;
        private Label label5;
    }
}