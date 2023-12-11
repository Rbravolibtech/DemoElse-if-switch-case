using System;

namespace DemoElse_if_switch_case
{
     class Program
    {
        static void Main(string[] args)
        {
            var season = Season2.Autumn;

            switch (season)
            {
                case Season2.Autumn:
                    //Console.WriteLine("It's Autumn and a beautiful season.");
                    //break;

                case Season2.Summer:
                    Console.WriteLine("It's too hot in the summer time.");
                    break;

                default:
                    Console.WriteLine("Winter is the best for snowboarding.");
                    break;
            }

            // Original code for time-based condition
            // int hour = 10;
            // if (hour >= 0 && hour < 12)
            // {
            //     Console.WriteLine("It's Morning");
            // }
            // else if (hour >= 12 && hour < 18)
            // {
            //     Console.WriteLine("It's Afternoon");
            // }
            // else
            // {
            //     Console.WriteLine("It's Evening");
            // }

            // New code for a customer-based condition

            //bool isGoldCustomer = true;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;

            //Console.WriteLine(price);
        }
    }
}
