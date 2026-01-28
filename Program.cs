//Madison Diefenbach
// section 3 group 13
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;


string [] boardGame = [];
string choice = "";
string choice2 = "";

Console.WriteLine("Welcome to Tic-Tac-Toe!");

Console.WriteLine("Player 1: Choose a spot (0-8");
choice = Console.ReadLine();
Console.WriteLine("Player 2: Choose a spot (0-8");
choice2 = Console.ReadLine();

do
{
    Console.WriteLine("Player 1: Choose a spot (0-8");
    choice = Console.ReadLine();
    boardGame[choice] = choice;
    Console.WriteLine("Player 2: Choose a spot (0-8");
    choice2 = Console.ReadLine();
    boardGame[choice2] = choice2;
}
while (boardGame.Length <= 8);