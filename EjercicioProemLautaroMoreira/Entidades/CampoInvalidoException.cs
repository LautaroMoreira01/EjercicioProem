using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CampoInvalidoException : Exception
    {
        /// <summary>
        /// contructor de la clase campoInvalidoException que recibe el mensaje de la excepcion 
        /// </summary>
        /// <param name="message">mensaje de la excepcion</param>
        public CampoInvalidoException(string message) : this(message, null)
        {}

        /// <summary>
        /// contructor de la clase campoInvalidoException que recibe el mensaje de la excepcion y una inner
        /// </summary>
        /// <param name="message">Mensaje de la excepcion</param>
        /// <param name="inner">Inner exception</param>
        public CampoInvalidoException(string message , Exception inner) : base(message, inner)  
        {}
    }
}
