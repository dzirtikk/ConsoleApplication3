using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static int x;
        public static int PlayNumb = 1;
        static int flag = 0;
        static void Main(string[] args)
        {
            Gameplay();
        }
        static void Gameplay()
        {
            var print = new PrintConsole();
            var gamep = new GameplayC();
            print.DrawDesk(arr);
            //Ход
            while (flag != 1 && flag != -1)
            {
                gamep.Khod(arr);
                print.DrawDesk(arr);
                flag = gamep.ChecWin(arr);
            }
            //Конец игры
            Console.WriteLine("Игра закончена!");
            if (flag == 1)
            {
                gamep.revertnumber();
                Console.WriteLine($"Победил игрок под номером {PlayNumb}");
            }
            else
            {
                Console.WriteLine("Ничья");
            }
            Console.WriteLine("Нажмите любую кнопку для закрытия");
            Console.ReadKey();
        }
    }
}
