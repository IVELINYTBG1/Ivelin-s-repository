namespace MyFirstMiniGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int RandomNum = random.Next(1, 100); 
            int UserGuess = int.Parse(Console.ReadLine());
            if (UserGuess == RandomNum)
            {
                Console.WriteLine("You guessed the right number!");
            }
            else if (UserGuess < RandomNum)
            {
                while (UserGuess < RandomNum)
                    Console.WriteLine("aim lower");
            }
            else
            {
                while (UserGuess > RandomNum)
                    Console.WriteLine("aim hier");
            }
        }
    }
}
