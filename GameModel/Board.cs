using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lifegame.GameModel
{
    internal class Board
    {
        public int Altura { get; set; }
        public int Ancho { get; set; }
        private ConsoleColor Color { get; set; }
        public Point LimiteSuperior { get; set; } // Limite para el dibujo del cuadro superior
        public Point LimiteInferior {  get; set; } // Limite para el dibujo del cuadro inferior
        
        public Board(int ancho, int altura, ConsoleColor color)
        {
            Altura = altura;
            Ancho = ancho;
            Color = color;
        }
        private void Init()
        {
            Console.SetWindowSize(Ancho, Altura);
            Console.Title = "Juego de Vida";
            Console.BackgroundColor = Color;
            Console.Clear();

        }
    }
}
