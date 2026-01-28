//Carson Hendrix
//Madison Diefenbach
// section 3 group 13
namespace mission4;

public class Program
{
    static void Main()
    {
        // Create game engine object
        gameEngine ge = new gameEngine();

        // Initialize game board array and variables
        int[] boardGame = new int[9];
        int choice;
        int choice2;
        bool gameOver = false;
        int winner = 0;

        // Welcome message
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // Main game loop
        while (!gameOver)
        {
            // Print the current board
            ge.printBoard(boardGame);

            // Player 1's turn
            Console.WriteLine("Player 1: Choose a spot (1-9)");
            choice = int.Parse(Console.ReadLine());
            // Validate input - check if spot is valid and not already taken
            while (choice < 1 || choice > 9 || boardGame[choice-1] == 1 || boardGame[choice-1] == 2)
            {
                Console.WriteLine("Invalid spot! Please choose a spot that is not already taken.");
                Console.WriteLine("Player 1: Choose a spot (1-9)");
                choice = int.Parse(Console.ReadLine());
            }
            // Update board with Player 1's choice
            boardGame[choice-1] = 1;

            // Print updated board
            ge.printBoard(boardGame);

            // Check for winner after Player 1's move
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

            // Player 2's turn
            Console.WriteLine("Player 2: Choose a spot (1-9)");
            choice2 = int.Parse(Console.ReadLine());
            // Validate input - check if spot is valid and not already taken
            while (choice2 < 1 || choice2 > 9 || boardGame[choice2-1] == 1 || boardGame[choice2-1] == 2)
            {
                Console.WriteLine("Invalid spot! Please choose a spot that is not already taken.");
                Console.WriteLine("Player 2: Choose a spot (1-9)");
                choice2 = int.Parse(Console.ReadLine());
            }
            // Update board with Player 2's choice
            boardGame[choice2-1] = 2;

            // Print updated board
            ge.printBoard(boardGame);

            // Check for winner after Player 2's move
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
