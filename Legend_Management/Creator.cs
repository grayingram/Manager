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
        
        public void AddLegend(string nickname, string activityword, int reservedmon)
        {
            MySqlConnection conn = new MySqlConnection(Repository.ConnStr);

            using (conn)
            {

                conn.Open();
                bool activity = true;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO legends (Nickname, Activity, ReservedMonDex)  VALUES(@nickname, @activity, @reservedmon);";
                cmd.Parameters.AddWithValue("nickname", nickname);
                cmd.Parameters.AddWithValue("activity", activity.ToString());
                cmd.Parameters.AddWithValue("reservedmon", reservedmon);
                cmd.ExecuteNonQuery();
            }
            updater.UpdateReservedMons(nickname, reservedmon);
        }
    }
}
