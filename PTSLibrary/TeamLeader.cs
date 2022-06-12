using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    internal class TeamLeader : User
    {
        private int teamid;

        public int TeamId 
        {
            get { return teamid; }
            set { teamid = value; }
        }

        public TeamLeader (string name, int id, int teamId) 
        {
            this.name = name;
            this.id = id;
            this.teamid = teamId;
        }
    }
}
