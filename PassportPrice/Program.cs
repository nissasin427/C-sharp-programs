using System;

namespace PassportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            double minimalPrice = 0;
            double startUpFee = 0.7;

            if (n < 20)
            {                
                if (timeOfDay == "day")
                {
                    minimalPrice = startUpFee + n * 0.79;
                }
                else
                {
                    minimalPrice = startUpFee + n * 0.9;
                }
            }
            else if (n > 100)
            {
                minimalPrice = n * 0.06;
            }
            else
            {
                minimalPrice = n * 0.09;
            }

            Console.WriteLine($"{minimalPrice:f2}");

        }
    }
}
