//Madison Diefenbach
// section 3 group 13
//Madison Diefenbach
// section 3 group 13
//Madison Diefenbach
// section 3 group 13
using System.Linq.Expressions;

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
        int winner = 0;

        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        while (!gameOver)
        {
            ge.printBoard(boardGame);

            Console.WriteLine("Player 1: Choose a spot (1-9)");
            choice = int.Parse(Console.ReadLine());
            boardGame[choice-1] = 1;

            ge.printBoard(boardGame);

           winner = ge.winner(boardGame);
            if (winner == 1)
            {
                Console.WriteLine("Player 1 wins!");
                gameOver = true;
                break;
            }
            else if (winner == 2)
            {
                Console.WriteLine("It's a draw!");
                gameOver = true;
                break;
            }

                Console.WriteLine("Player 2: Choose a spot (1-9)");
            choice2 = int.Parse(Console.ReadLine());
            boardGame[choice2-1] = 2;
            ge.printBoard(boardGame);

            winner = ge.winner(boardGame);
            if (winner == 1)
            {
                Console.WriteLine("Player 2 wins!");
                gameOver = true;
            }
            else if (winner == 2)
            {
                Console.WriteLine("It's a draw!");
                gameOver = true;
            }

        }
    }
    
}
