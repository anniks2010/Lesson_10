using System;

namespace Array_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] {10,20,15,69,87};

            int minNumber = Int32.MaxValue;
            int maxNumber = Int32.MinValue;

           foreach (int number in numbers)
            {
                if (number < minNumber)
                {
                    minNumber = number;
                }

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
           

            Console.WriteLine($" Min value is {minNumber} and max value is {maxNumber}");
            
            Console.ReadLine();


            ////võtta üks sõne, kasutaja annab. Kood peab kontrollima, kas see sõne on palindrome või mitte. for loop ja lenght.

        }
    }
}
