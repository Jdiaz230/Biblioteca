using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        private string nombre;
        private int codigo;
        private string autor;
        private List<Ejemplar> listaEjemplares = new List<Ejemplar>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Autor { get => autor; set => autor = value; }
        internal List<Ejemplar> ListaEjemplares { get => listaEjemplares; set => listaEjemplares = value; }

        public Libro(string nombre, int codigo, string autor)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.autor = autor;
        }

        public void AgregarEjemplares(int cantidad, int numedic1, int numedic2, int numedic3, string ubic, string ubic2, string ubic3)
        {

            int cont = 1;
            //agrego ejemplares a la lista de ejemplares
            while (cont <= cantidad)
            {
                if (cont == 1 && numedic1 != 0) { 
                    
                    Ejemplar ejemplar = new Ejemplar(numedic1, ubic, Codigo);
                    ListaEjemplares.Add(ejemplar);
                }
                if (cont == 2 && numedic2 != 0)
                {

                    Ejemplar ejemplar = new Ejemplar(numedic2, ubic2, Codigo);
                    ListaEjemplares.Add(ejemplar);
                }
                if (cont == 3 && numedic3 != 0)
                {

                    Ejemplar ejemplar = new Ejemplar(numedic3, ubic3, Codigo);
                    ListaEjemplares.Add(ejemplar);
                }
                cont++;
            }

        }

        public bool EjemplaresDisponibles()
        {
            //consultar si el libro tiene ejemplares disponibles , ture si tien false si no
            return listaEjemplares.Count() > 0;
        }

        public Ejemplar PrestarEjemplarASocio()
        {
            //el metodo tiene que eliminar de la lista de ejemplares el primer ejemplar
            //y retornar dicho ejemplar
            Ejemplar agregado= null ;


            if (EjemplaresDisponibles()) {
                //le elimino a la lsita de ejemplares del libro la primera posicion
                agregado = ListaEjemplares[0];
                ListaEjemplares.RemoveAt(0);
            }
            else
            {
                agregado = null;
            }
            return agregado;

        }

        public void ReingresoEjemplar(Ejemplar prestado)
        {
            //este metodo debe agregar a la lista de ejemplares, el ejemplar recibido por parametro
            //si prestaod es diferente de nulo y tieene el mismo codigo del libro seleccionado entonces se lo agrego

           if(prestado != null && prestado.CodigoLibro == codigo)
            {
                ListaEjemplares.Add(prestado);
                
            }
                

        }
    }
}

