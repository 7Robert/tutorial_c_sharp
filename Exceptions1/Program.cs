using System;

namespace Exceptions1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;
            Console.WriteLine("Introducir el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introducir el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (num2 == 0)
                {
                    throw new Exception("No se puede dividir entre 0");
                }

                resultado = num1 / num2;
                Console.WriteLine("{0}", "{1}", "{2}", num1, num2, resultado);
            }
            catch (Exception e)
            {
                Console.WriteLine("Se ha capturado la excepcion: {0}", e.ToString());
            }

        }
    }
}
