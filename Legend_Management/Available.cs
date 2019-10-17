using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_Management
{
    class Available
    {
        public string PokeName { get; private set; }
        public string NickName { get; private set; }

        public Available(string pokename, string nickname)
        {
                PokeName = pokename;
                NickName = nickname;
        }
        
    }
}
