using System;

namespace ConsoleApp1
{
    class Koira
    {

        public string nimi;
        public int ikä;
        public string rotu;

        public void Tulosdata()
        {
            Console.WriteLine("koiran nimi: " + nimi + ". ikä: " + ikä + ". rotu: " + rotu);
        }

        public void Hauku()
        {
            Console.WriteLine("woof woof");
        }

    }
}
