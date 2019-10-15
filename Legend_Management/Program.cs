using System;
using System.Collections.Generic;

namespace Legend_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Lawyer lawyer = new Lawyer();
            Reader reader = new Reader();
            List<Pokemon> Pokemons = reader.ReadPokemon();
            List<Legend> Legends = reader.ReadLegends();
            List<Available> Availables = reader.ReadAvailable();
            /*foreach(Pokemon poke in Pokemons)
            {
                Console.WriteLine("DexNum: " + poke.Dexnum + " Name:" + poke.Name + " Gen: " + poke.Generation);
                
            }*/
            //foreach(Legend legend in Legends)
            //{
            //    Console.WriteLine("id: " + legend.Id + " Name: " + legend.NickName  + " Active: " + legend.Activity + "Reserved line #: " +  legend.ReservedPokemon);
            //}
            foreach(Available available in Availables)
            {
                if (available.NickName.Length == 0)
                {
                    Console.WriteLine("Pokemon: " + available.PokeName);
                    Console.ReadLine();
                }
                //else
                //{
                //    Console.WriteLine("Pokemon: " + available.PokeName + " Nickname: " + available.NickName);
                //}
                                
            }
            Console.ReadLine();
        }

       
    }
    public class Available
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
