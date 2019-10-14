using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_Management
{
    class Pokemon
    {
       

        public int Dexnum { get; private set; }
        public string Name { get; private set; }
        public int Generation { get; private set; }

        public Pokemon(int dexNum, string pokeName, int gen)
        {
            Dexnum = dexNum;
            Name = pokeName;
            Generation = gen;
        }

    }
}
