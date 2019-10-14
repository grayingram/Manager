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
            /*foreach(Pokemon poke in Pokemons)
            {
                Console.WriteLine("DexNum: " + poke.Dexnum + " Name:" + poke.Name + " Gen: " + poke.Generation);
                
            }*/
            foreach(Legend legend in Legends)
            {
                Console.WriteLine("id: " + legend.Id + " Name: " + legend.NickName  + " Active: " + legend.Activity + "Reserved line #: " +  legend.ReservedPokemon);
            }
            Console.ReadLine();
        }
    }
}
