using System;

namespace Exceptions3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;

            Console.WriteLine("Introducir primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introducir segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                resultado = num1 / num2;
                Console.WriteLine("El resultado es: {0}", resultado);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
        }
    }
}
