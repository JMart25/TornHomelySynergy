using System;

class HomeSales
{
    static void Main(string[] args)
    {
        int totalD = 0, totalE = 0, totalF = 0;

        Console.WriteLine("Enter salesperson initial (D, E, or F), or Z to exit:");
        char initial;
        do
        {
            Console.Write("Salesperson initial: ");
            initial = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (initial == 'Z')
                break;

            if (initial != 'D' && initial != 'E' && initial != 'F')
            {
                Console.WriteLine("Invalid initial. Please enter D, E, F, or Z.");
                continue;
            }

            Console.Write("Enter sale amount: ");
            int sale;
            if (!int.TryParse(Console.ReadLine(), out sale))
            {
                Console.WriteLine("Invalid sale amount. Please enter a valid integer.");
                continue;
            }

            switch (initial)
            {
                case 'D':
                    totalD += sale;
                    break;
                case 'E':
                    totalE += sale;
                    break;
                case 'F':
                    totalF += sale;
                    break;
            }

        } while (initial != 'Z');

        string grandTotalFormatted = String.Format("{0:n0}", totalD + totalE + totalF);
        Console.WriteLine($"Grand Total: ${grandTotalFormatted}");

        char highestSalesperson = totalD > totalE ? (totalD > totalF ? 'D' : 'F') : (totalE > totalF ? 'E' : 'F');
        Console.WriteLine($"Highest Sale: {highestSalesperson}");
    }
}

