using System;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[5] { "apple", "pear", "banana", "mango", "ananas" };
            string[] vegetable = new string[5] { "potato", "carrot", "tomato", "onion", "cucumber" };

            string userInput;
            Console.WriteLine("Enter fruit or vegetable:");
            userInput = Console.ReadLine();

            int indexFruit;
            int indexVegetable;

            indexFruit = Array.IndexOf(fruit,userInput);
            indexVegetable = Array.IndexOf(vegetable, userInput);


            if (indexFruit !=-1)
            {
                Console.WriteLine("Your input is included to Fruit array");
            }
            else if (indexVegetable != -1)
            {
                Console.WriteLine("Your input is included to Vegetable array");
            }
            else
            {
                Console.WriteLine("Your input is out side of my array");
            }

            Console.ReadLine();
        }
       
            



        
    }
}
