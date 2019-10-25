using System;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            double sumOfNumbers = 0;
            double avarage = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1; 
                

            }
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
                sumOfNumbers = sumOfNumbers + num;
                avarage = sumOfNumbers / numbers.Length;

            }
          
            Console.WriteLine($"Sum of numbers 1 to 100 is {sumOfNumbers}.");
            Console.WriteLine(Math.Round((avarage),2));
            Console.ReadLine();


        }
    }
}
