using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        public static void Afisare(Produs[] tmp, string categ)
        {
            Console.WriteLine("Produse din categoria '" + categ + "' >");
            for(int i = 0; i < tmp.Length; i++)
            {
                if(tmp[i] != null && Convert.ToString(tmp[i].GetType()).Contains(categ))
                {
                    tmp[i].Afisare();
                }
            }
            Console.WriteLine("------------------------------------");
        }
        static void Main(string[] args)
        {
            Produs[] Asortiment = new Produs[500];
            int id = 0;
            int option = 1;
            int dec;
            string[] cat = { "Cofetarie", "Fructe_Legume", "Mezeluri", "Panificatie", "Bauturi" };
            Console.WriteLine(cat[0]);
            while (option == 1 && id < 500)
            {
                Console.WriteLine("Adaugare produs nou > ");
                Console.WriteLine("Categoria : ");
                Console.WriteLine("1. Cofetarie.");
                Console.WriteLine("2. Fructe/Legume.");
                Console.WriteLine("3. Mezeluri.");
                Console.WriteLine("4. Panificatie.");
                Console.WriteLine("5. Bauturi.");
                dec = Convert.ToInt32(Console.ReadLine());
                switch (dec)
                {
                    case 1: Asortiment[id] = ProdusNou.Create(cat[dec - 1]); Asortiment[id].Citire(); break;
                    case 2: Asortiment[id] = ProdusNou.Create(cat[dec - 1]); Asortiment[id].Citire(); break;
                    case 3: Asortiment[id] = ProdusNou.Create(cat[dec - 1]); Asortiment[id].Citire(); break;
                    case 4: Asortiment[id] = ProdusNou.Create(cat[dec - 1]); Asortiment[id].Citire(); break;
                    case 5: Asortiment[id] = ProdusNou.Create(cat[dec - 1]); Asortiment[id].Citire(); break;
                    default: Console.WriteLine("Categorie invalida !"); break;
                }
                id++;
                Console.WriteLine("Doriti sa adaugati alt produs ? (0/1) > ");
                option = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine("------------------------------------");
            foreach (string c in cat)
            {
                Afisare(Asortiment, c);
            }
        }
    }
}
