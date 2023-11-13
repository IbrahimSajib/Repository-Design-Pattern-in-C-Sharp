using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Design_Pattern.Models
{
    public static class PlayerDB
    {
        public static List<Player> PlayerList = new List<Player>()
        {
            new Player(){PlayerId=1,PlayerName="Shakib Al Hasan",Age=36, Role=Role_Type.All_Rounder,ClubName="Legends of Rupganj"},
            new Player(){PlayerId=2,PlayerName="Najmul Hossain Shanto",Age=25, Role = Role_Type.Batter, ClubName="Abahani Limited"},
            new Player(){PlayerId=3,PlayerName="Liton Das",Age=28, Role = Role_Type.Wicket_Keeper, ClubName="Abahani Limited"},
            new Player(){PlayerId=4,PlayerName="Towhid Hridoy",Age=22, Role = Role_Type.Batter, ClubName="Sheikh Jamal Dhanmondi"},
            new Player(){PlayerId=5,PlayerName="Mushfiqur Rahim",Age=36, Role = Role_Type.Wicket_Keeper, ClubName="Prime Bank"},
            new Player(){PlayerId=6,PlayerName="Mehidy Hasan Miraz",Age=25, Role = Role_Type.All_Rounder, ClubName="Mohammedan"},
            new Player(){PlayerId=7,PlayerName="Taskin Ahmed",Age=28, Role = Role_Type.Bowler, ClubName="Mohammedan"},
            new Player(){PlayerId=8,PlayerName="Hasan Mahmud",Age=23, Role = Role_Type.Bowler, ClubName="Khelaghar"},
            new Player(){PlayerId=9,PlayerName="Shoriful Islam",Age=22, Role = Role_Type.Bowler, ClubName="Prime Bank"},
        };
    }
}