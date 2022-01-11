using System;
using System.Collections.Generic;
using System.Text;

namespace henkilö
{
    class Opiskelija : Henkilö
    {
        public int opiskelijaID;
        public string koulu;

        public Opiskelija(string nimi, int ikä, int henkilötunnus, int _opiskelijaID, string _koulu) : base(nimi, ikä, henkilötunnus)
        {
            opiskelijaID = _opiskelijaID;
            koulu = _koulu;
        }

        public override void Tulostatiedot()


        {
            Console.WriteLine("opiskelija: " + Nimi + ". ikä: " + Ikä + "koulu: " + koulu + ". opiskelijaID: " + opiskelijaID);
        }

        public void Syö()
        {
            Console.WriteLine(Nimi + " syö ja juo");
        }
    }
}
