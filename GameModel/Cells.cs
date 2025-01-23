using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifegame.GameModel
{
    internal class Cells
    {
        public bool C_Viva; // Campo para determinar las celulas vivas
        public readonly List<Cells> vecinos = new List<Cells>();

        private bool Siguiente_Celula_Viva; // Campo para determinar la siguiente celula viva

        // Metodo para aplicar las reglas del juego
        public void Reglas()
        {
            //Una celda viva con menos de 2 vecinos vivos muere.
            //Una celda viva con 2 o 3 vecinos vivos sigue viva.
            //Una celda viva con más de 3 vecinos vivos muere.
            //Una celda muerta con exactamente 3 vecinos vivos vuelve a la vida.

            int VecinosVivos = vecinos.Where(x => x.C_Viva).Count();

            if (C_Viva)
                Siguiente_Celula_Viva = VecinosVivos == 2 || VecinosVivos == 3;
            else
                Siguiente_Celula_Viva = VecinosVivos == 3;
        }
        public void Avance()
        {
            C_Viva = Siguiente_Celula_Viva;
        }
    }
}
