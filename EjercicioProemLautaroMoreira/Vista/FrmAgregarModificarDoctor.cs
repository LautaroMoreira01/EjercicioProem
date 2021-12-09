using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAgregarModificarDoctor : Form
    {
        private Doctor doctor;
        public Doctor Objeto { get => doctor;}
        public FrmAgregarModificarDoctor()
        {
            InitializeComponent();
        }

        public FrmAgregarModificarDoctor(Doctor doctor) : this()
        {
            this.doctor = doctor;

        }

        private void FrmAgregarModificarDoctor_Load(object sender, EventArgs e)
        {
            cbEspecialidad.DataSource = Enum.GetValues(typeof(Doctor.EEspecialidades));

            if (doctor is not null)
            {
                tbNombre.Text = doctor.Nombre;
                tbApellido.Text = doctor.Apellido;
                tbDni.Text = doctor.Dni.ToString();
                dtpFechaDeNacimiento.Value = doctor.FechaDeNacimiento;
                tbDni.Enabled = false;

                btnAgregarModificar.Text = "Modificar";
            }
            else
            {

                btnAgregarModificar.Text = "Agregar";
            }

        }


        private void ValidarCampos()
        {
            try
            {
                bool nombre = ValidarCampoNombre();
                bool apellido = ValidarCampoApellido();
                bool dni = ValidarCampoDni();
                bool fechaNacimiento = ValidarCampoFechaDeNacimiento();
                

            }
            catch (CampoInvalidoException)
            {
                throw;
            }
        }
        private bool ValidarCampoNombre()
        {
            if (Validaciones.ValidarString(tbNombre.Text))
            {
                return true;
            }
            else
            {
                throw new CampoInvalidoException("El nombre no puede estar vacio");
            }
        }
        private bool ValidarCampoApellido()
        {
            if (Validaciones.ValidarString(tbApellido.Text))
            {
                return true;
            }
            else
            {
                throw new CampoInvalidoException("El apellido no puede estar vacio");
            }
        }
        private bool ValidarCampoFechaDeNacimiento()
        {
            if (Validaciones.ValidarFechaDeNacimiento(dtpFechaDeNacimiento.Value))
            {
                return true;
            }
            else
            {
                throw new CampoInvalidoException("La fecha de nacimiento no puede ser mas grande que la fecha actual.");
            }
        }
        
        private bool ValidarCampoDni()
        {
            if (Validaciones.ValidarNumero(tbDni.Text))
            {
                return true;
            }
            else
            {
                throw new CampoInvalidoException("El campo dni no puede estar vacio y solamente debe contener numeros.");
            }
        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();

                string nombre = tbNombre.Text;
                string apellido = tbApellido.Text;
                int.TryParse(tbDni.Text, out int dni);
                DateTime fechaNacimiento = dtpFechaDeNacimiento.Value;
                Doctor.EEspecialidades especialidad = (Doctor.EEspecialidades)cbEspecialidad.SelectedIndex;

                if (doctor is not null)
                {
                    doctor.Nombre = nombre;
                    doctor.Apellido = apellido;
                    doctor.Dni = dni;
                }
                else
                {
                    doctor = new Doctor(nombre, apellido, fechaNacimiento, dni, especialidad);
                }

                this.DialogResult = DialogResult.OK;

                Close();
            }
            catch (CampoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
