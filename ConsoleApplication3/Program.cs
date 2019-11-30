using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static char[] arr = { '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        public static int x;
        public static int PlayNumb = 1;
        static int flag = 0;
        static void Main(string[] args)
        {
            Gameplay();
        }
        static void Gameplay()
        {
            var gamep = new GameplayC(new Winnerchecker(),new PrintConsole());
            gamep.CreateDesk(arr);
            //Ход
            while (flag == 0)
            {
                gamep.Khod(arr);
                
                flag = gamep.HasWinner(arr);
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
