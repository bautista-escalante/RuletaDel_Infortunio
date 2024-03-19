using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos
{
    public class Numeros : Elementos
    {
        public int numero;
        public Numeros(string color, int valor, int numero) : base(color, valor) 
        {
            this.numero = numero;
        }
    }

}
