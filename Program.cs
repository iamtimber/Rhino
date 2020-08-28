using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhino
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall) // Using 2 ampersands means 'and'

            {
                Console.WriteLine("You are a tall Male");
            } else
            {
                Console.WriteLine("You are either not Male or not Tall or Both.");
            }

            Console.ReadLine();

        }



    }
}
