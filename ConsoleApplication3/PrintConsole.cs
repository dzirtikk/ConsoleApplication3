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
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  { arr[1]}  |  { arr[2]}  |  { arr[3]}");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  { arr[4]}  |  { arr[5]}  |  { arr[6]}");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  { arr[7]}  |  { arr[8]}  |  { arr[9]}");
            Console.WriteLine("_____|_____|_____");

        }
        
    }
}
