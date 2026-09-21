/*
* Student ID    :  1690700321
* Name          :  Tawan Khunwattanaporn
* Section       :  129A
* Class number  :  N/A
* Course        :  GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//1 If/Else Shenanigans
            int lives = 1;

            if (lives == 0) // <- Must have boolean inside.
            {
                Console.WriteLine("Game Over!");
            }

            Console.WriteLine("Continue Running.");

            //2
            int coin = 80;
            int price = 100;

            // if (money >= price) {Console.WriteLine("Purchased!");} <- This is fine too but not recommeneded.

            if (coin >= price)
            {
                Console.WriteLine("Purchased!");
            }
            else
            {
                Console.WriteLine("Not enough coins.");
            }

            //2.5 Uhhhh...Why did I even write this?
            int yourLevel = 7;

            if (yourLevel >= 5)
            {
                Console.WriteLine("The door opens");
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }

            //3
            int score = 75;

            if (score >= 90) // Will ignore the rest of the code if it found the right condition. Otherwise, It will go straight to "else".
            {
                Console.WriteLine("Rank S");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Rank A");
            }
            else
            {
                Console.WriteLine("Rank B");
            }

            //4
            bool hasKey = true;

            Console.Write("Your level (1-99): ");
            bool check = int.TryParse(Console.ReadLine(), out int level);

            if (!check || level < 1 || level > 99 && hasKey) // Just in case if user being an idiot.
            {
                Console.WriteLine("Invalid Level, please try again.");
            }
            else if (level >= 10 && hasKey) // Simplified.
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5) // Full.
            {
                if (hasKey)
                {
                    Console.WriteLine("The door opens.");
                }
                else
                {
                    Console.WriteLine("Locked. Find a key.");
                }
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }*/

            Console.WriteLine("<<Totally Original Turn Based Game>>");
            Console.WriteLine("\n[> 5 Tons Giant Slime has appeared! <]");

            int heroHP = 25;
            int heroATK = 10;
            int slimeHP = 150;
            int slimeATK = 999;

            Console.WriteLine($"\n5 Tons Giant Slime HP: {slimeHP}");
            Console.WriteLine($"Your HP: {heroHP}");

            Console.WriteLine("\nPlease choose your action.");
            Console.WriteLine("Action 1: Attack." + "\nAction 2: Evade." + "\nAction 3: Flee.");

            Console.Write("\nYour action: ");
            bool check = char.TryParse(Console.ReadLine(), out char choice);

            if (check && choice == '1')
            {
                Console.WriteLine($"\nYou attacked! Which dealt {heroATK} Damage to 5 Tons Giant Slime.");
                Console.WriteLine($"5 Tons Giant Slime HP: {slimeHP - heroATK}");
                Console.WriteLine($"Slime counter attacked you for {slimeATK} damage.");
                Console.WriteLine($"Your HP: {heroHP - slimeATK}");
                if (heroHP - slimeATK <= 0)
                {
                    Console.WriteLine("\n[>You died<]");
                }
            }
            else if (check && choice == '2')
            {
                Console.WriteLine("\nYou tried to evade the attack.");
                Console.WriteLine("That slime is literally the size of a 5 storey building. You're dodging nothing bud.");
                Console.WriteLine($"Slime attacked you for {slimeATK} damage.");
                Console.WriteLine($"Your HP: {heroHP - slimeATK}");
                if (heroHP - slimeATK <= 0)
                {
                    Console.WriteLine("\n[>You died<]");
                }
            }
            else if (check && choice == '3')
            {
                Console.WriteLine("\nYou tried to flee from it.");
                Console.WriteLine("Its body surface area is big enough to block all of your escape route. You ain't going to run away, bro. It caught you.");
                Console.WriteLine($"Slime attacked you for {slimeATK} damage.");
                Console.WriteLine($"Your HP: {heroHP - slimeATK}");
                if (heroHP - slimeATK <= 0)
                {
                    Console.WriteLine("\n[>You died<]");
                }
            }
            else
            {
                Console.WriteLine("You're supposed to choose between 1 - 3. Now you bricked the whole game. (Slime ate you and you died by the way.)");
            }
        }
    }
}