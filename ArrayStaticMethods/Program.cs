using System;

namespace ArrayStaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[5];
        
            /////--------------------------------------------------------------------------------
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write("Enter a color:");
                colors[i] = Console.ReadLine();
            }
            ///Sort Array
            Console.WriteLine("\n");
            Array.Sort(colors);
            Console.WriteLine("Array sorted:");
            PrintArray(colors);
            

            ///Reverse array
            Console.WriteLine("\n");
            Array.Reverse(colors);
            Console.WriteLine("Array reversed:");
            PrintArray(colors);
            //-------------------------------------------------------------------------------------



            Console.ReadLine();
        }
        public static void PrintArray(string[] array)
        {
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
