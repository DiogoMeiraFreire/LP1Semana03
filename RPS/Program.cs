using System;
using RPS.Items;
using RPS.Status;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);

            switch (result)
            {
                case 1:
                    Console.WriteLine("It's a draw!");
                    break;
                case 2:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 4:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            RockPaperScissorItems P1Play = 
            (RockPaperScissorItems)Enum.Parse(typeof(RockPaperScissorItems), player1);
            RockPaperScissorItems P2Play = 
            (RockPaperScissorItems)Enum.Parse(typeof(RockPaperScissorItems), player2);

            RockPaperScissorStatus result = 0;

            if (P1Play == P2Play)
            {
                result = RockPaperScissorStatus.Draw;
                return (int)result;
            }
            else if (((P1Play == RockPaperScissorItems.Rock) && 
                 (P2Play == RockPaperScissorItems.Scissors)) ||
                ((P1Play == RockPaperScissorItems.Scissors) && 
                 (P2Play == RockPaperScissorItems.Paper)) ||
                ((P1Play == RockPaperScissorItems.Paper) && 
                 (P2Play == RockPaperScissorItems.Rock)))
            {
                result = RockPaperScissorStatus.Player1Wins;
                return (int)result;
            }
            else
            {
                result = RockPaperScissorStatus.Player2Wins;
                return (int)result;
            }
                
        }
    }
}
