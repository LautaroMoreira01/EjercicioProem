namespace Vista
{
    partial class FrmAgregarPaciente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.cbEspecialidades = new System.Windows.Forms.ComboBox();
            this.lblTipoDoctor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBuscarDoctorPor = new System.Windows.Forms.ComboBox();
            this.tbNombreDoctor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(113, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(113, 122);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(212, 23);
            this.tbNombre.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 23);
            this.textBox2.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(113, 162);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(113, 219);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(117, 15);
            this.lblFechaDeNacimiento.TabIndex = 4;
            this.lblFechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 299);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 23);
            this.textBox3.TabIndex = 7;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(113, 281);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(25, 15);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "Dni";
            // 
            // cbEspecialidades
            // 
            this.cbEspecialidades.FormattingEnabled = true;
            this.cbEspecialidades.Location = new System.Drawing.Point(113, 357);
            this.cbEspecialidades.Name = "cbEspecialidades";
            this.cbEspecialidades.Size = new System.Drawing.Size(212, 23);
            this.cbEspecialidades.TabIndex = 8;
            // 
            // lblTipoDoctor
            // 
            this.lblTipoDoctor.AutoSize = true;
            this.lblTipoDoctor.Location = new System.Drawing.Point(113, 339);
            this.lblTipoDoctor.Name = "lblTipoDoctor";
            this.lblTipoDoctor.Size = new System.Drawing.Size(89, 15);
            this.lblTipoDoctor.TabIndex = 9;
            this.lblTipoDoctor.Text = "Nombre doctor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Buscar doctor por";
            // 
            // cbBuscarDoctorPor
            // 
            this.cbBuscarDoctorPor.FormattingEnabled = true;
            this.cbBuscarDoctorPor.Items.AddRange(new object[] {
            "Nombre",
            "Especialidad"});
            this.cbBuscarDoctorPor.Location = new System.Drawing.Point(224, 37);
            this.cbBuscarDoctorPor.Name = "cbBuscarDoctorPor";
            this.cbBuscarDoctorPor.Size = new System.Drawing.Size(200, 23);
            this.cbBuscarDoctorPor.TabIndex = 10;
            this.cbBuscarDoctorPor.SelectedIndexChanged += new System.EventHandler(this.cbBuscarDoctorPor_SelectedIndexChanged);
            // 
            // tbNombreDoctor
            // 
            this.tbNombreDoctor.Location = new System.Drawing.Point(113, 357);
            this.tbNombreDoctor.Name = "tbNombreDoctor";
            this.tbNombreDoctor.Size = new System.Drawing.Size(212, 23);
            this.tbNombreDoctor.TabIndex = 12;
            // 
            // FrmAgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 510);
            this.Controls.Add(this.tbNombreDoctor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBuscarDoctorPor);
            this.Controls.Add(this.lblTipoDoctor);
            this.Controls.Add(this.cbEspecialidades);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaDeNacimiento);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmAgregarPaciente";
            this.Text = "FrmAgregarPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.ComboBox cbEspecialidades;
        private System.Windows.Forms.Label lblTipoDoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBuscarDoctorPor;
        private System.Windows.Forms.TextBox tbNombreDoctor;
    }
}