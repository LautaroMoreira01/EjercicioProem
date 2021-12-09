using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int dni;

        /// <summary>
        /// constructor de la clase persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, string apellido, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
            this.apellido = apellido;
        }

        /// <summary>
        /// Muestra la informacion de una persona
        /// </summary>
        /// <returns>string con la informacion de una persona</returns>
        public virtual string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Dni: {Dni}");
            sb.AppendLine($"Fecha de nacimiento: {FechaDeNacimiento.ToShortDateString()}");
            sb.AppendLine($"Edad: {Edad}");

            return sb.ToString();

        }

        /// <summary>
        /// Compara dos personas por el dni
        /// </summary>
        /// <param name="p1">primera persona a comparar</param>
        /// <param name="p2">segunda persona a comparar</param>
        /// <returns>true si los dnis de las personas son iguales</returns>
        public static bool operator ==(Persona p1, Persona p2)
        {
            if (p1.dni == p2.Dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Compara si dos personas son distintas
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Sobre escritura del metodo to string que retona el nombre y el dni de una persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{nombre} {dni}";            
        }

        /// <summary>
        /// Propiedad que retorna o ingresa el nombre de una persona
        /// </summary>
        public string Nombre 
        { 
            get => nombre;
            set => nombre = value;
        }


        /// <summary>
        /// Propiedad que retorna o ingresa el apellido de una persona
        /// </summary>
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }


        /// <summary>
        /// Propiedad que retorna o ingresa el dni de una persona
        /// </summary>
        public int Dni 
        { 
            get => dni;
            set => dni = value;
        }


        /// <summary>
        /// Propiedad que retorna o ingresa la fecha de nacimiento de una persona
        /// </summary>
        public DateTime FechaDeNacimiento 
        { 
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }


        /// <summary>
        /// Propiedad que retorna la edad actual de una persona.
        /// </summary>
        public int Edad
        { 
            get => fechaNacimiento.CalcularEdadActual();
        }

        /// <summary>
        /// Sobrescritura del metodo equals que compara el objeto pasado con el actual por dni
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true si son iguales false si no</returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as Persona) && ((Persona)obj).Dni == dni;
        }

        /// <summary>
        /// Sobrescritura del metodo GetHashCode que retorna el hash code del dni
        /// </summary>
        /// <returns>int hash code del dni</returns>
        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }
    }
}
