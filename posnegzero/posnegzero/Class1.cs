using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosNegZero
{
    public class PNZ
    {
        int num;

        public PNZ()
        {
            num = 2;
        }

        public PNZ(int num)
        {
            this.num = num;
        }

        public void check()
        {
            if (num == 0)
            {
                Console.WriteLine("The number is 0");
            }
            else if (num > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is negative");

            }
        }

    }
}