using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList lista = new SortedList();

            lista.Add(4, "Cuarto");
            lista.Add(2, "Segundo");
            lista.Add(1, "Primero");
            lista.Add(3, "Tercero");

            foreach (object clave in lista.Keys)
            {
                //Console.WriteLine("{0} - {1}", clave.ToString(), lista[clave].ToString());
            }

            string[] nombres = new string[2] { "Roberto Perez", "http://google.com" };

            // bucle FOR
            for (IEnumerator e = nombres.GetEnumerator(); e.MoveNext(); Console.WriteLine(e.Current)) ;

            // FOREACH

            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
