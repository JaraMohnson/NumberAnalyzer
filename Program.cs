Console.WriteLine("Welcome :)");
Console.WriteLine("Please enter your name.");
string name = Console.ReadLine();

while (true)
{

    Console.WriteLine(name + ", please enter an integer between 1 and 100.");
    int number = int.Parse(Console.ReadLine());

    if (number < 1 || number > 100)
    {
        Console.WriteLine(name + ", please enter a valid number. The program will now restart!");
        continue;
    }

    int modulus = number % 2;

    // modulus 1 for odd, 0 for even 
    // used nested loops here so the parameters can easily be changed, and because it was only a single nest

    if (modulus == 1)
    {
        if (number > 60)
        {
            Console.WriteLine(name + ", your number is odd and greater than 60.");
        }
        else if (number < 60)
        {
            Console.WriteLine(name + ", your number is odd and less than 60.");
        }
    }

    if (modulus == 0)
    {
        if (number >= 2 && number <= 24)
        {
            Console.WriteLine(name + ", your number is even and less than 25.");
        }
        else if (number >= 26 && number <= 60)
        {
            Console.WriteLine(name + ", your number is even and between 26 and 60 inclusive");
        }
        else if (number > 60)
        {
            Console.WriteLine(name+ ", your number is even and greater than 60.");
        }
    }

   
  Console.WriteLine("Would you like to restart? Enter YES or Y to continue, or enter any other key to exit");
  string restart = Console.ReadLine().ToUpper();
    if (restart == "Y" || restart == "YES")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Thanks for playing! Exiting now...");
        break;
    }

}