using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test clasa Masini
            var masina = new Masini("Audi", "RS7", "SV01IRI", 2019, 3500, false);
            Console.WriteLine(masina.ConversieLaSir());
            var masina2 = new Masini("Audi", "R8", "SV02IRI", 2019, 4800, false);
            Console.WriteLine(masina2.ConversieLaSir());
            if (masina.Compare(masina2))
                Console.WriteLine("Masina este aceeasi");
            else
                Console.WriteLine("Masina NU este aceeasi");
            Console.ReadKey();

            // Test clasa Angajati
            var angajat = new Angajati("Turculet", "Irina", "Cuza Voda", "0745454545", 22,
                "2971231565658", "Vanzari", 4, 3, 2020);
            Console.WriteLine(angajat.ConversieLaSir());
            var angajat2 = new Angajati("Turculet", "Irina", "Cuza Voda", "0745454545", 22,
                "2971231565658", "Vanzari", 4, 3, 2020);
            Console.WriteLine(angajat2.ConversieLaSir());
            if (angajat.Compare(angajat2))
                Console.WriteLine("Este acelasi angajat");
            else
                Console.WriteLine("NU este acelasi angajat");
            Console.ReadKey();

            // Test clasa Clienti
            var client = new Clienti("Turculet", "Georgel", "Grigore Antipa", "0741414141", 27, "1921122565859",
                "SV92TGM", 1, 2, 2020, 7);
            Console.WriteLine(client.ConversieLaSir());
            Console.ReadKey();
        }
    }
}
