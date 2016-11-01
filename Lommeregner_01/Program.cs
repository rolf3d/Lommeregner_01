using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner_01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool forfra = true;
            int resultat;
            string Res = "Resultat er: ";
            string info = "Indtast tal og tryk Enter! ";

            do
            {
                Console.WriteLine("****************************");
                Console.WriteLine("***     LOMMEREGNER      ***");
                Console.WriteLine("****************************");
                Console.WriteLine("");

                Console.WriteLine(info);
                string indput1 = Console.ReadLine();
                int tal1 = Int32.Parse(indput1);
                //bool ok1 = Int32.TryParse(indput1, out tal1);
                Console.WriteLine("Vælg operator! ");
                string valg = Console.ReadLine();
                Console.WriteLine(info);
                string indput2 = Console.ReadLine();
                int tal2 = Int32.Parse(indput2);
                //bool ok2 = Int32.TryParse(indput2, out tal2);

                //Console.Read();


                if (valg == "+")
                {
                    resultat = tal1 + tal2;
                    Console.WriteLine(Res + resultat);
                    //forfra = true;
                }
                else if (valg == "-")
                {
                    resultat = tal1 - tal2;
                    Console.WriteLine(Res + resultat);
                }
                else if (valg == "*")
                {
                    resultat = tal1 * tal2;
                    Console.WriteLine(Res + resultat);
                }
                else if (valg == "/")
                {
                    resultat = tal1 / tal2;
                    Console.WriteLine(Res + resultat);
                }

                else
                {
                    Console.WriteLine("Du skal vælge + - eller * tegn! ");
                }

                Console.WriteLine("Tast Q/q for at lukke eller tryk på en vilkårlig tast for at fortsætte");
                string Quit = Console.ReadLine();
                if (Quit == "q" || Quit == "Q")
                {
                    forfra = false;
                }

            } while (forfra);
            
        }
    }
}
