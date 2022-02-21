// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Rock Paper Scissors!");

Console.Write("Please choose rock, paper, or scissors: ");
string[] outcomes = new string[3] { "rock", "paper", "scissors" };
var playerChoice = Console.ReadLine().ToLower();
// check if player choice is in outcomes
if (!outcomes.Contains(playerChoice))
{
    System.Console.WriteLine("THATS NOT A VALID CHOICE!!!!");
}
else
{
    var random = new Random();
    int compChoiceIndex = random.Next(outcomes.Length);
    string compChoice = outcomes[compChoiceIndex];
    Console.WriteLine($"Computer chooses: {outcomes[compChoiceIndex]}");


    // if(compChoiceIndex != null)
    if (String.Equals(playerChoice, compChoice))
    {
        Console.WriteLine("It's a draw!");
    }
    else
    {
        if (playerChoice == "rock" && compChoice == "scissors") ;

    }

}


