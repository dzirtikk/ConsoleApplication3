using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class GameplayC 
    {
        private GameplayI checker;
        private IPrint pritner;

        public GameplayC(GameplayI chec, IPrint pritner)
        {
            this.checker = chec;
            this.pritner = pritner;
            
        }
        public void CreateDesk(char[] arr)
        {
            pritner.DrawDesk(arr);
        }
        
       public int HasWinner(char[] arr)
        {
            return checker.ChecWin(arr);
        }
        public void Khod(char[] arr)
        {

            Console.WriteLine($"Введите координаты хода игрока {Program.PlayNumb}");
            Int32.TryParse(Console.ReadLine(), out Program.x);
            if (Program.x <= 9)
            {
                if (arr[Program.x - 1] != 'X' && arr[Program.x - 1] != 'O')
                {

                    switch (Program.PlayNumb)
                    {
                        case 1:
                            arr[Program.x - 1] = 'X';
                            revertnumber();
                            break;
                        case 2:
                            arr[Program.x - 1] = 'O';
                            revertnumber();
                            break;
                    }
                    pritner.DrawDesk(arr);
                }
                else Console.WriteLine("В этом месте уже есть знак");
            }

        }

        public void revertnumber()
        {
            if (Program.PlayNumb == 1)
                Program.PlayNumb = 2;
            else Program.PlayNumb = 1;
        }
    }
}
