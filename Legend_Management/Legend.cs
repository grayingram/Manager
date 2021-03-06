﻿using System;
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
        public bool Icon { get; private set; }
        /// <summary>
        /// a legend with all the info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userName"></param>
        /// <param name="nickName"></param>
        /// <param name="activity"></param>
        /// <param name="monNum"></param>
        /// <param name="iconstatus"></param>
        public Legend(int id, string userName, string nickName, string activity, int monNum, string iconstatus)
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
            if(monNum > 0)
            {
                ReservedPokemon = monNum;
            }
            else
            {
                ReservedPokemon = 0;
            }
            if (iconstatus.Equals("true"))
            {
                Icon = true;
            }
            else
            {
                Icon = false;
            }
            
        }
        /// <summary>
        /// any legend
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userName"></param>
        /// <param name="nickName"></param>
        /// <param name="activity"></param>
        /// <param name="iconstatus"></param>
        public Legend(int id, string userName, string nickName, string activity, string iconstatus)
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
            
            if (iconstatus.Equals("1"))
            {
                Icon = true;
            }
            else
            {
                Icon = false;
            }

        }
        /// <summary>
        /// a legend without the icon status
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userName"></param>
        /// <param name="nickName"></param>
        /// <param name="activity"></param>
        /// <param name="monNum"></param>
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
            if (monNum > 0)
            {
                ReservedPokemon = monNum;
            }
            else
            {
                ReservedPokemon = 0
;
            }
            Icon = false;
            
        }
        /// <summary>
        /// a legend without a reserved pokemon
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userName"></param>
        /// <param name="nickName"></param>
        /// <param name="activity"></param>
        public Legend(int id, string userName, string nickName, string activity)
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
            Icon = false;
            
        }
        public Legend(int id, string userName, string nickName, int icon)
        {
            Id = id;
            UserName = userName;
            NickName = nickName;
            if(icon == 0)
            {
                Icon = false;
            }
            else
            {
                Icon = true;
            }
        }
        

        public Legend()
        {
            Id = 0;
            UserName = "";
            NickName = "";
            Activity = false;
            ReservedPokemon = 0;
            Icon = false;
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
        public void SetIcon(string icon)
        {
            if (icon.Equals("true"))
            {
                Icon = true;
            }
            else
            {
                Icon = false;
            }
        }
    }
}
