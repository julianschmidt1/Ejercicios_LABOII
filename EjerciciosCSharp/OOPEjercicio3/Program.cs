using System.Text;

namespace OOPEjercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudianteUno = new("Schmidt", 123321.ToString(), "Julian");
            Estudiante estudianteDos = new("Schmidt", 23432.ToString(), "Javier");
            Estudiante estudianteTres = new("Schmidt", 34543.ToString(), "Guillermo");

            estudianteUno.SetNotaPrimerParcial(6);
            estudianteUno.SetNotaSegundoParcial(10);

            estudianteDos.SetNotaPrimerParcial(2);
            estudianteDos.SetNotaSegundoParcial(4);

            estudianteTres.SetNotaPrimerParcial(6);
            estudianteTres.SetNotaSegundoParcial(10);

            Console.WriteLine(estudianteUno.Mostrar());
            Console.WriteLine(estudianteDos.Mostrar());
            Console.WriteLine(estudianteTres.Mostrar());



        }
        class Estudiante
        {
            public string apellido;
            public string legajo;
            public string nombre;
            public int notaPrimerParcial;
            public int notaSegundoParcial;
            public static Random random;

            static Estudiante()
            {
                random = new Random();
            }

            public Estudiante(string apellido, string legajo, string nombre)
            {
                this.apellido = apellido;
                this.legajo = legajo;
                this.nombre = nombre;
            }

            public void SetNotaPrimerParcial(int notaPrimerParcial)
            {
                this.notaPrimerParcial = notaPrimerParcial;
            }

            public void SetNotaSegundoParcial(int notaSegundoParcial)
            {
                this.notaSegundoParcial = notaSegundoParcial;
            }

            private float CalcularPromedio()
            {
                return (float)(notaPrimerParcial + notaSegundoParcial) / 2;
            }

            public double CalcularNotaFinal()
            {
                if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4) return random.Next(6, 11);
                else return -1;
            }

            public string Mostrar()
            {
                StringBuilder sb = new StringBuilder();
                double notaFinal = CalcularNotaFinal();

                sb.AppendLine($"Nombre: {nombre}");
                sb.AppendLine($"Apellido: {apellido}");
                sb.AppendLine($"Legajo: {legajo}");
                sb.AppendLine($"Nota primer parcial: {notaPrimerParcial}");
                sb.AppendLine($"Nota segundo parcial: {notaSegundoParcial}");
                sb.AppendLine($"Promedio: {CalcularPromedio()}");
                sb.AppendLine($"Nota Final: {(notaFinal > 0 ? notaFinal : "Alumno desaprobado")}");

                return sb.ToString();
            }
        }
    }
}