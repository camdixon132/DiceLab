

bool rollagain = true;




Console.WriteLine("Wlecome to the Grand Circus Casino");


int sides = 0;

Console.WriteLine("How many sides do you want the dice to have?");

while (true)
{
    while (int.TryParse(Console.ReadLine(), out sides) == false)
    {
        Console.WriteLine("Invalid entry. Please try again");     
    }
    if (sides > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Entry, please enter a positive number.");
    }
}


int rollcounter = 1;
while (rollagain == true) 
{
    int roll1 = roll(sides);
    int roll2 = roll(sides);
    int total = roll1 + roll2;


    Console.WriteLine($"Roll {rollcounter}:");
    Console.WriteLine($"You rolled a {roll1} and a {roll2} ({total} total)");
    if(sides == 6)
    {
        Console.WriteLine(SixSides(roll1, roll2));
    }
    else
    {
        Console.WriteLine(notSix(total));
    }
    Console.WriteLine("Would you like to roll again? y/n");
    string again = Console.ReadLine();
    rollcounter += 1;
    if (again == "y" || again == "yes")
    {
        rollagain = true;
    }
    else
    {
        rollagain = false;
    }
}






static string notSix(int total)
{
    if(total == 7 || total == 11 )
    {
        return "Win!";
    }
    else if(total == 2 || total == 3 || total == 12)
    {
        return "Craps!";
    }
    else
    {
        return "";
    }
}

static string SixSides(int roll1, int roll2)
{
    if(roll1 == 1 && roll2 == 1)
    {
        return "Snake Eyes: Two 1s\r Craps!";
    }
    else if (roll1 == 1 && roll2 == 2)
    {
        return "Ace Deuce: A 1 and 2\r Craps!";
    }
    else if (roll1 == 2 && roll2 == 1)
    {
        return "Ace Deuce: A 1 and 2";
    }
    else if (roll1 == 6 && roll2 == 6)
    {
        return "Box Cars: Two 6s\r Craps!";
    }
    else if(roll1 + roll2 == 7 || roll1 + roll2 == 11)
    {
        return "Win!";
    }
    else
    {
        return "";
    }
}



static int roll(int sides)
{
    Random dice = new Random();
    return dice.Next(1, sides + 1);
}




