using System;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();

            p.hablar();
            p.setNombre("Roberto");
            Console.WriteLine("El Nombre: " + p.getNombre() + " ha sido modificado");
        }
    }
}
