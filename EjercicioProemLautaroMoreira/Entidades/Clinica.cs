using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Clinica
    {
        private string nombre;
        private static List<Doctor> doctores;
        private static Queue<Paciente> pacientesALaEspera;
        private static List<Consulta> consultasActivas;
        private static List<Consulta> consultasFinalizadas;
        
        /// <summary>
        /// Constructor de la clase clinica que inicializa el nombre
        /// </summary>
        /// <param name="nombre"></param>
        public Clinica(string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Constructor estatico que inicializa las listas de la clase
        /// </summary>
        static Clinica()
        {
            consultasFinalizadas = new List<Consulta>();
            consultasActivas = new List<Consulta>();
            pacientesALaEspera = new Queue<Paciente>();
            doctores = new List<Doctor>();
        }

        /// <summary>
        /// Sobrecarga explicita de string que retorna la informacion de la clinica.
        /// </summary>
        /// <param name="clinica"></param>
        public static explicit operator string(Clinica clinica)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine($"------------------------------{clinica.nombre}------------------------------");
            sb.AppendLine();
            if (clinica.ConsultasActivas.Count > 0)
            {
                sb.AppendLine($"Consultas en curso:");
                sb.AppendLine();
                sb.AppendLine($"{clinica.MostrarConsultasEnCurso()}");
            }
            else
            {
                sb.AppendLine($"No hay consultas en curso actualmente.");
            }
            if (clinica.ConsultasFinalizadas.Count > 0)
            {
                sb.AppendLine($"Consultas finalizadas:");
                sb.AppendLine();
                sb.AppendLine($"{clinica.MostrarConsultasFinalizadas()}");
            }
            else
            {
                sb.AppendLine($"No hay consultas en finalizadas actualmente.");
            }

            return sb.ToString();
        }

        
        /// <summary>
        /// Retorna la informacion de las consultas activas
        /// </summary>
        /// <returns>string con la informacion de las consultas activas</returns>
        public string MostrarConsultasEnCurso()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Consulta consulta in consultasActivas)
            {
                if (consulta.EnCurso)
                {
                    sb.AppendLine("--------------------------------------------------------");
                    sb.AppendLine(consulta.MostrarInformacionConsulta());
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Retorna la informacion de las consultas finalizadas
        /// </summary>
        /// <returns>string con la informacion de las consultas finalizadas</returns>
        public string MostrarConsultasFinalizadas()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Consulta consulta in consultasFinalizadas)
            {
                if (!consulta.EnCurso)
                {
                    sb.AppendLine(consulta.MostrarInformacionConsulta());
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// busca los doctores por especialidad
        /// </summary>
        /// <param name="especialidad">Especialidad a buscar</param>
        /// <returns>Lista de doctores de la especialidad pasada  por parametro</returns>
        public List<Doctor> BuscarDoctoresPorEspecialidad(Doctor.EEspecialidades especialidad)
        {
            List<Doctor> doctores = new List<Doctor>();

            foreach (Doctor doctor in Doctores)
            {
                if (doctor.Especialidad == especialidad)
                {
                    doctores.Add(doctor);
                }
            }

            return doctores;

        }

        /// <summary>
        /// busca los doctores por nombre
        /// </summary>
        /// <param name="nombreDoctor">nombre a buscar</param>
        /// <returns>Lista de doctores con el nombre pasado por parametro</returns>
        public List<Doctor> BuscarDoctoresPorNombre(string nombreDoctor)
        {
            List<Doctor> doctores = new List<Doctor>();

            foreach (Doctor doctor in Doctores)
            {
                if (doctor.Nombre == nombreDoctor)
                {
                    doctores.Add(doctor);
                }
            }

            return doctores;

        }

        /// <summary>
        /// Retorna una lista de doctores ordenada por la cantidad de pacientes atendidos descendientemente 
        /// </summary>
        /// <returns>Lista de doctores ordenada</returns>
        public List<Doctor> DoctoresOrdenadosPorCantidadDePacientesAtendidos()
        {
            List<Doctor> listDoctores = doctores;

            listDoctores.Sort(Doctor.CompararDoctoresPorCantidadDePacientesAtendidos);
            
            return listDoctores;
        }

        /// <summary>
        /// Busca el doctor que atendio mas pacientes
        /// </summary>
        /// <returns>Doctor que atendio mas pacientes</returns>
        public Doctor BuscarDoctorQueAtendioMasPacientes()
        {
            Doctor doc = null;

            foreach (Doctor doctor in doctores)
            {
                if(doc is null || doc.CantidadDePacientesAtendidos < doctor.CantidadDePacientesAtendidos)
                {
                    doc = doctor;
                }
            }
            return doc;
        }

        /// <summary>
        /// Busca el doctor que atendio menos pacientes
        /// </summary>
        /// <returns>Doctor que atendio menos pacientes</returns>
        public Doctor BuscarDoctorQueAtendioMenosPacientes()
        {
            Doctor doc = null;

            foreach (Doctor doctor in doctores)
            {
                if(doc is null || doc.CantidadDePacientesAtendidos > doctor.CantidadDePacientesAtendidos)
                {
                    doc = doctor;
                }
            }
            return doc;
        }

        //Proba esto
        /// <summary>
        /// Busca la especialidad mas requerida en la lista de consultas finalizadas
        /// </summary>
        /// <returns>keyValuePair con la especialidad y la cantidad de veces que fue requerida</returns>
        public KeyValuePair<Doctor.EEspecialidades, int> ConsultarEspecialidadMasPedida()
        {
            Dictionary<Doctor.EEspecialidades, int> lista = new Dictionary<Doctor.EEspecialidades, int>();
            KeyValuePair<Doctor.EEspecialidades, int> especialidadMasSolicitada = default;
            bool existe = false;

            foreach (Consulta consulta in consultasFinalizadas)
            {
                Doctor.EEspecialidades especialidad = consulta.Doctor.Especialidad;

                if (especialidad != Doctor.EEspecialidades.Null)
                {
                    foreach (KeyValuePair<Doctor.EEspecialidades, int> kvp in lista)
                    {
                        if(especialidad == kvp.Key)
                        {
                            lista[especialidad] = kvp.Value + 1;
                            existe = true;
                        }
                    }

                    if (existe == false)
                    {
                        lista.Add(especialidad, 1);
                    }
                }

            }

            foreach (KeyValuePair<Doctor.EEspecialidades, int> kvp in lista)
            {
                if (especialidadMasSolicitada.Equals(default(KeyValuePair<string, int>)) || especialidadMasSolicitada.Value < kvp.Value)
                {
                    especialidadMasSolicitada = kvp;
                }
            }

            return especialidadMasSolicitada;
        }

        /// <summary>
        /// Retorna la lista de doctores en la clinica
        /// </summary>
        public List<Doctor> Doctores
        {
            get => doctores;
            set => doctores = value;
        }


        /// <summary>
        /// Retorna la lista de consultas activas en la clinica
        /// </summary>
        public List<Consulta> ConsultasActivas 
        { 
            get => consultasActivas; 
            set => consultasActivas = value;
        }

        /// <summary>
        /// Retorna la lista de consultas finalizadas en la clinica
        /// </summary>
        public List<Consulta> ConsultasFinalizadas
        { 
            get => consultasFinalizadas; 
            set => consultasFinalizadas = value;
        }


        /// <summary>
        /// Retorna la lista de pacientes en espera en la clinica
        /// </summary>
        public Queue<Paciente> PacientesALaespera
        {
            get => pacientesALaEspera;
            set => pacientesALaEspera = value;
        }
    }
}
