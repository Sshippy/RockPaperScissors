internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter r for rock, p for paper or s for scissors");
        string userInput = Console.ReadLine();

        //generate a random number
        Random r = new Random();
        int computerInput = r.Next(4);

        // if computer chooses rock
        if (computerInput == 1)
        {
            if (userInput == "r")
            {
                Console.WriteLine("The computer chose rock");
                Console.WriteLine("It is a tie ");
            }
            else if (userInput == "p")
            {
                Console.WriteLine("The computer chose paper");
                Console.WriteLine("It is a tie ");
            }
            else if (userInput == "s")
            {
                Console.WriteLine("The computer chose scissors");
                Console.WriteLine("It is a tie ");
            }
            else
            {
                Console.WriteLine("Enter r for rock, p for paper or s for scissors!");
            }
        }

        // if computer chooses paper
        else if (computerInput == 2)
        {
            if (userInput == "r")
            {
                Console.WriteLine("The computer chose paper");
                Console.WriteLine("computer wins,paper beats rock");
            }
            else if (userInput == "p")
            {
                Console.WriteLine("The computer chose scissors");
                Console.WriteLine("computer wins,scissors beats paper ");
            }
            else if (userInput == "s")
            {
                Console.WriteLine("The computer chose rock");
                Console.WriteLine("computer wins,rock beats scissors");
            }
            else
            {
                Console.WriteLine("Enter r for rock, p for paper or s for scissors!");
            }
        }

        // if computer chooses scissors
        else if (computerInput == 3)
        {
            if (userInput == "r")
            {
                Console.WriteLine("The computer chose scissors");
                Console.WriteLine("You win,rock beats scissors");
            }
            else if (userInput == "p")
            {
                Console.WriteLine("The computer chose rock");
                Console.WriteLine("You win,paper beats rock");
            }
            else if (userInput == "s")
            {
                Console.WriteLine("The computer chose paper");
                Console.WriteLine("You win,scissors beat paper");
            }
            else
            {
                Console.WriteLine("Enter r for rock, p for paper or s for scissors!!");
            }
        }
        Console.ReadLine();
    }
}
