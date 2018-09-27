using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = Console.ReadLine();

            if (tekst == "Date")
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(now);
            }

            else if (tekst.ToCharArray().Any(char.IsDigit))
            {
                Console.WriteLine("I,m not calculator");

            }
            else
            {
                Console.WriteLine("Hi!");
            }

            Console.ReadKey();
        }
    }
}
