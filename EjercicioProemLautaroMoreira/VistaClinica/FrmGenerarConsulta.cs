using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaClinica
{
    public partial class FrmGenerarConsulta : Form
    {
        private Paciente paciente;
        private List<Doctor> doctoresDisponibles;
        private Consulta consulta;

        /// <summary>
        /// Propiedad que retorna la consulta generada
        /// </summary>
        public Consulta Consulta { get => consulta;}

        /// <summary>
        /// Constructor que recibe un paciente y una lista de doctores disponibles
        /// </summary>
        /// <param name="paciente"></param>
        /// <param name="doctoresDisponibles"></param>
        public FrmGenerarConsulta(Paciente paciente,  List<Doctor> doctoresDisponibles)
        {
            InitializeComponent();
            this.paciente = paciente;
            this.doctoresDisponibles = doctoresDisponibles;
        }

        /// <summary>
        /// Carga la informacion en los controles del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGenerarConsulta_Load(object sender, EventArgs e)
        {
            tbInformacionPaciente.Text = paciente.ToString();
            cbDoctoresDisponibles.DataSource = doctoresDisponibles;
        }

        /// <summary>
        /// Genera la consulta con los datos seleccionados en el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarConsulta_Click(object sender, EventArgs e)
        {
            consulta = new Consulta((Doctor)cbDoctoresDisponibles.SelectedItem, paciente);

            if (consulta.IniciarConsulta())
            {
                MessageBox.Show("Consulta iniciada.", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Hubo un error al iniciar la consulta.", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                consulta = null;
            }

            Close();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
