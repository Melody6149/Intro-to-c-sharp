using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_tutorial
{
    class Game
    {
        int numberOne = 10;
        int numberTwo = 200;

        public void start()
        {
            int biggestnumber = ReturnBiggestNumber(numberOne, numberTwo);
            Console.WriteLine("Of " + numberOne + " and " + numberTwo + " the biggest number is " + biggestnumber);
            Console.ReadKey();
        }
        int ReturnBiggestNumber(int first, int second)
        {
            if(first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
