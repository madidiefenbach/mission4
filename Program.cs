//Madison Diefenbach
// section 3 group 13
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using mission4;
gameEngine ge = new gameEngine();


int [] boardGame = new int[9];
int choice = 0;
int choice2 = 0;
bool gameOver = false;
string currentPlayer = "X";

Console.WriteLine("Welcome to Tic-Tac-Toe!");
for (int spot = 0; spot < boardGame.Length; spot++)
{
    boardGame[spot] = 0;
}

Console.WriteLine("Player 1: Choose a spot (0-8");
choice = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Player 2: Choose a spot (0-8");
choice2 = int.Parse(Console.ReadLine() ?? "0");

while (!gameOver)
{
    ge.printBoard(boardGame);
    Console.WriteLine("Player 1: Choose a spot (0-8");
    choice = int.Parse(Console.ReadLine() ?? "0");
    if (boardGame[choice] != 1 && boardGame[choice] != 2)
    {
        boardGame[choice] = 1;
    }

    ge.printBoard(boardGame);
    Console.WriteLine("Player 2: Choose a spot (0-8");
    choice2 = int.Parse(Console.ReadLine() ?? "0");
    if (boardGame[choice2] != 1 && boardGame[choice2] != 2)
    {
        boardGame[choice2] = 2;
    }
    
}