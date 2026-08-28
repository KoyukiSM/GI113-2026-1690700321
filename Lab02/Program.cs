/*
 * Student ID    :  1690700321
 * Name          :  Tawan Khunwattanaporn
 * Section       :  129A
 * Class number  :  N/A
 * Course        :  GI113 Computer Programming (GI)
*/
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            int damageTaken = 60;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine("");
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine("");
            Console.WriteLine($"Kirin takes {damageTaken} damage!");
            Console.WriteLine("");
            int remainingHp = currentHp - damageTaken;
            int remainingHpPercentage = remainingHp * 100 / maxHp;
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {remainingHp} / {maxHp}");
            Console.WriteLine($"HP: {remainingHpPercentage}%");
            Console.WriteLine("");
            Console.WriteLine("=================================================================");
            Console.WriteLine("Simulation stability state: critical. Reset protocol initiated...");
            Console.WriteLine("...");
            Console.WriteLine("..");
            Console.WriteLine(".");
            Console.WriteLine("Reset protocol completed. Please select your new companion.");
            Console.WriteLine("=================================================================");
            Console.WriteLine("");
            string nameAlice = "Alice";
            string raceAlice = "Human";
            string classAlice = "Magician";
            int ageAlice = 26;
            char genderAlice = 'F';
            double heightAlice = 1.65;
            Console.WriteLine("Companion 1 Data:");
            Console.WriteLine($"Name: {nameAlice}");
            Console.WriteLine($"Race: {raceAlice}");
            Console.WriteLine($"Gender: {genderAlice}");
            Console.WriteLine($"Age: {ageAlice}");
            Console.WriteLine($"height: {heightAlice} M");
            Console.WriteLine($"Class: {classAlice}");
            Console.WriteLine("");

            string nameThyme = "Thyme";
            string raceThyme = "Wood-Elf";
            string classThyme = "Ranger";
            int ageThyme = 169;
            char genderThyme = 'F';
            double heightThyme = 1.77;
            Console.WriteLine("Companion 2 Data:");
            Console.WriteLine($"Name: {nameThyme}");
            Console.WriteLine($"Race: {raceThyme}");
            Console.WriteLine($"Gender: {genderThyme}");
            Console.WriteLine($"Age: {ageThyme}");
            Console.WriteLine($"height: {heightThyme} M");
            Console.WriteLine($"Class: {classThyme}");
            Console.WriteLine("");

            string nameTaki = "Taki";
            string raceTaki = "Halfling (Canine)";
            string classTaki = "Fighter";
            int ageTaki = 43;
            char genderTaki = 'M';
            double heightTaki = 1.82;
            Console.WriteLine("Companion 3 Data:");
            Console.WriteLine($"Name: {nameTaki}");
            Console.WriteLine($"Race: {raceTaki}");
            Console.WriteLine($"Gender: {genderTaki}");
            Console.WriteLine($"Age: {ageTaki}");
            Console.WriteLine($"height: {heightTaki} M");
            Console.WriteLine($"Class: {classTaki}");
            Console.WriteLine("");

            string nameUnknown = "Ko";
            string raceUnknown = "Halfling (???)";
            string ageUnknown = "Physically in mid 30 (Presumably older than Tonantzintla-618)";
            string genderUnknown = "Physically F";
            string heightUnknown = "Physically 1.8";
            bool unknownStatus = true;
            Console.WriteLine("Companion 4 Data: (Locked)");
            Console.WriteLine($"Name: {nameUnknown}");
            Console.WriteLine($"Race: {raceUnknown}");
            Console.WriteLine($"Gender: {genderUnknown}");
            Console.WriteLine($"Age: {ageUnknown}");
            Console.WriteLine($"height: {heightUnknown} M");
            Console.WriteLine($"Safe to approach?:...{unknownStatus}.");
        }
    }
}
