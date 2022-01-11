using System;

namespace ConsoleApp1
{
    class Koira
    {

        public string nimi;
        public int ikä;
        public string rotu;

        public Koira() { }
        public Koira(string _nimi, int _ikä, string _rotu)
        {
            nimi = _nimi;
            ikä = _ikä;
            rotu = _rotu;

            Hauku();
        }
            


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
