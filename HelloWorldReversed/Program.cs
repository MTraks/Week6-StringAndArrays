﻿using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab "Hello World!" tagurpidid

            Console.WriteLine("Hello World!");
            string Sentence = "Hello World!";

            for (int i = Sentence.Length - 1; i >= 0; i--)
            {
                Console.Write(Sentence[i]);
            }
        }
    }
}
