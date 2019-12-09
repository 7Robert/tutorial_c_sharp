using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class recursividad
    {
        public int fibonacci(int num)
        {
            if (num < 2)
            {
                return num;
            }
            else 
            {
                return fibonacci(num - 1) + fibonacci(num - 2);
            }
        }   
    }
}
