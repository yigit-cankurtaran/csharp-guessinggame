// See https://aka.ms/new-console-template for more information

class GuessingGame
{
    public static void Main(string[] args)
    {
        int max = 100;
        int random = new Random().Next(1, max);
        int guess = 0;

        Console.WriteLine("Welcome to my Guessing Game!");
        Console.WriteLine("Guess a number between 1 and " + max);

        // check if the first guess is not a number
        if (!int.TryParse(Console.ReadLine(), out guess))
        {
            Console.WriteLine("That's not a number!");
            return;
        }

        while (guess != random)
        {
            if (guess < random)
            {
                Console.WriteLine("Too low, try again!");
            }
            else if (guess > random)
            {
                Console.WriteLine("Too high, try again!");
            }

            // read the next guess at the end of the loop
            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("That's not a number!");
                return;
            }
        }

        // print the success message after the loop
        Console.WriteLine("You guessed it!");
    }
}