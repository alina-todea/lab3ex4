using System;
using System.Globalization;

namespace Lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
             Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din sir sa inceapa cu
            MAJUSCULA, restul literelor fiind transformate in litere mici.
            */

            Console.WriteLine("Introduceti un string de caractere");

            string mesaj = Console.ReadLine();

            Console.WriteLine("Stringul formatat:");


            string formatat = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mesaj.ToLower());
            Console.WriteLine(formatat);

        }
    }
}
