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
            Updater updater = new Updater();

            Moderator meg = new Moderator();
            // meg.UpdateLegends();
           // meg.UpdateNickname();
           // reader.GetPokemonName(75);
            Console.WriteLine("done");
            //Console.ReadLine();

            List<Pokemon> Pokemons = reader.ReadPokemon();
            List<Legend> Legends = reader.ReadLegends();
            //List<Available> Availables = reader.ReadAvailable();
            //int num = lawyer.GetInt("How many pokemon names would you like to search for?");
            //for(int count = 0; count < num; count++)
            //{
            //    int dexNum = lawyer.GetInt("What Dex number entry would you like to see?");
            //    Console.WriteLine("Pokemon Name: " + reader.GetPokemonName(dexNum) + " DexNum: " + dexNum);
            //}
            //Console.ReadLine();
            /*foreach(Pokemon poke in Pokemons)
            {
                Console.WriteLine("DexNum: " + poke.Dexnum + " Name:" + poke.Name + " Gen: " + poke.Generation);
                
            }*/
            //foreach(Legend legend in Legends)
            //{
            //    Console.WriteLine("id: " + legend.Id + " Name: " + legend.NickName  + " Active: " + legend.Activity + "Reserved line #: " +  legend.ReservedPokemon);
            //}
            //foreach(Available available in Availables)
            //{
            //    if (available.NickName.Length == 0)
            //    {
            //        Console.WriteLine("Pokemon: " + available.PokeName);
            //        Console.ReadLine();
            //    }
            //    //else
            //    //{
            //    //    Console.WriteLine("Pokemon: " + available.PokeName + " Nickname: " + available.NickName);
            //    //}
                                
            //}
            Console.ReadLine();
        }

       
    }
    
}
