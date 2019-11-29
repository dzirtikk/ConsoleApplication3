using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class GameplayC : GameplayI
    {

        public int ChecWin(char[] arr) //Страшные проверки победы
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

        public void Khod(char[] arr)
        {

            Console.WriteLine($"Введите координаты хода игрока {Program.PlayNumb}");
            Int32.TryParse(Console.ReadLine(), out Program.x);
            if (arr[Program.x] != 'X' && arr[Program.x] != 'O')

                switch (Program.PlayNumb)
                {
                    case 1:
                        arr[Program.x] = 'X';
                        revertnumber();
                        break;
                    case 2:
                        arr[Program.x] = 'O';
                        revertnumber();
                        break;
                }
            else Console.WriteLine("В этом месте уже есть знак");
        }

        public void revertnumber()
        {
            if (Program.PlayNumb == 1)
                Program.PlayNumb = 2;
            else Program.PlayNumb = 1;
        }
    }
}
