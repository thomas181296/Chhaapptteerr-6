using System;

namespace FindPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEntry;
            userEntry = Convert.ToString(Console.ReadLine());
            while(userEntry != "Y")
            {
                int[] validValue = { 101, 108, 201, 213, 266, 304, 311, 409, 411, 412 };
                double[] prices = { 0.89, 1.23, 3.50, 0.69, 5.79, 3.19, 0.99, 0.89, 1.26, 8.00 };

                int itemOrdered;
                double itemPrice = 0;
                bool isValidItem = false;

                Console.WriteLine("Please enter an item >>>> ");
                itemOrdered = Convert.ToInt32(Console.ReadLine());

                for (int x = 0; x < validValue.Length; ++x)
                {
                    if (itemOrdered == validValue[x])
                    {
                        isValidItem = true;
                        itemPrice = prices[x];
                    }
                }
                if (isValidItem)
                {
                    Console.WriteLine("Price is {0}", itemPrice.ToString("C"));
                }
                else
                {
                    Console.WriteLine("Sorry - item not found");
                }
            }
            
               


        }
    }
}
