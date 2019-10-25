using System;

namespace number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[5] { "apple", "banana", "pear", "orange", "lemon" };
           
            PrintArray(fruit);

            ///Get element index
            int index;
            string userInput;

            index = Array.IndexOf(fruit, "orange");
            Console.WriteLine($"The index of your element is {index}");

            Console.WriteLine("Enter some fruit: ");
            userInput = Console.ReadLine();


            index = Array.IndexOf(fruit, userInput);

            if (index == -1)
            {
                Console.WriteLine($"Your fruit - {userInput} is excluded to my array");
            }
            else
            {
                Console.WriteLine($"Your fruit - {userInput} is included to my array");
            }
            Console.ReadLine();

        }
        public static void PrintArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
