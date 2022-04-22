using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ProdusNou
    {
        private static readonly Dictionary<string, Func<Produs>> _produs = 
            new Dictionary<string, Func<Produs>>();
        
        static ProdusNou()
        {
            _produs["Cofetarie"] = () => new Cofetarie();
            _produs["Fructe_Legume"] = () => new Fructe_Legume();
            _produs["Mezeluri"] = () => new Mezeluri();
            _produs["Panificatie"] = () => new Panificatie();
            _produs["Bauturi"] = () => new Bauturi();
        }
        public static Produs Create(string tip)
        {
            Func<Produs> prod;
            _produs.TryGetValue(tip, out prod);
            if (prod == null)
                throw new Exception("Categorie incorecta!");
            Produs produs = prod();
            return produs;
        }
    }
}
