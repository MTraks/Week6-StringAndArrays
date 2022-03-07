using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't Panic" nulliga
            //programm asendab kõik 'a' tähed samas lauses '4' -ga

            string DPanic = "Don't Panic";

            DPanic = DPanic.Replace('o', '0');
            DPanic = DPanic.Replace('a', '4');
            Console.WriteLine(DPanic);

        }
    }
}
