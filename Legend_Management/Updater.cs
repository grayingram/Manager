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

        public void UpdateLegends(string nickName, int id)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update legends SET UserName = @nickName WHERE idLegends = @id;";
                cmd.Parameters.AddWithValue("nickName", nickName);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
