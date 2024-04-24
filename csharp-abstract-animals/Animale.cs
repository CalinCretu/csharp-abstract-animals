using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale       // classe astratta Animale
    {
        public string Dormi()             // metodo pubblico
        {
            string dormi = "~_~";
            return dormi;
        }
        public abstract string Verso();   //metodi astratti

        public abstract string Mangia();
    }
}
