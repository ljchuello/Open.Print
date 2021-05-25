namespace Test01.api
{
    public class Resultado
    {
        public bool Success { set; get; } = false;
        public string Messages { set; get; } = string.Empty;

        public static Resultado No(string msj)
        {
            Resultado resultado = new Resultado();
            resultado.Success = false;
            resultado.Messages = msj;
            return resultado;
        }

        public static Resultado Si(string msj)
        {
            Resultado resultado = new Resultado();
            resultado.Success = true;
            resultado.Messages = msj;
            return resultado;
        }
    }
}