namespace objetos
{
    public class Elementos
    {
        public string color;
        public int valor;
        

        public Elementos(string color, int valor)
        {
            this.color = color;
            this.valor = valor;
        }
        public bool esPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
