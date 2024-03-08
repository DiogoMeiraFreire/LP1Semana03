using System;
using System.Diagnostics;
using PlayerPowers.Enum;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert the number of players: ");
            
            int n = int.Parse(Console.ReadLine());
            string result = "";

            PlayerPowersEnum [] playersPowers = new PlayerPowersEnum[n];

            for (int i = 0; i < playersPowers.Length; i++)
            {   
                result += $"Player {i+1}: ";
                
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"Player {i+1} choose your Power: ");
                    string str2 = Console.ReadLine();
                    if (str2 == "Fly")
                    {
                        playersPowers[i] ^= PlayerPowersEnum.Fly;
                    }
                    else if (str2 == "XRayVision")
                    {
                        playersPowers[i] ^= PlayerPowersEnum.XRayVision;
                    }
                    else if (str2 == "SuperStrength")
                    {
                        playersPowers[i] ^= PlayerPowersEnum.SuperStrength;
                    }
                    else
                        continue;
                }
                
                result += $"{playersPowers[i]} \n";


                if ((playersPowers[i] & PlayerPowersEnum.Fly) == PlayerPowersEnum.Fly
                    && ((playersPowers[i] & PlayerPowersEnum.SuperStrength)
                     == PlayerPowersEnum.SuperStrength))
                {
                    result +="Flying radiation!\n";
                }
                
            }
            Console.WriteLine(result);
        }
    }
}
