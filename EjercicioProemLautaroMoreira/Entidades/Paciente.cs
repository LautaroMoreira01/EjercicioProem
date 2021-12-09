using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {

        private EObraSocial obraSocial;
        private Doctor.EEspecialidades especialidadRequerida;
        private string nombreDelDoctor;

        /// <summary>
        /// Constructor privado de la clase paciente
        /// </summary>
        /// <param name="nombre">nombre del paciente</param>
        /// <param name="apellido">apellido del paciente</param>
        /// <param name="fechaNacimiento">fecha de nacimiento del paciente</param>
        /// <param name="dni">dni del paciente</param>
        /// <param name="obraSocial">Cobertura social del paciente</param>
        private Paciente(string nombre, string apellido, DateTime fechaNacimiento, int dni, EObraSocial obraSocial) : base(nombre, apellido, fechaNacimiento, dni) 
        {
            this.obraSocial = obraSocial;
        }

        /// <summary>
        /// Constructor de la clase paciente que inicializa los datos del paciente y el nombre del doctor
        /// </summary>
        /// <param name="nombre">nombre del paciente</param>
        /// <param name="apellido">apellido del paciente</param>
        /// <param name="fechaNacimiento">fecha de nacimiento del paciente</param>
        /// <param name="dni">dni del paciente</param>
        /// <param name="obraSocial">obra social del paciente</param>
        /// <param name="nombreDelDoctor">nombre del doctor que requiere el paciente</param>
        public Paciente(string nombre, string apellido, DateTime fechaNacimiento, int dni, EObraSocial obraSocial, string nombreDelDoctor) : this(nombre , apellido, fechaNacimiento, dni , obraSocial)
        {
            this.nombreDelDoctor = nombreDelDoctor;

        }

        /// <summary>
        /// Constructor de la clase paciente que inicializa los datos del paciente y la especialidad requerida por el paciente
        /// </summary>
        /// <param name="nombre">nombre del paciente</param>
        /// <param name="apellido">apellido del paciente</param>
        /// <param name="fechaNacimiento">fecha de nacimiento del paciente</param>
        /// <param name="dni">dni del paciente</param>
        /// <param name="obraSocial">obra social del paciente</param>
        /// <param name="especialidadRequerida">especialida solicitada por el paciente</param>
        public Paciente(string nombre, string apellido, DateTime fechaNacimiento, int dni, EObraSocial obraSocial, Doctor.EEspecialidades especialidadRequerida) : this(nombre, apellido, fechaNacimiento, dni , obraSocial)
        {
            this.especialidadRequerida = especialidadRequerida;
        }

        /// <summary>
        /// Verifica si un paciente se encuentra en una cola de pacientes
        /// </summary>
        /// <param name="pacientes">cola de pacientes</param>
        /// <param name="paciente">paciente a buscar</param>
        /// <returns>true si el paciente se encuentra false si no se encuentra</returns>
        public static bool operator ==(Queue<Paciente> pacientes, Paciente paciente)
        {
            foreach (Paciente paciente1 in pacientes)
            {
                if (paciente1 == paciente)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si un paciente no se encuentra en una cola de pacientes
        /// </summary>
        /// <param name="pacientes">cola de pacientes</param>
        /// <param name="paciente">paciente a buscar</param>
        /// <returns>true si el paciente no se encuentra, false si se encuentra</returns>
        public static bool operator !=(Queue<Paciente> pacientes, Paciente paciente)
        {
            return !(pacientes == paciente);
        }

        /// <summary>
        /// Agrega un paciente a una cola de pacientes si este no se encuentra en la cola
        /// </summary>
        /// <param name="pacientes">cola de pacientes</param>
        /// <param name="paciente">paciente a agregar</param>
        /// <returns>true si se pudo agregar, false si no se pudo</returns>
        public static bool operator +(Queue<Paciente> pacientes, Paciente paciente)
        {
            if (pacientes != paciente)
            {
                pacientes.Enqueue(paciente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Elimina un paciente de una cola si este se encuentra
        /// </summary>
        /// <param name="pacientes">cola de pacientes</param>
        /// <param name="paciente">paciente a eliminar</param>
        /// <returns>true si se pudo eliminar false si no</returns>
        public static bool operator -(Queue<Paciente> pacientes, Paciente paciente)
        {
            if (pacientes == paciente)
            {
                pacientes.Dequeue();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Propiedad que retorna o asinga la obra social de un paciente
        /// </summary>
        public EObraSocial ObraSocial
        { 
            get => obraSocial;
            set => obraSocial = value;
        }

        /// <summary>
        /// Propiedad que retorna o asinga la especialidad que requiere un paciente
        /// </summary>
        public Doctor.EEspecialidades EspecialidadRequerida 
        { 
            get => especialidadRequerida;
            set => especialidadRequerida = value;
        }


        /// <summary>
        /// Propiedad que retorna o asinga el nombre de un doctor que requiere un paciente
        /// </summary>
        public string NombreDelDoctor 
        { 
            get => nombreDelDoctor;
            set => nombreDelDoctor = value; 
        }

        /// <summary>
        /// Enumerado con los tipos de coberturas que puede tener una obra social
        /// </summary>
        public enum EObraSocial
        {
            NoTiene,
            CoberturaBasica,
            CoberturaCompleta
        }

        /// <summary>
        /// Sobrescritura del metodo equals que compara el objeto pasado por dni
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Paciente paciente && Dni == paciente.Dni;
        }

        /// <summary>
        /// Sobrescritura del metodo GetHashCode que retorna el hash code del dni
        /// </summary>
        /// <returns>int hash code del dni</returns>
        public override int GetHashCode()
        {
            return Dni.GetHashCode() ;
        }
    }
}

