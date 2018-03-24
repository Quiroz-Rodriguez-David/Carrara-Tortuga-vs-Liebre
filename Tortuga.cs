using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga_VS_Liebre
{
   class Tortuga:Corredor
    {
        private static int _Pasos=0;
        public Tortuga(string nombre)
            : base(nombre)
        {
            _Pasos++;
        }
        public int Pasos{get{ return _Pasos; }}
        public string  avanzar()
        {
            string avanzo="";
            int jugador = base.correr();
            /*
            Jugador=1,2,3,4,5 avanza 3 pasos
            jugador=6,7 retrocedes 6 pasos
            jugador=8,9,10 avansa 1 paso
            */
            if (jugador == 1|| jugador == 2 || jugador == 3 || jugador == 4 || jugador == 5)
            {
                posicion =posicion + 3;
                avanzo += posicion;
            }
            else if(jugador==6 || jugador == 7)
            {
                posicion =posicion- 6;
                avanzo += posicion;
            }
            else if(jugador==8||jugador==9||jugador==10)
            {
                posicion = posicion + 1;
                avanzo += posicion;
            }
           return avanzo; // REGRESA EL VALOR DE LA POSICION
        }
        public override string ToString()
        {
            return nombre+" avanzo "+avanzar()+"     ";
        }
    }
}
