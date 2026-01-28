namespace mission4;

public class gameEngine
{
    // Print the current state of the bord
    public void printBoard(int[] board)
    {
        string GetSymbol(int value, int index)
        {
            return value switch
            {
                1 => "X",
                2 => "O",
                _ => (index + 1).ToString()  // 0 or anything else
            };
        }

        Console.WriteLine();
        Console.WriteLine("Current board:");
        Console.WriteLine();

        Console.WriteLine($" {GetSymbol(board[0],0)} | {GetSymbol(board[1],1)} | {GetSymbol(board[2],2)} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {GetSymbol(board[3],3)} | {GetSymbol(board[4],4)} | {GetSymbol(board[5],5)} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {GetSymbol(board[6],6)} | {GetSymbol(board[7],7)} | {GetSymbol(board[8],8)} ");

        Console.WriteLine();
    }
    
    // Check the current state of the game
    // Returns:
    // 0 = game ongoing
    // 1 = someone won
    // 2 = draw
    public int winner(int[] board)
    {
        // All winning combinations
        int[,] winningCombos =
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8},
            {0, 3, 6},
            {1, 4, 7},
            {2, 5, 8},
            {0, 4, 8},
            {2, 4, 6}
        };

        // Check if someone won
        for (int i = 0; i < winningCombos.GetLength(0); i++)
        {
            int a = winningCombos[i, 0];
            int b = winningCombos[i, 1];
            int c = winningCombos[i, 2];

            if (board[a] != 0 && board[a] == board[b] && board[b] == board[c])
            {
                return 1; // someone won
            }
        }

        // Check for draw
        bool draw = true;
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i] == 0)
            {
                draw = false;
                break;
            }
        }

        if (draw) return 2; // draw

        return 0; // game ongoing
    }
}
    