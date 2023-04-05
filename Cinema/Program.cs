using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColumns =int.Parse(Console.ReadLine());

            double totalIncome = 0;

            switch (projectionType)
            {
                case "Premiere":
                    totalIncome = (numberOfRows * numberOfColumns) * 12.00;
                    break;

                case "Normal":
                    totalIncome = (numberOfRows * numberOfColumns) * 7.50;
                    break;

                case "Discount":
                    totalIncome = (numberOfRows * numberOfColumns) * 5.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{totalIncome:F2} leva");
        }
    }
}