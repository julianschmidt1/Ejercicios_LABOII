using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class KilometrosPorDia
    {
        public float diaUno;
        public float diaDos;
        public float diaTres;
        public float diaCuatro;
        public float diaCinco;
        public float diaSeis;
        public float diaSiete;

        public KilometrosPorDia(float diaUno, float diaDos, float diaTres, float diaCuatro, float diaCinco, float diaSeis, float diaSiete)
        {
            this.diaUno = diaUno;
            this.diaDos = diaDos;
            this.diaTres = diaTres;
            this.diaCuatro = diaCuatro;
            this.diaCinco = diaCinco;
            this.diaSeis = diaSeis;
            this.diaSiete = diaSiete;
        }

        public float GetDiaUno()
        {
            return diaUno;
        }

        public float GetDiaDos()
        {
            return diaDos;
        }

        public float GetDiaTres()
        {
            return diaTres;
        }

        public float GetDiaCuatro()
        {
            return diaCuatro;
        }

        public float GetDiaCinco()
        {
            return diaCinco;
        }

        public float GetDiaSeis()
        {
            return diaSeis;
        }

        public float GetDiaSiete()
        {
            return diaSiete;
        }

        public float GetTotalHoras()
        {
            return diaUno + diaDos + diaTres + diaCuatro + diaCinco + diaSeis + diaSiete;
        }
    }
}
