using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            foreach(string str in args)
            {
                
                if (str.Length > 3)
                {
                    if(str.Length > 6)
                    {
                        return; 
                    }
                    Console.WriteLine(args[i]);
                } 

                i++;
            }
        }
    }
}
