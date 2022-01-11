using System;

namespace Muuntaja
{
    class Program
    {
        static void Main(string[] args)
        {
            float km = 45f;

            float mailit = Muuntaja.KmToMiles(km);

            Console.WriteLine(km + " kilometriä on yhtä kuin " + mailit + " mailia");
        }
    }
}
