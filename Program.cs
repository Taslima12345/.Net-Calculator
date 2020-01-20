using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        public double[] takeingInput()
        {
            string numer;
            int value;
            
            numer = Console.ReadLine();
            value = Convert.ToInt32(numer);

            double[] ele = new double[value];

            for (int i=0; i<value; value++)
            {
                ele[i] = Convert.ToDouble(Console.ReadLine());
            }

            return ele;
        }
         


    }
}

  

