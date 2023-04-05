using System;

namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kind = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double suma;
 
             if  (kind == "Roses") 
             {
                double price = 5;
                suma = price * number;
                double left_I = budget - suma;
                if (number >= 80)
                {
                    double discount = suma * 0.2;
                    double new_suma = suma + discount;
                    double left_II = budget - new_suma;
                    if (left_II <= 0)
                    {
                        double need_I = budget - new_suma;
                        double need_II = need_I * -1;
                        Console.WriteLine($"Not enough money, you need {need_II:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {number} {kind} and {left_II:F2} leva left.");
                    }
                }
                else if (budget <= suma)
                {
                    double need = suma - budget;
                    Console.WriteLine($"Not enough money, you need {need:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {number} {kind} and {left_I:F2} leva left");
                }
            }
             else if(kind == "Dahlias")
             {
                double price = 3.80;
                suma = price * number;
                double left_I = budget - suma;
                if (number >= 90)
                {
                    double discount = suma * 0.15;
                    double new_suma = suma + discount;
                    double left_II = budget - new_suma;
                    if (left_II <= 0)
                    {
                        double need_I = budget - new_suma;
                        double need_II = need_I * -1;
                        Console.WriteLine($"Not enough money, you need {need_II:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {number} {kind} and {left_II:F2} leva left.");
                    }
                }
                else if (budget <= suma)
                {
                    double need = suma - budget;
                    Console.WriteLine($"Not enough money, you need {need:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {number} {kind} and {left_I:F2} leva left.");
                }
            }
             else if (kind == "Tulips")
             {
                double price = 2.80;
                suma = price * number;
                double left_I = budget - suma;
                if (number >= 80)
                {
                    double discount = suma * 0.15;
                    double new_suma = suma + discount;
                    double left_II = budget - new_suma;
                    if (left_II <= 0)
                    {
                        double need_I = budget - new_suma;
                        double need_II = need_I * -1;
                        Console.WriteLine($"Not enough money, you need {need_II:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {number} {kind} and {left_II:F2} leva left.");
                    }
                }
                else if (budget <= suma)
                {
                    double need = suma - budget;
                    Console.WriteLine($"Not enough money, you need {need:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {number} {kind} and {left_I:F2} leva left.");
                }
            }
             else if (kind == "Narcissus")
             {
                double price = 3;
                suma = price * number;
                double left_I = budget - suma;
                if (number < 120)
                {
                    double discount = suma * 0.15;
                    double new_suma = suma + discount;
                    double left_II = budget - new_suma;
                    if (left_II <= 0)
                    {
                        double need_I = budget - new_suma;
                        double need_II = need_I * -1;
                        Console.WriteLine($"Not enough money, you need {need_II:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {number} {kind} and {left_II:F2} leva left.");
                    }
                }
                else if (budget <= suma)
                {
                    double need = suma - budget;
                    Console.WriteLine($"Not enough money, you need {need:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {number} {kind} and {left_I:F2} leva left.");
                }
            }
             else if (kind == "Gladiolus")
             {
                double price = 2.50;
                suma = price * number;
                double left_I = budget - suma;
                if (number < 80)
                {
                    double discount = suma * 0.2;
                    double new_suma = suma + discount;
                    double left_II = budget - new_suma;
                    if (left_II <= 0)
                    {
                        double need_I = budget - new_suma;
                        double need_II = need_I * -1;
                        Console.WriteLine($"Not enough money, you need {need_II:F2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {number} {kind} and {left_II:F2} leva left.");
                    }
                }
                else if (budget <= suma)
                {
                    double need = suma - budget;
                    Console.WriteLine($"Not enough money, you need {need:F2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {number} {kind} and {left_I:F2} leva left.");
                }
            }
        }
    }
}