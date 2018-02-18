using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            string output = "invalid";

            if ((a + b) > c
                && (a + c) > b
                && (b + c) > a)
            {
                if (a == b && b == c)
                {
                    output = "equilateral";
                }
                else if (a == b || a == c || b == c)
                {
                    output = "isosceles";
                }
                else
                {
                    output = "scalene";
                }
            }

            return output;
        }
    }
}
