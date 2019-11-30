using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface GameplayI
    {
        int ChecWin(char[] arr);
    }
    class Winnerchecker : GameplayI
    {
        static Tuple<byte, byte, byte>[] keys = new Tuple<byte, byte, byte>[]
       {
            new Tuple<byte, byte, byte>(0,1,2),
            new Tuple<byte, byte, byte>(3,4,5),
            new Tuple<byte, byte, byte>(6,7,8),
            new Tuple<byte,byte,byte>(0,3,6),
            new Tuple<byte,byte,byte>(1,4,5),
            new Tuple<byte,byte,byte>(2,5,8),
            new Tuple<byte, byte, byte>(0,4,8),
            new Tuple<byte, byte, byte>(2,4,6),
       };
        private int CheckTri(char x, char y, char z)
        {
            if (x == '-' | y == '-' | z == '-')
            {
                return 0;
            }
            if (x == y && y == z)
            {
                return 1;
            }
            return 0;
        }
        public int ChecWin(char[] arr) //Красивые проверки победы
        {
            for (var i = 0; i < keys.Length; i++)
            {
                var result = CheckTri(arr[keys[i].Item1], arr[keys[i].Item2], arr[keys[i].Item3]);
                if (result == 1)
                {
                    return result;
                }
            }
            return 0;





            //if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            //  {
            //    return -1;
            //}

        }

    }
}
