namespace mission4;

public class gameEngine
{
    // Print the current state of the bord
    public void printBoard(int[] board)
    {
        string GetSymbol(int value)
        {
            return value switch
            {
                1 => "X",
                2 => "O",
                _ => " "  // 0 or anything else
            };
        }

        Console.WriteLine();
        Console.WriteLine("Current board:");
        Console.WriteLine();

        Console.WriteLine($" {GetSymbol(board[0])} | {GetSymbol(board[1])} | {GetSymbol(board[2])} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {GetSymbol(board[3])} | {GetSymbol(board[4])} | {GetSymbol(board[5])} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {GetSymbol(board[6])} | {GetSymbol(board[7])} | {GetSymbol(board[8])} ");

        Console.WriteLine();
    }
    
}