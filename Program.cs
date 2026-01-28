//Madison Diefenbach
// section 3 group 13
//Madison Diefenbach
// section 3 group 13
//Madison Diefenbach
// section 3 group 13
namespace mission4;

public class Program
{
    static void Main()
    {
        gameEngine ge = new gameEngine();

        int[] boardGame = new int[9];
        int choice;
        int choice2;
        bool gameOver = false;

        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        for (int spot = 0; spot < boardGame.Length; spot++)
        {
            boardGame[spot] = spot;
        }

        while (!gameOver)
        {
            ge.printBoard(boardGame);

            Console.WriteLine("Player 1: Choose a spot (0-8)");
            choice = int.Parse(Console.ReadLine());
            boardGame[choice] = 1;

            ge.printBoard(boardGame);

            Console.WriteLine("Player 2: Choose a spot (0-8)");
            choice2 = int.Parse(Console.ReadLine());
            boardGame[choice2] = 2;
        }
    }
    
}
