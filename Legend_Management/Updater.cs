using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Legend_Management
{
    class Updater
    {
        Repository Repository = new Repository();
        public Reader Reader = new Reader();


//        UPDATE insight
//SET Nickname = 'sutto247'
//WHERE PokemonName = 'Serperior';
        public void UpdateReservedMons(string nickname, int dexNum)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {
                conn.Open();
                string pokemonName = Reader.GetPokemonName(dexNum);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update insight SET Nickname = @nickname WHERE PokemonName = @pokemonName;";
                cmd.Parameters.AddWithValue("nickname", nickname);
                cmd.Parameters.AddWithValue("pokemonName", pokemonName);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
