using System;
using System.Collections;

namespace StackyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Implementacion de la Clase Queue
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.WriteLine("Los elementos de la Lista son:");

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }

            Console.WriteLine("Ahora el contenido de nuestra cola son: " + q.Count);

            // Implementacion de la Clase Stack
            Stack s = new Stack();

            s.Push(1);
            s.Push(2);
            s.Push(3);

            Console.WriteLine("Los elementos de la Lista son:");

            while (s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }

            Console.WriteLine("Ahora el contenido de nuestra cola son: " + q.Count);
        }
    }       
}
