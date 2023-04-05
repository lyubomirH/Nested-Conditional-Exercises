namespace A_journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mony = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination;
            double persent;
            double cost;
            double FinalCost;
            string location;
            switch (season)
            {
                case "winter":
                    if (mony <= 100)
                    {
                        destination = "Bulgaria";
                        location = "Bulgaria";
                        persent = 0.7;
                        cost = mony * persent;
                        FinalCost = mony - cost;
                        Console.WriteLine($"Somewhere in {location}");
                        Console.WriteLine($"Hotel - {FinalCost}");
                    }
                    else if (mony <= 1000)
                    {
                        destination = "Balkans";
                        location = "Balkans";
                        persent = 0.8;
                        cost = mony * persent;
                        FinalCost = mony - cost;
                        Console.WriteLine($"Somewhere in {location}");
                        Console.WriteLine($"Hotel - {FinalCost}");
                    }
                    else
                    {
                        destination = "Europe";
                        location = "Europe";
                        persent = 0.9;
                        cost = mony * persent;
                        FinalCost = mony - cost;
                        Console.WriteLine($"Somewhere in {location}");
                        Console.WriteLine($"Hotel - {FinalCost}");
                    }
                    break;
                case "summer":
                    if (mony <= 100)
                    {
                        destination = "Bulgaria";
                        location = "Bulgaria";
                        persent = 0.3;
                        cost = mony * persent;
                        FinalCost = mony - cost;
                        Console.WriteLine($"Somewhere in {location}");
                        Console.WriteLine($"Camp - {FinalCost}");
                    }
                    else if (mony <= 1000)
                    {
                        destination = "Balkans";
                        location = "Balkans";
                        persent = 0.4;
                        cost = mony * persent;
                        FinalCost = mony - cost;
                        Console.WriteLine($"Somewhere in {location}");
                        Console.WriteLine($"Camp - {FinalCost}");
                    }
                    else
                    {
                        destination = "Europe";
                        location = "Europe";
                        persent = 0.9;
                        cost = mony * persent;
                        FinalCost = mony - cost;
                        Console.WriteLine($"Somewhere in {location}");
                        Console.WriteLine($"Hotel - {FinalCost}");
                    }
                    break;
            }
            
        }
    }
}