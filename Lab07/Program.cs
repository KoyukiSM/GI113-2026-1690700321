/*
* Student ID    :  1690700321
* Name          :  Tawan Khunwattanaporn
* Section       :  129A
* Class number  :  N/A
* Course        :  GI113 Computer Programming (GI)
*/
namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            /*int level = 0;

            switch (level)
            {
                case >=10:
                    Console.WriteLine("Unlocked Sword.");
                    break;
                case 5:
                    Console.WriteLine("Unlocked Stick.");
                    break;
                default:
                    Console.WriteLine("Invalid level.");
                    break;
            }
            */

            // 2
            /*int classId = 2;

            string weapon = classId switch
            {
                1 => "Sword",
                2 => "Staff",
                3 => "Bow",
                _ => "Fist."
            };
            Console.WriteLine($"weapons {weapon}.");
            */
            
            // Part A
            Console.WriteLine("Part A.");
            //-- Main settings.
            const int MonsterHp1 = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense1);
            Console.WriteLine($"A Slime appears! HP {MonsterHp1}, DEF {monsterDefense1}");
            //-- Menu, Switch Statement.
            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.Write("Choose (1-4): ");
            int.TryParse(Console.ReadLine(), out int command1);

            switch (command1)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }
            //-- Calculate damage with switch expression.
            int power1 = command1 switch
            {
                1 => 12,
                2 => 18,
                _ => 0
            };
            int damage1 = Math.Max(0, power1 - monsterDefense1);
            Console.WriteLine($"Damage: {damage1}");
            //-- Calculate rating with relational pattern.
            string rating1 = damage1 switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating1}");
            //-- Check if monster is defeated with relational pattern or not. (Ternary)
            string monsterStatus1 = damage1 >= MonsterHp1 ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus1}");
            //-- Escape.
            Console.Write("Really run away? (y/n): ");
            string answer1 = Console.ReadLine();

            switch (answer1)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }


            // Part B
            Console.WriteLine("\nPart B.");
            const int MonsterHp2 = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense2);
            Console.WriteLine($"A Slime appears! HP {MonsterHp2}, DEF {monsterDefense2}");

            Console.WriteLine("[]===> COMBAT MENU <===[]");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Ball");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Flee");
            Console.WriteLine("5) Boom Shurikens");
            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command2);

            switch (command2)
            {
                case 1:
                    Console.WriteLine("You strike your sword!");
                    break;
                case 2:
                    Console.WriteLine("You cast a fire ball!");
                    break;
                case 3:
                    Console.WriteLine("You look for a way out.");
                    break;
                case 4:
                    Console.WriteLine("You prepare to take a hit.");
                    break;
                case 5:
                    Console.WriteLine("You throw boom shurikens!");
                    break;
                default:
                    Console.WriteLine("You hesitate. Invalid command!");
                    break;
            }

            int power2 = command2 switch
            {
                1 => 12,
                2 => 18,
                5 => 20,
                _ => 0
            };
            int damage2 = Math.Max(0, power2 - monsterDefense2);
            Console.WriteLine($"Damage: {damage2}");

            string rating2 = damage2 switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating2}");

            if (damage2 >= MonsterHp2)
            {
                Console.WriteLine("The slime is defeated!");
                Console.Write("Do you want to go to the next area? (y/n): ");
                string answer2 = Console.ReadLine();
                switch (answer2)
                {
                    case "y":
                    case "Y":
                        Console.WriteLine("You proceed to the next area.");
                        break;
                    case "n":
                    case "N":
                        Console.WriteLine("You stay on the same area.");
                        break;
                    default:
                        Console.WriteLine("Please type y or n.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("The slime is still standing.");
                Console.Write("Do you want to flee? (y/n): ");
                string answer2 = Console.ReadLine();
                switch (answer2)
                {
                    case "y":
                    case "Y":
                        Console.WriteLine("You flee from the battle!");
                        break;
                    case "n":
                    case "N":
                        Console.WriteLine("You stay on the battle.");
                        break;
                    default:
                        Console.WriteLine("Please type y or n.");
                        break;
                }
            }
        }
    }
}
