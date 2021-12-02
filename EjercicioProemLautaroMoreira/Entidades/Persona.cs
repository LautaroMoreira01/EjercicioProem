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
        private DateTime fechaNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public virtual string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Dni: {Dni}");
            sb.AppendLine($"Fecha de nacimiento: {FechaDeNacimiento.ToShortDateString()}");
            sb.AppendLine($"Edad: {Edad}");

            return sb.ToString();

        }

        public override string ToString()
        {
            return nombre + " " + dni + " " + Edad + " ";            
        }

        public string Nombre 
        { 
            get => nombre;
            set => nombre = value;
        }

        public int Dni 
        { 
            get => dni;
            set => dni = value;
        }
        public DateTime FechaDeNacimiento 
        { 
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public int Edad
        { 
            get => fechaNacimiento.CalcularEdadActual();
        }

    }
}
