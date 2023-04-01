namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimo = 0;
            int maximo = 0;
            int total = 0;

            PedirValoresYCalcularlos(ref minimo, ref maximo, ref total);
            Console.WriteLine("Minimo: {0}, Maximo: {1}, Promedio: {2}", minimo, maximo, CalcularPromedio(total, 10));

        }

        public static void PedirValoresYCalcularlos(ref int minimo, ref int maximo, ref int total)
        {
            int valorIngresado;

            for (int i = 0; i < 10; i++)
            {
                valorIngresado = PedirNumeroEnteroValidado();
                total += valorIngresado;
                if (i == 0)
                {
                    minimo = valorIngresado;
                    maximo = valorIngresado;
                }

                if (minimo > valorIngresado)
                {
                    minimo = valorIngresado;
                }

                if (maximo < valorIngresado)
                {
                    maximo = valorIngresado;
                }

            }
        }

        public static int CalcularPromedio(int total, int cantidad)
        {
            return total / cantidad;
        }

        public static int PedirNumeroEnteroValidado()
        {
            int valorParseado;
            bool numeroEsValido;

            do
            {
                Console.WriteLine("Ingrese el valor: ");
                numeroEsValido = int.TryParse(Console.ReadLine(), out valorParseado);
            } while (!numeroEsValido || !Validador.Validar(valorParseado, -100, 100));

            return valorParseado;
        }

        class Validador
        {
            public static bool Validar(int valor, int min, int max)
            {
                return valor >= min && valor <= max;
            }
        }
    }
}