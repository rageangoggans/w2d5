using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine(" How old are you?");
                
            int age = (Convert.ToInt16(Console.ReadLine()));
             
            if
                (age >= 16)
            { Console.WriteLine("You can drive."); }

            else if
                (age >= 18)
            { Console.WriteLine("Youre an adult."); }
            
            else
            { Console.WriteLine("You're not old enough!"); }

            Console.ReadLine();


        }
    }
}
