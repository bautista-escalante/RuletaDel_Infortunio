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
        public bool EsRojo(int num)
        {
            bool retorno = false;
            for(int i = 0; i < base.rojo.Count; i++)
            {
                if (num == i)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }

}
