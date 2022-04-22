using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Produs
    {
        protected string nume;
        protected int cantitate;

        public abstract void Citire();
        public abstract void Afisare();
    }
}
