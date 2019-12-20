using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idNumbers = { 122, 167, 204, 219, 345 };
            string[] names = { "Tyna", "Jordan", "Jon", "Isabelle", "Thomas", "Ethan" };
            int entryID;

            Console.WriteLine("Enter an employee ID ");
            entryID = Convert.ToInt32(Console.ReadLine());
            displayBinarySort(idNumbers, entryID);
            displayNames(names);

        }
        public static void displayNames(string[] names)
        {
            
            Array.Sort(names);
            for(int x = 0; x < names.Length; ++x)
            {
                Console.WriteLine(names[x]);
            }
            Array.Reverse(names);
            for (int x = 0; x < names.Length; ++x)
            {
                Console.WriteLine(names[x]);
            }
        }
        public static void displayBinarySort(int[] idNumbers, int entryID)
        {
            int x;
            x = Array.BinarySearch(idNumbers, entryID);
            if(x < 0)
            {
                Console.WriteLine("ID {0} not found", entryID);
            }
            else
            {
                Console.WriteLine("ID {0} found at position {1} ", entryID, x);
            }
        }
    }
}
