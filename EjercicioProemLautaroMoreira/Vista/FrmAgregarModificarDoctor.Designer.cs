namespace Vista
{
    partial class FrmAgregarModificarDoctor
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
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarModificar = new System.Windows.Forms.Button();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEspecialidad.Location = new System.Drawing.Point(80, 328);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(72, 15);
            this.lblEspecialidad.TabIndex = 33;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Nombre",
            "Especialidad"});
            this.cbEspecialidad.Location = new System.Drawing.Point(80, 346);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(212, 23);
            this.cbEspecialidad.TabIndex = 32;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.Location = new System.Drawing.Point(203, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 45);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarModificar
            // 
            this.btnAgregarModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnAgregarModificar.FlatAppearance.BorderSize = 0;
            this.btnAgregarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarModificar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarModificar.Location = new System.Drawing.Point(80, 420);
            this.btnAgregarModificar.Name = "btnAgregarModificar";
            this.btnAgregarModificar.Size = new System.Drawing.Size(89, 45);
            this.btnAgregarModificar.TabIndex = 30;
            this.btnAgregarModificar.Text = "button1";
            this.btnAgregarModificar.UseVisualStyleBackColor = false;
            this.btnAgregarModificar.Click += new System.EventHandler(this.btnAgregarModificar_Click);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(80, 280);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(212, 23);
            this.tbDni.TabIndex = 24;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDni.Location = new System.Drawing.Point(80, 262);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(25, 15);
            this.lblDni.TabIndex = 23;
            this.lblDni.Text = "Dni";
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(80, 218);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(212, 23);
            this.dtpFechaDeNacimiento.TabIndex = 22;
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(80, 200);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(117, 15);
            this.lblFechaDeNacimiento.TabIndex = 21;
            this.lblFechaDeNacimiento.Text = "Fecha de nacimiento";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(80, 161);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(212, 23);
            this.tbApellido.TabIndex = 20;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblApellido.Location = new System.Drawing.Point(80, 143);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(80, 103);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(212, 23);
            this.tbNombre.TabIndex = 18;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombre.Location = new System.Drawing.Point(80, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // FrmAgregarModificarDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(378, 572);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarModificar);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.lblFechaDeNacimiento);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "FrmAgregarModificarDoctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.FrmAgregarModificarDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarModificar;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}