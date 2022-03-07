using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o', 'l' tähte on lauses "Hello World!"

            Console.WriteLine("Mitu 'h', 'o', 'l' tähte on lauses 'Hello World!'?");
            string Sentence = "Hello World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < Sentence.Length; i++)
            {
                if (Sentence[i] == 'h')
                {
                    hCounter++;
                }
            }
            if (hCounter != 0)
            {
                Console.WriteLine($"Lauses on {hCounter} 'h' tähte");
            }
            else
            {
                Console.WriteLine($"Lauses ei ole ühtegi 'h' tähte");
            }

            for (int i = 0; i < Sentence.Length; i++)
            {
                if (Sentence[i] == 'o')
                {
                    oCounter++;
                }
            }
            if (oCounter != 0)
            {
                Console.WriteLine($"Lauses on {oCounter} 'o' tähte");
            }
            else
            {
                Console.WriteLine($"Lauses ei ole ühtegi 'o' tähte");
            }
            
            
            for (int i = 0; i < Sentence.Length; i++)
            {
                if (Sentence[i] == 'l')
                {
                    lCounter++;
                }
            }
            if (lCounter != 0)
            {
                Console.WriteLine($"Lauses on {lCounter} 'l' tähte");
            }
            else
            {
                Console.WriteLine($"Lauses ei ole ühtegi 'l' tähte");
            }
        }
    }
}
