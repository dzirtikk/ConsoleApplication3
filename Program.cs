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
        static int x, PlayNumb;
        static int flag = 0;
        static void Main(string[] args)
        {
            Program.PlayNumb = 2;
            var print = new PrintConsole();
            print.DrawDesk(arr);
            while (flag != 1 && flag != -1)
            {
                 Khod(arr, PlayNumb);
                 print.DrawDesk(arr);
                 flag = CheckWin();
            }
            Console.WriteLine("Игра закончена!");
            if(flag == 1){
                Console.WriteLine($"Победил игрок под номером {PlayNumb}");
            } else
            {
                Console.WriteLine("Ничья");
            }
        }

        static void Khod(char[] arr, int PlayNumb)
        {
            Console.WriteLine($"Введите координаты хода игрока {PlayNumb}");
            Int32.TryParse(Console.ReadLine(), out x);
            if (arr[x] != 'X' && arr[x] != 'O')
            {
                if (PlayNumb == 2)
                {
                    Console.WriteLine("check");
                    arr[x] = 'X';
                    Program.PlayNumb = 1;
                }
                else
                {
                    arr[x] = 'O';
                    Program.PlayNumb = 2;
                }
            } else
            {
                Console.WriteLine("В этом месте уже есть знак");
            }

        }
        private static int CheckWin()

        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

    }
}
