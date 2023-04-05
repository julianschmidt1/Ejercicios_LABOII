namespace OOPEjercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona miPersona = new Persona("Julian", 42000831, 9, 6, 1999);
            Persona miPersonaDos = new Persona("Javier", 999999222, 25, 9, 2008);
            Persona miPersonaTres = new Persona("Guillermo", 123321456, 8, 5, 1992);

            Console.WriteLine(miPersona.Mostrar());
            if (miPersona.EsMayor()) Console.WriteLine("Es mayor" + "\n");
            else Console.WriteLine("Es menor" + "\n");


            Console.WriteLine(miPersonaDos.Mostrar());
            if (miPersonaDos.EsMayor()) Console.WriteLine("Es mayor" + "\n");
            else Console.WriteLine("Es menor" + "\n");

            Console.WriteLine(miPersonaTres.Mostrar());
            if (miPersonaTres.EsMayor()) Console.WriteLine("Es mayor" + "\n");
            else Console.WriteLine("Es menor" + "\n");
        }

        class Persona
        {
            public string nombre;
            public DateTime fechaDeNacimiento;
            public int dni;

            public Persona(string nombre, int dni, int dia, int mes, int anio)
            {
                SetNombre(nombre);
                SetDNI(dni);
                SetFechaDeNacimiento(dia, mes, anio);
            }

            private int CalcularEdad()
            {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - fechaDeNacimiento.Year;

                if (fechaDeNacimiento.Date > hoy.AddYears(-edad)) edad--;
                return edad;
            }

            public string Mostrar()
            {
                return $"Nombre: {nombre}\n DNI: {dni}\n Edad: {CalcularEdad()}";
            }

            public bool EsMayor()
            {
                return CalcularEdad() >= 18;
            }

            public string GetNombre()
            {
                return nombre;
            }

            public DateTime GetFechaDeNacimiento()
            {
                return fechaDeNacimiento;
            }

            public int GetDNI()
            {
                return dni;
            }

            public void SetNombre(string nombre)
            {
                this.nombre = nombre;
            }

            public void SetFechaDeNacimiento(int dia, int mes, int anio)
            {
                this.fechaDeNacimiento = new DateTime(anio, mes, dia);
            }

            public void SetDNI(int dni)
            {
                this.dni = dni;
            }
        }
    }
}