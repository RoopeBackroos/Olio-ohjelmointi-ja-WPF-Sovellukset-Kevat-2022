using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus_6
{
    abstract class eläin
    {
        private static int instanssit;

        public eläin()
        {
            instanssit++;
        }
        public static void kuinkamonta()
        {
            Console.WriteLine("eläimiä elossa" + instanssit);
        }

        public abstract void ääntele();

    }
}