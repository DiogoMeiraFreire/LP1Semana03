using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string answer ="";
            char c; 


            Console.Write("String: ");

            str = Console.ReadLine(); 

            Console.Write("Caráter: ");

            c = char.Parse(Console.ReadLine());


            foreach(char character in str)
            {

                if(character == c)
                {
                    answer += "X"; 
                }


                else
                {
                    answer += character; 
                }
            }
            Console.WriteLine(answer); 
        }
    }
}
