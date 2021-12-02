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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDoctoresDisponibles = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(194, 44);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 15);
            this.lblPaciente.TabIndex = 7;
            this.lblPaciente.Text = "Paciente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 23);
            this.textBox1.TabIndex = 6;
            // 
            // lblDoctoresDisponibles
            // 
            this.lblDoctoresDisponibles.AutoSize = true;
            this.lblDoctoresDisponibles.Location = new System.Drawing.Point(47, 44);
            this.lblDoctoresDisponibles.Name = "lblDoctoresDisponibles";
            this.lblDoctoresDisponibles.Size = new System.Drawing.Size(117, 15);
            this.lblDoctoresDisponibles.TabIndex = 5;
            this.lblDoctoresDisponibles.Text = "Doctores disponibles";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // FrmGenerarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDoctoresDisponibles);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmGenerarConsulta";
            this.Text = "FrmGenerarConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDoctoresDisponibles;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}