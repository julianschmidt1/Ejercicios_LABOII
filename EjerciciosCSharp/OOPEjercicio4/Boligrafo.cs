using System.Text;

namespace OOPEjercicio4
{
    internal class Boligrafo
    {
        public const short CANTIDAD_TINTA_MAXIMA = 100;
        public ConsoleColor color;
        public short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            short tintaResultante = (short)(this.tinta + tinta);
            if (tintaResultante >= 0 && tintaResultante <= CANTIDAD_TINTA_MAXIMA)
            {
                this.tinta = tintaResultante;
            }
        }

        public void Recargar()
        {
            SetTinta(CANTIDAD_TINTA_MAXIMA);
        }

        public bool Pintar(short gasto, out string? dibujo)
        {
            StringBuilder stringBuilder = new();

            if (tinta > 0)
            {

                for (; gasto > 0 && tinta > 0; gasto--)
                {
                    SetTinta(-1);
                    stringBuilder.Append('*');
                }
            }
            else
            {
                stringBuilder.Append("");
            }

            dibujo = stringBuilder.ToString();

            return dibujo.Length > 0;
        }



    }
}
