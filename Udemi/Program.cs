using System;

namespace Udemi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metodo Replace
            string texto1 = "Curso de Dessarrollo C#";
            string nuevotexto1 = texto1.Replace("Curso", "Video");
            //Console.WriteLine(nuevotexto1);

            // METODO Length
            string texto2 = "Roberto Pérez";
            int numerotexto2 = texto2.Length;
            //Console.WriteLine(numerotexto2);

            // BOXING
            int numero = 1;
            object obj = numero;

            // UNBOXING
            object obj1 = 5.5;
            int x = (int)(double)obj1;
            //Console.WriteLine(x);
        }
    }
}
