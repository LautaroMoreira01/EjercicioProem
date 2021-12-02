using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Clinica
    {
        private string nombre;
        private List<Doctor> doctores;
        private Queue<Paciente> pacientesALaEspera;
        private List<Consulta> consultas;


        public string Nombre 
        { 
            get => nombre;
        }

        public List<Doctor> Doctores 
        { 
            get => doctores; 
        }
       
        public string InformacionClinica()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine($"------------------------------{nombre}------------------------------");
            sb.AppendLine();
            sb.AppendLine($"Consultas en curso:");
            sb.AppendLine();
            sb.AppendLine($"{MostrarConsultasEnCurso()}");

            return sb.ToString();
        }

        private string MostrarConsultasEnCurso()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Consulta consulta in consultas)
            {
                if (consulta.EnCurso)
                {

                }
            }

            return sb.ToString();
        }

        public List <Doctor> DoctoresDisponibles()
        {
            List<Doctor> doctoresDisp = new List<Doctor>();

            foreach(Doctor doctor in doctores)
            {
                if (doctor.Disponible)
                {
                    doctoresDisp.Add(doctor);
                }
            }

            return doctoresDisp;
        }

        public List<Doctor> BuscarDoctoresPorEspecialidad(Doctor.EEspecialidades especialidad)
        {
            List<Doctor> doctoresDeEspecialidad = new List<Doctor>();

            foreach (Doctor doctor in Doctores)
            {
                if (doctor.Especialidad == especialidad)
                {
                    doctoresDeEspecialidad.Add(doctor);
                }
            }

            return doctoresDeEspecialidad;

        }

        public Queue<Paciente> PacientesALaespera
        {
            get => pacientesALaEspera;
        }
    }
}
