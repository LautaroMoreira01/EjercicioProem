﻿using Entidades;
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
    public partial class FrmAgregarModificarDoctor : Form
    {
        private Doctor doctor;
        
        /// <summary>
        /// propiedad que retonrna el doctor creado
        /// </summary>
        public Doctor Objeto { get => doctor;}

        /// <summary>
        /// Constructor publico del form
        /// </summary>
        public FrmAgregarModificarDoctor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor publico que recibe un doctor para poder modificarlo
        /// </summary>
        /// <param name="doctor"></param>
        public FrmAgregarModificarDoctor(Doctor doctor) : this()
        {
            this.doctor = doctor;

        }

        /// <summary>
        /// Load del form que carga datos en los controles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
