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
        public List<Legend> Legends { get; private set; }

        public Moderator()
        {
            Availables = reader.ReadAvailable();
            Legends = reader.ReadLegends();
        }
        public void Test()
        {
            Reserve reserve = CheckAvailable();
            if (reserve.Fact)
            {
                lawyer.Message("The Pokemon:" + reader.GetPokemonName(reserve.Pokemon) + " is available!");

            }
            else
            {
                lawyer.Message("The Pokemon:" + reader.GetPokemonName(reserve.Pokemon) + " is available!");
            }
        }

        public void UpdateLegends()
        {
            List<Legend> Legends = reader.ReadLegends();
            foreach(Legend legend in Legends)
            {
                updater.UpdateLegends(legend.NickName, legend.Id);
            }
        }

        public void UpdateNickname()
        {
            bool fact = lawyer.GetYesNo("Do you have more than one legend nickname to update?");
            if(!fact)
            {
                int reservedMon = lawyer.GetInt("What is the reserved dexnum of the legend you wish to change?");
                string username = reader.GetLegendUserNamebyRM(reservedMon);
                string nickname = lawyer.GetResponse("What new nickname would you like to give them?");
                updater.UpdateNickname(nickname, username);
            }
            else
            {
                int num = lawyer.GetInt("How many legends would you like to change the nickname of?");
                for(int count = 0; count < num; count++)
                {
                    int reservedMon = lawyer.GetInt("What is the reserved dexnum of the legend you wish to change?");
                    string username = reader.GetLegendUserNamebyRM(reservedMon);
                    string nickname = lawyer.GetResponse("What new nickname would you like to give them?");
                    updater.UpdateNickname(nickname, username);
                }
            }
        }

        public void AddLegend()
        {
            string username = lawyer.GetResponse("What is their username?");
            string nickname;
            if (lawyer.GetYesNo("Is the nickname the same as the username?"))
            {
                nickname = username;
            }
            else {
                nickname =lawyer.GetResponse("What nickname would the legend like?") ;
            }
            Reserve reserve = CheckAvailable();
            if (reserve.Fact)
            {
                creator.AddLegend(username, nickname, reserve.Pokemon);
            }
            
            
                
        }

        public void AddPokemon()
        {
            string name = lawyer.GetResponse("What is the name of the Pokemon?");
            int generation = lawyer.GetInt("What generation is it from?");
            creator.AddPokemon(name, generation);
        }
        public void AddPokemon(int num)
        {
            int generation;
            if(lawyer.GetYesNo("Are the mons you wish to enter from the same generation?"))
            {
                generation = lawyer.GetInt("What is the generation of the pokemon to be entered?");
                for (int count = 0; count < num; count++)
                {
                    string name = lawyer.GetResponse("What is the name of the Pokemon?");
                    creator.AddPokemon(name, generation);
                }
            }
            else
            {
                for(int count = 0; count < num; count++)
                {
                    string name = lawyer.GetResponse("What is the name of the Pokemon?");
                    generation = lawyer.GetInt("What generation is it from?");
                    creator.AddPokemon(name, generation);
                }
            }
        }
        public void DoesLegendExist()
        {
             string username = lawyer.GetResponse("What is the username of the legend you want to check?");
                if (!(reader.DoesLegendExists(username)))
                {
                    Console.WriteLine("Let's fix that!");
                    this.AddLegend();
                }
                else
                {
                    Console.WriteLine("They exist!");
                }
            if (lawyer.GetYesNo("Would you like to see if another legend exist?"))
            {
                this.DoesLegendExist();
            }
            
        }

        public Reserve CheckAvailable()
        {
            Reserve reserve;
            int dexNum = lawyer.GetInt("What is dex number of the final evo or split of dex number of the pokemon?");
            string pokemon = reader.GetPokemonName(dexNum);
            foreach (Available mon in Availables)
            {
                if(mon.PokeName == pokemon)
                {
                    reserve = new Reserve(true, dexNum);
                    return reserve;
                }
            }
            Console.WriteLine("That pokemon evolution line is unavailable, Sorry.");
            if(lawyer.GetYesNo("Would you like check the availability of another pokemon line?"))
            {
                CheckAvailable();
            }
            reserve = new Reserve(false, dexNum);
            return reserve;

        }
    }
    public class Reserve
    {
        public bool Fact { get; private set; }
        public int Pokemon { get; private set; }

        public Reserve(bool fact, int pokemon)
        {
            Fact = fact;
            Pokemon = pokemon;
        }
        public Reserve()
        {
            Fact = false;
            Pokemon = 0;
        }

        public void SetFact(bool fact)
        {
            Fact = fact;
        }
        public void SetPokemon(int pokemon)
        {
            Pokemon = pokemon;
        }
        //public 
    }

   
}
