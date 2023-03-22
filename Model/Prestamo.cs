using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Prestamo
    {
        private Ejemplar _ejemplar;
        private Socio _socio;
        private string _fecha;
        private bool _devolucion;

        public Prestamo(Socio socioRecibido, Ejemplar ejemplarRecibido, bool devolucion)
        {
            _socio = socioRecibido;
            _ejemplar = ejemplarRecibido;
            _fecha = DateTime.Now.ToString();
            _devolucion = devolucion;
            
        }

        public string Fecha => _fecha;
        internal Ejemplar Ejemplar => _ejemplar;
        internal Socio Socio => _socio;
        internal bool Devolucion => _devolucion;
    }
}
