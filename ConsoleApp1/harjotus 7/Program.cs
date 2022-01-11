using System;

namespace harjotus_7
{
    class Program
    {
        private static string syöte;

        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 6);

            while(true)
            {
                Console.WriteLine("olet kerroksessa " + hissi.NykyinenKerros);
                Console.WriteLine("mihin kerrokseen olet menossa? ");
                syöte = Console.ReadLine();

                if (syöte == "poistu")
                {
                    Console.WriteLine("poistuit hissistä");
                    break;
                }
                else
                {
                    hissi.NykyinenKerros = int.Parse(syöte);
                }
            }   
        }
    }
}
