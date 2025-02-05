using Lifegame.GameModel;

Board board = new Board(Filas:25, Columnas:70); // Asignar un tamaño a la tabla
while (true)
{
    board.Pintar();             // Dibujar el tablero en la consola
    board.SiguienteGeneracion(); // Calcular la siguiente generación
    Thread.Sleep(500);          // Pausar para visualizar
}

