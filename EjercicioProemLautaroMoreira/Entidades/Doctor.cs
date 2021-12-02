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

        public Doctor(string nombre, DateTime fechaNacimiento, int dni , EEspecialidades especialidad) : base(nombre, fechaNacimiento, dni)
        {
            this.especialidad = especialidad;
            this.pacientesEnEspera = new Queue<Paciente>();
            cantidadDePacientesAtendidos = 0;
            disponible = false;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Especialidad.ToString();
        }

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

        public bool Disponible
        { 
            get => disponible ;
            set => disponible = value;
        }

        public Queue<Paciente> PacientesEnEspera
        {
            get => pacientesEnEspera;
        }

        public EEspecialidades Especialidad 
        { 
            get => especialidad;
        }

        public enum EEspecialidades
        {
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
