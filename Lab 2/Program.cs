using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            bool isOdd = false;
            Console.WriteLine("Enter an integer between 1 and 100");
            input = int.Parse( Console.ReadLine());
            if (input % 2 == 1)
            {
                isOdd = true;
                Console.WriteLine(input +" is odd");

            }
            if (isOdd == false && input >= 2 && input < 25)
            {
                Console.WriteLine("Even and Less than 25");
            }
            else if (!isOdd && input >= 26 && input <= 60)
            {
                Console.WriteLine("Even");
            }
            else if (!isOdd && input >= 60)
            {
                Console.WriteLine(input + " Even");
            }
            else if (isOdd && input > 60)
            {
                Console.WriteLine(input + " Odd");
            }
            
        }
    }
}
