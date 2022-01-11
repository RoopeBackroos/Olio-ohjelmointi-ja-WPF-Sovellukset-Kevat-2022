using System;

namespace Harjoitus_1
{
    class ajoneuvo
    {
        static void Main(string[] args)
        {
            ajoneuvo ajoneuvo1 = new ajoneuvo();
            ajoneuvo1.merkki = "BMW";
            ajoneuvo1.vuosimalli = 2008;
            ajoneuvo1.malli = "335i";

            ajoneuvo1.tööttää();
            ajoneuvo1.Tulosdata();
        }
    }
}
