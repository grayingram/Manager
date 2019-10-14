﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_Management
{
    class Legend
    {
        public int Id { get; private set; }
        public string NickName { get; private set; }
        public bool  Activity { get; private set; }
        public int ReservedPokemon { get; private set; }

        public Legend(int id, string nickName, string activity, int monNum)
        {
            Id = id;
            NickName = nickName;
            if (activity.Equals("true"))
            {
                Activity = true;
            }
            else
            {
                Activity = false;
            }
            ReservedPokemon = monNum;
        }
    }
}
