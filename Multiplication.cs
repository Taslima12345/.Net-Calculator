using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Multiplication
    {
        Program program = new Program();
        double multipres = 1;

        public static double add(int[] newarray, int value, double multipres)
        {
            for (int i = 0; i < value; value++)
            {
                multipres = newarray[i] * multipres;
            }
            return multipres;
        }
    }
}
