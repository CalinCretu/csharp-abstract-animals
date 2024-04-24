using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale, INuotante
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

        public void Nuota()
        {
            Console.WriteLine("Il Delfino nuota");
        }
    }
}
