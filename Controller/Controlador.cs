using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Controlador
    {


        public void CrearSocioVIP(string nombre, string apellido, int identificacion) {

            Biblioteca.CrearSocioVIP(nombre, apellido, identificacion);
        }

        public void CrearSocioComun(string nombre, string apellido, int identificacion)
        {

           
            Biblioteca.CrearSocioComun(nombre, apellido, identificacion);
        }

        public void CrearLibro(int cantidad = 0, string nombre = "", string autor = "", int codigo = 0,  int numedic1 = 0, int numedic2 = 0, int numedic3 = 0, string ubic = "", string ubic2 = "", string ubic3 = "") {
 
            //revisar que pasa cuando le paso a autor numeros ,se agrega o no , se pueden comparar con int.parse(autor)>0 ?
             Biblioteca.CrearLibro(autor, nombre, codigo, cantidad, numedic1, numedic2, numedic3, ubic, ubic2, ubic3);

        }

        public bool BuscarSocio( string target )
        {
            
            bool encontrar = false;

            foreach (Socio so in Biblioteca.ListaSocios)
            {
                if (Equals(so.Nombre, target))
                {
                    encontrar = true;
                }
                
            }

            return encontrar;
        }

        public string BuscarLibro(string target )
        {

            //error cuando no encuntra coloca 0 pero cuando encuentra y no tiene disponibles tambien coloca 0  en cantidad
            bool encontrar = false;
            string cantidad = "libro no encontrado";
            foreach (Libro li in Biblioteca.ListaLibros)
            {
                if (Equals(li.Nombre, target))
                {
                    encontrar = true;
                    cantidad = li.ListaEjemplares.Count().ToString();
                }
                
            }
            
            return cantidad;
        }

        public bool AgregarPrestamo(string socio="", string libro="")
        {
            
            bool agregado = false;
            
            foreach (Socio so in Biblioteca.ListaSocios)
            {
                if (Comparer.Equals(so.Nombre, socio))
                {
                    foreach (Libro li in Biblioteca.ListaLibros)
                    {
                        if (Comparer.Equals(li.Nombre, libro))
                        {

                            //lo elimino y retorno cual eliminé
                            //ese que elimine se lo agrego al socio
                            
                                agregado = so.PedirEjemplarALibro(li); 
                                //le digo que retorne true
                                

                        }
                        
                    }
                }
               
            }
            return agregado;
        }

        public string ListaLibrosMostrar()
        {
            string texto = "";

            foreach (Libro li in Biblioteca.ListaLibros)
            {
                texto += li.Nombre + li.Autor + li.Codigo + " num ejemplares : " + li.ListaEjemplares.Count + "\n";

            }

            return texto;
        }

        public string ListaSociosMostrar()
        {


            string texto = "";

            foreach (Socio li in Biblioteca.ListaSocios)
            {
                texto += li.Nombre + li.Apellido + li.Identificacion + "num ejemplares retirados : " + li.EjemplaresRetirados.Count + "\n";

            }

            return texto;
        }
        
        public bool DevolverEjemplar(int rowIndex, string nombre)
        {
            bool devuelto = false;
            try {

                foreach (Socio so in Biblioteca.ListaSocios)
                {
                    if (so.Nombre == nombre)
                    {
                        so.DevolverEjemplar(so.EjemplaresRetirados[rowIndex]);
                        devuelto = true;
                    }

                }

            } catch {

                devuelto = false;
            
            }
            return devuelto;
        }

        public string MostrarHistorialDePrestamos() {
            //mostrar lista de prestamos

            string texto="";
            foreach(Prestamo pre in Biblioteca.ListaHistorialPrestamos){
               
                foreach (Libro li in Biblioteca.ListaLibros)
                {
                    if (pre.Devolucion == true)
                    {
                        if (li.Codigo == pre.Ejemplar.CodigoLibro)
                        {
                            texto += "\n"+"Devolucion hecho por: " + pre.Socio.Nombre + " " + pre.Socio.Apellido + "\n" +
                                     "Del libro: " + li.Nombre + "\n" +
                                     "Con fecha de: " + pre.Fecha + "\n";
                            ;

                        }

                    }
                    else
                    {
                        if (li.Codigo == pre.Ejemplar.CodigoLibro)
                        {
                            texto += "\n" + "Prestamo hecho por: " + pre.Socio.Nombre + " " + pre.Socio.Apellido + "\n" +
                                     "Del libro: " + li.Nombre + "\n" +
                                     "Con fecha de: " + pre.Fecha + "\n"; 
                             ;

                        }

                    }
                    
                    //mostrar el contenido en texto
                    

                }
                
            }
            return texto;
        }

        public string MostrarCupoDelSocio(string target)
        {
            string cupo = "";

            foreach (Socio so in Biblioteca.ListaSocios)
            {
                if (Comparer.Equals(so.Nombre, target))
                {
                    cupo += "El cupo del socio es : " + so.CantidadMax;
                }
                else
                {
                    cupo = "";
                }
            }

            return cupo;
        }
    
    }

    
}
