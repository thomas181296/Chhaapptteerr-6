using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany;
            Console.WriteLine("How many numbers are you going to enter?");
            howMany = Convert.ToInt32(Console.ReadLine());
            int[] eightNums = new int[howMany];
            int userEntry;
            for(int i = 0; i < eightNums.Length; ++i)
            {
                Console.Write("Please enter a number >>>>");
                eightNums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("How do you want to see the information\n" + 
                "1) First to Last?\n" +
                "2) Last to First?\n" +
                "3) Choose a specific position?");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if(userEntry = )
            {
                DisplayFirstTolast();
            }
            


        }
        public static void DisplayFirstTolast()
        {
            int howMany;
            howMany = Convert.ToInt32(Console.ReadLine());
            int[] eightNums = new int[howMany];
            int x;
            Array.Sort(eightNums);
            for(x = 0; x < eightNums.Length; ++x)
            {
                Console.WriteLine(eightNums[x]);
            }
        }
    }
        
}
