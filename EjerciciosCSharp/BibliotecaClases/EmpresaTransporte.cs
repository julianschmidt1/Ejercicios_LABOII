using System.Text;

namespace BibliotecaClases
{
    public class EmpresaTransporte
    {
        public string? nombreConductor;
        public KilometrosPorDia kilometrosRecorridos;

        public EmpresaTransporte(string? nombreConductor, float diaUno, float diaDos, float diaTres, float diaCuatro, float diaCinco, float diaSeis, float diaSiete)
        {
            this.nombreConductor = nombreConductor;
            kilometrosRecorridos = new KilometrosPorDia(diaUno, diaDos, diaTres, diaCuatro, diaCinco, diaSeis, diaSiete);
        }

        public string MostrarEmpleado()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre de conductor: {nombreConductor}");
            sb.AppendLine("Kilometros recorridos por dia: ");
            sb.AppendLine($"Dia 1: {kilometrosRecorridos.diaUno}");
            sb.AppendLine($"Dia 2: {kilometrosRecorridos.diaDos}");
            sb.AppendLine($"Dia 3: {kilometrosRecorridos.diaTres}");
            sb.AppendLine($"Dia 4: {kilometrosRecorridos.diaCuatro}");
            sb.AppendLine($"Dia 5: {kilometrosRecorridos.diaCinco}");
            sb.AppendLine($"Dia 6: {kilometrosRecorridos.diaSeis}");
            sb.AppendLine($"Dia 7: {kilometrosRecorridos.diaSiete}");

            return sb.ToString();
        }

    }
}