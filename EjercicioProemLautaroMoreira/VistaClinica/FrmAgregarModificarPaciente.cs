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

namespace VistaClinica
{
    public partial class FrmAgregarModificarPaciente : Form
    {

        Paciente paciente;
        
        /// <summary>
        /// propiedad que retonrna el paciente creado
        /// </summary>
        public Paciente Objeto { get => paciente; }

        /// <summary>
        /// Constructor publico del form
        /// </summary>
        public FrmAgregarModificarPaciente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor publico que recibe un paciente para poder modificarlo
        /// </summary>
        /// <param name="paciente"></param>
        public FrmAgregarModificarPaciente(Paciente paciente) : this()
        {
            this.paciente = paciente;
        }

        /// <summary>
        /// Load del form que carga datos en los controles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Cambia partes del form dependiendo de la opcion que se elija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// camnbia el form para cargar el nombre del doctor a buscar
        /// </summary>
        private void BuscarDoctorPorNombre()
        {
            lblTipoDoctor.Text = "Nombre del doctor";
            tbNombreDoctor.Visible = true;
            cbEspecialidades.Visible = false;
        }


        /// <summary>
        /// camnbia el form para cargar la especialida de los doctores a buscar
        /// </summary>
        private void BuscarDoctorPorEspecialidad()
        {
            lblTipoDoctor.Text = "Especialidad del doctor";
            tbNombreDoctor.Visible = false;
            cbEspecialidades.Visible = true;
            cbEspecialidades.DataSource = Enum.GetValues(typeof(Doctor.EEspecialidades));
        }

        /// <summary>
        /// Valida los campos de los controles disponibles y nodifica o crea un paciente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Valida los campos del form y tira una excepcion si hay algun error
        /// </summary>
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

        /// <summary>
        /// Valida el campo nombre que no este vacio.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CampoInvalidoException">Si el nombre esta vacio tira la excepcion</exception>
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

        /// <summary>
        /// Valida el campo apellido que no este vacio.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CampoInvalidoException">Si el apellido esta vacio tira la excepcion</exception>
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


        /// <summary>
        /// Valida el campo fecha de nacimiento que no sea mayor o igual a la fecha actual.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CampoInvalidoException">Si la fecha de nacimiento es invalida tira la excepcion</exception>
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

        /// <summary>
        /// Valida el campo nombre doctor
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CampoInvalidoException">Si el campo es invalido tira la excepcion </exception>
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

        /// <summary>
        /// Valida el campo dni 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CampoInvalidoException">si el dni es invalido tira la excepcion</exception>
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


        /// <summary>
        /// Cancela la creacoin o modificacion del doctor y cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


