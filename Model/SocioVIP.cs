using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class SocioVIP : Socio
    {

        private float cuotaMensual = 120;
 
        public float CuotaMensual { get => cuotaMensual; set => cuotaMensual = value; }

        public SocioVIP(string nombre, string apellido, int identificacion) : base( nombre,  apellido, identificacion)
        {
            cantidadMax = 3; //por ser socio VIP
        }
    }
}
