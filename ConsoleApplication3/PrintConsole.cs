using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class PrintConsole : IPrint
    {
        public void DrawDesk(char[] arr)
        {
            Console.Clear();
            Console.WriteLine("_________________");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  { arr[0]}  |  { arr[1]}  |  { arr[2]}");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  { arr[3]}  |  { arr[4]}  |  { arr[5]}");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  { arr[6]}  |  { arr[7]}  |  { arr[8]}");
            Console.WriteLine("_____|_____|_____");

        }
    }
    
}
