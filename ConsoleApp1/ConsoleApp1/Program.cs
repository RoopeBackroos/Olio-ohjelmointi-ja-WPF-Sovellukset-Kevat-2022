using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira Koira1 = new Koira();
            Koira1.nimi = "Rekku";
            Koira1.ikä = 4;
            Koira1.rotu = "lapradorinnoutaja";

            Koira1.Hauku();
            Koira1.Tulosdata();

            Koira koira2 = new Koira();
            koira2.nimi = "kissa";
            koira2.ikä = 6;
            koira2.rotu = "doopermanne";

            koira2.Tulosdata();

            Koira koira3 = new Koira("urpo", 5, "mopsi");
        }
    }
}
