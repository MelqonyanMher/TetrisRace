using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;

namespace MyRace
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                char a = (Char)1;
                Car c = new Car(a);
                c.Play();

            } while (ReadKey().Key == ConsoleKey.Enter);

        }
    }
}
