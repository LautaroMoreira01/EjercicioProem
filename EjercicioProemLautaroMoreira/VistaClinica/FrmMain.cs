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
    public partial class FrmMain : Form
    {
        Clinica clinica;

        /// <summary>
        /// Constructor del form principal
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            clinica = new Clinica("Clinica");
        }

        /// <summary>
        /// Evento que carga datos en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {

            CargarDoctores();
            CargarPacientes();

            cbEstadisticasHistoricas.Visible = false;
            btnAgregarDoctor.Enabled = false;
            btnModificarDoctor.Enabled = false;
            btnModificarPaciente.Enabled = false;
            btnAgregarPaciente.Enabled = false;
            btnEliminarDoctor.Enabled = false;
            btnEliminarPaciente.Enabled = false;
            btnConsulta.Enabled = false;
            btnFinalizarConsulta.Enabled = false;

        }

        /// <summary>
        /// Carga los doctores en la clinica
        /// </summary>
        private void CargarDoctores()
        {
            clinica.Doctores.Add(new Doctor("Miguel", "Alemany", new DateTime(1970, 2, 12), 12457896, Doctor.EEspecialidades.Neurologia));
            clinica.Doctores.Add(new Doctor("Alejandro", "Terejo", new DateTime(1969, 10, 18), 16987654, Doctor.EEspecialidades.Neurologia));
            clinica.Doctores.Add(new Doctor("Marc", "Sevilla", new DateTime(1974, 5, 10), 13456789, Doctor.EEspecialidades.Clinico));
            clinica.Doctores.Add(new Doctor("Pedro", "Zamora", new DateTime(1964, 5, 9), 10325478, Doctor.EEspecialidades.Cardgilogia));
            clinica.Doctores.Add(new Doctor("Camila", "Osorio", new DateTime(1960, 1, 8), 11321654, Doctor.EEspecialidades.Pediatria));
            clinica.Doctores.Add(new Doctor("Jose", "Sousa", new DateTime(1959, 5, 15), 15654987, Doctor.EEspecialidades.Pediatria));
            clinica.Doctores.Add(new Doctor("Manuel", "Cerezo", new DateTime(1974, 7, 23), 16879654, Doctor.EEspecialidades.Clinico));

        }


        /// <summary>
        /// Carga los pacientes en la clinica
        /// </summary>
        private void CargarPacientes()
        {
            clinica.PacientesALaespera.Enqueue(new Paciente("Valerio", "Manzano", new DateTime(1974, 7, 23), 16879654, Paciente.EObraSocial.CoberturaCompleta, Doctor.EEspecialidades.Cardgilogia));
            clinica.PacientesALaespera.Enqueue(new Paciente("Alezander", "Cabanillas", new DateTime(1978, 5, 21), 24321654, Paciente.EObraSocial.CoberturaBasica, Doctor.EEspecialidades.Neurologia));
            clinica.PacientesALaespera.Enqueue(new Paciente("Julio", "Talavera", new DateTime(1998, 4, 19), 26321654, Paciente.EObraSocial.NoTiene, Doctor.EEspecialidades.Clinico));
            clinica.PacientesALaespera.Enqueue(new Paciente("Maria", "Galera", new DateTime(2000, 3, 5), 26654987, Paciente.EObraSocial.CoberturaBasica, "Marc"));
            clinica.PacientesALaespera.Enqueue(new Paciente("Tomasa", "Verdugo", new DateTime(2001, 6, 8), 28987654, Paciente.EObraSocial.CoberturaCompleta, Doctor.EEspecialidades.Cardgilogia));
            clinica.PacientesALaespera.Enqueue(new Paciente("Luis", "Herreros", new DateTime(1997, 2, 6), 32654987, Paciente.EObraSocial.CoberturaBasica, Doctor.EEspecialidades.Neurologia));
            clinica.PacientesALaespera.Enqueue(new Paciente("Maximo", "Palazon", new DateTime(1996, 5, 12), 33321654, Paciente.EObraSocial.NoTiene, "Marc"));
            clinica.PacientesALaespera.Enqueue(new Paciente("Eva", "Galan", new DateTime(2021, 4, 21), 44321654, Paciente.EObraSocial.CoberturaBasica, "Jose"));
            clinica.PacientesALaespera.Enqueue(new Paciente("Florencia", "Cadenas", new DateTime(2000, 8, 19), 28975654, Paciente.EObraSocial.CoberturaCompleta, Doctor.EEspecialidades.Clinico));
            clinica.PacientesALaespera.Enqueue(new Paciente("Leonardo", "Valdivia", new DateTime(1995, 4, 20), 27987423, Paciente.EObraSocial.NoTiene, Doctor.EEspecialidades.Infectologia));
            clinica.PacientesALaespera.Enqueue(new Paciente("Mariano", "Laguna", new DateTime(2000, 7, 2), 28654125, Paciente.EObraSocial.CoberturaCompleta, Doctor.EEspecialidades.Clinico));
            clinica.PacientesALaespera.Enqueue(new Paciente("Fabian", "Montoya", new DateTime(1998, 5, 1), 25879642, Paciente.EObraSocial.CoberturaBasica, "Manuel"));

        }

        /// <summary>
        /// Evento que muestra la informacion de los doctores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInformacionDoctores_Click(object sender, EventArgs e)
        {
            ActualizarDataGridDoctores(clinica.Doctores);

            cbEstadisticasHistoricas.Visible = false;
            btnAgregarDoctor.Enabled = true;
            btnEliminarDoctor.Enabled = true;
            btnModificarDoctor.Enabled = true;
            btnAgregarPaciente.Enabled = false;
            btnEliminarPaciente.Enabled = false;
            btnModificarPaciente.Enabled = false;
            btnConsulta.Enabled = false;
            btnFinalizarConsulta.Enabled = false;
            dgvPersonas.Visible = true;

        }

        /// <summary>
        /// Evento que muestra la informacion de los pacientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInformacionPacientes_Click(object sender, EventArgs e)
        {
            ActualizarDataGridPacientes(clinica.PacientesALaespera);
            cbEstadisticasHistoricas.Visible = false;
            dgvPersonas.Visible = true;
            btnAgregarDoctor.Enabled = false;
            btnEliminarDoctor.Enabled = false;
            btnModificarDoctor.Enabled = false;
            btnConsulta.Enabled = false;
            btnFinalizarConsulta.Enabled = false;
            btnAgregarPaciente.Enabled = true;
            btnEliminarPaciente.Enabled = true;
            btnModificarPaciente.Enabled = true;

        }

        /// <summary>
        /// Actualiza el dataGrid con la informacion de los doctores
        /// </summary>
        /// <param name="doctores">Lista de doctores a poner en el data grid</param>
        private void ActualizarDataGridDoctores(List<Doctor> doctores)
        {
            if (dgvPersonas.Columns.Contains("state"))
            {
                dgvPersonas.Columns.Remove("columnNum");
                dgvPersonas.Columns.Remove("state");
                dgvPersonas.Columns.Remove("doctorName");
                dgvPersonas.Columns.Remove("patientName");
                dgvPersonas.Columns.Remove("especialidadRequerida");


            }

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = doctores;
            dgvPersonas.Columns[1].Visible = false;
            dgvPersonas.Select();
        }

        /// <summary>
        /// Actualiza el dataGrid con la informacion de los pacientes
        /// </summary>
        /// <param name="pacientes">cola de pacientes a poner en el datagrid</param>
        private void ActualizarDataGridPacientes(Queue<Paciente> pacientes)
        {
            if (dgvPersonas.Columns.Contains("state"))
            {
                dgvPersonas.Columns.Remove("columnNum");
                dgvPersonas.Columns.Remove("state");
                dgvPersonas.Columns.Remove("doctorName");
                dgvPersonas.Columns.Remove("patientName");
                dgvPersonas.Columns.Remove("especialidadRequerida");


            }
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = pacientes.ToList();
            dgvPersonas.Select();
        }

        /// <summary>
        /// Llama al frmGenerarConsulta pasando el primer paciente en la fila y los doctores si pide por especialidad o por nombre, y actualiza la lista de las consultas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            List<Paciente> aux = clinica.PacientesALaespera.ToList();
           
            Paciente p = aux[0];

            List<Doctor> doctoresABuscar = new List<Doctor>();
            
            if (p.EspecialidadRequerida == Doctor.EEspecialidades.Null)
            {
                doctoresABuscar = clinica.BuscarDoctoresPorNombre(p.NombreDelDoctor);
            }
            else
            {
                doctoresABuscar = clinica.BuscarDoctoresPorEspecialidad(p.EspecialidadRequerida);
            }

            FrmGenerarConsulta frmGenerarConsulta =  new FrmGenerarConsulta(p, doctoresABuscar);
            frmGenerarConsulta.ShowDialog();
            
            if (frmGenerarConsulta.Consulta is not null)
            {
                clinica.ConsultasActivas.Add(frmGenerarConsulta.Consulta);
                clinica.PacientesALaespera.Dequeue();
                MostrarDgvConsultas();
            }
        }

        /// <summary>
        /// Permite acceder al historial de la clinica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInformacionClinica_Click(object sender, EventArgs e)
        {
            cbEstadisticasHistoricas.SelectedIndex = 0;
            cbEstadisticasHistoricas.Visible = true;
            
            dgvPersonas.Visible = false;
            rtbInformacion.Visible = true;


        }

        /// <summary>
        /// llama al formulario agregarModificar Doctor y permite agregar un doctor a la lista de doctores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctorAAgregar;

            FrmAgregarModificarDoctor frmAgregarModificarDoctor = new FrmAgregarModificarDoctor();
            
            frmAgregarModificarDoctor.ShowDialog();

            if(frmAgregarModificarDoctor.Objeto is not null)
            {
                doctorAAgregar = frmAgregarModificarDoctor.Objeto;

                if(clinica.Doctores + doctorAAgregar)
                {
                    MessageBox.Show("Doctor agregado." , "Agregrar" , MessageBoxButtons.OKCancel , MessageBoxIcon.Exclamation);
                } 

                ActualizarDataGridDoctores(clinica.Doctores);
            }

        }

        /// <summary>
        /// llama al formulario agregarModificar Doctor y permite Modificar el doctor seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarDoctor_Click(object sender, EventArgs e)
        {
                         
            
            if (dgvPersonas.SelectedRows.Count >= 0)
            {
                Doctor doctorAModificar = (Doctor)dgvPersonas.CurrentRow.DataBoundItem;

                FrmAgregarModificarDoctor frmAgregarModificarDoctor = new FrmAgregarModificarDoctor(doctorAModificar);

                frmAgregarModificarDoctor.ShowDialog();

                if (frmAgregarModificarDoctor.DialogResult == DialogResult.OK)
                {
                    
                    MessageBox.Show("Doctor modificado.", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    ActualizarDataGridDoctores(clinica.Doctores);
                }
            }

        }

        /// <summary>
        /// permite eliminar un doctor seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarDoctor_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count >= 0)
            {
                Doctor doctorAEliminar = (Doctor)dgvPersonas.CurrentRow.DataBoundItem;

                DialogResult dr = MessageBox.Show($"Esta seguro que desea eiliminar a {doctorAEliminar.ToString()}.", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.OK && clinica.Doctores - doctorAEliminar)
                {
                    MessageBox.Show("Doctor eliminado.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                ActualizarDataGridDoctores(clinica.Doctores);
                
            }
        }

        /// <summary>
        /// llama al formulario agregarModificarPaciente y permite agregar un paciente a la lista de pacientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            Paciente pacienteAAgregar;

            FrmAgregarModificarPaciente frmAgregarModificarPaciente = new FrmAgregarModificarPaciente();

            frmAgregarModificarPaciente.ShowDialog();

            if (frmAgregarModificarPaciente.Objeto is not null)
            {
                pacienteAAgregar = frmAgregarModificarPaciente.Objeto;

                if (clinica.PacientesALaespera + pacienteAAgregar)
                {
                    MessageBox.Show("Paciente agregado.", "Agregrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }

                ActualizarDataGridPacientes(clinica.PacientesALaespera);
            }

        }

        /// <summary>
        /// llama al formulario agregarModificarPaciente y permite mopdificar un paciente seleccioando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {

            if (dgvPersonas.SelectedRows.Count >= 0)
            {
                Paciente pacienteAModificar = (Paciente)dgvPersonas.CurrentRow.DataBoundItem;

                FrmAgregarModificarPaciente frmAgregarModificarPaciente = new FrmAgregarModificarPaciente(pacienteAModificar);

                frmAgregarModificarPaciente.ShowDialog();

                if (frmAgregarModificarPaciente.DialogResult == DialogResult.OK)
                {

                    MessageBox.Show("Paciente modificado.", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    ActualizarDataGridPacientes(clinica.PacientesALaespera);

                }
            }
        }

        /// <summary>
        /// Elimina el paciente seleccionado en el dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count >= 0)
            {
                Paciente pacienteAEliminar = (Paciente)dgvPersonas.CurrentRow.DataBoundItem;

                DialogResult dr = MessageBox.Show($"Esta seguro que desea eiliminar a {pacienteAEliminar}.", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.OK && clinica.PacientesALaespera - pacienteAEliminar)
                {
                    MessageBox.Show("Paciente eliminado.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                ActualizarDataGridPacientes(clinica.PacientesALaespera);


            }
        }

        /// <summary>
        /// Muestra las consultas activas en un dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarConsultasActivas_Click(object sender, EventArgs e)
        {
            cbEstadisticasHistoricas.Visible = false;
            btnAgregarDoctor.Enabled = false;
            btnModificarDoctor.Enabled = false;
            btnEliminarDoctor.Enabled = false;
            btnEliminarPaciente.Enabled = false;
            btnAgregarPaciente.Enabled = false;
            btnModificarPaciente.Enabled = false;
            btnConsulta.Enabled = true;
            btnFinalizarConsulta.Enabled = true;
            MostrarDgvConsultas();
        }
        
        /// <summary>
        /// Muestra las consultas en un dataGridView
        /// </summary>
        private void MostrarDgvConsultas()
        {
            dgvPersonas.Visible = true;

            int count = 0;

            dgvPersonas.DataSource = null;

            if (dgvPersonas.Columns.Contains("state"))
            {
                dgvPersonas.Columns.Remove("especialidadRequerida");
                dgvPersonas.Columns.Remove("columnNum");
                dgvPersonas.Columns.Remove("state");
                dgvPersonas.Columns.Remove("doctorName");
                dgvPersonas.Columns.Remove("patientName");
                dgvPersonas.Rows.Clear();

            }

            dgvPersonas.Columns.Add("columnNum", "numero consulta");
            dgvPersonas.Columns.Add("state", "Estado de consulta");
            dgvPersonas.Columns.Add("doctorName" , " Nombre doctor");
            dgvPersonas.Columns.Add("PatientName", "Nombre de paciente");
            dgvPersonas.Columns.Add("especialidadRequerida", "Especialidad");


            foreach (Consulta consulta in clinica.ConsultasActivas)
            {
                count++;
                Object[] consult = new Object[] { count, consulta.EnCurso ,consulta.Doctor.Nombre , consulta.Paciente.Nombre };
        
                dgvPersonas.Rows.Add(consult);

            }

        }

        /// <summary>
        /// Finaliza una consulta seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvPersonas.CurrentRow.Index;

                if (dgvPersonas.CurrentRow.Index >= 0)
                {
                    Consulta consulta = clinica.ConsultasActivas[index];
                    DialogResult dr = MessageBox.Show($"Esta seguro que desea finalizar la consulta {consulta.MostrarInformacionConsulta()}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        consulta.FinalizarConsulta();
                        clinica.ConsultasFinalizadas.Add(consulta);
                        clinica.ConsultasActivas.RemoveAt(index);

                        MostrarDgvConsultas();

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar una consulta para finalizarla", "Error" , MessageBoxButtons.OKCancel , MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Al cambiar el inidce de el combobox muestra en el RichTextBox La opcion seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbEstadisticasHistoricas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEstadisticasHistoricas.SelectedIndex)
            {
                case 0:
                    MostrarDoctoresOrdenadosPorCantidadDePacientesAtendidos();
                    break;
                case 1:
                    MostrarDoctorConMasPacientesAtendidos();
                    break;
                case 2:
                    MostrarEspecialidadConMasConsultas();
                    break;
                case 3:
                    MostrarDoctorConMenosPacientesAtendidos();
                    break;
            }
        }

        /// <summary>
        /// Muestra los doctores ordenados por cantidad de pacientes atendidos en forma descendiente
        /// </summary>
        private void MostrarDoctoresOrdenadosPorCantidadDePacientesAtendidos()
        {
            StringBuilder sb = new StringBuilder();  
            List<Doctor>doctors = clinica.DoctoresOrdenadosPorCantidadDePacientesAtendidos();
            
            foreach (Doctor doc in doctors)
            {
                sb.Append(doc.ToString() + $" Cantidad de pacientes atendidos: {doc.CantidadDePacientesAtendidos} \n");
            }

            rtbInformacion.Text = sb.ToString();
        }

        /// <summary>
        /// Muestra el doctor con mas pacientes atendidos
        /// </summary>
        private void MostrarDoctorConMasPacientesAtendidos()
        {
            Doctor doctor = clinica.BuscarDoctorQueAtendioMasPacientes();
            rtbInformacion.Text = doctor.ToString() + $" Cantidad de pacientes atendidos: {doctor.CantidadDePacientesAtendidos}";
        }


        /// <summary>
        /// Muestra el doctor con menos pacientes atendidos
        /// </summary>
        private void MostrarDoctorConMenosPacientesAtendidos()
        {
            Doctor doctor = clinica.BuscarDoctorQueAtendioMenosPacientes();
            rtbInformacion.Text = doctor.ToString() + $" Cantidad de pacientes atendidos: {doctor.CantidadDePacientesAtendidos}";


        }

        /// <summary>
        /// Muestra la especialidad mas requerida por los pacientes
        /// </summary>
        private void MostrarEspecialidadConMasConsultas()
        {
            KeyValuePair<Doctor.EEspecialidades, int> especialidadConMasConsultas = clinica.ConsultarEspecialidadMasPedida();
            rtbInformacion.Text = $"Especialidad mas pedida: {especialidadConMasConsultas.Key} Veces pedida: {especialidadConMasConsultas.Value}";

        }

        /// <summary>
        /// Muestra las consutlas finalizadas en un dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarConsultasFinalizadas_Click(object sender, EventArgs e)
        {
            cbEstadisticasHistoricas.Visible = false;
            btnAgregarDoctor.Enabled = false;
            btnModificarDoctor.Enabled = false;
            btnEliminarDoctor.Enabled = false;
            btnEliminarPaciente.Enabled = false;
            btnAgregarPaciente.Enabled = false;
            btnModificarPaciente.Enabled = false;
            btnConsulta.Enabled = true;
            btnFinalizarConsulta.Enabled = true;
            MostrarConsultasFinalizadas();
        }


        /// <summary>
        /// Guarda las consultas finalizadas en un dataGridView
        /// </summary>
        private void MostrarConsultasFinalizadas()
        {
            dgvPersonas.Visible = true;

            int count = 0;

            dgvPersonas.DataSource = null;

            if (dgvPersonas.Columns.Contains("state"))
            {
                dgvPersonas.Columns.Remove("columnNum");
                dgvPersonas.Columns.Remove("state");
                dgvPersonas.Columns.Remove("doctorName");
                dgvPersonas.Columns.Remove("patientName");
                dgvPersonas.Columns.Remove("especialidadRequerida");
                dgvPersonas.Rows.Clear();

            }

            dgvPersonas.Columns.Add("columnNum", "numero consulta");
            dgvPersonas.Columns.Add("state", "Estado de consulta");
            dgvPersonas.Columns.Add("doctorName", " Nombre doctor");
            dgvPersonas.Columns.Add("PatientName", "Nombre de paciente");
            dgvPersonas.Columns.Add("especialidadRequerida", "Especialidad");


            foreach (Consulta consulta in clinica.ConsultasFinalizadas)
            {
                count++;
                Object[] consult = new Object[] { count, consulta.EnCurso, consulta.Doctor.Nombre, consulta.Paciente.Nombre , consulta.Doctor.Especialidad};

                dgvPersonas.Rows.Add(consult);

            }

        }
    }
}
