using Lifegame.GameModel;

Board board = new Board(20, 50);
while (true)
{
    board.Pintar();             // Dibujar el tablero en la consola
    board.SiguienteGeneracion(); // Calcular la siguiente generación
    Thread.Sleep(500);          // Pausar para visualizar
}

