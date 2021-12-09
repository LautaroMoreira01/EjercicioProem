namespace Vista
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.btnInformacionPacientes = new System.Windows.Forms.Button();
            this.btnEliminarDoctor = new System.Windows.Forms.Button();
            this.btnModificarDoctor = new System.Windows.Forms.Button();
            this.btnInformacionDoctores = new System.Windows.Forms.Button();
            this.btnAgregarDoctor = new System.Windows.Forms.Button();
            this.btnInformacionClinica = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMostrarConsultasFinalizadas = new System.Windows.Forms.Button();
            this.btnFinalizarConsulta = new System.Windows.Forms.Button();
            this.btnMostrarConsultasActivas = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbEstadisticasHistoricas = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Location = new System.Drawing.Point(9, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 83);
            this.panel2.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNombre.Location = new System.Drawing.Point(52, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 37);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Clinica";
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnEliminarPaciente.FlatAppearance.BorderSize = 0;
            this.btnEliminarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(-3, 627);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(202, 76);
            this.btnEliminarPaciente.TabIndex = 7;
            this.btnEliminarPaciente.Text = "Eliminar paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = false;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnModificarPaciente.FlatAppearance.BorderSize = 0;
            this.btnModificarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnModificarPaciente.Location = new System.Drawing.Point(-3, 558);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(202, 76);
            this.btnModificarPaciente.TabIndex = 6;
            this.btnModificarPaciente.Text = "Modificar paciente";
            this.btnModificarPaciente.UseVisualStyleBackColor = false;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnAgregarPaciente.FlatAppearance.BorderSize = 0;
            this.btnAgregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarPaciente.Location = new System.Drawing.Point(-3, 487);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(202, 76);
            this.btnAgregarPaciente.TabIndex = 5;
            this.btnAgregarPaciente.Text = "Agregar paciente";
            this.btnAgregarPaciente.UseVisualStyleBackColor = false;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // btnInformacionPacientes
            // 
            this.btnInformacionPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnInformacionPacientes.FlatAppearance.BorderSize = 0;
            this.btnInformacionPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacionPacientes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInformacionPacientes.Location = new System.Drawing.Point(-3, 415);
            this.btnInformacionPacientes.Name = "btnInformacionPacientes";
            this.btnInformacionPacientes.Size = new System.Drawing.Size(202, 76);
            this.btnInformacionPacientes.TabIndex = 9;
            this.btnInformacionPacientes.Text = "Mostrar pacientes";
            this.btnInformacionPacientes.UseVisualStyleBackColor = false;
            this.btnInformacionPacientes.Click += new System.EventHandler(this.btnInformacionPacientes_Click);
            // 
            // btnEliminarDoctor
            // 
            this.btnEliminarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnEliminarDoctor.FlatAppearance.BorderSize = 0;
            this.btnEliminarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDoctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminarDoctor.Location = new System.Drawing.Point(-3, 306);
            this.btnEliminarDoctor.Name = "btnEliminarDoctor";
            this.btnEliminarDoctor.Size = new System.Drawing.Size(202, 76);
            this.btnEliminarDoctor.TabIndex = 4;
            this.btnEliminarDoctor.Text = "Eliminar doctor";
            this.btnEliminarDoctor.UseVisualStyleBackColor = false;
            this.btnEliminarDoctor.Click += new System.EventHandler(this.btnEliminarDoctor_Click);
            // 
            // btnModificarDoctor
            // 
            this.btnModificarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnModificarDoctor.FlatAppearance.BorderSize = 0;
            this.btnModificarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDoctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnModificarDoctor.Location = new System.Drawing.Point(-3, 240);
            this.btnModificarDoctor.Name = "btnModificarDoctor";
            this.btnModificarDoctor.Size = new System.Drawing.Size(202, 76);
            this.btnModificarDoctor.TabIndex = 3;
            this.btnModificarDoctor.Text = "Modificar doctor";
            this.btnModificarDoctor.UseVisualStyleBackColor = false;
            this.btnModificarDoctor.Click += new System.EventHandler(this.btnModificarDoctor_Click);
            // 
            // btnInformacionDoctores
            // 
            this.btnInformacionDoctores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnInformacionDoctores.FlatAppearance.BorderSize = 0;
            this.btnInformacionDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacionDoctores.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInformacionDoctores.Location = new System.Drawing.Point(-3, 103);
            this.btnInformacionDoctores.Name = "btnInformacionDoctores";
            this.btnInformacionDoctores.Size = new System.Drawing.Size(202, 76);
            this.btnInformacionDoctores.TabIndex = 8;
            this.btnInformacionDoctores.Text = "Mostrar doctores";
            this.btnInformacionDoctores.UseVisualStyleBackColor = false;
            this.btnInformacionDoctores.Click += new System.EventHandler(this.btnInformacionDoctores_Click);
            // 
            // btnAgregarDoctor
            // 
            this.btnAgregarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnAgregarDoctor.FlatAppearance.BorderSize = 0;
            this.btnAgregarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDoctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarDoctor.Location = new System.Drawing.Point(-3, 172);
            this.btnAgregarDoctor.Name = "btnAgregarDoctor";
            this.btnAgregarDoctor.Size = new System.Drawing.Size(202, 76);
            this.btnAgregarDoctor.TabIndex = 2;
            this.btnAgregarDoctor.Text = "Agregar doctor";
            this.btnAgregarDoctor.UseVisualStyleBackColor = false;
            this.btnAgregarDoctor.Click += new System.EventHandler(this.btnAgregarDoctor_Click);
            // 
            // btnInformacionClinica
            // 
            this.btnInformacionClinica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnInformacionClinica.FlatAppearance.BorderSize = 0;
            this.btnInformacionClinica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacionClinica.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnInformacionClinica.Location = new System.Drawing.Point(0, 3);
            this.btnInformacionClinica.Name = "btnInformacionClinica";
            this.btnInformacionClinica.Size = new System.Drawing.Size(202, 76);
            this.btnInformacionClinica.TabIndex = 1;
            this.btnInformacionClinica.Text = "Informacion Clinica";
            this.btnInformacionClinica.UseVisualStyleBackColor = false;
            this.btnInformacionClinica.Click += new System.EventHandler(this.btnInformacionClinica_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnInformacionClinica);
            this.panel1.Controls.Add(this.btnAgregarDoctor);
            this.panel1.Controls.Add(this.btnInformacionDoctores);
            this.panel1.Controls.Add(this.btnModificarDoctor);
            this.panel1.Controls.Add(this.btnEliminarDoctor);
            this.panel1.Controls.Add(this.btnInformacionPacientes);
            this.panel1.Controls.Add(this.btnAgregarPaciente);
            this.panel1.Controls.Add(this.btnModificarPaciente);
            this.panel1.Controls.Add(this.btnEliminarPaciente);
            this.panel1.Location = new System.Drawing.Point(9, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 706);
            this.panel1.TabIndex = 12;
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.Location = new System.Drawing.Point(19, 93);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.Size = new System.Drawing.Size(620, 695);
            this.rtbInformacion.TabIndex = 0;
            this.rtbInformacion.Text = "";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(12, 94);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowTemplate.Height = 25;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(627, 695);
            this.dgvPersonas.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMostrarConsultasFinalizadas);
            this.panel4.Controls.Add(this.btnFinalizarConsulta);
            this.panel4.Controls.Add(this.btnMostrarConsultasActivas);
            this.panel4.Controls.Add(this.btnConsulta);
            this.panel4.Location = new System.Drawing.Point(645, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 344);
            this.panel4.TabIndex = 12;
            // 
            // btnMostrarConsultasFinalizadas
            // 
            this.btnMostrarConsultasFinalizadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnMostrarConsultasFinalizadas.FlatAppearance.BorderSize = 0;
            this.btnMostrarConsultasFinalizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarConsultasFinalizadas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMostrarConsultasFinalizadas.Location = new System.Drawing.Point(8, 257);
            this.btnMostrarConsultasFinalizadas.Name = "btnMostrarConsultasFinalizadas";
            this.btnMostrarConsultasFinalizadas.Size = new System.Drawing.Size(202, 75);
            this.btnMostrarConsultasFinalizadas.TabIndex = 13;
            this.btnMostrarConsultasFinalizadas.Text = "Mostrar consultas finalizadas";
            this.btnMostrarConsultasFinalizadas.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarConsulta
            // 
            this.btnFinalizarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnFinalizarConsulta.FlatAppearance.BorderSize = 0;
            this.btnFinalizarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarConsulta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFinalizarConsulta.Location = new System.Drawing.Point(8, 176);
            this.btnFinalizarConsulta.Name = "btnFinalizarConsulta";
            this.btnFinalizarConsulta.Size = new System.Drawing.Size(202, 75);
            this.btnFinalizarConsulta.TabIndex = 12;
            this.btnFinalizarConsulta.Text = "Finalizar consulta";
            this.btnFinalizarConsulta.UseVisualStyleBackColor = false;
            this.btnFinalizarConsulta.Click += new System.EventHandler(this.btnEliminarConsulta_Click);
            // 
            // btnMostrarConsultasActivas
            // 
            this.btnMostrarConsultasActivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnMostrarConsultasActivas.FlatAppearance.BorderSize = 0;
            this.btnMostrarConsultasActivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarConsultasActivas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMostrarConsultasActivas.Location = new System.Drawing.Point(8, 14);
            this.btnMostrarConsultasActivas.Name = "btnMostrarConsultasActivas";
            this.btnMostrarConsultasActivas.Size = new System.Drawing.Size(202, 75);
            this.btnMostrarConsultasActivas.TabIndex = 11;
            this.btnMostrarConsultasActivas.Text = "Mostrar consultas activas";
            this.btnMostrarConsultasActivas.UseVisualStyleBackColor = false;
            this.btnMostrarConsultasActivas.Click += new System.EventHandler(this.btnMostrarConsultasActivas_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnConsulta.Location = new System.Drawing.Point(8, 95);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(202, 75);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "Generar consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbEstadisticasHistoricas);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvPersonas);
            this.panel3.Controls.Add(this.rtbInformacion);
            this.panel3.Location = new System.Drawing.Point(217, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 819);
            this.panel3.TabIndex = 14;
            // 
            // cbEstadisticasHistoricas
            // 
            this.cbEstadisticasHistoricas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadisticasHistoricas.FormattingEnabled = true;
            this.cbEstadisticasHistoricas.Items.AddRange(new object[] {
            "Doctores ordenados descendientemente por cantidad de pacientes atendidos",
            "Doctor con mas pacientes atendidos",
            "La especialidad con mas consultas",
            "Doctor con menos pacientes atendidos"});
            this.cbEstadisticasHistoricas.Location = new System.Drawing.Point(12, 60);
            this.cbEstadisticasHistoricas.Name = "cbEstadisticasHistoricas";
            this.cbEstadisticasHistoricas.Size = new System.Drawing.Size(627, 23);
            this.cbEstadisticasHistoricas.TabIndex = 10;
            this.cbEstadisticasHistoricas.SelectedIndexChanged += new System.EventHandler(this.cbEstadisticasHistoricas_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1084, 831);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1100, 870);
            this.MinimumSize = new System.Drawing.Size(1100, 870);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Button btnInformacionPacientes;
        private System.Windows.Forms.Button btnEliminarDoctor;
        private System.Windows.Forms.Button btnModificarDoctor;
        private System.Windows.Forms.Button btnInformacionDoctores;
        private System.Windows.Forms.Button btnAgregarDoctor;
        private System.Windows.Forms.Button btnInformacionClinica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbInformacion;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMostrarConsultasFinalizadas;
        private System.Windows.Forms.Button btnFinalizarConsulta;
        private System.Windows.Forms.Button btnMostrarConsultasActivas;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbEstadisticasHistoricas;
    }
}
