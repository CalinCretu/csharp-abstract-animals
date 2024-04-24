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
           string dormire = "~_~";
            return dormire;
        }
        public abstract string Verso();   //metodi astratti

        public abstract string Mangia();
    }

    public class Cane : Animale
    {
        public override string Verso()
        {
            string abbaio = "Bau Bau!";
            return abbaio;
        }

        public override string Mangia()
        {
            string alimentazione = "Carne";
            return alimentazione;
        }
    }
}
