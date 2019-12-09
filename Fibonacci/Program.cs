using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //fibonacci(50);
            //double f = factorial(5);

            recursividad r = new recursividad();
            int num = 1;

            while (num < 10)
            {
                Console.WriteLine(r.fibonacci(num));
                num++;
            }
        }

        public static void fibonacci(int end)
        {
            int num = 1;
            int aux = 1;
            int result;

            while (num < end)
            {
                Console.WriteLine(num);
                result = num + aux;
                aux = num;
                num = result;
            }

       }

        public static int factorial (int num)
        {
            int aux = 1;

            if (num == 0)
            {
                return 1;
            }else
            {
                while(num > 0)
                {
                    aux = aux * num;
                    num--;
                }        
                return aux;
            }
        }
    }
}
