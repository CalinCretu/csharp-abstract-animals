﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
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
}
