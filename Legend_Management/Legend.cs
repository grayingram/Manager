using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_Management
{
    class Legend
    {
        public int Id { get; private set; }
        public string UserName { get; set; }
        public string NickName { get; private set; }
        public bool  Activity { get; private set; }
        public int ReservedPokemon { get; private set; }

        public Legend(int id, string userName, string nickName, string activity, int monNum)
        {
            Id = id;
            UserName = userName;
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

        public Legend()
        {
            Id = 0;
            UserName = "";
            NickName = "";
            Activity = false;
            ReservedPokemon = 0;
        }

        public void SetId(int id)
        {
            Id = id;
        }
        public void SetUserName(string username)
        {
            UserName = username;
        }
        public void SetNickName(string nickname)
        {
            NickName = nickname;
        }
        public void SetActivity(string activity)
        {
            if (activity.Equals("true"))
            {
                Activity = true;
            }
            else
            {
                Activity = false;
            }
        }
        public void SetReservedMon(int dexNum)
        {
            ReservedPokemon = dexNum;
        }
    }
}
