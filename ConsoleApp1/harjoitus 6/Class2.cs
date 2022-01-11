using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_6
{
    class Kissa : Koira
    {
        public string rotu;
        public int ikä;

        public static int instanssit = 0;
        public Kissa(string _rotu, int _ikä)
        {
            rotu = _rotu;
            ikä = _ikä;
            instanssit++;
        }
        public static new void kuinkamonta()
        {
            Console.WriteLine("kissaa on elossa:" + instanssit);
        }




        public override void ääntele()
        {
            Console.WriteLine("mou mou");
        }
    }
}