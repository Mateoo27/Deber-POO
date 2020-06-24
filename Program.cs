using System;

namespace AplicacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }

            Console.Write("Buenas tardes, ");
            Console.WriteLine("cómo te llamas?");
            string datos1 = Console.ReadLine();
            Console.WriteLine("Mucho gusto " + datos1 + " ¿Cómo estás?");
            string datos2 = Console.ReadLine();
            Console.WriteLine("Cuantos años tienes?");
            int datos3 = Console.Read();
            Console.WriteLine("Muchas gracias por tu tiempo!");


        }
    }
}
