using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class LaCentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public LaCentralitaException(string mensaje, string clase, string metodo) : base(mensaje, null)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public LaCentralitaException(string mensaje,string clase, string metodo , Exception inner) : base(mensaje, inner)
        {

            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public string NombreClase
        {
            get { return nombreClase; }
        }
        public string NombreMetodo
        {
            get { return nombreMetodo; }
        }
    }
}
