using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga_VS_Liebre
{
    class Corredor
    {
        static Random R = new Random(); // es la ruleta que nos va a dar el numero que utilizaremos para las condiciones
        private string _nombre; // nombre de los corredores
        public int posicion { get; set; } //la posicion pedira unn
        public string nombre { get { return _nombre; } }
        public Corredor(string nombre)
        {
            _nombre = nombre;
        }
        public int correr()
        {
            int j= R.Next(1,11);
            return j;
        }
        public override string ToString()
        {
            return _nombre + correr(); // manda el nombre y la pocicion en la que esta (jorge, 1)
        }
    }
}
