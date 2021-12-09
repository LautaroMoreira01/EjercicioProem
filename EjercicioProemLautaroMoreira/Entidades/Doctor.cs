using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Doctor : Persona
    {

        private EEspecialidades especialidad;
        private int cantidadDePacientesAtendidos;
        private bool disponible;
        private Queue<Paciente> pacientesEnEspera;
        private List<Paciente> pacientesAtendidos;

        /// <summary>
        /// Constructor de la clase Doctor que inicializa los atributos
        /// </summary>
        /// <param name="nombre">Nombre del doctor</param>
        /// <param name="apellido">Apellido del doctor</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del doctor</param>
        /// <param name="dni">Dni del doctor</param>
        /// <param name="especialidad">Especialidad del doctor</param>
        public Doctor(string nombre, string apellido, DateTime fechaNacimiento, int dni , EEspecialidades especialidad) : base(nombre, apellido ,fechaNacimiento, dni)
        {
            this.especialidad = especialidad;
            this.pacientesEnEspera = new Queue<Paciente>();
            this.pacientesAtendidos = new List<Paciente>();
            cantidadDePacientesAtendidos = 0;
            disponible = true;
        }

        /// <summary>
        /// Sobrescritura del metodo ToString que muestra nombre, dni y la especialidad del doctor
        /// </summary>
        /// <returns>string con los datos del doctor</returns>
        public override string ToString()
        {
            return base.ToString() + " " + Especialidad.ToString();
        }

        /// <summary>
        /// Muestra la informacion del doctor
        /// </summary>
        /// <returns>string con la informacion del doctor</returns>
        public override string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(base.MostrarInformacion());
            sb.AppendLine($"Especialidad: {especialidad}");

            if (disponible)
            {
                sb.AppendLine($"Estado: disponible");
            }
            else
            {
                sb.AppendLine($"Estado: ocupado");
            }

            sb.AppendLine($"Cantidad de pacientes en lista de espera: {pacientesEnEspera.Count}");

            return sb.ToString();
        }

        /// <summary>
        /// Busca si un doctor se encuentra en una lista de doctores
        /// </summary>
        /// <param name="doctores">Lista de doctores</param>
        /// <param name="doctor">Doctor a buscar</param>
        /// <returns>true si se encuentra, false si no se encuentra</returns>
        public static bool operator ==(List<Doctor> doctores, Doctor doctor)
        {
            foreach (Doctor doc1 in doctores)
            {
                if (doc1 == doctor)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Busca si un doctor no se encuentra en una lista de doctores
        /// </summary>
        /// <param name="doctores">Lista de doctores</param>
        /// <param name="doctor">Doctor a buscar</param>
        /// <returns>false si se encuentra, true si no se encuentra</returns>
        public static bool operator !=(List<Doctor> doctores , Doctor doctor)
        {
            return !(doctores == doctor);
        }

        /// <summary>
        /// Agrega un doctor a una lista de doctores si el doctor no se encuentra en la lista
        /// </summary>
        /// <param name="doctores">Lista de doctores</param>
        /// <param name="doctor">doctor a agregar</param>
        /// <returns>true si se pudo agregar, false si no se pudo</returns>
        public static bool operator +(List<Doctor> doctores, Doctor doctor)
        {
            if (doctores != doctor)
            {
                doctores.Add(doctor);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Elimina un doctor a una lista de doctores si el doctor se encuentra en la lista
        /// </summary>
        /// <param name="doctores">Lista de doctores</param>
        /// <param name="doctor">doctor a agregar</param>
        /// <returns>true si se pudo eliminar, false si no se pudo</returns>
        public static bool operator -(List<Doctor> doctores, Doctor doctor)
        {
            if(doctores == doctor)
            {
                doctores.Remove(doctor);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Propiedad que retorna o asigna el estado de disponibilidad de un doctor
        /// </summary>
        public bool Disponible
        { 
            get => disponible ;
            set => disponible = value;
        }
        
        /// <summary>
        /// Propiedad que retorna la cola de pacientes en espera
        /// </summary>
        public Queue<Paciente> PacientesEnEspera
        {
            get => pacientesEnEspera;
        }

        /// <summary>
        /// Propiedad que retorna la especialidad de un doctor
        /// </summary>
        public EEspecialidades Especialidad 
        { 
            get => especialidad;
        }

        /// <summary>
        /// Propiedad que retorna o asigna la cantidad de pacientes que atendio un doctor
        /// </summary>
        public int CantidadDePacientesAtendidos 
        { 
            get => cantidadDePacientesAtendidos;
            set => cantidadDePacientesAtendidos = value;
        }

        /// <summary>
        /// Compara dos doctores por la cantidad de pacientes atendidos
        /// </summary>
        /// <param name="doctor">Primer doctor a comparar</param>
        /// <param name="doctor1">Segundo doctor a comparar</param>
        /// <returns> 1 si el primer doctor atendio menos pacientes que el segundo, -1 si el segundo atendio menos pacientes</returns>
        public static int CompararDoctoresPorCantidadDePacientesAtendidos(Doctor doctor ,Doctor doctor1)
        {
            if (doctor.CantidadDePacientesAtendidos < doctor1.CantidadDePacientesAtendidos)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Sobrescritura del metodo equals que valida por el dni
        /// </summary>
        /// <param name="obj">obj a comparar</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Doctor doctor && Dni == doctor.Dni ;
        }

        /// <summary>
        /// sobrecarga del getHashCode.
        /// </summary>
        /// <returns>Hash code del dni del doctor</returns>
        public override int GetHashCode()
        {
            return Dni.GetHashCode();
        }

        /// <summary>
        /// Enumerado de las especialidades que pueden tener los doctores
        /// </summary>
        public enum EEspecialidades
        {
            Null,
            Cardgilogia,
            Geriatrica,
            Hematologia,
            Infectologia,
            Neurologia,
            Nutriologia,
            Pediatria,
            Traumatologia,
            Clinico
        }
    }
}
