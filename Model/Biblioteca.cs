using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    static class Biblioteca
    {
        private static List<Socio> listaSocios = new List<Socio>();
        private static List<Libro> listaLibros = new List<Libro>();
        private static List<Prestamo> listaHistorialPrestamos = new List<Prestamo>();

        internal static List<Socio> ListaSocios { get => listaSocios; set => listaSocios = value; }
        internal static List<Libro> ListaLibros { get => listaLibros; set => listaLibros = value; }
        public static List<Prestamo> ListaHistorialPrestamos => listaHistorialPrestamos;

        public static void CrearSocioVIP(string nombre, string apellido, int identificacion)
        {
           
                SocioVIP socioVIP = new SocioVIP(nombre, apellido, identificacion);

                ListaSocios.Add(socioVIP);
            
            
        }

        public static void CrearSocioComun(string nombre, string apellido, int identificacion)
        {

            Socio socio = new Socio(nombre, apellido, identificacion);

            ListaSocios.Add(socio);
        }
        public static void CrearLibro(string autor, string nombre, int codigo, int cantidad, int numedic1, int numedic2, int numedic3, string ubic, string ubic2, string ubic3)
        {
            //constructor que pase lo datos

            if (nombre != "" & codigo != 0 && autor != "") {

                

                    Libro libro = new Libro(nombre, codigo, autor);
                    libro.AgregarEjemplares(cantidad, numedic1, numedic2, numedic3, ubic, ubic2, ubic3);
                    ListaLibros.Add(libro);
                
            
            }
               /* Libro libro = new Libro(nombre, codigo, autor);
                libro.AgregarEjemplares(cantidad, numedic1, numedic2, numedic3, ubic, ubic2, ubic3);
               */
            

        }

        public static void NuevoPrestamo(Prestamo nuevoPrestamo)
        {
            listaHistorialPrestamos.Add(nuevoPrestamo);
        }

        public static Libro EncontrarLibroPorCodigo (int codigoLibro)
        {
            return listaLibros.Find((value) => { return value.Codigo == codigoLibro; });
        }

    }
}
