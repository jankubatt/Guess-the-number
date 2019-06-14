using System;

namespace guessnum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("Guess number between 0-100");
                int ranNum = random.Next(100);
                int i = 0;

                while (true)
                {
                    input = int.Parse(Console.ReadLine());
                    
                    if (input < ranNum)
                    {
                        Console.WriteLine("higher");
                        i++;
                    }
                    else if (input > ranNum)
                    {
                        Console.WriteLine("Lower");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("You won after {0} guesses, the number was {1}", i, ranNum);
                        Console.WriteLine(" ");
                        break;
                    }
                }
            }
        }      
    }
}
