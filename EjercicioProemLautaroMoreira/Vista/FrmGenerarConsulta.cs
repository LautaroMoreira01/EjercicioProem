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

namespace Vista
{
    public partial class FrmGenerarConsulta : Form
    {
        private Paciente paciente;
        private List<Doctor> doctoresDisponibles;
        private Consulta consulta;
        public Consulta Consulta { get => consulta;}

        public FrmGenerarConsulta(Paciente paciente,  List<Doctor> doctoresDisponibles)
        {
            InitializeComponent();
            this.paciente = paciente;
            this.doctoresDisponibles = doctoresDisponibles;
        }

        private void FrmGenerarConsulta_Load(object sender, EventArgs e)
        {
            tbInformacionPaciente.Text = paciente.ToString();
            cbDoctoresDisponibles.DataSource = doctoresDisponibles;
        }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
