//Madison Diefenbach
// section 3 group 13
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
gameEngine ge = new gameEngine();


int [] boardGame = new int[9];
int choice = 0;
int choice2 = 0;
bool gameOver = false;
string currentPlayer = "X";

Console.WriteLine("Welcome to Tic-Tac-Toe!");
for (int spot = 0; spot < boardGame.Length; spot++)
{
    boardGame[spot] = choice.ToString();
}

Console.WriteLine("Player 1: Choose a spot (0-8");
choice = Console.ReadLine();
Console.WriteLine("Player 2: Choose a spot (0-8");
choice2 = Console.ReadLine();

while (!gameOver)
{
    ge.printBoard(boardGame);
    Console.WriteLine("Player 1: Choose a spot (0-8");
    choice = Console.ReadLine();
    boardGame[choice] = 1;

    ge.printBoard(boardGame);
    Console.WriteLine("Player 2: Choose a spot (0-8");
    choice2 = Console.ReadLine();
    boardGame[choice2] = 2;
}