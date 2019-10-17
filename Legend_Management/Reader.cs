using System;
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
//reads the pokemon that exist
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
//reads the legends that exist
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
                    Legend legend = new Legend(int.Parse(dr["idLegends"].ToString()), dr["UserName"].ToString(), dr["NickName"].ToString(), dr["Activity"].ToString(), int.Parse(dr["ReservedMonDex"].ToString()));
                    legends.Add(legend);
                }
                return legends;
            }
        }
        //want to know if a mon evo line is available
        public List<Available> ReadAvailable()
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);
            List<Available> availables = new List<Available>();
            using (conn)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM insight;";

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Available available = new Available((dr["PokemonName"].ToString()), dr["NickName"].ToString());
                    availables.Add(available);
                }
                return availables;
            }
        }
        //want to know what mon name is tied to which dex entry
        public string GetPokemonName(int dexNum)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);
            using (conn)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT PokemonName from pokemon_real WHERE DexNum = @dexNum;";
                cmd.Parameters.AddWithValue("dexNum", dexNum);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string pokemonName = dr[0].ToString();
                return pokemonName;

            }
        }
    }
}
