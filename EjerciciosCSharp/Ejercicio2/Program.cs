namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Suma total {0}", SolicitarYValidar());
        }

        static public int SolicitarYValidar()
        {
            int acumulador = 0;
            string? respuestaUsuario;

            do
            {
                acumulador += SolicitarNumero();
                Console.WriteLine("Desea continuar? (S. SI | Cualquiercosa. NO): ");
                respuestaUsuario = Console.ReadLine();
            } while (Validador.ValidarRespuesta(respuestaUsuario));

            return acumulador;
        }

        static public int SolicitarNumero()
        {
            int valorParseado;
            bool numeroEsValido = true;

            do
            {
                if (!numeroEsValido)
                {
                    Console.WriteLine("El valor ingresado no es un numero");
                }
                Console.Write("Ingrese el valor: ");
                numeroEsValido = int.TryParse(Console.ReadLine(), out valorParseado);
            } while (!numeroEsValido);

            return valorParseado;
        }

        class Validador
        {
            public static bool ValidarRespuesta(string? respuesta)
            {
                return respuesta?.ToUpper() == "S";
            }
        }
    }
}