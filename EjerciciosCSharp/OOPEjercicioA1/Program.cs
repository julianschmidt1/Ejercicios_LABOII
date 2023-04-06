using BibliotecaClases;

namespace OOPEjercicioA1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            EmpresaTransporte[] conductores;

            conductores = new EmpresaTransporte[3];

            conductores[0] = new EmpresaTransporte("Pepe Veraz", 5, 7, 2, 6, 8, 0, 0);
            conductores[1] = new EmpresaTransporte("Timmy Turner", 3, 5, 0, 2, 0, 10, 4);
            conductores[2] = new EmpresaTransporte("Trixie Tang", 0, 0, 4, 9, 3, 14, 3);

            Console.WriteLine($"Conductor con mas kilometros semanales: {ConductorConMasKilometros(conductores, 0)}");
            Console.WriteLine($"Conductor con mas kilometros en dia 3: {ConductorConMasKilometros(conductores, 3)}");
            Console.WriteLine($"Conductor con mas kilometros en dia 5: {ConductorConMasKilometros(conductores, 5)}");
        }

        static string? ConductorConMasKilometros(EmpresaTransporte[] conductores, int dia)
        {
            int indiceConductorConMasHoras = 0;
            for (int i = 0; i < conductores.Length; i++)
            {
                switch (dia)
                {
                    case 3:
                        if (conductores[i].kilometrosRecorridos.GetDiaTres() > conductores[indiceConductorConMasHoras].kilometrosRecorridos.GetDiaTres())
                        {
                            indiceConductorConMasHoras = i;
                        }
                        break;
                    case 5:
                        if (conductores[i].kilometrosRecorridos.GetDiaCinco() > conductores[indiceConductorConMasHoras].kilometrosRecorridos.GetDiaCinco())
                        {
                            indiceConductorConMasHoras = i;
                        }
                        break;
                    default:
                        if (conductores[i].kilometrosRecorridos.GetTotalHoras() > conductores[indiceConductorConMasHoras].kilometrosRecorridos.GetTotalHoras())
                        {
                            indiceConductorConMasHoras = i;
                        }
                        break;
                }
            }

            return conductores[indiceConductorConMasHoras].nombreConductor;
        }


    }
}