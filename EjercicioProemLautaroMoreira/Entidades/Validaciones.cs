using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Valida si un string no esta vacio o es null
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true si el string es valido, si no false</returns>
        public static bool ValidarString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Valida una fecha de nacimiento.
        /// </summary>
        /// <param name="fechaDeNacimiento">Date a validar</param>
        /// <returns>True si la fecha de nacimiento es mas chica que la fecha actual.</returns>
        public static bool ValidarFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            if (fechaDeNacimiento.Date >= DateTime.Today)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Valida un numero.
        /// </summary>
        /// <param name="numeroStr"></param>
        /// <returns>true si el numero es valido</returns>
        public static bool ValidarNumero(string numeroStr)
        {
            if (ValidarString(numeroStr) && long.TryParse(numeroStr , out long numero))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
