using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Socio
    {
        protected string nombre;
        protected string apellido;
        protected int identificacion;
        protected List<Ejemplar> ejemplaresRetirados = new List<Ejemplar>();
        protected int cantidadMax;

        public string Nombre => nombre;
        public string Apellido => apellido;
        public int Identificacion => identificacion;
        public int CantidadMax => cantidadMax;
        public List<Ejemplar> EjemplaresRetirados { get => ejemplaresRetirados; set => ejemplaresRetirados = value; }

        public Socio(string nombre, string apellido, int identificacion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.identificacion = identificacion;
            cantidadMax = 1; // por ser socio común
        }

        public bool CupoDisponible()
        {
            //consultar si un socio tiene cupo disponible para llevarse un libro
            return (CantidadMax - ejemplaresRetirados.Count()) > 0;
        }

        public bool PedirEjemplarALibro(Libro libro)
        {
            //este meotod debera agregar un ejemplar a la lista de ejemplares retirados por el socio

            if (CupoDisponible())
            {
                Ejemplar ejemplarPrestado = libro.PrestarEjemplarASocio();
                if (ejemplarPrestado != null)
                {
                    EjemplaresRetirados.Add(ejemplarPrestado);
                    Prestamo nuevoPrestamo = new Prestamo(this, ejemplarPrestado, false);
                    Biblioteca.NuevoPrestamo(nuevoPrestamo);
                    return true;
                }
            }
            return false;
        }

        public void DevolverEjemplar(Ejemplar ejemplarADevolver)
        {
            ////este metodo debera eliminar de la lista de ejemlares restirados por el socio, el ejemplar prestado
            ////ya que el socio hizo la devolucion

            int posEjemplarPrestado = ejemplaresRetirados.IndexOf(ejemplarADevolver);

            // Verifica si el ejemplar recibido es en realidad un ejemplar prestado por el socio
            if (posEjemplarPrestado > -1)
            {
                Libro libroDelEjemplar = Biblioteca.EncontrarLibroPorCodigo(ejemplarADevolver.CodigoLibro);
                if (libroDelEjemplar != null)
                {
                    libroDelEjemplar.ReingresoEjemplar(ejemplarADevolver);
                    ejemplaresRetirados.RemoveAt(posEjemplarPrestado); // elimina el ejemplar 
                    Prestamo devolucion = new Prestamo(this, ejemplarADevolver, true);
                    Biblioteca.ListaHistorialPrestamos.Add(devolucion);
                }
            }
        }
    }
}
