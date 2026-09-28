/*
* Student ID    :  1690700321
* Name          :  Tawan Khunwattanaporn
* Section       :  129A
* Class number  :  N/A
* Course        :  GI113 Computer Programming (GI)
*/
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Little Forge";
            Console.WriteLine(" |O|                    |O|");
            Console.WriteLine("[==========================]");
            Console.WriteLine("|====== " + GameTitle + " ======|");
            Console.WriteLine("[==========================]");
            Console.WriteLine("\n- Tungsten Smelt/Salvage ratio: 0.25/0.5");
            Console.WriteLine("- Key 'S' for Smelting, 'B' for Salvage");

            Console.Write("\n> Enter your choice: ");
            bool check = char.TryParse(Console.ReadLine().ToUpper(), out char choice);

            if (check && choice == 'S')
            {
                Console.WriteLine("\nYou have chosen to smelt your ore.");
                Console.Write("> Enter the amount of ore you want to smelt: ");
                bool checkAmount = int.TryParse(Console.ReadLine(), out int amount);

                if (!checkAmount || amount <= 0)
                {
                    Console.WriteLine("> You can't enter a negative amount. Please enter a positive amount.");
                }
                else
                {
                    double smeltedAmount = amount * 0.25;

                    string ore = "ores";
                    if (amount == 1)
                    {
                        ore = "ore";
                    }
                    string bar = "bars";
                    if (smeltedAmount == 1)
                    {
                        bar = "bar";
                    }
                    Console.WriteLine($"> You have smelted {amount} Tungsten {ore} and got {smeltedAmount} {bar} of Tungsten.");
                }
            }

            else if (check && choice == 'B')
            {
                Console.WriteLine("\nYou have chosen to salvage your ore.");
                Console.Write("> Enter the amount of ore you want to salvage: ");
                bool checkAmount = int.TryParse(Console.ReadLine(), out int amount);

                if (!checkAmount || amount <= 0)
                {
                    Console.WriteLine("> You can't enter a negative amount. Please enter a positive amount.");
                }
                else
                {
                    double salvagedAmount = amount * 0.5;

                    string bar = "bars";
                    if (amount == 1)
                    {
                        bar = "bar";
                    }
                    string ore = "ores";
                    if (salvagedAmount == 1)
                    {
                        ore = "ore";
                    }
                    Console.WriteLine($"> You have salvaged {amount} Tungsten {bar} and got {salvagedAmount} Tungsten {ore}.");
                }
            }
            else
            {
                Console.WriteLine("> Invalid choice. Please enter 'S' for Smelting or 'B' for Salvage.");
            }
        }
    }
}
