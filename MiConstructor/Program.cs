using System;

namespace MiConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.nombre = "Roberto";
            p.ojos = 2;
            p.brazos = 2;
            p.piernas = 2;
            p.colorOjos = "Marrones";
            p.colorPelo = "Negro";

            Console.WriteLine("Mi nombre es: " + p.nombre + " y tengo: " +
                p.ojos + " ojos y además tengo " + p.brazos + " brazos y " +
                p.piernas + " piernas, ojos: " + p.colorOjos + " y pelo: " + p.colorPelo);
        }
    }
}
