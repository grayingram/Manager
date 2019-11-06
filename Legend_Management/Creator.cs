using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Legend_Management
{
    class Creator
    {
        Repository Repository = new Repository();
        public Reader reader = new Reader();
        public Updater updater = new Updater();
        public Lawyer lawyer = new Lawyer();
        
        public void AddLegend(string userName, string nickname, int reservedmon)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {

                conn.Open();
                bool activity = true;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO legends (UserName, Nickname, Activity, ReservedMonDex)  VALUES(@userName,@nickname, @activity, @reservedmon);";
                cmd.Parameters.AddWithValue("userName", userName);
                cmd.Parameters.AddWithValue("nickname", nickname);
                cmd.Parameters.AddWithValue("activity", activity.ToString());
                cmd.Parameters.AddWithValue("reservedmon", reservedmon);
                cmd.ExecuteNonQuery();
            }
            updater.UpdateReservedMons(nickname, reservedmon);
        }

        public void AddLegend(string username, string nickname)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {

                conn.Open();
                bool activity = true;
                int icon = 0;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO legends (UserName, Nickname, Activity, Icon) Values(@username, @nickname, @activity, @icon);";
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("nickname", nickname);
                cmd.Parameters.AddWithValue("activity", activity.ToString());
                cmd.Parameters.AddWithValue("icon", icon);
                cmd.ExecuteNonQuery();

            }
        }

        public void AddPokemon(string pokemonName, int generation)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into pokemon_real(PokemonName, Generation) values(@pokemonName,@generation);";
                cmd.Parameters.AddWithValue("pokemonName",pokemonName);
                cmd.Parameters.AddWithValue("generation", generation);
                cmd.ExecuteNonQuery();
            }
        }

        public void AddRervableMon(int dexNum, string pokemonName)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into reservablemons(DexNum, PokemonName) values (@dexNum,@pokemonName);";
                cmd.Parameters.AddWithValue("dexNum", dexNum);
                cmd.Parameters.AddWithValue("pokemonName", pokemonName);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
