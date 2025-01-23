using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifegame.GameModel
{
    internal class Board
    {
        public int filas {  get; set; }
        public int columnas { get; set; }
        
        // Constructor
        public Board(int Filas, int Columnas)
        {
            filas = Filas;
            columnas = Columnas;
            Relleno();
        }

        public void Relleno()
        {
            // Instancia random
            Random random = new Random();

            // Declaración de la cuadrícula
            int[,] grid = new int[filas, columnas];

            // Llenado del arreglo
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    grid[i, j] = random.Next(2); // Asigna 0 a cada celda
                }
            }

            // Mostrar el contenido del arreglo
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (grid[i,j] == 1)
                    {
                        Console.Write("█");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine(); // Salto de línea para cada fila
            }
        }
    }
}
