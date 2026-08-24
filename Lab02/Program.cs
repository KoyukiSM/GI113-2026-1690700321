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
            Console.WriteLine($"Hp Percent: {hpPercent}%");
            Console.WriteLine("");
            Console.WriteLine($"Kirin takes {damageTaken} damage!");
            Console.WriteLine("");
            int remainingHp = currentHp - damageTaken;
            int remainingHpPercentage = remainingHp * 100 / maxHp;
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {remainingHp} / {maxHp}");
            Console.WriteLine($"Hp: {remainingHpPercentage}%");
            Console.WriteLine("");
            Console.WriteLine("");


        }
    }
}
