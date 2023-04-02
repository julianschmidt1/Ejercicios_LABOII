using System.Text;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int decimalABinario = 124;
            int binarioADecimal = 1111100;
            Console.WriteLine("El numero decimal {0} en binario es {1}", decimalABinario, Conversor.ConvertirDecimalABinario(decimalABinario));

            Console.WriteLine("El numero binario {0} en decimal es {1}", binarioADecimal, Conversor.ConvertirBinarioADecimal(binarioADecimal));
        }

        class Conversor
        {
            public static string ConvertirDecimalABinario(int numeroEntero)
            {

                StringBuilder stringBuilder = new StringBuilder();

                for (; numeroEntero >= 1; numeroEntero /= 2)
                {
                    stringBuilder.Insert(0, $"{numeroEntero % 2}");
                }

                return stringBuilder.ToString();
            }


            public static int ConvertirBinarioADecimal(int numeroEntero)
            {
                string numeroEnteroString = numeroEntero.ToString();
                int acumulador = 0;

                for (int i = 0; i < numeroEnteroString.Length; i++)
                {
                    int numeroActual;
                    bool esValido = int.TryParse(numeroEnteroString[i].ToString(), out numeroActual);
                    if (!esValido) break;

                    if (numeroActual == 1)
                    {
                        acumulador += (int)Math.Pow(2, numeroEnteroString.Length - i - 1);
                    }
                }
                return acumulador;
            }
        }
    }
}