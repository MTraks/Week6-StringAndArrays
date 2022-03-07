using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtub kasutajaga homme (Random klass)

            string[] predictions = { "win a million", "fall in love", "buy youtube Premium", "join the dark side", "change sex", "conquer the great nation of jugoslavia" };

            Random rnd = new Random();
            int UserNumber = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Today you will {predictions[UserNumber]}. Prepare yourself!");


        }
    }
}
