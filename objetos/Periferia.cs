namespace objetos
{
    public class Periferia:Elementos
    {
        private new List<int> rojo;
        private List<int> negro;
        public string objeto;
        public Periferia(string obj, int valor, string color = null) : base(color, valor)
        {
            this.objeto = obj;
            this.rojo = [1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36];
            this.negro = [2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35];
        }
        public List<int> ObtenerNumeros()
        {
            List<int> retorno = new List<int>();
            switch(this.objeto)
            {
                case "rombo":
                    if(base.color == "rojo")
                    {
                        retorno = this.rojo;
                    }
                    else if(base.color == "negro")
                    {
                        retorno = this.negro;
                    }
                    break;
                case "pares":
                    for(int i = 0; i < 36; i++)
                    {
                        if (base.esPar(i))
                        {
                            retorno.Add(i);
                        }
                    }
                    break;
                case "impares":
                    for (int i = 0; i < 36; i++)
                    {
                        if (base.esPar(i) == false)
                        {
                            retorno.Add(i);
                        }
                    }
                    break;
                case "1ra docena":
                    retorno.AddRange([1,12]);
                    break;
                case "2da docena":
                    retorno.AddRange([13, 24]);
                    break;
                case "3ra docena":
                    retorno.AddRange([25, 36]);
                    break;
                case "1ra linea":
                    bool bandera = true;
                    int resultado = 1;
                    for (int i = 1; i < 37; i++)
                    {
                        if (bandera || i == resultado)
                        {
                            bandera = false;
                            retorno.Add(i);
                        }
                        resultado += 3;
                    }
                    break;
                case "2da linea":
                    bool flag = true;
                    int result = 1;
                    for (int i = 2; i < 37; i++)
                    {
                        if (flag || i == result)
                        {
                            flag = false;
                            retorno.Add(i);
                        }
                        result += 3;
                    }
                    break;
                case "3ra linea":
                    for (int i = 1; i < 37; i++)
                    {
                        if (i % 3 == 0)
                        {
                            retorno.Add(i);
                        }
                    }
                    break;
            }
            return retorno;
        }

    }
}
