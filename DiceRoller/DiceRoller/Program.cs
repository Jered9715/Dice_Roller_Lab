//welcome user to dice roller
Console.WriteLine("Welcome to the Dice Roller Game!");

//ask user the number of sides for a pair of dice
//Need to add try parse to this
Console.WriteLine("How many sides should each die have? ");
int sidesOfDice = int.Parse(Console.ReadLine());

//program will loop if user wants to go again
bool userEngagement = true;

while (userEngagement == true) {
    int rollCounter = 1;


    //request user rolls the dice

    //application rolls 2 n-sided dice

    //display results of dice roll along with total

    //if 6 sided dice refer to method and display special name if applicable



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
    }

}










//method that generates the random numbers for dice rolls



/*make this a method
 * application will recognize following combination for 6 sided dice
 * no other size will be recognized
 * 
 * snake Eyes: two 1s
 * Ace Deuce: A 1 and 2
 * Box Cars: Two 6s
 * 
 * returns string of valind combos or empty string if not matched
 * */

/*method
for 6 sided dice take the two dice values returns string for 
below values

Win: a total of 7 or 11
Craps: a total of 2,3,or12
or empty string
 
 *\