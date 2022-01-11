using System;

namespace harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira dogi1 = new Koira("mopsi", 4);

            eläin.kuinkamonta();
            Koira.kuinkamonta();
            Kissa.kuinkamonta();
            Kissa kissa1 = new Kissa("hens", 2);


            dogi1.ääntele();
            kissa1.ääntele();


        }


    }
}
