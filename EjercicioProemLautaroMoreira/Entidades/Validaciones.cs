using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {

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

        public static bool ValidarDni(string dni)
        {
            if (ValidarString(dni) && long.TryParse(dni , out long dniLong))
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
