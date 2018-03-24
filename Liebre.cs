using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga_VS_Liebre
{
    class Liebre:Corredor
    {
        private static int _Pasos = 0; //
        public Liebre(string nombre)
            : base(nombre)
        {
            _Pasos++;
        }
        public int Pasos { get { return _Pasos; } }
        public string avanzar()
        {
            string avanzo = "";
            int jugador = base.correr(); 
            /*
            judador = el valor que me regresa el metodo correr en este caso me devuelve 
            el valor de j y su rango es de 1 a 10
            el valor que me de lo voy a utilizar para hacer las comparaciones
            judador= 1 o 2 va tener un avanze de 0 pasos
            jugador=3 o 4 va tener un avanze de 9 pasos
            judador=5 va tener un avance de -12 pasos  lo que significa que si 
            estaba en la posiscion 50 - los 12 pasos que le tocaron por el 5 
            es igual a 38 en teoria si no falla el programa
            jugador=6,7 o 8 tiene un avance de 1 paso
            judador=9 0 10 tiene un avance de -2 se le restan dos pasos a la posicion que tenia 
            */
            if (jugador == 1 || jugador == 2)// Dormir
            {
                posicion =posicion + 0;
                avanzo += posicion;
            }
            else if (jugador == 3 || jugador == 4)// salto grande
            {
                posicion =posicion+ 9;
                avanzo += posicion;
            }
            else if (jugador ==5)// resbalon grande
            {
                posicion =posicion-12;
                avanzo += posicion;
            }
            else if (jugador == 6 || jugador == 7 || jugador == 8)//salto pequeño
            {
                posicion =posicion+ 1;
                avanzo += posicion;
            }
            else if(jugador==9||jugador==10)//resbalon pequeño
            {
                posicion =posicion - 2 ;
                avanzo += posicion;
            }
            return avanzo; // REGRESA EL VALOR DE LA POSICIO N
        }
        public override string ToString()
        {
            return nombre+" avanso "+avanzar();
        }
    }
}
