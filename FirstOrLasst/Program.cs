using System;

namespace FirstOrLasst
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem


            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine($"sinu eesnimes on {firstName.Length} sümbolit.");

            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"sinu perekonnanimes on {lastName.Length} sümbolit.");

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi");
            }
            else
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi.");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
