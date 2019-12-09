using System;
using System.Collections.Generic;

namespace GenericPersonalizado
{
    class Program
    {
        public class ListaElementos<T>
        {
            private List<T> elementos;

            public ListaElementos()
            {
                elementos = new List<T>();
            }

            public void Agregar(T nuevoelemento)
            {
                elementos.Add(nuevoelemento);
            }

            public void Eliminar (T elementoeliminar)
            {
                elementos.Remove(elementoeliminar);
            }

            public void Listar()
            {
                foreach (var elemento in elementos)
                {
                    Console.WriteLine("El elemento es: {0}", elemento);
                }
            }
        }
        static void Main(string[] args)
        {
            ListaElementos<int> ListaEntera = new ListaElementos<int>();
            ListaEntera.Agregar(1);
            ListaEntera.Agregar(2);
            ListaEntera.Agregar(3);
            ListaEntera.Eliminar(2);

            ListaEntera.Listar();

            ListaElementos<string> ListaCadena = new ListaElementos<string>();
            ListaCadena.Agregar("Roberto");
            ListaCadena.Agregar("Carlos");
            ListaCadena.Agregar("Pedro");
            ListaCadena.Eliminar("Pedro");
            ListaCadena.Listar();
        }
    }
}
