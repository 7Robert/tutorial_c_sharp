using System;
using System.Collections;
using System.Collections.Generic;

namespace SeguridadTipos
{
    class Program
    {
        public class Usuario
        {
            int id { get; set; }
            string nombre { get; set; }
        }
        static void Main(string[] args)
        {
            // COLECCION NO GENERICA ARRAY LIST

            //ArrayList objetos = new ArrayList();
            //objetos.Add(1);
            //objetos.Add("Roberto Perez");
            //objetos.Add(new Usuario());

            //foreach (int i in objetos)
            //{
            //    Console.WriteLine(i);
            //}

            // COLECCION GENERIA List<T>

            List<int> objetos = new List<int>();

            objetos.Add(1);
            objetos.Add(2);
            objetos.Add(3);

        }
    }
}
