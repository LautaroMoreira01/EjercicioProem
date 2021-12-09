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
    public partial class FrmAgregarModificarPaciente : Form
    {

        Paciente paciente;
        public Paciente Objeto { get => paciente; }
        public FrmAgregarModificarPaciente()
        {
            InitializeComponent();
        }

        public FrmAgregarModificarPaciente(Paciente paciente) : this()
        {
            this.paciente = paciente;
        }

        private void FrmAgregarPaciente_Load(object sender, EventArgs e)
        {
            if(paciente is not null)
            {
                tbNombre.Text = paciente.Nombre;
                tbApellido.Text = paciente.Apellido;
                tbDni.Text = paciente.Dni.ToString();
                dtpFechaDeNacimiento.Value = paciente.FechaDeNacimiento;
                cbObraSocial.SelectedIndex = (int)paciente.ObraSocial;
                tbDni.Enabled = false;

                if(paciente.NombreDelDoctor is not null)
                {
                    BuscarDoctorPorNombre();
                    tbNombreDoctor.Text = paciente.NombreDelDoctor;
                }
                else
                {
                    BuscarDoctorPorEspecialidad();
                    cbBuscarDoctorPor.SelectedIndex = (int)paciente.EspecialidadRequerida;
                }

                btnAgregarModificar.Text = "Modificar";
            }
            else
            {
                cbObraSocial.DataSource = Enum.GetValues(typeof(Paciente.EObraSocial));

                btnAgregarModificar.Text = "Agregar";
            }
        }


        private void cbBuscarDoctorPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBuscarDoctorPor.SelectedIndex == 0)
            {
                BuscarDoctorPorNombre();
            }
            else
            {
                BuscarDoctorPorEspecialidad();
            }
        }
        
        private void BuscarDoctorPorNombre()
        {
            lblTipoDoctor.Text = "Nombre del doctor";
            tbNombreDoctor.Visible = true;
            cbEspecialidades.Visible = false;
        }
        private void BuscarDoctorPorEspecialidad()
        {
            lblTipoDoctor.Text = "Especialidad del doctor";
            tbNombreDoctor.Visible = false;
            cbEspecialidades.Visible = true;
            cbEspecialidades.DataSource = Enum.GetValues(typeof(Doctor.EEspecialidades));
        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
        {

            try
            {
                ValidarCampos();

                string nombre = tbNombre.Text;
                string apellido = tbApellido.Text;
                int.TryParse(tbDni.Text, out int dni);
                string nombreDoctor = tbNombreDoctor.Text;
                DateTime fechaNacimiento = dtpFechaDeNacimiento.Value;
                Paciente.EObraSocial obraSocial = (Paciente.EObraSocial)cbObraSocial.SelectedIndex;
                Doctor.EEspecialidades especialidades = (Doctor.EEspecialidades)cbEspecialidades.SelectedIndex;

                if (paciente is not null)
                {
                    paciente.Nombre = nombre;
                    paciente.Apellido = apellido;
                    paciente.NombreDelDoctor = nombreDoctor;
                    paciente.FechaDeNacimiento = fechaNacimiento;
                    
                    if (cbBuscarDoctorPor.SelectedIndex == 0)
                    {
                        paciente.NombreDelDoctor = nombreDoctor;
                    }
                    else
                    {
                        paciente.EspecialidadRequerida = especialidades;
                    }
                }
                else
                {
                    if (cbBuscarDoctorPor.SelectedIndex == 0 ) 
                    { 
                        paciente = new Paciente(nombre, apellido, fechaNacimiento ,dni, obraSocial ,nombreDoctor);
                    }
                    else
                    {
                        paciente = new Paciente(nombre, apellido, fechaNacimiento, dni, obraSocial, especialidades);
                    }
                }

            }
            catch (CampoInvalidoException ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if(cbBuscarDoctorPor.SelectedIndex == 0)
                {
                    bool nombreDoctor = ValidarCampoNombreDoctor();
                }

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
        private bool ValidarCampoNombreDoctor()
        {
            if (Validaciones.ValidarString(tbNombreDoctor.Text))
            {
                return true;
            }
            else
            {
                throw new CampoInvalidoException("El nombre del doctor no puede estar vacio");
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
    }
}
