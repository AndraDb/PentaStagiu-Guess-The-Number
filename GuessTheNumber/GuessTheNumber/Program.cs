using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 100);

            bool isCorrect = false;
            while (isCorrect != true)
            {
                Console.WriteLine("Guess the number : ");
                string str = Console.ReadLine();
                int guess = int.Parse(str);
                if (guess == number)
                {
                    Console.WriteLine("You`ve won! Yay :)");
                    isCorrect = true;

                }
                else
                {
                    if (guess > number)
                    {
                        Console.WriteLine("The number you`ve guessed is too big.Go lower!");
                        isCorrect = false;

                    }
                    else
                    {
                        Console.WriteLine("The number you`ve guessed is too small.Go Higher!");
                        isCorrect = false;

                    }
                }
            }



        }
    }
}

