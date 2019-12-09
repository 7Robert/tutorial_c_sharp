using System;
using System.Collections.Generic;

namespace Reutilizacion
{
    class Usuario
    {
        int id { get; set; }
        string nombre { get; set; }

        public class ListaElementos<T>
        {
            private List<T> elementos;
        

            public ListaElementos()
            {
                elementos = new List<T>();
            }

            public void Agregar (T nuevoelemento)
            {
               elementos.Add(nuevoelemento);
            }

            public void Eliminar(T eliminarelemento)
            {
               elementos.Remove(eliminarelemento);
            }

        }

        static void Main(string[] args)
        {
            ListaElementos<int> Entero = new ListaElementos<int>();
            Entero.Agregar(1);
            Entero.Eliminar(1);

            ListaElementos<string> Cadenas = new ListaElementos<string>();
            Cadenas.Agregar("Roberto Perez");
            Cadenas.Eliminar("Roberto Perez");

            ListaElementos<Usuario> Objetos = new ListaElementos<Usuario>();
            Objetos.Agregar(new Usuario { id = 1, nombre = "Roberto Perez" });
            Objetos.Eliminar(new Usuario { id = 1, nombre = "Roberto Perez" });

        }
    }
}
