using System;
using System.Collections.Generic;
using System.Text;

namespace overloading_in_c_sharp
{
    class Overloading
    {
        public int add(int a, int b)
        {
            int sum= a+b;
            return sum;
        }

        public int add(int a,int b,int c)
        {
            int sum1 = a + b + c;
            return sum1;
        }

        public float add(float a, float b)
        {
            float sum = a * b;
            return sum;
        }
    }
}
