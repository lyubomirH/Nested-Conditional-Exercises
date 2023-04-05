using System.Diagnostics.CodeAnalysis;

namespace Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());
            

            switch (season)
            {
                case "Spring":
                    double sum_I_Spring = 3000;
                    double discount_II_Spring;
                    double sum_III_Spring;
                    double discount_IV_Spring;
                    double final_Spring;
                    double need
                    double odd_Spring = fisherman % 2;
                    if (fisherman <= 6)
                    {
                        discount_II_Spring = sum_I_Spring * 0.1;
                        sum_III_Spring = sum_I_Spring - discount_II_Spring; 
                            if (odd_Spring == 0)
                            {
                            discount_IV_Spring = sum_III_Spring * 0.5;
                            final_Spring = sum_III_Spring - discount_IV_Spring;
                              if (final_Spring > money)
                              {
                                need = final_Spring - money;
                                Console.WriteLine($"Not enough money! You need {need:F2} leva.");
                              }
                            }
                            else
                            {

                            }
                    }
                    else if (fisherman >= 7 && fisherman <= 11)
                    {
                        sum_I_Spring = sum_I_Spring * 0.15;
                    }
                    else 
                    {
                        sum_I_Spring = sum_I_Spring * 0.25;
                    }
                    
                    break;
                case "Summer":
                case "Autumn":
                    double sum_II_Autumn = 4200;

                    break;
                case "Winter":
                    double sum_III_Winter = 2600;
                    break;
            }
        }
    }
}