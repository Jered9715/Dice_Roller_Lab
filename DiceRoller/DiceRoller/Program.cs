
Console.WriteLine("Welcome to the Dice Roller Game!");

Console.Write("How many sides should each die have? ");
int sidesOfDice = int.Parse(Console.ReadLine());

bool userEngagement = true;
int rollCounter = 1;
while (userEngagement == true)
{
    
    Console.WriteLine($"Roll {rollCounter}:");
    Console.ReadKey();

    int diceRoll1 = RandomDiceRoll(sidesOfDice);
    int diceRoll2 = RandomDiceRoll(sidesOfDice);
    int sumOfRolls = diceRoll1 + diceRoll2;

    Console.WriteLine($"You Rolled a {diceRoll1} and a {diceRoll2} ({sumOfRolls} total)");

    if (sidesOfDice == 6)
    {
        Console.WriteLine(SixSideDiceCombos(diceRoll1,diceRoll2));
        Console.WriteLine(SixSideDiceSpecialTotals(diceRoll1,diceRoll2));
        Console.WriteLine();
    }


    Console.WriteLine("Roll again? (y/n): ");
    string userInput = Console.ReadLine();
    if (userInput.ToLower().Trim() == "n")
    {
        Console.WriteLine("Thanks for playing!");
        userEngagement = false;
    }
    else
    {
        rollCounter++;
        Console.WriteLine();
    }

}







int RandomDiceRoll(int diceSides)
{
    diceSides++;
    Random rnd = new Random();
    int randomDiceRoll = rnd.Next(1, diceSides);
    return randomDiceRoll;
}

string SixSideDiceCombos(int dice1, int dice2)
{
    if (dice1 == 1 && dice2 == 1)
    {
        return "Snake Eyes";
    }
    else if ((dice1 == 1 && dice2 == 2) || (dice1 == 2 && dice2 == 1))
    {
        return "Ace Deuce";
    }
    else if (dice1 == 6 && dice2 == 6)
    {
        return "Box Cars";
    }
    else
    {
        return "";
    }
}

string SixSideDiceSpecialTotals(int dice1, int dice2)
{
    if (dice1 + dice2 == 7 || dice1 + dice2 == 11)
    {
        return "Win";
    }
    else if (dice1 + dice2 == 2 || dice1 + dice2 == 3 || dice1 + dice2 == 12)
    {
        return "Craps";
    }
    else
    {
        return "";
    }
}