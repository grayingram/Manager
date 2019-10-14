﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Legend_Management
{
    class Reader
    {
        Repository Repository = new Repository();
        //public List<Legends> Legends {get; private set;}

        public Reader()
        {

        }

        public List<Pokemon> ReadPokemon()
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);
            List<Pokemon> pokemons = new List<Pokemon>();
            using (conn)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM pokemon_real;";

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Pokemon pokemon = new Pokemon(int.Parse(dr["DexNum"].ToString()),dr["PokemonName"].ToString(), int.Parse(dr["Generation"].ToString()));
                    pokemons.Add(pokemon);
                }
                return pokemons;
            }
        }

        public List<Legend> ReadLegends()
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);
            List<Legend> legends = new List<Legend>();
            using (conn)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM legends;";

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Legend legend = new Legend(int.Parse(dr["idLegends"].ToString()), dr["NickName"].ToString(), dr["Activity"].ToString(), int.Parse(dr["ReservedMonDex"].ToString()));
                    legends.Add(legend);
                }
                return legends;
            }
        }
    }
}
