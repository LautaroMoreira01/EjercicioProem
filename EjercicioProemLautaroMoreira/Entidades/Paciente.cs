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

        public Paciente(string nombre, DateTime fechaNacimiento, int dni, EObraSocial obraSocial, string nombreDelDoctor) : base(nombre, fechaNacimiento, dni)
        {
            this.obraSocial = obraSocial;
            this.nombreDelDoctor = nombreDelDoctor;
        }

        public Paciente(string nombre, DateTime fechaNacimiento, int dni, EObraSocial obraSocial, Doctor.EEspecialidades especialidadRequerida) : base(nombre, fechaNacimiento, dni)
        {
            this.obraSocial = obraSocial;
            this.especialidadRequerida = especialidadRequerida;
        }

        public EObraSocial ObraSocial
        { 
            get => obraSocial;
            set => obraSocial = value;
        }

        public enum EObraSocial
        {
            NoTiene,
            CoberturaBasica,
            CoberturaCompleta
        }
    }
}

