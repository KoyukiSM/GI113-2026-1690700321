/*
* Student ID    :  1690700321
* Name          :  Tawan Khunwattanaporn
* Section       :  129A
* Class number  :  N/A
* Course        :  GI113 Computer Programming (GI)
*/
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = """
             ____ ____ _  _ ____ ____ ____ ___     ____ ____ ____ ____    _  _ _     ____ _ ____ ____ ____    ____ ____    ____ _  _ ___  _ ____ ____ _  _ 
             |__| |__/ |\/| |  | |__/ |___ |  \    |    |  | |__/ |___    |  | | .   |___ | |__/ |___ [__     |  | |___    |__/ |  | |__] | |    |  | |\ | 
             |  | |  \ |  | |__| |  \ |___ |__/    |___ |__| |  \ |___     \/  | .   |    | |  \ |___ ___]    |__| |       |  \ |__| |__] | |___ |__| | \|
            [======================================================================O======================================================================]
            """;

            var chara = "C4-621 \"Raven\"";
            var charaCombatRanking = 'S';
            string charaOccupation = "AC pilot/Independent mercenary";
            int charaSerialDesignation = 621;
            bool charaIsAugmented = true;
            float charaGeneration = 4.0f;
            int charaAcAP = 9840;
            double charaAcSpeed = 326.575;
            double charaAcCost = 456300.75;
            double charaKillRatio = 24.5;

            Console.WriteLine($"{GameTitle}\n");
            Console.WriteLine($"Character Name               : {chara}");
            Console.WriteLine($"Combat Ranking               : {charaCombatRanking}");
            Console.WriteLine($"Occupation                   : {charaOccupation}");
            Console.WriteLine($"Serial Designation           : {charaSerialDesignation}");
            Console.WriteLine($"Character Body Augmentation  : {charaIsAugmented}");
            Console.WriteLine($"Character Generation         : {charaGeneration}");
            Console.WriteLine($"Armored core AP              : {charaAcAP}");
            Console.WriteLine($"Armored core Speed           : {charaAcSpeed}");
            Console.WriteLine($"Armored core Cost            : {charaAcCost}");
            Console.WriteLine($"Kill Ratio Per Mission       : {charaKillRatio}\n");
            Console.WriteLine("[======================================================================O======================================================================]\n");

            double maxAcAP = charaAcAP;
            int limitedAcSpeed = (int)charaAcSpeed;
            int maximumAcSpeed = Convert.ToInt32(charaAcSpeed);
            int totalAcCost = Convert.ToInt32(charaAcCost);

            Console.WriteLine($"Maximum Armored core AP      : {maxAcAP}");
            Console.WriteLine($"Armored core Limited Speed   : {limitedAcSpeed}");
            Console.WriteLine($"Armored core Maximum Speed   : {maximumAcSpeed}");
            Console.WriteLine($"Total Armored core Cost      : {totalAcCost}\n");
            Console.WriteLine("[======================================================================O======================================================================]\n");

            const string Raven = """
                                                                   ..
                                                                   ##
                                                                   ##+
                                                                   +##.
                                                                   +###
                                                                   -###+++------------.
                                                                   -###.       ##     ..++++----------
                                                                   -###-     .###     ##
                                                                   -###+     ###.   .###.
                                                                   -###+    ###+   .###.
                                                                  +###+  .###+   +###
                                                                  ####- .###+  .####-----+--
                                                                 -####.+###+  -###+   .##+   .
                                                                 +#########  +####   +##+   ..
                                                                 ######### .#####  .###-  .##-
                                                                -######## #####+  ####. .###+
                                                               .########+#####- -####..####.
                                                               ##############+.####+ +###+
                                                              ####################.+####-  .###
                                                             ###################-+####+ -####-
                                                            +++++++++------------------++++-++-----
                                                         -#######################-######.              ..
                                                        +############################-.#-            .##-     -#
                                                       ###########################-+####           -##+    -##+  -#+
                                                      ........................... .....           .+##.   ###- -###.
                                                      -###############++++++++++++++++.          .--.  .---...--..
                                                     +##############-#################+        -###--####-####--##+
                                                     ###############+###############+##     .-#############-###+..
                                                    .++++++++++++---###++++##+++++++++    -##+-..........-....-..
                                                   +###############################---.#############+####+###-
                                                    ######################################################--.
                                                      -+++++++++++++++++################################++##-
                                                       -#################################################+-
                                                         +###########################################-.
                                                          +########################################+
                                                           .####################################+-
                                                             #################################-+-
                                                              .-############################+.
                                                                ###########################.+--
                                                                 #########################-
                                                                 .########################+-
                                                                 .#######################.
                                                                 .######################+
                                                                 +#######################.
                                                               -#######################
                                                               +#########################.
                                                           .    #############################+-.---.
                                                           .. .##################################+---.    ......
                                                            ..##########.  ###############################+.
                                                               ########+     -##########################++-.
                                                                -#####-+-.  .############--#########--+++-
                                                                   .##+ +#.+#####- -##-##-  --###-.+####-
                                                                    -#########+.-#-    ..       .+#-  .--.
                                                                  ---####+-.---+++----......       .
            
                                                              ..         ..          ...      ..      ..
                                                           .##++##-     ###        ##+++#+ -##++##.  .##+
                                                           +#    ##   .#--#  ....  #-      -+   .#- .#.#-
                                                           +#        -#. -#  ####  ##---##  .+###-     #-
                                                           +#    ##. #######       #-   +# +#.         #+
                                                            +#####.      -#        -#####- +######.    #-
            """;
            Console.WriteLine($"{Raven}");
        }
    }
}
