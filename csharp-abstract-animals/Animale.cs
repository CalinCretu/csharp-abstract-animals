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

    public class Cane : Animale
    {
        public override string Verso()
        {
            string verso = "Bau Bau!";
            return verso;
        }

        public override string Mangia()
        {
            string mangia = "Carne";
            return mangia;
        }
    }

    public class Passerotto : Animale
    {
        public override string Verso()
        {
            string verso = "Cip Cip Cirip";
            return verso;
        }
        public override string Mangia()
        {
            string mangia = "Insetti";
            return mangia;
        }
    }

    public class Aquila : Animale
    {
        public override string Verso()
        {
            string verso = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH";
            return verso;
        }
        public override string Mangia()
        {
            string mangia = "Topini Simpatici";
            return mangia;
        }
    }

    public class Delfino : Animale
    {
        public override string Verso()
        {
            string verso = "Fiiiiiiii ( fischio )";
            return verso;
        }
        public override string Mangia()
        {
            string mangia = "Pesciotti Simpatici";
            return mangia;
        }
    }
}
