/*
* Student ID    :  1690700321
* Name          :  Tawan Khunwattanaporn
* Section       :  129A
* Class number  :  N/A
* Course        :  GI113 Computer Programming (GI)
*/
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[======O- Basic DND -O=====]");
            Console.WriteLine("Hero vs. Monsters == Fight Calculator");

            Console.Write("Hero HP: ");
            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defence: ");
            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);

            Console.Write("Monster HP: ");
            bool isMonsterHp = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.Write("Monster Attack: ");
            bool isMonsterAtk = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.Write("Monster Defence: ");
            bool isMonsterDef = int.TryParse(Console.ReadLine(), out int monsterDef);
            int monsterMaxHp = monsterHp;

            //Check stats
            bool allHeroValid = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonsterValid = isMonsterHp && isMonsterAtk && isMonsterDef;
            Console.WriteLine($"Stats Validation: Hero: {allHeroValid}, Stats Validation: Monster: {allMonsterValid}");
            Console.WriteLine($"[Hero]  HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[Monster]   HP: {monsterHp} ATK: {monsterAtk} DEF: {monsterDef}");

            // Hero Heals
            int potionHeal = 8;
            heroHp += potionHeal; // heroHp = heroHp + potionHeal; -> Long form.
            Console.WriteLine($"\nHero drinks a potion, Healing {potionHeal} HP. Current HP is now {heroHp} HP");
            
            // Hero Normal Attack
            int normalDamage = Math.Max(0, heroAtk - monsterDef);
            Console.WriteLine($"Normal Attack deal: {normalDamage} DMG");
            
            // Hero Power Attack
            int powerDamage = Math.Max(0, heroAtk * 2 - monsterDef);
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");

            // Monster Attack
            int counterDamage = Math.Max(0, monsterAtk - heroDef);
            Console.WriteLine($"Monster Counter Attack deal: {counterDamage} DMG");

            //Random Crits
            Random rng = new Random();
            int roll = rng.Next(1, 101); // Ramdom Crit Number from 1-100
            bool isCrit = roll <= 10; // Basically 10% Crit Chance
            int critDmg = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // 1 = Crit, 0 = No Crit
            Console.WriteLine($"Critical hit roll: {roll} (Critical: {isCrit})");
            Console.WriteLine($"Normal Attack would deal Critical: {critDmg} DMG");

            // Foreshadow ahh.
            bool heroHitsHarder = heroAtk > monsterAtk;
            bool normalOneShot = normalDamage >= monsterHp;
            bool monsterOneShotHero = counterDamage >= heroHp;
            bool safeTrade = normalDamage > counterDamage && !monsterOneShotHero;
            bool luckyOrLethal = isCrit || normalOneShot;
            Console.WriteLine($"\nHero hits harder than Monster: {heroHitsHarder}");
            Console.WriteLine($"Normal Attack can defeat Monster in one hit: {normalOneShot}");
            Console.WriteLine($"Monster could defeat Hero in one hit back: {monsterOneShotHero}");
            Console.WriteLine($"This is a safe trade for Hero: {safeTrade}");
            Console.WriteLine($"This attack is lucky or lethal: {luckyOrLethal}");

            // Normal Attack
            monsterHp -= normalDamage;
            Console.WriteLine($"Hero attacks! Monster HP: {monsterHp}/{monsterMaxHp}");

            // Result + reward
            bool monsterDefeated = monsterHp <= 0;
            int goldEarned = (monsterMaxHp - monsterHp) * 2;
            Console.WriteLine($"\nMonster defeated: {monsterDefeated}");
            Console.WriteLine($"Gold earned: {goldEarned}");
        }
    }
}
