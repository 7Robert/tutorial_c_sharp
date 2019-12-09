using System;
using System.Collections.Generic;

namespace EjemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // Agregar Elementos Lista

            IList<int> entero = new List<int>();
            entero.Add(2);
            entero.Add(3);

            IList<string> cadena = new List<string>();
            cadena.Add("Dos");
            cadena.Add("Tres");

            IList<int> entero1 = new List<int>() { 2, 3 };
            IList<string> cadena1 = new List<string>() { "Uno", "Cuatro" };

            // Metodo AddRange

            List<int> entero2 = new List<int>();
            entero2.AddRange(entero);

            // Acceder a los elementos coleccion List

            Console.WriteLine("El valor en la posicion 1 de mi lista es: {0}", entero[0]);

            foreach (int i in entero)
            {
                Console.WriteLine(1);
            }

            for (int i = 0; i < entero.Count; i++)
            {
                Console.WriteLine(entero[i]);
            }

            // Insertar elementos a la coleccion generica List

            IList<int> entero3 = new List<int>() { 2, 3 };
            entero3.Insert(1, 5);
            Console.WriteLine("--");

            foreach (var i in entero3)
            {
                Console.WriteLine(i);
            }

            //Eliminar elementos de la coleccion generica List

            IList<int> entero4 = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine("--");
            entero4.Remove(2); // Eliminar el primer valor numero 2 que encuentre en la lista
            entero4.RemoveAt(2); // Eliminar el elemento que esta en la segunda posicion de la lista

            foreach (var i in entero4)
            {
                Console.WriteLine(i);
            }

        }

    }
}
