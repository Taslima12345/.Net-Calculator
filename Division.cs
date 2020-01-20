using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Division
    {
        Program program = new Program();
        double divpres = 1;

        public static double add(int[] newarray, int value, double divpres)
        {
            for (int i = 0; i < value; value++)
            {
                divpres = newarray[i] / divpres;
            }
            return divpres;
        }
    }
}
