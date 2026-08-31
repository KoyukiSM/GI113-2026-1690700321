/*
* Student ID    :  1690700321
* Name          :  Tawan Khunwattanaporn
* Section       :  129A
* Class number  :  N/A
* Course        :  GI113 Computer Programming (GI)
*/
namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // output
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}\nRank: {rank}\nLevel: {level}/{maxHp}\nHP: {currentHp}/{maxHp}" +
                $"\nAttack Power: {attackPower}\nCrit Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

            // Implicit int -> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; // Int -> Double, No cast, ใส่ค่าได้เลย
            Console.WriteLine($"HP (double): {currentHpDouble}");

            // Implicit after calculation when result is decimal
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercent = currentHpDouble * 100 / maxHp; // int / int then calculate to double to be decimal
            Console.WriteLine($"HP Percent (exact): {hpPercent}%");

            // Explicit by Casting (float) AttackPower -> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackInt = (int)attackPower; // Convert data by Cast (insert wanted data)name of the data
            Console.WriteLine($"Attacl Power (int cast): {attackInt}");

            //
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}
