using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Static_Extention_Homework.Helpers
{
    public static class Extention
    {
        public static int Factorial(this int num)
        {
            int power = 1;
            for (int i = 1; i <= num; i++)
            {
                power *= i;
            }
            return power;
        }



        public static double Power(this int a, int b)
        {
            var result = Math.Pow(a, b);

            return result;


        }

    }
}

    





