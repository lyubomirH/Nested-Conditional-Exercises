namespace Operations_between_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string Operator = Console.ReadLine();

            double mat;
            string taep;
            switch (Operator)
            {
                case "+":
                    mat = N1 + N2;
                    if (mat % 2 == 0)
                    {
                        taep = "even";
                        Console.WriteLine($"{N1} {Operator} {N2} = {mat} - {taep}");

                    }
                    else if (mat % 2 == 1)
                    {
                        taep = "odd";
                        Console.WriteLine($"{N1} {Operator} {N2} = {mat} - {taep}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                break;
                case "-":
                    mat = N1 - N2;
                    if (mat % 2 == 0)
                    {
                        taep = "even";
                        Console.WriteLine($"{N1} {Operator} {N2} = {mat} - {taep}");

                    }
                    else if (mat % 2 == 1)
                    {
                        taep = "odd";
                        Console.WriteLine($"{N1} {Operator} {N2} = {mat} - {taep}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
                case "*":
                    mat = N1 * N2;
                    if (mat % 2 == 0)
                    {
                        taep = "even";
                        Console.WriteLine($"{N1} {Operator} {N2} = {mat} - {taep}");

                    }
                    else if (mat % 2 == 1)
                    {
                        taep = "odd";
                        Console.WriteLine($"{N1} {Operator} {N2} = {mat} - {taep}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
                case "/":
                    mat = N1 / N2;
                    if (mat % 2 == 0)
                    {
                        taep = "even";
                        Console.WriteLine($"{N1} {Operator} {N2} = {mat} - {taep}");

                    }
                    else if (mat % 2 == 1)
                    {
                        taep = "odd";
                        Console.WriteLine($"{N1} {Operator} {N2} = {mat} - {taep}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
                case "%":
                    mat = N1 % N2;
                    if (mat % 2 == 0)
                    {
                        taep = "even";
                        Console.WriteLine($"{N1} {Operator} {N2} = {mat} - {taep}");

                    }
                    else if (mat % 2 == 1)
                    {
                        taep = "odd";
                        Console.WriteLine($"{N1} {Operator} {N2} = {mat} - {taep}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
            }
        }
    }
}