using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //output text//
            Console.WriteLine("Hello. What is your name?");
            string playername = Console.ReadLine();
            // allows you to type in name//

            int playerscore = 0;
           
            int add = 0;
            
            while (playerscore < 10)
            {
                Console.Write("increment score: ");
                add = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Score of " + playername);
                // adds to score//
                playerscore = playerscore + add;
                Console.WriteLine(playerscore);
                //dislplays score make sure to put it after i add to score//
                
            }
            
        }
    }
}
