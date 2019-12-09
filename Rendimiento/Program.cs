using System;
using System.Collections;

namespace Rendimiento
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objetos = new ArrayList();
            objetos.Add(50); // Boxing
            int x = (int)objetos[0]; // Unboxing

            foreach (int i in objetos)
            {
                Console.WriteLine(i);
            }
        }
    }
}
