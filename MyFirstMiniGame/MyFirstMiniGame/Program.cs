namespace MyFirstMiniGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int RandomNum = random.Next(int.MinValue, int.MaxValue);
            int UserGuess = 0;
            bool isValidInput = false;

            while (UserGuess != RandomNum)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out UserGuess);

                if (!isValidInput)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                if (UserGuess == RandomNum)
                {
                    Console.WriteLine("You are correct");
                }
                else if (UserGuess < RandomNum)
                {
                    Console.WriteLine("You are wrong");
                    GiveHint(RandomNum);
                    Console.WriteLine("The number is greater than your guess");
                }
                else
                {
                    Console.WriteLine("You are wrong");
                    GiveHint(RandomNum);
                    Console.WriteLine("The number is less than your guess");
                }
                
            }

            Console.WriteLine("Press Enter to exit...");
        }

        static void GiveHint(int randomNum)
        {
            if (randomNum % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
