namespace OOPEjercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 150000;
            string? razonSocial = "Julian Schmidt";

            Cuenta miCuenta = new Cuenta(razonSocial, saldo);
            Console.WriteLine(miCuenta.mostrar());

            saldo = PedirNumeroDecimal("Ingresa el monto a retirar: ");
            miCuenta.retirar(saldo);
            Console.WriteLine(miCuenta.mostrar());

            saldo = PedirNumeroDecimal("Monto a ingresar: ");
            if (miCuenta.ingresar(saldo))
            {
                Console.WriteLine("Saldo acreditado con exito");
            }
            Console.WriteLine(miCuenta.mostrar());

        }

        public static double PedirNumeroDecimal(string mensaje)
        {
            double valorParseado;
            bool numeroEsValido;

            do
            {
                Console.Write(mensaje);
                numeroEsValido = double.TryParse(Console.ReadLine(), out valorParseado);
            } while (!numeroEsValido);

            return valorParseado;
        }

        class Cuenta
        {
            private string titular;
            private double cantidad;

            public Cuenta(string? titular, double cantidad)
            {
                this.titular = titular;
                this.cantidad = cantidad;
            }

            public string GetTitular()
            {
                return titular;
            }

            public double GetCantidad()
            {
                return cantidad;
            }

            public string mostrar()
            {
                return $"Nombre de titular: {titular}\nSaldo actual: {cantidad}";
            }

            public bool ingresar(double monto)
            {
                if( monto > 0 )
                {
                    cantidad += monto;
                }

                return monto > 0;
            }

            public void retirar(double monto)
            {
                cantidad -= monto;
            }
        }
    }
}