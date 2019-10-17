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
        public List<Available> Availables {get; private set;}
    }

   
}
