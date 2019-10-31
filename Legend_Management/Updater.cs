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
        public void UpdateReservedMonstoAvail(int dexNum)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {
                conn.Open();
                string pokemonName = Reader.GetPokemonName(dexNum);
                string nickname = "";
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

        public void UpdateLegendStatus(int id, bool fact)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update legends SET Activity = @fact WHERE idLegends = @id;";
                cmd.Parameters.AddWithValue("fact", fact.ToString());
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }

        }
        public void UpdateLegendNickname(string old, string newName)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update legends SET NickName = @newName WHERE NickName = @old;";
                cmd.Parameters.AddWithValue("newName", newName);
                cmd.Parameters.AddWithValue("old", old);
                cmd.ExecuteNonQuery();
            }
        }


        public void UpdateLegendReserveMon(int id, int dexNum)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update legends SET ReservedMonDex = @dexnum WHERE idLegends = @id;";
                cmd.Parameters.AddWithValue("dexnum", dexNum);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }

        }

        public void UpdateNickname(string nickName, string userName)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update legends SET Nickname = @nickName WHERE UserName = @userName;";
                cmd.Parameters.AddWithValue("nickName", nickName);
                cmd.Parameters.AddWithValue("userName", userName);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
