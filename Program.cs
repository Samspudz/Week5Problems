/*
 * author: Adam Marshall
 * date: 02/23/2023
 * class: GAME-1343
 * project: Week 5 Assignment
 */

namespace Week5Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
            
            ProblemThree();
            
            ProblemFive();
        }


        static void ProblemOne()
        {
            int Count = 0;
            int[] myArray = new int[100];
            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Count++;
                }
            }

            Console.WriteLine("There are " + Count + " numbers between 1-100 that are divisible by 3.");
        }

        
        static void ProblemThree()
        {
            Console.WriteLine("Please enter a number and get the factorial of it");

            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("{0}! : {1}", number, factorial);
        }

        static void ProblemFive()
        {
            Console.Write("Enter a series of numbers, seperated by commas: ");
           
			var userInput = Console.ReadLine();

            var numbers = userInput.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);
        }
    }
}
