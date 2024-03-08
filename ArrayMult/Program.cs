using System;

namespace ArrayMult
{
    class Program
    {
        private static void Main(string[] args)
        {
            float[,] array1 = new float[2, 2];
            float[,] array2 = new float[2, 1];
           
            array1[0,0] = float.Parse(args[0]);
            array1[0,1] = float.Parse(args[1]);
            array1[1,0] = float.Parse(args[2]);
            array1[1,1] = float.Parse(args[3]);

            array2[0,0] = float.Parse(args[4]);
            array2[1,0] = float.Parse(args[5]);   
        
            
            for(int i = 0; i < 2; i++)
            {
                float answer = 0F; 
                for(int j = 0; j < 2 ; j++)
                {
                    answer += array1[i, j] * array2[j, 0];
                    
                }
                Console.WriteLine(answer);
            }

           
        }
    }
}