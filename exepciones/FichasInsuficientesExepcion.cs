namespace exepciones
{
    public class FichasInsuficientesExepcion : Exception
    {
        public FichasInsuficientesExepcion(int creditos, int ficha) : base($"creditos insuficientes necesitas {ficha - creditos}")
        {

        }
    }
}
