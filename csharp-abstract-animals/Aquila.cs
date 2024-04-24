using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
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
}
