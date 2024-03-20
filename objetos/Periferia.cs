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
        }
        public List<int> ObtenerNumeros()
        {
            List<int> retorno = new List<int>();
            switch(this.objeto)
            {
                case "rombo":
                    if(base.color == "rojo")
                    {
                        retorno = base.rojo;
                    }
                    else if(base.color == "negro")
                    {
                        retorno = base.negro;
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
