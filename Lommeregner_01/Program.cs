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
            //double input01 = 0.0;
            //double input1 = 0.0;
            //double input2 = 0.0;
            //string valg = "";
            bool forfra = false;

            

            int resultat;
            string Res = "Resultat er: ";

            do
            {
                Console.WriteLine("****************************");
                Console.WriteLine("***     LOMMEREGNER      ***");
                Console.WriteLine("****************************");

                Console.WriteLine("Indtast det første tal: ");
                string indput1 = Console.ReadLine();
                int tal1 = Int32.Parse(indput1);
                Console.WriteLine("Vælg operator! ");
                string valg = Console.ReadLine();
                Console.WriteLine("Indtast det andet tal");
                string indput2 = Console.ReadLine();
                int tal2 = Int32.Parse(indput2);

                //Console.Read();


                if (valg == "+")
                {
                    resultat = tal1 + tal2;
                    Console.WriteLine(Res + resultat);
                    forfra = true;
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

            } while (!forfra);

            Console.ReadLine();
                
          

            //Console.WriteLine(resultat);
            //Console.WriteLine("Tast Q for at lukke eller tryk på en vilkårlig tast for at fortsætte");
            //string Quit = Console.ReadLine();
            //if (Quit == "q")
            //{
            //    Console.ReadKey();
            //    forfra = false;
            //}

            

        }
    }
}
