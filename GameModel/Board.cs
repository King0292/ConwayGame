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
        // Miembros de clase
        public int filas {  get; set; }
        public int columnas { get; set; }

        private Cells[,] grid; // Plano para las celulas

        Random random = new Random();

        // Constructor
        public Board(int Filas, int Columnas)
        {
            filas = Filas;
            columnas = Columnas;
            grid = new Cells[ Filas, Columnas];
            Console.CursorVisible = false;
            Console.Title = "Juego de Vida";
            IniciarVida();
            AsignarVecinos();
        }

        public void IniciarVida() // Asignar celulas vivas
        {
            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    grid[i, j] = new Cells { C_Viva = random.Next(2) == 1 }; 
                }
            }
        }

        public void AsignarVecinos() 
        {
            int[] desplazamiento = { -1, 0, 1 };

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    // Obtener vecinos para la celda actual
                    grid[i, j].vecinos.AddRange(ObtenerVecinos(i, j, desplazamiento));
                }
            }
        }

        private List<Cells> ObtenerVecinos(int x, int y, int[] desplazamieto) // Obtener las celulas vecinas
        {
            List<Cells> List_Vecinos = new List<Cells>();

            foreach (int dx in desplazamieto)
            {
                foreach (int dy in desplazamieto)
                {
                    if (dx == 0 && dy == 0) continue; // Saltar la celda actual

                    int nx = x + dx;
                    int ny = y + dy;

                    // Verificar límites del tablero
                    if (nx >= 0 && nx < filas && ny >= 0 && ny < columnas)
                    {
                        List_Vecinos.Add(grid[nx, ny]);
                    }
                }
            }

            return List_Vecinos;
        }
        public void SiguienteGeneracion() // Calcular quien muere o sigue vivo
        {
            foreach(var celula in grid)
            {
                celula.Reglas();
            }
            foreach(var celula in grid)
            {
                celula.Avance();
            }
        }
        public void Pintar() // Pintar en consola
        {
            Console.Clear();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(grid[i, j].C_Viva ? "█" : " "); // Caracter █ para celulas vivas y " " para las muertas
                }
                Console.WriteLine(); // Salto de filas
            }
        }
    }
}
