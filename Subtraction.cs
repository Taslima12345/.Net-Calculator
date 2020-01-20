using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Subtraction
    {
        Program program = new Program();
        double subres = 0;

        public static double add(int[] newarray, int value, double subres)
        {
            for (int i = 0; i < value; value++)
            {
                subres =  newarray[i]- subres;
            }
            return subres;
        }
    }
}
