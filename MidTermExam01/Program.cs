/*
* Student ID    :  1690700321
* Name          :  Tawan Khunwattanaporn
* Section       :  129A
* Class number  :  19
* Course        :  GI113 Computer Programming (GI)
*/
namespace MidTermExam01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back, Commander!");
            Console.Write("Please enter the amount of your log in day: ");
            bool logIn = int.TryParse(Console.ReadLine(), out int logInDay);

            string dailyReward = "\n>Standard daily supplies: 1000 CC";
            int standardPoint = 1000;

            if (logInDay <= 0)
            {
                Console.WriteLine("\n>Invaild amount. Please enter the correct amount, Commander >:V");
            }
            else if (logInDay >= 30)
            {
                Console.WriteLine($"{dailyReward}" + $"\n>Bonus daily supplies: {standardPoint * 0.25} CC" + $"\n>Your total supplies: { standardPoint + (standardPoint * 0.25)} CC");
            }
            else if (logInDay >= 14)
            {
                Console.WriteLine($"{dailyReward}" + $"\n>Bonus daily supplies: {standardPoint * 0.15} CC" + $"\n>Your total supplies: {standardPoint + (standardPoint * 0.15)} CC");
            }
            else if (logInDay >= 7)
            {
                Console.WriteLine($"{dailyReward}" + $"\n>Bonus daily supplies: {standardPoint * 0.1} CC" + $"\n>Your total supplies: {standardPoint + (standardPoint * 0.1)} CC");
            }
            else if (logInDay > 1)
            {
                Console.WriteLine($"{dailyReward}" + $"\n>Bonus daily supplies: {standardPoint * 0.05} CC" + $"\n>Your total supplies: {standardPoint + (standardPoint * 0.05)} CC");
            }
            else if (logInDay == 1)
            {
                Console.WriteLine($"{dailyReward}" + $"\n>There's no daily bonus for today, Commander :(");
            }
        }
    }
}
