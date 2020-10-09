using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKeyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key, please...");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(key.Key.ToString());

            if (key.Key.ToString() == "Enter")
            {
                Console.WriteLine("ENTER");
            }
            if (key.Key.ToString() == "LeftArrow")
            {
                Console.WriteLine("you pressed LeftArrow");
            }
        }
    }
}
