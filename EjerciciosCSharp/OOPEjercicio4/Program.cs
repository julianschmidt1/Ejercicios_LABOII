namespace OOPEjercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool pudoPintar;
            string? dibujo;
            string mensajeSinTinta = "Sin tinta rey!";

            Boligrafo lapiceraAzul = new(ConsoleColor.Blue, 100);
            Boligrafo lapiceraRoja = new(ConsoleColor.Red, 50);

            Console.ForegroundColor = lapiceraAzul.GetColor();
            pudoPintar = lapiceraAzul.Pintar(95, out dibujo);
            if (pudoPintar) Console.WriteLine(dibujo);
            else Console.WriteLine(mensajeSinTinta);

            Console.ForegroundColor = lapiceraRoja.GetColor();
            pudoPintar = lapiceraRoja.Pintar(35, out dibujo);
            if (pudoPintar) Console.WriteLine(dibujo);
            else Console.WriteLine(mensajeSinTinta);


            Console.ResetColor();
        }
    }
}