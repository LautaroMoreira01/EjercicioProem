namespace Vista
{
    partial class FrmGenerarConsulta
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
            this.lblPaciente = new System.Windows.Forms.Label();
            this.tbInformacionPaciente = new System.Windows.Forms.TextBox();
            this.lblDoctoresDisponibles = new System.Windows.Forms.Label();
            this.cbDoctoresDisponibles = new System.Windows.Forms.ComboBox();
            this.btnGenerarConsulta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(32, 56);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 15);
            this.lblPaciente.TabIndex = 7;
            this.lblPaciente.Text = "Paciente";
            // 
            // tbInformacionPaciente
            // 
            this.tbInformacionPaciente.Location = new System.Drawing.Point(31, 73);
            this.tbInformacionPaciente.Name = "tbInformacionPaciente";
            this.tbInformacionPaciente.Size = new System.Drawing.Size(219, 23);
            this.tbInformacionPaciente.TabIndex = 6;
            // 
            // lblDoctoresDisponibles
            // 
            this.lblDoctoresDisponibles.AutoSize = true;
            this.lblDoctoresDisponibles.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDoctoresDisponibles.Location = new System.Drawing.Point(32, 125);
            this.lblDoctoresDisponibles.Name = "lblDoctoresDisponibles";
            this.lblDoctoresDisponibles.Size = new System.Drawing.Size(117, 15);
            this.lblDoctoresDisponibles.TabIndex = 5;
            this.lblDoctoresDisponibles.Text = "Doctores disponibles";
            // 
            // cbDoctoresDisponibles
            // 
            this.cbDoctoresDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctoresDisponibles.FormattingEnabled = true;
            this.cbDoctoresDisponibles.Location = new System.Drawing.Point(32, 143);
            this.cbDoctoresDisponibles.Name = "cbDoctoresDisponibles";
            this.cbDoctoresDisponibles.Size = new System.Drawing.Size(218, 23);
            this.cbDoctoresDisponibles.TabIndex = 4;
            // 
            // btnGenerarConsulta
            // 
            this.btnGenerarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnGenerarConsulta.FlatAppearance.BorderSize = 0;
            this.btnGenerarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarConsulta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenerarConsulta.Location = new System.Drawing.Point(3, 56);
            this.btnGenerarConsulta.Name = "btnGenerarConsulta";
            this.btnGenerarConsulta.Size = new System.Drawing.Size(219, 64);
            this.btnGenerarConsulta.TabIndex = 8;
            this.btnGenerarConsulta.Text = "Crear consulta";
            this.btnGenerarConsulta.UseVisualStyleBackColor = false;
            this.btnGenerarConsulta.Click += new System.EventHandler(this.btnGenerarConsulta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.Location = new System.Drawing.Point(0, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(219, 64);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerarConsulta);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(270, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 253);
            this.panel1.TabIndex = 10;
            // 
            // FrmGenerarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(501, 253);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.tbInformacionPaciente);
            this.Controls.Add(this.lblDoctoresDisponibles);
            this.Controls.Add(this.cbDoctoresDisponibles);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximumSize = new System.Drawing.Size(517, 292);
            this.MinimumSize = new System.Drawing.Size(517, 292);
            this.Name = "FrmGenerarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar consulta";
            this.Load += new System.EventHandler(this.FrmGenerarConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox tbInformacionPaciente;
        private System.Windows.Forms.Label lblDoctoresDisponibles;
        private System.Windows.Forms.ComboBox cbDoctoresDisponibles;
        private System.Windows.Forms.Button btnGenerarConsulta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
    }
}