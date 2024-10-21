bool continueRunning = true;

while (continueRunning)
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine(); //prompts the user for their name//
    int number;

    while (true)
    {
        Console.Write($"{name}, enter an integer between 1 and 100: ");
        if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 100) //&& means and//
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid, please enter a positive integer between 1 and 100.");
        }
    }

    if (number % 2 != 0) //% divides and gives remainder //
    {
        if (number < 60)
        {
            Console.WriteLine($"{number} - Odd and less than 60.");
        }
        else
        {
            Console.WriteLine($"{number} - Odd and greater than 60.");
        }
    }
    else
    {
        if (number >= 2 && number <= 24)  //<= less than or equal too//
        {
            Console.WriteLine("Even and less than 25.");
        }
        else if (number >= 26 && number <= 60)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }
        else if (number > 60)
        {
            Console.WriteLine($"{number} - Even and greater than 60.");
        }
    }

    Console.Write("Would you like to enter another number? (yay/nay): ");  //yay or nay is more fun than yes or no//
    string response = Console.ReadLine().ToLower();
    if (response != "yay")
    {
        continueRunning = false;
    }
}