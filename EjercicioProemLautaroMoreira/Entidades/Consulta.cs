using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta
    {
        Doctor doctor;
        Paciente paciente;
        bool enCurso;
        EResultadoConsulta resultadoConsulta;

        /// <summary>
        /// Constructor de la clase consulta
        /// </summary>
        /// <param name="doctor">Doctor de la consulta</param>
        /// <param name="paciente">Paciente de la consulta</param>
        public Consulta(Doctor doctor, Paciente paciente)
        {
            this.doctor = doctor;
            this.paciente = paciente;
        }

        /// <summary>
        /// Muestra la informacion de la consulta
        /// </summary>
        /// <returns>string con la informacion de la consulta</returns>
        public string MostrarInformacionConsulta()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Doctor: {doctor.ToString()}");

            sb.AppendLine();
            
            sb.AppendLine($"Paciente: {paciente.ToString()}");

            sb.AppendLine();

            if (enCurso)
            {
                sb.AppendLine("Estado: en curso.");
            }
            else
            {
                sb.AppendLine("Estado: finalizada.");
            }

            return sb.ToString();

        }

        /// <summary>
        /// Metodo que inicializa la consulta
        /// </summary>
        /// <returns>true si se pudo inicializar la consulta, false si no se pudo inicializar</returns>
        public bool IniciarConsulta( )
        {

            if (doctor is not null && doctor.Disponible)
            {
                doctor.Disponible = false;
                doctor.CantidadDePacientesAtendidos++;
                enCurso = true;
                return true;
            }
            else
            {
                return false;
            } 
        }

        /// <summary>
        /// Metodo que finaliza la consulta
        /// </summary>
        /// <returns>Consulta finalizada</returns>
        public Consulta FinalizarConsulta()
        {
            Random random = new Random();

            if (enCurso)
            {
                doctor.Disponible = true;
                enCurso = false;
                resultadoConsulta = (EResultadoConsulta)random.Next(0, 10);
                return this;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Propiedad que retorna le doctor de la consulta
        /// </summary>
        public Doctor Doctor 
        {
            get => doctor;
        }


        /// <summary>
        /// Propiedad que retorna el paciente de la consulta
        /// </summary>
        public Paciente Paciente
        {
            get => paciente;
        }

        /// <summary>
        /// Retorna o asigna el estadp de la consulta
        /// </summary>
        public bool EnCurso 
        { 
            get => enCurso;
        }
    }
}
