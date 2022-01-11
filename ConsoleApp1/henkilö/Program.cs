using System;

namespace henkilö
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö henkilö = new Henkilö("Matti", 20, 699999);
            Opiskelija opiskelia = new Opiskelija("Peksi", 18, 696969, 12345, "careeria");

            henkilö.Tulostatiedot();
            opiskelia.Tulostatiedot();

            
        }
    }
}
