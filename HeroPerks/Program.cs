using System;
using HeroPerks.Enum;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerPerks = "";
            HeroPerksEnum perksEnum = 0;

            foreach (string s in args)
            {
                playerPerks = s;
            }

            for (int i = 0; i < playerPerks.Length; i++)
            {
                if (playerPerks[i] == 'w')
                {
                    perksEnum ^= HeroPerksEnum.WaterBreathing;
                }
                else if (playerPerks[i] == 's')
                {
                    perksEnum ^= HeroPerksEnum.Stealth;
                }
                else if (playerPerks[i] == 'a')
                {
                    perksEnum ^= HeroPerksEnum.AutoHeal;
                }
                else if (playerPerks[i] == 'd')
                {   
                    perksEnum ^= HeroPerksEnum.DoubleJump;
                }
                else if (playerPerks[i] != 'w' || playerPerks[i] != 's'||
                    playerPerks[i] != 'a'|| playerPerks[i] != 'd')
                    {
                        Console.WriteLine("Unknown perk!");
                        return;
                    }
            }
            if (perksEnum != 0)
                Console.WriteLine(perksEnum);

            if ((perksEnum & HeroPerksEnum.Stealth) == HeroPerksEnum.Stealth 
            && (perksEnum & HeroPerksEnum.DoubleJump) == HeroPerksEnum.DoubleJump)
            {
                Console.WriteLine("Silent jumper!");
            }

            if ((perksEnum & HeroPerksEnum.AutoHeal) != HeroPerksEnum.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }

            if (perksEnum == 0)
            {
                Console.WriteLine("No perks at all!");
            }

        }
    }
}
