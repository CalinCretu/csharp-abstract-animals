using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale, IVolante
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

        public void Vola()
        {
            Console.WriteLine("Il Passerotto vola");
        }
    }
}
