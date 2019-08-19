using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int count = 3; count >= 1; count -= 2)
            {
               
                Console.WriteLine("The value of count is now " + count + ".");

            }
            Console.ReadKey();
        }
    }
}
