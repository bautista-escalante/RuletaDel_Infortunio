namespace objetos
{
    public class Elementos
    {
        public string color;
        public int valor;
        public List<int> rojo;
        public List<int> negro;

        public Elementos(string color, int valor)
        {
            this.color = color;
            this.valor = valor;
            this.rojo = [1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36];
            this.negro = [2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35];
        }
        public bool esPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
