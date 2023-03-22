using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Ejemplar
    {
        private int numEdicion;
        private string ubicacion;
        private int codigoLibro;

        public Ejemplar(int _numEdicion, string _ubicacion, int _codigoLibro)
        {
            numEdicion = _numEdicion;
            ubicacion = _ubicacion;
            codigoLibro = _codigoLibro;
        }

        public int NumEdicion => numEdicion;
        public string Ubicacion => ubicacion;
        public int CodigoLibro => codigoLibro;
    }
}
