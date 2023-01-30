Random randomNumber = new Random();
int computerNumber = randomNumber.Next(1, 101);

string playerInput = "";
int playerNumber = 0;
int cntPlayerInput = 0;

while (true)
{
    Console.Write("Guess a number (1 - 100): ");
    playerInput = Console.ReadLine();
    cntPlayerInput++;
    Console.WriteLine(cntPlayerInput);
    bool isValid = int.TryParse(playerInput, out playerNumber);


    if (playerNumber <= 100)
    {
        if (computerNumber == playerNumber)
        {
            Console.WriteLine("You guess it!");
            break;
        }
        else if (computerNumber < playerNumber)
        {
            Console.WriteLine("Too High");
        }
        else
        {
            Console.WriteLine("Too Low");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}



Console.WriteLine("Do you want to play next level 2 ?");
playerInput = Console.ReadLine();

if (playerInput == "yes" || playerInput == "y")
{
    Console.WriteLine("LEVEL 2. You have 10 attempts.");

    Random randomNumber2 = new Random();
    int computerNumber2 = randomNumber2.Next(1, 201);
    int cntPlayerInput2 = 0;
    string playerInput2 = "";
    int playerNumber2 = 0;
    string result2 = "";

    while (cntPlayerInput2 != 10)
    {
        Console.Write("Guess a number (1 - 200): ");
        playerInput2 = Console.ReadLine();
        cntPlayerInput2++;
        Console.WriteLine(cntPlayerInput2);
        bool isValid2 = int.TryParse(playerInput2, out playerNumber2);


        if (playerNumber2 <= 200)
        {
            if (computerNumber2 == playerNumber2)
            {
                result2 = "You guess it!";
                Console.WriteLine("You guess it!");
                break;
            }
            else if (computerNumber2 < playerNumber2)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Too Low");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }


        if (cntPlayerInput2 == 10)
        {
            Console.WriteLine("No more attempts.");
            Console.WriteLine("You lose.");
            Console.WriteLine($"Computers choise: {computerNumber2}");
            return;
        }
    }
}
else
{
    Console.WriteLine("Bye");
    return;
}





Console.WriteLine("Do you want to play next level 3 ?");
playerInput = Console.ReadLine();

string result = "";

if (playerInput == "yes" || playerInput == "y")
{
    Console.WriteLine("LEVEL 3. You have 5 attempts.");

    Random randomNumber3 = new Random();
    int computerNumber3 = randomNumber3.Next(1, 301);
    int cntPlayerInput3 = 0;
    string playerInput3 = "";
    int playerNumber3 = 0;

    while (cntPlayerInput3 <= 5 || result == "You guess it!")
    {
        Console.Write("Guess a number (1 - 300): ");
        playerInput3 = Console.ReadLine();
        cntPlayerInput3++;
        Console.WriteLine(cntPlayerInput3);
        bool isValid3 = int.TryParse(playerInput3, out playerNumber3);

        if (playerNumber3 <= 300)
        {
            if (computerNumber3 == playerNumber3)
            {
                result = "You guess it!";
                Console.WriteLine(result);
                break;

                if (playerInput == "no" || playerInput == "n")
                {
                    break;
                }
                else
                {
                    cntPlayerInput3 = 0;
                    int cntFinal = cntPlayerInput3;
                    cntFinal++;
                }
            }
            else if (computerNumber3 < playerNumber3)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Too Low");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }

        if (cntPlayerInput3 == 5)
        {
            Console.WriteLine("No more attempts.");
            Console.WriteLine("You lose.");
            Console.WriteLine($"Computers choise: {computerNumber3}");
            break;
        }


    }
}
else
{
    Console.WriteLine("Bye");
}

