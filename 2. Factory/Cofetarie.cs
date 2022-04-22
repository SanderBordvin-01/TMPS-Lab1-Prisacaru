using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Cofetarie : Produs
    {
        public override void Citire()
        {
            Console.Write("Nume >");
            nume = Convert.ToString(Console.ReadLine());
            Console.Write("Cantitate >");
            cantitate = Convert.ToInt32(Console.ReadLine());
        }
        public override void Afisare()
        {
            Console.WriteLine(nume + "............." + cantitate);
        }

    }
}
