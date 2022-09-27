bool restart = true;

while (restart)
{
    Console.WriteLine("How many people are we making PB&J sandwiches for?");
    string userInput = Console.ReadLine();
    int totalPeople = int.Parse(userInput);
    double numberOfSlices = 28;
    double numberOfPB = 32;
    double numberOfJ = 48;
    double slices = 2 * totalPeople;
    double tablespoons = 2 * totalPeople;
    double teaspoons = 4 * totalPeople;
    Console.WriteLine("You will need " + slices + " slices.");
    Console.WriteLine("You will need " + tablespoons + " tablespoons of peanut butter.");
    Console.WriteLine("You will need " + teaspoons + " teaspoons of jelly.");
    double loaves = Math.Ceiling(numberOfSlices / slices);
    double pbJars = Math.Ceiling(numberOfPB / tablespoons);
    double jJars = Math.Ceiling(numberOfJ / teaspoons);
    Console.WriteLine("You will need " + loaves + " loaves of bread.");
    Console.WriteLine("You will need " + pbJars + " jars of peanut butter.");
    Console.WriteLine("You will need " + jJars + " jars of jelly.");
    Console.WriteLine("Would you like to start the program over?");
    userInput = Console.ReadLine();
    if (userInput == "y" || userInput == "yes")
    {
        restart = true;
    }
    else
    {
        restart = false;
        Console.WriteLine("Goodbye.");
    }
}

// ayo