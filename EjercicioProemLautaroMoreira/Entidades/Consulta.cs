using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta
    {
        private Doctor doctor;
        private Paciente paciente;
        private bool enCurso;
        

        public string MostrarInformacionConsulta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Doctor: {doctor.ToString()}");

            sb.AppendLine();
            
            sb.AppendLine($"Paciente: {paciente.ToString()}");

            return sb.ToString();

        }

        public bool IniciarConsulta( Doctor doctor, Paciente paciente)
        {

            if(enCurso == false)
            {
                this.doctor = doctor;
                this.paciente = paciente;
                enCurso = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        private Consulta FinalizarConsulta()
        {
            if (enCurso)
            {
                enCurso = false;
                return this;
            }
            else
            {
                return null;
            }
        }

        public Doctor Doctor 
        {
            get => doctor;
            set => doctor = value;
        }

        public Paciente Paciente
        {
            get => paciente;
            set => paciente = value;
        }

        public bool EnCurso 
        { 
            get => enCurso;
            set => enCurso = value;
        }
    }
}
