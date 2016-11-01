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
            double input1 = 0.0;
            double input2 = 0.0;
            string valg = "";
            double resultat = 0.0;

            double input01 = Convert.ToDouble(Console.ReadLine());
            double input02 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(input01);

            if (valg == "+")
            {
                resultat = input1 + input2;
            }
            else if (valg == "-")
            {
                resultat = input1 - input2;
            }
            else if (valg == "*")
            {
                resultat = input1 * input2;
            }
            else
            {
                Console.WriteLine("Du skal vælge + - eller * tegn! ");
            }


      
        }
    }
}
