using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_Management
{
    class Moderator
    {
        private Lawyer lawyer = new Lawyer();
        public Reader reader = new Reader();
        private Creator creator = new Creator();
        private Updater updater = new Updater();
        public List<Available> Availables {get; private set;}

        public Moderator()
        {
            Availables = reader.ReadAvailable();
        }

        public void UpdateLegends()
        {
            List<Legend> Legends = new List<Legend>();
            foreach(Legend legend in Legends)
            {
                updater.UpdateLegends(legend.NickName, legend.Id);
            }
        }

        // public void AddLegend()
    }

   
}
